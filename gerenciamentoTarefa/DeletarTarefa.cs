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
    public partial class DeletarTarefa : Form
    {
        DAOTarefa dao;
        public DeletarTarefa()
        {
            InitializeComponent();
            dao = new DAOTarefa();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//codigo

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }//voltar

        private void button2_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(textBox1.Text);
            MessageBox.Show(dao.Deletar(codigo));
        }//excluir

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }//fim do class
}//fim do projeto
