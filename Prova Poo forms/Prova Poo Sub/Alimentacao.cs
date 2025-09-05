using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_Poo_Sub
{
    public class Alimentacao : Pagamento
    {
        protected string descricao;
        protected double valorUnit;

        public string Descricao { get => descricao; set => descricao = value; }
        public double ValorUnit { get => valorUnit; set => valorUnit = value; }

        public void setDescricao(string descricao)
        {
            this.descricao = descricao;
        }

        public void setValorUnit(double valorUnit)
        {
            this.valorUnit = valorUnit;
        }

        
        public override void faturar()
        {
            valor = valorUnit + (valorUnit * 0.05 ) ; //  5%
        }

        public override double getValor()
        {
            return valor;
        }

        public override string getDescricao()
        {
            return $"Alimento: {descricao}";
        }
    }

}
