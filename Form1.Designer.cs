namespace Make_IDE_From_Zero
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileTool = new System.Windows.Forms.ToolStripMenuItem();
            this.newTool = new System.Windows.Forms.ToolStripMenuItem();
            this.openTool = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTool = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editTool = new System.Windows.Forms.ToolStripMenuItem();
            this.fontColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rUNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debug = new System.Windows.Forms.Label();
            this.myContext = new System.Windows.Forms.RichTextBox();
            this.treeFile = new System.Windows.Forms.TreeView();
            this.fileName = new System.Windows.Forms.Label();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileTool,
            this.editTool,
            this.rUNToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1396, 41);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileTool
            // 
            this.fileTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTool,
            this.openTool,
            this.saveTool,
            this.saveAsToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.fileTool.Name = "fileTool";
            this.fileTool.Size = new System.Drawing.Size(89, 37);
            this.fileTool.Text = "File";
            // 
            // newTool
            // 
            this.newTool.Name = "newTool";
            this.newTool.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newTool.ShowShortcutKeys = false;
            this.newTool.Size = new System.Drawing.Size(224, 38);
            this.newTool.Text = "New";
            this.newTool.Click += new System.EventHandler(this.newTool_Click);
            // 
            // openTool
            // 
            this.openTool.Name = "openTool";
            this.openTool.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openTool.ShowShortcutKeys = false;
            this.openTool.Size = new System.Drawing.Size(224, 38);
            this.openTool.Text = "Open";
            this.openTool.Click += new System.EventHandler(this.openTool_Click);
            // 
            // saveTool
            // 
            this.saveTool.Name = "saveTool";
            this.saveTool.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveTool.ShowShortcutKeys = false;
            this.saveTool.Size = new System.Drawing.Size(224, 38);
            this.saveTool.Text = "Save";
            this.saveTool.Click += new System.EventHandler(this.saveTool_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(224, 38);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click_1);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(224, 38);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // editTool
            // 
            this.editTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontColorToolStripMenuItem,
            this.fontSizeToolStripMenuItem});
            this.editTool.Name = "editTool";
            this.editTool.Size = new System.Drawing.Size(89, 37);
            this.editTool.Text = "Edit";
            // 
            // fontColorToolStripMenuItem
            // 
            this.fontColorToolStripMenuItem.Name = "fontColorToolStripMenuItem";
            this.fontColorToolStripMenuItem.Size = new System.Drawing.Size(239, 38);
            this.fontColorToolStripMenuItem.Text = "Color";
            this.fontColorToolStripMenuItem.Click += new System.EventHandler(this.fontColorToolStripMenuItem_Click);
            // 
            // fontSizeToolStripMenuItem
            // 
            this.fontSizeToolStripMenuItem.Name = "fontSizeToolStripMenuItem";
            this.fontSizeToolStripMenuItem.Size = new System.Drawing.Size(239, 38);
            this.fontSizeToolStripMenuItem.Text = "Font size";
            this.fontSizeToolStripMenuItem.Click += new System.EventHandler(this.fontSizeToolStripMenuItem_Click);
            // 
            // rUNToolStripMenuItem
            // 
            this.rUNToolStripMenuItem.Name = "rUNToolStripMenuItem";
            this.rUNToolStripMenuItem.Size = new System.Drawing.Size(74, 37);
            this.rUNToolStripMenuItem.Text = "Run";
            this.rUNToolStripMenuItem.Click += new System.EventHandler(this.rUNToolStripMenuItem_Click);
            // 
            // debug
            // 
            this.debug.AutoSize = true;
            this.debug.Location = new System.Drawing.Point(547, 732);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(41, 15);
            this.debug.TabIndex = 2;
            this.debug.Text = "label1";
            // 
            // myContext
            // 
            this.myContext.AcceptsTab = true;
            this.myContext.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myContext.Location = new System.Drawing.Point(327, 146);
            this.myContext.Name = "myContext";
            this.myContext.Size = new System.Drawing.Size(1043, 534);
            this.myContext.TabIndex = 3;
            this.myContext.Text = "";
            this.myContext.TextChanged += new System.EventHandler(this.myContext_TextChanged);
            this.myContext.KeyDown += new System.Windows.Forms.KeyEventHandler(this.myContext_KeyDown);
            // 
            // treeFile
            // 
            this.treeFile.Location = new System.Drawing.Point(0, 89);
            this.treeFile.Name = "treeFile";
            this.treeFile.Size = new System.Drawing.Size(317, 735);
            this.treeFile.TabIndex = 5;
            this.treeFile.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeFile_NodeMouseDoubleClick);
            // 
            // fileName
            // 
            this.fileName.AutoSize = true;
            this.fileName.Location = new System.Drawing.Point(343, 104);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(0, 15);
            this.fileName.TabIndex = 6;
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(224, 38);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 685);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.treeFile);
            this.Controls.Add(this.myContext);
            this.Controls.Add(this.debug);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "HappyIDE";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileTool;
        private System.Windows.Forms.ToolStripMenuItem openTool;
        private System.Windows.Forms.ToolStripMenuItem saveTool;
        private System.Windows.Forms.ToolStripMenuItem editTool;
        private System.Windows.Forms.Label debug;
        private System.Windows.Forms.RichTextBox myContext;
        private System.Windows.Forms.TreeView treeFile;
        private System.Windows.Forms.Label fileName;
        private System.Windows.Forms.ToolStripMenuItem newTool;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rUNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
    }
}

