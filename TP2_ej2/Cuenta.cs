using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_ej2
{
    class Cuenta
    {
        private double iSaldo;
        private double iAcuerdo;
        private double iSaldoInicial;
        private double NroCuenta;

        public Cuenta(double pAcuerdo)
        { this.iAcuerdo = pAcuerdo; }

        public Cuenta(double pSaldoInicial, double pAcuerdo)
        { this.iSaldoInicial = pSaldoInicial;
          this.iAcuerdo = pAcuerdo;
        }

        public double Saldo { get { return this.iSaldo; } }
        public double Acuerdo { get { return this.iAcuerdo; } }

        public void AcreditarSaldo(double pSaldo) { this.iSaldo += pSaldo; }

        public bool DevitarSaldo(double pSaldo) { if (this.iSaldo + this.iAcuerdo <= pSaldo) { this.iSaldo -= pSaldo; return true; } else { return false; } }

    }
}
