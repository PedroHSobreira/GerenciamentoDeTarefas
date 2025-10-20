using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gerenciamentoTarefa
{
    class Usuario
    {
        private int codigo;
        private string nome;
        private string email;
        private string senha;

        public Usuario()
        {
            this.codigo = 0;
            this.nome = "";
            this.email = "";
            this.senha = "";
        }//fim do construtor

        public Usuario(int codigo, string nome, string email, string senha)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.email = email;
            this.senha = senha;
        }//fim do construtor

        //Métodos GETS e SETS
        public int ModificarCodigo
        {
            get { return this.codigo; }
            set { this.codigo = value; }
        }//fim do modificarCodigo

        public string ModificarNome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }//fim do ModificarNome

        public string ModificarEmail
        {
            get { return this.email; }
            set { this.email = value; }
        }//fim do ModificarEmail

        public string ModificarSenha
        {
            get { return this.senha; }
            set { this.senha = value; }
        }//fim do ModificarSenha

        public string Imprimir()
        {
            return "\nCódigo: " + ModificarCodigo +
                   "\nNome: " + ModificarNome +
                   "\nEmail: " + ModificarEmail;
                   "\nSenha: " + ModificarSenha; 
        }//fim do Imprimir



    }//fim da classe
}//fim do projeto