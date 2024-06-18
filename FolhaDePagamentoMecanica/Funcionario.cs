using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaDePagamentoMecanica
{
    class Funcionario : Pessoa
    {
        protected double salBase;
        protected int numDependentes;
        protected double comissao;
        protected double totalPecas;
        protected double totalServ;
        protected double percPeca;
        protected double percServ;
        protected char cnh;
        protected int validadeCnh;
        protected char escolaridade;

        public Funcionario()
        {
            salBase = 0.0;
            numDependentes = 0;
            comissao = 0.0;
            totalPecas = 0.0;
            totalServ = 0.0;
            percPeca = 0.0;
            percServ = 0.0;
            cnh = ' ';
            validadeCnh = 0;
            escolaridade = 'F';
        }
        public Funcionario(string nome, string sexo, int idade, double salBase, int numDependentes, double comissao, double totalPecas, double totalServ, char cnh, int validadeCnh, double percPeca, double percServ, char escolaridade) : base(nome, sexo, idade)
        {
            this.salBase = salBase;
            this.numDependentes = numDependentes;
            this.comissao = comissao;
            this.totalPecas = totalPecas;
            this.totalServ = totalServ;
            this.percServ = percServ;
            this.percPeca = percPeca;
            this.cnh = cnh;
            this.validadeCnh = validadeCnh;
            this.escolaridade = escolaridade;
        }
        public double SalBase
        {
            get => salBase;
            set => salBase = value;
        }
        public int NumDependentes
        {
            get => numDependentes;
            set => numDependentes = value;
        }
        public double Comissao
        {
            get => comissao;
            set => comissao = value;
        }
        public double TotalPecas
        {
            get => totalPecas;
            set => totalPecas = value;
        }
        public double TotalServ
        {
            get => totalServ;
            set => totalServ = value;
        }
        public char Cnh
        {
            get => cnh;
            set => cnh = value;
        }
        public int ValidadeCnh
        {
            get => validadeCnh;
            set => validadeCnh = value;
        }
        public double PercPeca
        {
            get => percPeca;
            set => percPeca = value;
        }
        public double PercServ
        {
            get => percServ;
            set => percServ = value;
        }


        public double auxEduc()
        {
            double aux = 0.0;
            int numDependentes = this.numDependentes;
            if (this.escolaridade == 'F')
            {
                aux = 200;
                if (numDependentes <= 4)
                    aux = numDependentes * 50;
            }
            return aux;
        }

        public virtual double calcSalBruto()
        {
            return salBase + this.calcComissao();
        }

        public double calcDescontos()
        {
            return this.calcIR() + calcINSS();
        }

        public double calcIR()
        {
            double bruto = this.calcSalBruto();
            double IR;
            if (bruto <= 1903.98)
                IR = 0;
            else if (bruto <= 2826.65)
                IR = (bruto * 0.075) - 142.80;
            else if (bruto <= 3751.05)
                IR = (bruto * 0.15) - 354.80;
            else if (bruto <= 4664.68)
                IR = (bruto * 0.225) - 636.13;
            else
                IR = (bruto * 0.27) - 869.36;
            return IR;

        }

        public double calcINSS()
        {
            return this.calcSalBruto() * 0.10;
        }

        public double calcSalLiquido()
        {
            return (this.calcSalBruto() - this.calcDescontos()) + this.auxEduc();
        }

        public virtual double calcComissao()
        {
            return 0;
        }






    }
}
