using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gerenciamentoTarefa
{
    class ControlTarefa
    {
        private DAOTarefa dao;

        public ControlTarefa ()
        {
            this.dao = new DAOTarefa();
        }//fim do construtor

        public ControlTarefa(string titulo, string descricao, string prioridade, DateTime prazo, string lembrete, int usuarioCodigo)
        {
            this.dao = new DAOTarefa();
            this.dao.Inserir(titulo,descricao,prioridade,prazo,lembrete,usuarioCodigo);
        }//fim do construtor

        public void Imprimir()
        {
            this.dao = new DAOTarefa();
            Console.WriteLine(this.dao.ConsultarTudo());
        }//fim do imprimir

        public void ConsultarPorCodigo()
        {
            this.dao = new DAOTarefa();
            Console.WriteLine("Informe o código que deseja consultar: ");
            int codigo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(this.dao.ConsultarPorCodigo(codigo));
        }//fim do imprimir
    }//fim da classe
}//fim do projeto