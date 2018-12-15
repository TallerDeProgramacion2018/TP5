using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ02
{
    class Account
    {
        private double iDescubierto;
        private int iID;
        private string iName;
        private Client iCliente;
        private List<AccountMovement> iMovements;

        public int ID
        {
            get { return this.iID; }
            set { this.iID = value; }
        }

        public string Name
        {
            get { return this.iName; }
            set { this.iName = value; }
        }

        public double Descubierto
        {
            get { return this.iDescubierto; }
            set { this.iDescubierto = value; }
        }

        public double GetBalance()
        {
            double suma = 0;

            foreach (AccountMovement movement in iMovements)
            {
                suma += movement.Amount;
            }

            return suma;
        }

        /*public Cuenta(double pDescubierto)
        {
            this.iSaldo = 0;
            this.iDescubierto = pDescubierto;
        }

        public Cuenta(double pDescubierto, double pSaldo)
        {
            this.iSaldo = pSaldo;
            this.iDescubierto = pDescubierto;
        }

        public double Saldo
        {
            get { return this.iSaldo; }
            set { this.iSaldo = value; }
        }

        public double AcreditarSaldo(double pSaldo)             //Suma un monto que se pasa como parametro al saldo actual de 
        {                                                       //la cuenta
            this.iSaldo += pSaldo;
            return this.iSaldo;
        }

        public double DebitarSaldo(double pSaldo)                //Resta un monto que se pasa como paramentro al saldo 
        {                                                        //actual de la cuenta, si esta operación no es posible, 
                                                                 //se lanza una excepción.
            if (this.iSaldo <= pSaldo)
            {
                throw new SaldoInsuficienteException();
            }

            this.iSaldo -= pSaldo;
            return this.iSaldo;
        }*/

    }
}
