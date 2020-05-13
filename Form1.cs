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

namespace Make_IDE_From_Zero
{
    public partial class Form1 : Form
    {
        private string dPath;   // the folder's path of the selected file
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

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
            FileInfo f = new FileInfo(name);
            return f.FullName + "\\..\\";
        }

        private void ShowFile(ArrayList arr) {
            this.myContext.Text = "";
            for (int i = 0; i < arr.Count; i++)
                this.myContext.Text += arr[i] + Environment.NewLine;
        }

        private void openTool_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Text|*.txt|csv|*.csv|ALL|*.*";
            op.InitialDirectory = @"C:\Users\john\copy\Visual Studio\Project";
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

                //this.label1.Text = nodePath;
                using (StreamReader sr = new StreamReader(nodePath, Encoding.UTF8))
                {
                    while (!sr.EndOfStream)
                    {
                        context.Add(sr.ReadLine());
                    }
                }
                ShowFile(context);
            }
            
            

        }
    }
}
