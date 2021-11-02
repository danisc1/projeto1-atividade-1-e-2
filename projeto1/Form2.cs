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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                string strConexao = @"Data Source=DESKTOP-75HM2IQ\dani;Integrated Security=SSPI;";



                string Query = "INSERT INTO[dbo].[Table]([Id], [Nome], [Email], [Senha], [CPF], [Celular])VALUES(1, N'Leticia Alves', N'leticia@gmail.com', N'123456', N'56325698548', N'11968597558')";

                // coloca o nome da tabela e dos campos
                // Em values copia das propriedades da caixa de texto em txt



                SqlConnection conexao = new SqlConnection(strConexao);
                SqlCommand comando = new SqlCommand(Query, conexao);

                conexao.open();
                // Para abrir a conexão

                comando.ExecuteNonQuery();
                // Para executar a Query

                conexao.Close();
                // Para fechar a conexão

                MessageBox.Show("Foi");
                //Para exibir mensagem
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}