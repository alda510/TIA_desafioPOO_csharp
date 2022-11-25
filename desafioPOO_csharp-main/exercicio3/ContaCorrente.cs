using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio3
{
    public class ContaCorrente
    {
        public string NomeCorrentista { get; set; }
        public int NumeroConta { get; set; }
        public int NumeroAgencia { get; set; }
        public double Saldo {get; private set;}
        public void Depositar(double valor)
        {
            Saldo += valor;
        }
        public void Sacar(double valor)
        {
            if(valor > Saldo)
                return;

            Saldo -= valor;
        }
    }
}