using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace gerenciamentoTarefa
{
    public partial class AtualizaTarefa : Form
    {
        DAOTarefa dao;
        public AtualizaTarefa()
        {
            InitializeComponent();
            dao = new DAOTarefa();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//Codigo

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }//titulo

        private void button3_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(textBox1.Text);
            textBox2.Text = dao.ConsultarTitulo(codigo);
            textBox3.Text = dao.ConsultarDescricao(codigo);
            textBox4.Text = dao.ConsultarPrioridade(codigo);
            textBox5.Text = dao.ConsultarPrazo(codigo);
            textBox6.Text = dao.ConsultarLembrete(codigo);
            textBox7.Text = dao.ConsultarUsuario(codigo);
        }//Buscar

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }//Descricao

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }//Prioridade

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }//Prazo

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }//Lembrete

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }//Situação

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }//Voltar

        private void button2_Click(object sender, EventArgs e)
        {
            //pegar os dados
            string titulo = textBox2.Text;
            string descricao = textBox3.Text;
            string prioridade = textBox4.Text;
            DateTime prazo = Convert.ToDateTime(textBox5.Text);
            string lembrete = textBox6.Text;
            int usuarioCodigo = Convert.ToInt32(textBox6.Text);
            //Atualizar
            int codigo = Convert.ToInt32(textBox1.Text);
            dao.Atualizar(codigo, "titulo", titulo);
            dao.Atualizar(codigo, "descricao", descricao);
            dao.Atualizar(codigo, "prioridade", prioridade);
            dao.Atualizar(codigo, "prazo", prazo);
            dao.Atualizar(codigo, "lembrete", lembrete);
            dao.Atualizar(codigo, "usuarioCodigo", usuarioCodigo);
            //Mensagem
            MessageBox.Show("Atualizado com sucesso");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }//Atualizar

    }//fim do class
}//fim do projeto
