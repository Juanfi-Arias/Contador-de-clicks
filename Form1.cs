using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contador_de_cliks
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "You win 👏🏆")
            {
                textBox1.Text = "0";
                return;
            }
            int count = int.Parse(textBox1.Text);
            count++;
            textBox1.Text = count.ToString();

            if (textBox1.Text == "101")
                textBox1.Text = "You win 👏🏆";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text="0";
        }
    }
}
