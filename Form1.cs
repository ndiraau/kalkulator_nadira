using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulator_nadira
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            hasil.Text = "";
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("angka 1 dan angka 2 isi dulu gan");
            }
            else
            {
                int a, b, c;
                a = int.Parse(this.textBox1.Text);
                b = int.Parse(this.textBox2.Text);
                c = a / b;
                this.hasil.Text = c.ToString();
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty (textBox1.Text) || string.IsNullOrEmpty (textBox2.Text))
            {
                MessageBox.Show("angka 1 dan angka 2 isi dulu gan");
            }
            else
            {
                int a, b, c;
                a = int.Parse(this.textBox1.Text);
                b = int.Parse(this.textBox2.Text);
                c = a + b;
                this.hasil.Text = c.ToString();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("angka 1 dan angka 2 isi dulu gan");
            }
            else
            {
                int a, b, c;
                a = int.Parse(this.textBox1.Text);
                b = int.Parse(this.textBox2.Text);
                c = a - b;
                this.hasil.Text = c.ToString();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("angka 1 dan angka 2 isi dulu gan");
            }
            else
            {
                int a, b, c;
                a = int.Parse(this.textBox1.Text);
                b = int.Parse(this.textBox2.Text);
                c = a * b;
                this.hasil.Text = c.ToString();
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            hasil.Text = "";
        }
    }
}
