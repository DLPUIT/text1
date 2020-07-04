using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace text2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int op1Number = int.Parse(this.textBox1op1.Text);
            int op2Number = int.Parse(this.textBox1op2.Text);
            int result = op1Number + op2Number;
            this.laberrResult.text = this.textBox1.Text + this.textBox2.Text;
        }
    }
}
