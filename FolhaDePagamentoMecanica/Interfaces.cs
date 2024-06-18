using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaDePagamentoMecanica
{
    class Interfaces
    {
        public Interfaces()
        {
        }

        public void pecaDadosFuncionario(ref string mNome, ref string mSexo, ref int mIdade, ref double mSalBase, ref int mNumDependentes, ref double mComissao, ref double mTotalPecas, ref double mTotalServ, ref char mCnh, ref int mValidadeCnh, ref char mCargo, ref double mPercPeca, ref double mPercServ, ref char mEscolaridade)
        {
            Console.WriteLine("Qual o nome do funcionario");
            mNome = Console.ReadLine();
            Console.WriteLine("idade");
            mIdade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sexo");
            mSexo = Console.ReadLine();
            Console.WriteLine("Qual a escolaridade (F)fundamental, (M)Ensino medio, (S)Superior");
            mEscolaridade = Console.ReadKey().KeyChar;
            Console.WriteLine("Salario base do funcionario");
            mSalBase = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Cargo do funcionario: (N) funcionario Normal, (F)Funileiro, (G)gerente, (E)Entregador");
            mCargo = Console.ReadKey().KeyChar;
            Console.WriteLine("Quantidade de dependentes do funcionario");
            mNumDependentes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Quantidade de pecas vendidas pelo funcioanrio");
            mTotalPecas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Quantidade de servicos efetuados pelo funcionario");
            mTotalServ = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Percentual de comissao de pecas /100");
            mPercPeca = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Percentual de comissao de servicos /100");
            mPercServ = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Funcionario possui cnh? (S)sim (N)não");
            mCnh = Console.ReadKey().KeyChar;
            Console.WriteLine("Qual a validade da CNH?");
            mValidadeCnh = Convert.ToInt32(Console.ReadLine());
        }

        public void mostraDadosFuncionario(Funcionario oFunc)
        {
            Console.WriteLine("\n--------------------------------------------------------------");
            Console.WriteLine("Nome: " + oFunc.Nome);
            Console.WriteLine("Idade: " + oFunc.Idade);
            Console.WriteLine("Sexo: " + oFunc.Sexo);
            Console.WriteLine("Salario Bruto: " + oFunc.calcSalBruto());
            Console.WriteLine("Salario liquido: " + oFunc.calcSalLiquido());
            Console.WriteLine("Total comissao: " + oFunc.calcComissao());
            Console.WriteLine("Total Descontos: " + oFunc.calcDescontos());
            Console.WriteLine("--------------------------------------------------------------\n");

        }


        public void pecaDadosEmpresa(ref string razaoSocial, ref string mCnpj, ref int mNumFunc)
        {
            Console.WriteLine("razaoSocial");
            razaoSocial = Console.ReadLine();
            Console.WriteLine("cnpj");
            mCnpj = Console.ReadLine();
            Console.WriteLine("Quantidade de Funcionarios");
            mNumFunc = Convert.ToInt32(Console.ReadLine());
        }
        public void mostraDadosEmpresa(double totalSalBruto, double totalComissao, double totalDescontos, double totalSalLiquido, string razaoSocial, string cnpj, int numFunc)
        {
            Console.WriteLine("\n--------------------------------------------------------------");
            Console.WriteLine("Razao social: " + razaoSocial);
            Console.WriteLine("CNPJ: " + cnpj);
            Console.WriteLine("Numero de funcionarios: " + numFunc);
            Console.WriteLine("Folha de Pagamento");
            Console.WriteLine("Total de salarios bruto pagos pela empresa: " + totalSalBruto);
            Console.WriteLine("Total de comissao: " + totalComissao);
            Console.WriteLine("Total de salarios Liquidos pagos pela empresa: " + totalSalLiquido);
            Console.WriteLine("Total de descontos: " + totalDescontos);
            Console.WriteLine("--------------------------------------------------------------");
        }

    }
}
