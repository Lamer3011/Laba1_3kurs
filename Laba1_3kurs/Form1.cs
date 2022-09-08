using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba1_3kurs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_sign_Click(object sender, EventArgs e)
        {
            if (textBox_login.Text == "root" && textBox_password.Text == "toor")
            {
                check_label.BackColor = Color.Green;
                MessageBox.Show("Hello admin!");
            }
            else
            {
                check_label.BackColor = Color.Red;
                MessageBox.Show($"Unknown user : {textBox_login.Text}!");
            }
        }
    }
}
