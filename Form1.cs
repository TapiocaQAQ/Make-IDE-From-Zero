using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace Make_IDE_From_Zero
{
    public partial class Form1 : Form
    {
        
        private string dPath;   // the folder's path of the selected file
        private FileInfo codeFile;
        double oldWidth;
        double oldHeight;
        KeyWords[] keyWords;
        bool canRun;
        public static string[] colorlist = new string[9];       // marked!
        DoStack buffer;
        Font myContextFont;
        public Form1()
        {
            InitializeComponent();
        }

        public void iniPos()
        {
            // Form size
            this.Width = 1600;
            this.Height = 900;
            oldWidth = this.Width;
            oldHeight = this.Height;
            this.MinimumSize = new System.Drawing.Size(1280, 720);

            // TreeView
            this.treeFile.Location = new Point(10, 70);
            this.treeFile.Width = 250;
            this.treeFile.Height = 750;
            this.treeFile.Font = new Font("Consolas", 20);

            // FileName
            this.fileName.Location = new Point(300, 70);
            this.fileName.Font = new Font("Consolas", 20);
            this.fileName.Text = "";

            // Mycontext
            this.myContext.Location = new Point(300, 120);
            this.myContext.Width = 1240;
            this.myContext.Height = 600;
            this.myContext.Font = new Font("Consolas", 20);

            // Debug
            this.debug.Location = new Point(300, 760);
            this.debug.Font = new Font("Consolas", 20);
            this.debug.Text = "";
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            buffer = new DoStack();
            buffer.UndoStack.Push("");

            int i = 0;
            using (StreamReader sr = new StreamReader("ColorList.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    colorlist[i++] = line;
                }
            }
            i = 0;
            keyWords = new KeyWords[] {
            new KeyWords("Basis", new string[]{ }, colorlist[i++]),
            new KeyWords("Header", new string[]{ "#include" }, colorlist[i++]),
            new KeyWords("NameSpace", new string[]{ "using", "namespace" }, colorlist[i++]),
            new KeyWords("Value", new string[]{ "int", "float", "double", "long", "longlong", "string" }, colorlist[i++]),
            new KeyWords("Judge", new string[]{ "if", "else", "switch" }, colorlist[i++]),
            new KeyWords("Loop", new string[]{ "for", "while", "foreach", "do" }, colorlist[i++]),
            new KeyWords("brutal", new string[]{ "break", "continue", "return", "system" }, colorlist[i++]),
            new KeyWords("Class", new string[]{"class", "public", "private", "protected", "static" }, colorlist[i++]),
            };

            changeBackgroungColor(ColorTranslator.FromHtml(colorlist[i]));

            PassKeyWords.keyWords = keyWords;

            iniPos();

            canRun = false;

        }
        public void ChangeColor(string tmp, int start, int len, Color color, Color basis)
        {
            int caretPos = this.myContext.SelectionStart;
            this.myContext.Select(start, len);
            this.myContext.SelectionColor = color;
            this.myContext.Select(caretPos, 0);
            this.myContext.SelectionColor = basis;
        }

        public void FindWords(string tmp, string key, Color c, Color b)
        {
            Regex regf = new Regex("^" + key + "[^a-zA-Z0-9]{1}");
            foreach(Match match in regf.Matches(tmp))
            {
                ChangeColor(tmp, match.Index, match.Length - 1, c, b);
            }
            Regex re = new Regex("[^a-zA-Z0-9]{1}" + key + "[^a-zA-Z0-9]{1}");
            foreach(Match match in re.Matches(tmp))
            {
                ChangeColor(tmp, match.Index + 1, match.Length - 2, c, b);
            }
        }


        private void MakeTreeView(string path, TreeNode nodeParent)
        {

            DirectoryInfo dif = new DirectoryInfo(path);
            DirectoryInfo[] difFolderArr = dif.GetDirectories();
            FileInfo[] fifArr = dif.GetFiles();
            for (int i = 0; i < difFolderArr.Length; i++)
            {
                TreeNode node = new TreeNode();
                node.Text = difFolderArr[i] + Environment.NewLine;
                nodeParent.Nodes.Add(node);
                MakeTreeView(difFolderArr[i].FullName, nodeParent.Nodes[i]);
            }
            for (int i = 0; i < fifArr.Length; i++)
            {
                TreeNode node = new TreeNode();
                node.Text = fifArr[i] + Environment.NewLine;
                nodeParent.Nodes.Add(node);
            }
        }


        private string GetThedPath(string name)
        {
            codeFile = new FileInfo(name);
            fileName.Text = codeFile.Name;    // show the opened file name, when first open 
            return codeFile.FullName + "\\..\\";
        }

        private void ShowFile(ArrayList arr) {
            this.myContext.Text = "";
            for (int i = 0; i < arr.Count; i++)
                this.myContext.Text += arr[i] + Environment.NewLine;
        }

        private void openTool_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Cpp|*.cpp|ALL|*.*";
            op.CheckFileExists = true;
            op.CheckPathExists = true;
            DialogResult result = op.ShowDialog();
            ArrayList context = new ArrayList();

            if (result == DialogResult.OK)
            {
                System.Text.Encoding encode = System.Text.Encoding.GetEncoding("utf-8");
                using (StreamReader sr = new StreamReader(op.FileName, encode))
                {
                    while (!sr.EndOfStream)
                    {
                        context.Add(sr.ReadLine());
                    }
                }
                ShowFile(context);

                dPath = GetThedPath(op.FileName);   // get the folder's path of the selected file
                DirectoryInfo d = new DirectoryInfo(dPath);

                this.treeFile.Nodes.Clear();
                this.treeFile.Nodes.Add(d.Name);
                MakeTreeView(dPath, this.treeFile.Nodes[0]);
                this.treeFile.Nodes[0].Expand();
            }
        }

        private void treeFile_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Text.Contains(".")) {
                ArrayList context = new ArrayList();
                string nodePath = Regex.Replace(dPath + "..\\" + e.Node.FullPath, @"[\r\n]", "");
                codeFile = new FileInfo(nodePath);

                //this.label1.Text = nodePath;
                using (StreamReader sr = new StreamReader(nodePath, Encoding.UTF8))
                {
                    while (!sr.EndOfStream)
                    {
                        context.Add(sr.ReadLine());
                    }
                }
                fileName.Text = e.Node.Text.ToString();
                ShowFile(context);
            }

        }

        private void saveTool_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter sw;
                sw = codeFile.CreateText();
                sw.WriteLine(this.myContext.Text);
                sw.Flush();
                sw.Close();
                canRun = true;
            }
            catch (Exception ex){
                MessageBox.Show("File can't find!");
                canRun = false;
            }
        }

        private void SaveFileUseDialog(string title, string initName) 
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Cpp|*.cpp|ALL|*.*";
            sfd.FileName = initName;
            sfd.Title = title;
            if (sfd.ShowDialog() == DialogResult.OK && sfd.FileName != "")
            {
                using (StreamWriter sw = new StreamWriter(sfd.OpenFile(), System.Text.Encoding.UTF8))
                {
                    for (int i = 0; i < this.myContext.Lines.Length; i++)
                    {
                        sw.WriteLine(myContext.Lines[i]);
                    }
                }
                dPath = GetThedPath(sfd.FileName);   // get the folder's path of the selected file
                DirectoryInfo d = new DirectoryInfo(dPath);

                this.treeFile.Nodes.Clear();
                this.treeFile.Nodes.Add(d.Name);
                MakeTreeView(dPath, this.treeFile.Nodes[0]);
                this.treeFile.Nodes[0].Expand();
            }
        }

        private void newTool_Click(object sender, EventArgs e)
        {
            SaveFileUseDialog("New File", "NewFile");
        }

        private void saveAsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SaveFileUseDialog("Save as", this.fileName.Text.Split('.')[0] + "(copy)");
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if ((oldWidth != 0 && oldHeight != 0) )
            {
                double x = (this.Width / oldWidth);
                double y = (this.Height / oldHeight);

                RePos(this.myContext, x, y);
                RePos(this.treeFile, x, y);
                RePos(this.debug, x, y);
                RePos(this.fileName, x, y);

                oldHeight = this.Height;
                oldWidth = this.Width;
            }
        }

        private void RePos(Control item, Double x, Double y)
        {
                item.Width = Convert.ToInt32(x * item.Width);
                item.Height = Convert.ToInt32(y * item.Height);
                item.Location = new Point(Convert.ToInt32(item.Location.X * x), Convert.ToInt32(item.Location.Y * y));
        }

        
        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this);
            f2.ShowDialog();
            if (f2.DialogResult == System.Windows.Forms.DialogResult.OK)    // form2
            {
                myContext_TextChanged(sender, e);
            }

        }
        public void changeBackgroungColor(Color c)
        {
            myContext.BackColor = c;

        }

        private void fontSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.Font = myContext.Font;
            if (fd.ShowDialog() != DialogResult.Cancel)
            {
                myContext.Font = fd.Font;
                myContext_TextChanged(sender, e);
            }
        }

        public void changeKeywordsColor(string text) {
            ChangeColor(text, 0, text.Length, ColorTranslator.FromHtml(keyWords[0].color), ColorTranslator.FromHtml(keyWords[0].color));

            foreach (KeyWords ele in keyWords)
            {
                foreach (string key in ele.keywords)
                {
                    FindWords(text, key, ColorTranslator.FromHtml(ele.color), ColorTranslator.FromHtml(keyWords[0].color));
                }
            }
        }

        private void myContext_TextChanged(object sender, EventArgs e)
        {
            changeKeywordsColor(this.myContext.Text);
        }

        private void rUNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // compile and execute cpp
            this.saveTool_Click(sender, e);
            if (canRun)
            {
                string exePath = Directory.GetCurrentDirectory();
                exePath += "\\..\\..\\MinGW\\bin\\g++.exe ";
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd";
                startInfo.Arguments = $"/c {exePath + codeFile.FullName + " -o " + this.fileName.Text.Split('.')[0] + ".exe"}";
                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();
                int result = process.ExitCode;
                if (result == 0)
                {
                    Process process2 = new Process();
                    ProcessStartInfo startInfo2 = new ProcessStartInfo();
                    startInfo2.FileName = this.fileName.Text.Split('.')[0] + ".exe";
                    process2.StartInfo = startInfo2;
                    process2.Start();
                    this.debug.Text = "Success";
                }
                else
                {
                    MessageBox.Show("Compile error");
                    this.debug.Text = "Debug鴨";
                }
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (buffer.UndoStack.Count > 0)
            {
                buffer.RedoStack.Push(this.myContext.Text);
                this.myContext.Text = buffer.UndoStack.Pop();
                this.myContext.Select(this.myContext.Text.Length, 0);
            }
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (buffer.RedoStack.Count > 0)
            {
                buffer.UndoStack.Push(this.myContext.Text);
                this.myContext.Text = buffer.RedoStack.Pop();
                this.myContext.Select(this.myContext.Text.Length, 0);
            }
        }

        private void myContext_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Enter || e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.OemPeriod) {
                    buffer.UndoStack.Push(this.myContext.Text);
            }
        }
    }
}
