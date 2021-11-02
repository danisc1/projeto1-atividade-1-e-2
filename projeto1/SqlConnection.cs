using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1
{
    internal class SqlConnection
    {
        private string strConexao;

        public SqlConnection(string strConexao)
        {
            this.strConexao = strConexao;
         
        }

        internal void open()
        {
            throw new Exception("eeeeee");
        }

        internal void Close()
        {
            throw new NotImplementedException();
        }
    }

    internal class SqlCommand
    {
        private string query;
        private SqlConnection conexao;

        public SqlCommand(string query, SqlConnection conexao)
        {
            this.query = query;
            this.conexao = conexao;
        }

        internal void ExecuteNonQuery()
        {
            throw new NotImplementedException();
        }
    }
}

