using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_Poo_Sub
{
    public class Saude : Pagamento
    {
        protected string estabelecimento;
        protected double valorBase;

        public string Estabelecimento { get => estabelecimento; set => estabelecimento = value; }
        public double ValorBase { get => valorBase; set => valorBase = value; }

        public void setEstabelecimento(string est)
        {
            this.estabelecimento = est;
        }

        public void setValorBase(double valor)
        {
            this.valorBase = valor;
        }

        public override void faturar()
        {
            valor = valorBase + (valorBase * 0.12); //  12%
        }

        public override double getValor()
        {
            return valor;
        }

        public override string getDescricao()
        {
            return $"Saúde: {estabelecimento}";
        }

        internal void setEstab(object text)
        {
            throw new NotImplementedException();
        }
    }

}
