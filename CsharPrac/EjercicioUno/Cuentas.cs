using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharPrac.EjercicioUno
{
    public class Cuentas
    {
        public string Titular;
        public int Saldo;
        public string Moneda;
        public Cuentas(string _titular, string _moneda, int _saldo) 
        {
            this.Titular = _titular;
            this.Moneda = _moneda;
            this.Saldo = _saldo; ;
            
        }

        public void SetTitular(string _titular)
        {
            this.Titular = _titular;
        }

        public string GetTitular()
        {
            return this.Titular;
        }

        public void SetSaldo(int _saldo)
        {
            this.Saldo = _saldo;
        }

        public int GetSaldo()
        {
            return this.Saldo;
        }

        public void SetMoneda(string _moneda)
        {
            this.Moneda = _moneda;
        }

        public string GetMoneda()
        {
            return this.Moneda;
        }

        //metodo implementado para ser modificado en otras clases
        public virtual void Depositar()
        {
            Console.WriteLine("Usted deposito a su Cuenta Gs.200.000");
        }

        public virtual void Retirar()
        {
            Console.WriteLine("El monto retirado de su Cuenta es de Gs.100.000");
        }
    }
}
