using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();
        int number;
        int tries;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            number = random.Next(1, 7);
            textBox1.Text = number.ToString();
            number = random.Next(1, 7); 
            textBox2.Text = number.ToString();
            tries++;
            if (textBox1.Text == "6" && textBox2.Text == "6")
            {
                MessageBox.Show("Du hade bara " + tries + " försök");
            }
        }
    }
}
