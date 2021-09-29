namespace Make_IDE_From_Zero
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.btn_backColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pb_background = new System.Windows.Forms.PictureBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.listBox_keyword = new System.Windows.Forms.ListBox();
            this.btn_keyWord = new System.Windows.Forms.Button();
            this.pb_keyWord = new System.Windows.Forms.PictureBox();
            this.lb_show = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_keyWord)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_backColor
            // 
            this.btn_backColor.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_backColor.Location = new System.Drawing.Point(59, 386);
            this.btn_backColor.Name = "btn_backColor";
            this.btn_backColor.Size = new System.Drawing.Size(176, 39);
            this.btn_backColor.TabIndex = 0;
            this.btn_backColor.Text = "Back Ground";
            this.btn_backColor.UseVisualStyleBackColor = true;
            this.btn_backColor.Click += new System.EventHandler(this.btn_backColor_Click);
            // 
            // pb_background
            // 
            this.pb_background.Location = new System.Drawing.Point(255, 386);
            this.pb_background.Name = "pb_background";
            this.pb_background.Size = new System.Drawing.Size(32, 39);
            this.pb_background.TabIndex = 1;
            this.pb_background.TabStop = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_cancel.Location = new System.Drawing.Point(532, 386);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(100, 39);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_ok
            // 
            this.btn_ok.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_ok.Location = new System.Drawing.Point(661, 386);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(100, 39);
            this.btn_ok.TabIndex = 3;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            // 
            // listBox_keyword
            // 
            this.listBox_keyword.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_keyword.FormattingEnabled = true;
            this.listBox_keyword.ItemHeight = 32;
            this.listBox_keyword.Location = new System.Drawing.Point(33, 27);
            this.listBox_keyword.Name = "listBox_keyword";
            this.listBox_keyword.Size = new System.Drawing.Size(311, 228);
            this.listBox_keyword.TabIndex = 4;
            this.listBox_keyword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox_keyword_MouseClick);
            // 
            // btn_keyWord
            // 
            this.btn_keyWord.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_keyWord.Location = new System.Drawing.Point(59, 321);
            this.btn_keyWord.Name = "btn_keyWord";
            this.btn_keyWord.Size = new System.Drawing.Size(176, 39);
            this.btn_keyWord.TabIndex = 5;
            this.btn_keyWord.Text = "Key Word";
            this.btn_keyWord.UseVisualStyleBackColor = true;
            this.btn_keyWord.Click += new System.EventHandler(this.btn_keyWord_Click);
            // 
            // pb_keyWord
            // 
            this.pb_keyWord.Location = new System.Drawing.Point(255, 321);
            this.pb_keyWord.Name = "pb_keyWord";
            this.pb_keyWord.Size = new System.Drawing.Size(32, 39);
            this.pb_keyWord.TabIndex = 6;
            this.pb_keyWord.TabStop = false;
            // 
            // lb_show
            // 
            this.lb_show.AutoSize = true;
            this.lb_show.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_show.Location = new System.Drawing.Point(501, 122);
            this.lb_show.Name = "lb_show";
            this.lb_show.Size = new System.Drawing.Size(131, 36);
            this.lb_show.TabIndex = 7;
            this.lb_show.Text = "Example";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_show);
            this.Controls.Add(this.pb_keyWord);
            this.Controls.Add(this.btn_keyWord);
            this.Controls.Add(this.listBox_keyword);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.pb_background);
            this.Controls.Add(this.btn_backColor);
            this.Name = "Form2";
            this.Text = "Font Color";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_keyWord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Button btn_backColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox pb_background;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.ListBox listBox_keyword;
        private System.Windows.Forms.Button btn_keyWord;
        private System.Windows.Forms.PictureBox pb_keyWord;
        private System.Windows.Forms.Label lb_show;
    }
}