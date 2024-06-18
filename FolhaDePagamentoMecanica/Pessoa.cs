using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaDePagamentoMecanica
{
    class Pessoa
    {
        protected string nome;
        protected string sexo;
        protected int idade;

        public Pessoa()
        {
            nome = "";
            sexo = "";
            idade = 0;
        }

        public Pessoa(string nome, string sexo, int idade)
        {
            this.nome = nome;
            this.sexo = sexo;
            this.idade = idade;
        }

        public string Nome
        {
            get => nome;
            set => nome = value;
        }
        public string Sexo
        {
            get => sexo;
            set => sexo = value;
        }
        public int Idade
        {
            get => idade;
            set => idade = value;
        }
    }
}
