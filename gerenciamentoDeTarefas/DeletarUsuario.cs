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
    public partial class DeletarUsuario : Form
    {
        DAOUsuario dao;
        public DeletarUsuario()
        {
            InitializeComponent();
            dao = new DAOUsuario();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//fim codigo

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
    }
}
