using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaDePagamentoMecanica
{
    class Funileiro : Funcionario
    {
        double totalServ = 0.0;
        double percentual = (0.04 + 0.01);
        public Funileiro(string nome, string sexo, int idade, double salBase, int numDependentes, double comissao, double totalPecas, double totalServ, char cnh, int validadeCnh, double percPeca, double percServ, char escolaridade) : base(nome, sexo, idade, salBase, numDependentes, comissao, totalPecas, totalServ, cnh, validadeCnh, percPeca, percServ, escolaridade)
        {

        }
        public double TotalServ
	    {
		    get => totalServ;
		    set => totalServ = value;	
	    }
        public double Percentual
	    {
	    	get => percentual;
	    	set => percentual = value;	
	    }

        public override double calcComissao()
        {
            return totalServ * percentual;
        }
    }
}
