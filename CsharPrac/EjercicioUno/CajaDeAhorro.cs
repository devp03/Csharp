using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharPrac.EjercicioUno
{
    public class CajaDeAhorro:Cuentas
    { 
        public int TasaDeInteres;
        public string Vinculada;
        public CajaDeAhorro(string _titular, int _saldo, string _moneda, int _tasaDeInteres, string _vinculada) :
            base(_titular: _titular, _saldo: _saldo, _moneda: _moneda)
        {
            this.TasaDeInteres = _tasaDeInteres;
            this.Vinculada = _vinculada;
        }

        public void SetTasaDeInteres(int _tasaDeInteres){this.TasaDeInteres = _tasaDeInteres;}
        public int GetTasaDeInteres(){return this.TasaDeInteres;}

        public void SetVinculada(string _vinculada) {this.Vinculada= _vinculada;}
        public string GetVinculada() {return this.Vinculada;}

        //metodo implementado de la clase Cuentas
        public override void Retirar()
        {
            Console.WriteLine("El monto retirado de su Caja de Ahorro es de: Gs.250.000");
        }

        public void SetConsultarSaldo(int _saldo){this.Saldo = _saldo;}

        public int GetConsultarSaldo(){return this.Saldo;}

    }
}
