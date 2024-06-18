using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaDePagamentoMecanica
{
    class Gerente : Funcionario
    {
        public Gerente(string nome, string sexo, int idade, double salBase, int numDependentes, double comissao, double totalPecas, double totalServ, char cnh, int validadeCnh, double percPeca, double percServ, char escolaridade) : base(nome, sexo, idade, salBase, numDependentes, comissao, totalPecas, totalServ, cnh, validadeCnh, percPeca, percServ, escolaridade)
        {

        }

        public override double calcComissao()
        {
            return 0;
        }
    }
}
