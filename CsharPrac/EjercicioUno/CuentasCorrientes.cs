using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharPrac.EjercicioUno
{
    public class CuentasCorrientes:Cuentas
    {
        public int LimiteDiario;
        public string TipoCuentaCorriente;
        public CuentasCorrientes(string _titular, int _saldo, string _moneda, int _limiteDiario, string _tipoCuentaCorriente):
            base(_titular:_titular, _saldo:_saldo, _moneda: _moneda) 
        {
            this.LimiteDiario = _limiteDiario;
            this.TipoCuentaCorriente = _tipoCuentaCorriente;
        }

        public void SetLimiteDiario(int _limiteDiario)
        {
            this.LimiteDiario = _limiteDiario;
        }

        public int GetLimiteDiario()
        {
            return this.LimiteDiario;
        }

        public void SetTipoCuentaCorriente(string _tipoCuentaCorriente)
        {
            this.TipoCuentaCorriente = _tipoCuentaCorriente;
        }

        public string GetTipoCuentaCorriente()
        {
            return this.TipoCuentaCorriente;
        }

        //metodo implementado de la clase Cuentas
        public override void Retirar()
        {
            Console.WriteLine("El monto retirado de su Cuenta Corriente es de Gs.500.000");
        }

        public void SetConsultarSaldo(int _saldo)
        {
            this.Saldo = _saldo;
        }

        public int GetConsultarSaldo()
        {
            return this.Saldo;
        }

    }
}
