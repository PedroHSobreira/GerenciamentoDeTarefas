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
    public partial class AtualizaUsuario : Form
    {
        DAOUsuario dao;
        public AtualizaUsuario()
        {
            InitializeComponent();
            dao = new DAOUsuario();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//codigo

        private void button3_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(textBox1.Text);
            textBox2.Text = dao.ConsultarNome(codigo);
            textBox3.Text = dao.ConsultarEmail(codigo);
            textBox4.Text = dao.ConsultarSenha(codigo);
        }//buscar

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }//nome

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }//email

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }//senha

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }//voltar

        private void button2_Click(object sender, EventArgs e)
        {
            string nome = textBox2.Text;
            string email = textBox3.Text;
            string senha = textBox4.Text;

            //Atualizar
            int codigo = Convert.ToInt32(textBox1.Text);
            dao.Atualizar(codigo, "nome", nome);
            dao.Atualizar(codigo, "email", email);
            dao.Atualizar(codigo, "senha", senha);
            //Mensagem:
            MessageBox.Show("Atualizado com sucesso!");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }//Atualizar
    }
}
