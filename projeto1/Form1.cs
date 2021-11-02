using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "Dani") && (textBox2.Text == "123"))
            {

                MDIParent1 tela2 = new MDIParent1();
                tela2.Show();
                this.Visible = true;

            }
            else
            {
                MessageBox.Show("Login ou Senha inválidos");

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
        }




