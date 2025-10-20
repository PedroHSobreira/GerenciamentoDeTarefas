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
    public partial class ConsultaTarefa : Form
    {
        ControlTarefa controle;
        DAOTarefa dao;
        public ConsultaTarefa()
        {
            InitializeComponent();
            controle = new ControlTarefa();
            dao = new DAOTarefa();
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
                dataGridView1.Rows.Add(dao.codigo[i], dao.titulo[i], dao.descricao[i], dao.prioridade[i], dao.prazo[i], dao.lembrete[i], dao.usuarioCodigo[i]);
            }
        }//fim do metodo

        public void ConfigurarGrid()
        {
            dataGridView1.AllowUserToAddRows = false;//Adicionar linhas
            dataGridView1.AllowUserToDeleteRows = false;//Apagar Linhas
            dataGridView1.AllowUserToResizeColumns = false;//Modificar Colunas
            dataGridView1.AllowUserToResizeRows = false;//Modificar Linhas
            dataGridView1.ColumnCount = 7;
        }//fim do configurarGrid


        public void NomeDados()
        {
            dataGridView1.Columns[0].Name = "Código";
            dataGridView1.Columns[0].Name = "Título";
            dataGridView1.Columns[0].Name = "Descrição";
            dataGridView1.Columns[0].Name = "Prioridade";
            dataGridView1.Columns[0].Name = "Prazo";
            dataGridView1.Columns[0].Name = "Lembrete";
            dataGridView1.Columns[0].Name = "UsuárioCódigo";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//codigo

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }//fim do datagridView

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }//voltar

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }//fim do class
}//fim do projeto
