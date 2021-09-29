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


namespace Make_IDE_From_Zero
{
    public partial class Form2 : Form
    {
        KeyWords[] keyWords;
        int index = 1;
        public Form2(Form1 Parentform)
        {
            InitializeComponent();
            btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;

            keyWords = PassKeyWords.keyWords;

            this.Tag = Parentform;  //form2 use the function &  return parameter to form1
            
        }

        
        
        private void Form2_Load(object sender, EventArgs e)
        {
            pb_background.BackColor = Color.White;
            pb_keyWord.BackColor = ColorTranslator.FromHtml(keyWords[1].color); 

            foreach (KeyWords ele in keyWords) {
                this.listBox_keyword.Items.Add(ele.name);
            }
            listBox_keyword.SelectedIndex = 1;
            this.lb_show.ForeColor = ColorTranslator.FromHtml(keyWords[1].color);

        }
        
        
        private void btn_backColor_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pb_background.BackColor = colorDialog1.Color;
                ((Form1)this.Tag).changeBackgroungColor(colorDialog1.Color);

                string hex = "#" + colorDialog1.Color.R.ToString("X2") + colorDialog1.Color.G.ToString("X2") + colorDialog1.Color.B.ToString("X2");
                UpDate.UpdateColor(8, hex);
            }
            
        }



        private void listBox_keyword_MouseClick(object sender, MouseEventArgs e)
        {
            Color newColor = ColorTranslator.FromHtml(keyWords[this.listBox_keyword.SelectedIndex].color);
            this.lb_show.ForeColor = newColor;

            index = this.listBox_keyword.SelectedIndex;
            pb_keyWord.BackColor = newColor;
        }

        private void btn_keyWord_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pb_keyWord.BackColor = colorDialog1.Color;
                this.lb_show.ForeColor = colorDialog1.Color;

                //RGB 2 Hex
                string hex = "#"+colorDialog1.Color.R.ToString("X2") + colorDialog1.Color.G.ToString("X2") + colorDialog1.Color.B.ToString("X2");

                UpDate.UpdateColor(index, hex);
            }
        }

        
    }
}
