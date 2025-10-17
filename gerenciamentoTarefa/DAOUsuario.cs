using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data; //Import do MySQL
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Org.BouncyCastle.Asn1.Mozilla; //Import do MySql - Com métodos do crud
using System.Windows.Forms;

namespace gerenciamentoTarefa
{
    class DAOUsuario
    {
        public MySqlConnection conexao;//Criando uma chave para a classe MYSQLCONNECTION
        public string dados;
        public string comando;
        public int i;
        public int contador;
        public string msg;
        public int[] codigo;
        public string[] nome;
        public string[] email;
        public string[] senha;

    }
}
