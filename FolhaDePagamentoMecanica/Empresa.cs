using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaDePagamentoMecanica
{
    class Empresa
    {
        private string razaoSocial;
        private string cnpj;
        private int numFunc;
        private double totalSalBruto;
        private double totalDescontos;
        private double totalComissao;
        private double totalSalLiquido;
        public Empresa()
        {

        }
        public Empresa(string razaoSocial, int numFunc, string cnpj)
        {
            this.razaoSocial = razaoSocial;
            this.numFunc = numFunc;
            this.cnpj = cnpj;
        }
        public string RazaoSocial
        {
            get => razaoSocial;
            set => razaoSocial = value;
        }
        public int NumFunc
        {
            get => numFunc;
            set => numFunc = value;
        }
        public double TotalSalBruto
        {
            get => totalSalBruto;
            set => totalSalBruto = value;
        }
        public double TotalDescontos
        {
            get => totalDescontos;
            set => totalDescontos = value;
        }
        public double TotalComissao
        {
            get => totalComissao;
            set => totalComissao = value;
        }
        public double TotalSalLiquido
        {
            get => totalSalLiquido;
            set => totalSalLiquido = value;
        }

        public void ProcessaFolha(Interfaces aInter)
        {
            string mNome = "";
            string mSexo = "";
            int mIdade = 0;
            int mNumDependentes = 0;
            double mSalBase = 0.0;
            double mComissao = 0.0;
            double mTotalPecas = 0.0;
            double mTotalServ = 0.0;
            double mPercServ = 0.0;
            double mPercPeca = 0.0;
            char mCnh = ' ';
            int mValidadeCnh = 0;
            char mEscolaridade = ' ';
            char mCargo = 'M';
            Funcionario oFunc;

            for (int i = 0; i < numFunc; i++)
            {
                aInter.pecaDadosFuncionario(ref mNome, ref mSexo, ref mIdade, ref mSalBase, ref mNumDependentes, ref mComissao, ref mTotalPecas, ref mTotalServ, ref mCnh, ref mValidadeCnh, ref mCargo, ref mPercPeca, ref mPercServ, ref mEscolaridade);


                if (mCargo == ' ')
                {
                    oFunc = new Gerente(mNome, mSexo, mIdade, mSalBase, mNumDependentes, mComissao, mTotalPecas, mTotalServ, mCnh, mValidadeCnh, mPercServ, mPercPeca, mEscolaridade);
                }
                else if (mCargo == ' ')
                {
                    oFunc = new Entregador(mNome, mSexo, mIdade, mSalBase, mNumDependentes, mComissao, mTotalPecas, mTotalServ, mCnh, mValidadeCnh, mPercServ, mPercPeca, mEscolaridade);
                }
                else if (mCargo == 'F')
                {
                    oFunc = new Funileiro(mNome, mSexo, mIdade, mSalBase, mNumDependentes, mComissao, mTotalPecas, mTotalServ, mCnh, mValidadeCnh, mPercServ, mPercPeca, mEscolaridade);
                    ((Funileiro)oFunc).TotalPecas = mTotalServ;
                    ((Funileiro)oFunc).PercPeca = mPercServ;
                }
                else
                {
                    oFunc = new Mecanico(mNome, mSexo, mIdade, mSalBase, mNumDependentes, mComissao, mTotalPecas, mTotalServ, mCnh, mValidadeCnh, mPercServ, mPercPeca, mEscolaridade);
                    ((Mecanico)oFunc).TotalPecas = mTotalPecas;
                    ((Mecanico)oFunc).PercPeca = mPercPeca;
                }
                totalComissao += oFunc.calcComissao();
                totalDescontos += oFunc.calcDescontos();
                totalSalBruto += oFunc.calcSalBruto();
                totalSalLiquido += oFunc.calcSalLiquido();
                aInter.mostraDadosFuncionario(oFunc);
            }
            aInter.mostraDadosEmpresa(totalSalBruto, totalComissao, totalDescontos, totalSalLiquido, razaoSocial, cnpj, numFunc);
        }
    }
}
