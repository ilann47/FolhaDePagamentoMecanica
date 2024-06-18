using FolhaDePagamentoMecanica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaDePagamentoMecanica
{
    internal class Programa
    {
        private Interfaces inter;
        private Empresa empresa;

        public Programa()
        {
            inter = new Interfaces();
        }
        public void Run()
        {
            string razaoSocial = "";
            string cnpj = "";
            int NF = 0;


            inter.pecaDadosEmpresa(ref razaoSocial, ref cnpj, ref NF);
            empresa = new Empresa(razaoSocial, NF, cnpj);
            empresa.ProcessaFolha(inter);
 
        }
    }
}
