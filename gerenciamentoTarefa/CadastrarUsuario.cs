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
    public partial class CadastrarUsuario : Form
    {
        public CadastrarUsuario()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
            try
            {
                //Coletar os dados
                string usuario = textBox1.Text;
                string email = textBox2.Text;
                string senha = textBox3.Text;
                //Cadastrar no banco de Dados
                ControlUsuario controleUsuario = new ControlUsuario(
                                                    usuario,
                                                    email,
                                                    senha);
                //Confirmar que foi inserido
                MessageBox.Show($"Cadastrado com sucesso !!! \n\nUsuário: {usuario}" +
                                                                $"\nEmail: {email}" +
                                                                $"\nSenha: {senha}");
                //Limpar os campos apos cadastro
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Algo deu errado!!! \n\n{ex}");
            }

        }//Cadastrar
    }//fim do class
}//fim do projeto
