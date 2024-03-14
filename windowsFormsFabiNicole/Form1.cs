using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;                                          
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsFormsFabiNicole
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

        private void btnClickThis_Click(object sender, EventArgs e)
        {
            string login = richTextLogin.Text;
            string senha = richTextSenha.Text;

            if (login == "admin" && senha == "ds@etefmc")
            {
                //btnOK.Text = "Login correto!";
                MessageBox.Show("Login correto!");
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void richTextSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
