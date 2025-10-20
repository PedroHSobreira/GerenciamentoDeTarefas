using gerenciamentoDeTarefas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gerenciamentoTarefa
{
    class ControlUsuario
    {
        private DAOUsuario dao;

        public ControlUsuario()
        {
            this.dao = new DAOUsuario();
        }//fim do construtor

        public ControlUsuario(string nome, string email, string senha)
        {
            this.dao = new DAOUsuario();
            this.dao.Inserir(nome, email, senha);
        }//fim do construtor

        public void Imprimir()
        {
            this.dao = new DAOUsuario();
            Console.WriteLine(this.dao.ConsultarTudo());
        }//fim do imprimir

        public void ConsultarPorCodigo()
        {
            this.dao = new DAOUsuario();
            Console.WriteLine("Informe o código que deseja consultar: ");
            int codigo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(this.dao.ConsultarPorCodigo(codigo));
        }//fim do imprimir
    }//fim da classe
}//fim do projeto