using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gerenciamentoTarefa
{
    public partial class ConsultaUsuario : Form
    {
        ControlUsuario controle;
        DAOUsuario dao;
        public ConsultaUsuario()
        {
            InitializeComponent();
            controle = new ControlUsuario();
            dao = new DAOUsuario();
            //Chamar todos os metodos na ordem
            ConfigurarGrid();//Estruturando o grid
            NomeDados();//Nomear as colunas
            dao.PreencherVetor();//Preenchewr os vetores e consultar o banco
            AdicionarDados();//Inserir os dados na tela, linha por linha
        }

        public void AdicionarDados()
        {
            for (int i = 0; i < dao.QuantidadeDeDados(); i++)
            {
                dataGridView1.Rows.Add(dao.codigo[i], dao.email[i], dao.senha[i]);
            }
        }//fim do metodo

        public void ConfigurarGrid()
        {
            dataGridView1.AllowUserToAddRows = false;//Adicionar linhas
            dataGridView1.AllowUserToDeleteRows = false;//Apagar Linhas
            dataGridView1.AllowUserToResizeColumns = false;//Modificar Colunas
            dataGridView1.AllowUserToResizeRows = false;//Modificar Linhas
            dataGridView1.ColumnCount = 3;
        }//fim do configurarGrid

        public void NomeDados()
        {
            dataGridView1.Columns[0].Name = "Código";
            dataGridView1.Columns[0].Name = "Email";
            dataGridView1.Columns[0].Name = "Senha";

        private void button3_Click(object sender, EventArgs e)
        {

        }//buscar

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }//fim do dataGridView1

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }//fim do class
}//fim do projeto
