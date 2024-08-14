using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace klavye
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text = textBox1.Text + b.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }
        bool CapsLock = true;
        private void button2_Click(object sender, EventArgs e)
        {
            if (CapsLock)
            {
                CapsLock = false;
                lbl_bilgi.Text = lbl_bilgi.Text.ToLower();
            }
            else
            {
                CapsLock = true;
                lbl_bilgi.Text = lbl_bilgi.Text.ToUpper();
            }
            foreach ( Button item in panel1.Controls )
            {
                if (CapsLock)
                    item.Text = item.Text.ToUpper();
                else
                    item.Text = item.Text.ToLower();
            }
        }

        
    }
}
