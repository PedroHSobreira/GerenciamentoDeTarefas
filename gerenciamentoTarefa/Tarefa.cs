using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gerenciamentoTarefa
{
    class Tarefa
    {
        //Declaração de variáveis
        private int codigo;
        private string titulo;
        private string descricao;
        private string prioridade;
        private DateTime prazo;
        private string lembrete;
        private int codigoUsuario;

        //Primeiro Grande Método - Método Construtor
        //Instancia as variáveis na memória do equipamento
        public Tarefa()
        {
            ModificarCodigo = 0;
            ModificarTitulo = "";
            ModificarDescricao = "";
            ModificarPrioridade = "";
            ModificarPrazo = new DateTime();
            ModificarLembrete = "";
            ModificarCodigoUsuario = 0;
        }//Fim do construtor

        public Tarefa(int codigo, string titulo, string descricao, string prioridade,
                     DateTime prazo, string lembrete, int codigoUsuario)
        {
            ModificarCodigo = codigo;
            ModificarTitulo = titulo;
            ModificarDescricao = descricao;
            ModificarPrioridade = prioridade;
            ModificarPrazo = prazo;
            ModificarLembrete = lembrete;
            ModificarCodigoUsuario = codigoUsuario;
        }//Fim do construtor

        //Métodos GETs e SETs
        //Métodos de acesso e modificação

        public int ModificarCodigo
        {
            get
            {
                return this.codigo;
            }//fim do get
            set
            {
                this.codigo = value;
            }//fim do set
        }//fim do modificarCodigo

        public string ModificarTitulo
        {
            get { return this.titulo; }
            set { this.titulo = value; }
        }//fim do ModificarTitulo

        public string ModificarDescricao
        {
            get { return this.descricao; }
            set { this.descricao = value; }
        }//fim do ModificarDescricao
        public string ModificarPrioridade
        {
            get { return this.prioridade; }
            set { this.prioridade = value; }
        }//fim do ModificarDescricao

        public DateTime ModificarPrazo
        {
            get { return this.prazo; }
            set { this.prazo = value; }
        }//fim do ModificarPrazo

        public string ModificarLembrete
        {
            get { return this.lembrete; }
            set { this.lembrete = value; }
        }//fim do ModificarLembrete

        public int ModificarCodigoUsuario
        {
            get { return this.codigoUsuario; }
            set { this.codigoUsuario = value; }
        }//fim do método

        public string Imprimir()
        {
            return "\nCódigo: " + ModificarCodigo +
                   "\nTitulo: " + ModificarTitulo +
                   "\nDescrição: " + ModificarDescricao +
                   "\nPrazo: " + ModificarPrazo +
                   "\nLembrete: " + ModificarLembrete +
                   "\nCategoria: " + ModificarCodigoUsuario;
        }//fim do imprimir

    }//fim da classe
}//fim do projeto