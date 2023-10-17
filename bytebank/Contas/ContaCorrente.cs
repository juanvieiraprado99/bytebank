using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytebank.Titular;

namespace bytebank.Contas
{
    public class ContaCorrente
    {
        private int numero_agencia;
        public int Numero_Agencia
        {
            get { return numero_agencia; }
            set { 
                    if(value > 0)
                    {
                        this.numero_agencia = value;
                    }
                    
                }
        }
        private string conta;
        private double saldo;

        private Cliente titular;


        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            else
            {
                Sacar(valor);
                destino.Depositar(valor);
                return true;
            }
        }

        public void SetSaldo(double valor)
        {
            if (valor < 0)
            {
                return;
            }
            else
            {
                this.saldo = valor;
            }
        }

        public double GetSaldo()
        {
            return this.saldo;
        }
    }
}
