using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaDePagamentoMecanica
{
    class Mecanico : Funcionario
    {
        double totalPecas = 0.0;
        double percentual = 0.03;
        public Mecanico(string nome, string sexo, int idade, double salBase, int numDependentes, double comissao, double totalPecas, double totalServ, char cnh, int validadeCnh, double percPeca, double percServ, char escolaridade) : base(nome, sexo, idade, salBase, numDependentes, comissao, totalPecas, totalServ, cnh, validadeCnh, percPeca, percServ, escolaridade)
        {

        }
        public double TotalPecas
	    {
		    get => totalPecas;
		    set => totalPecas = value;	
	    }
        public double Percentual
	    {
	    	get => percentual;
	    	set => percentual = value;	
	    }


        public override double calcComissao()
        {
            return totalPecas * percentual;
        }
    }
}
