using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30_kadar__yazdırmak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            do
            {
                richTextBox1.Text += sayac.ToString();
                sayac++;
            } while (sayac <= 30);
        }
    }
}
