using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormatFloat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float ft = 10.123213f;
            // MessageBox.Show(ft.ToString("#0.0"));
            MessageBox.Show(ft.ToString("F2"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> nn = new List<string>();
            nn.Add("1111");
            string str = "11011";
            string str1 = nn.Find(delegate(string p) { return p == str; });
            if (str1 == null)
            {
                MessageBox.Show(str);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str = "123";
            str = str.Substring(3, str.Length-3);
            MessageBox.Show(str);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float ft = 1.1111111111111161f;
            int it = (int)ft;
            MessageBox.Show(it.ToString());
        }

      
    }
}
