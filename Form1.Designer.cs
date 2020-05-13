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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.openFileButton1 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.fileTool = new System.Windows.Forms.ToolStripMenuItem();
            this.openTool = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTool = new System.Windows.Forms.ToolStripMenuItem();
            this.editTool = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.myContext = new System.Windows.Forms.RichTextBox();
            this.treeFile = new System.Windows.Forms.TreeView();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 27);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(889, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // openFileButton1
            // 
            this.openFileButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openFileButton1.Image = ((System.Drawing.Image)(resources.GetObject("openFileButton1.Image")));
            this.openFileButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openFileButton1.Name = "openFileButton1";
            this.openFileButton1.Size = new System.Drawing.Size(29, 24);
            this.openFileButton1.Text = "toolStripButton1";
            this.openFileButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileTool,
            this.editTool});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(889, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // fileTool
            // 
            this.fileTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openTool,
            this.saveTool});
            this.fileTool.Name = "fileTool";
            this.fileTool.Size = new System.Drawing.Size(47, 23);
            this.fileTool.Text = "File";
            // 
            // openTool
            // 
            this.openTool.Name = "openTool";
            this.openTool.Size = new System.Drawing.Size(224, 26);
            this.openTool.Text = "Open";
            this.openTool.Click += new System.EventHandler(this.openTool_Click);
            // 
            // saveTool
            // 
            this.saveTool.Name = "saveTool";
            this.saveTool.Size = new System.Drawing.Size(224, 26);
            this.saveTool.Text = "Save";
            // 
            // editTool
            // 
            this.editTool.Name = "editTool";
            this.editTool.Size = new System.Drawing.Size(50, 23);
            this.editTool.Text = "Edit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(444, 463);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // myContext
            // 
            this.myContext.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.myContext.Location = new System.Drawing.Point(209, 57);
            this.myContext.Name = "myContext";
            this.myContext.Size = new System.Drawing.Size(668, 342);
            this.myContext.TabIndex = 3;
            this.myContext.Text = "";
            // 
            // treeFile
            // 
            this.treeFile.Location = new System.Drawing.Point(0, 57);
            this.treeFile.Name = "treeFile";
            this.treeFile.Size = new System.Drawing.Size(203, 471);
            this.treeFile.TabIndex = 5;
            this.treeFile.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeFile_NodeMouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 540);
            this.Controls.Add(this.treeFile);
            this.Controls.Add(this.myContext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "HappyIDE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton openFileButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileTool;
        private System.Windows.Forms.ToolStripMenuItem openTool;
        private System.Windows.Forms.ToolStripMenuItem saveTool;
        private System.Windows.Forms.ToolStripMenuItem editTool;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox myContext;
        private System.Windows.Forms.TreeView treeFile;
    }
}

