using gerenciamentoTarefa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gerenciamentoDeTarefas
{
    public partial class CadastrarTarefa : Form
    {
        public CadastrarTarefa()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }//titulo

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }//Descricao

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//Propriedade

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
            try
            {
                //Coletar os dados
                string titulo = textBox1.Text;
                string descricao = textBox2.Text;
                string prioridade = textBox2.Text;
                DateTime prazo = Convert.ToDateTime(textBox4.Text);
                string lembrete = textBox5.Text;
                int usuarioCodigo = Convert.ToInt32(textBox6.Text);
                //Cadastrar no Banco de Dados
                ControlTarefa controleTarefa = new ControlTarefa(
                                                titulo,
                                                descricao,
                                                prioridade,
                                                prazo,
                                                lembrete,
                                                usuarioCodigo);
                //Confirmar que foi inserido
                MessageBox.Show($"Cadastrado com sucesso !!! \nTítulo: {titulo}" +
                                                          $"\nDescrição:  {descricao}" +
                                                          $"\nPrioridade:  {prioridade}" +
                                                          $"\nPrazo:  {prazo}" +
                                                          $"\nLembrete:  {lembrete}" +
                                                          $"\nUsuarioCódigo: {usuarioCodigo}");

                //Limpar os campos apos cadastro
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Algo deu errado!!! \n\n{ex}");
            }
        }//Cadastrar
    }//fim da classe
}//fim do projeto
