using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_Poo_Sub
{
    public abstract class Pagamento
    {
        protected double valor;

        protected double Valor { get => valor; set => valor = value; }

        public abstract void faturar();
        public abstract double getValor();
        public abstract string getDescricao();
    }

}
