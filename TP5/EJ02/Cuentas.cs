using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ02
{
    class Cuentas
    {
        private Client iCliente;
        private Cuenta iCuentaCorrientePesos;
        private Cuenta iCuentaCorrienteDolares;
        private Cuenta iCuentaSueldo;
        private Cuenta iCajaAhorro;

        public Cuenta CuentaCorrientePesos
        {
            get { return this.iCuentaCorrientePesos; }
            set { this.iCuentaCorrientePesos = value; }
        }

        public Cuenta CuentaCorrienteDolares
        {
            get { return this.iCuentaCorrienteDolares; }
            set { this.iCuentaCorrienteDolares = value; }
        }

        public Cuenta CuentaSueldo
        {
            get { return this.iCuentaSueldo; }
            set { this.iCuentaSueldo = value; }
        }

        public Cuenta CajaAhorro
        {
            get { return this.iCajaAhorro; }
            set { this.iCajaAhorro = value; }
        }

        public Cuentas()
        {
            this.iCliente = new Client(95583134, "Kevin");          //Se considera un cliente por defecto y cuentas con saldo incial
            this.iCuentaCorrientePesos = new Cuenta(500, 350);       //para poder hacer operaciones
            this.iCajaAhorro = new Cuenta(300, 100);
        }

        public void AbrirCuentaCorrienteDolares()
        {
            this.iCuentaCorrienteDolares = new Cuenta(-2000);
        }

        public void AbrirCuentaSaldo()
        {
            this.iCuentaSueldo = new Cuenta(1500);
        }

    }
}
