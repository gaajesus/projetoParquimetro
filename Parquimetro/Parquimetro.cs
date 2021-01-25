using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parquimetro
{
    class Parquimetro
    {
        private decimal saldo = 0, troco=0, ticket = 1.50M;

        public void addMoeda(decimal valor)
        {
            saldo += valor;
        }
        public decimal SaldoCons()
        {
            return saldo;
        }
        public decimal Troco()
        {
            return troco;
        }
        public string Confirmar()
        {
            if (saldo < ticket)
            {
                return "Saldo insuficiente!! :(";
            }
            else
            {
                troco = saldo - ticket;
                saldo = 0;
                return "Compra finalizada!! :)";
                
            }
        }
        public decimal Cancel()
        {
            decimal aux = saldo;
            saldo = 0;
            return aux;
        }
    }
}
