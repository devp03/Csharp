using CsharPrac.EjercicioUno;
using static CsharPrac.EjercicioUno.Cuentas;

var cuentas = new Cuentas("Martin Ocampos", "Gs." , 500000);
var cuentasCorrientes = new CuentasCorrientes("",4500000, "Gs.", 350000, "Profesional");
var cajaDeAhorro = new CajaDeAhorro("", 5600000, "Gs.", 10, "Cuenta Corriente");

Console.WriteLine("Cuentas:");

Console.WriteLine("El titular de la Cuenta es: " + cuentas.GetTitular() + " su saldo es de: " + cuentas.GetMoneda()
+cuentas.GetSaldo());
cuentas.Depositar();
cuentas.Retirar();

Console.WriteLine(" ");
Console.WriteLine("Cuentas Corrientes:");

Console.WriteLine("El limite Diario para retirar de su Cuenta Corriente es de: " +"Gs."+ cuentasCorrientes.GetLimiteDiario());
Console.WriteLine("Tipo de Cuenta Corriente: " + cuentasCorrientes.GetTipoCuentaCorriente());
cuentasCorrientes.Retirar();
Console.WriteLine("El saldo de su Cuenta Corriente es de: " +"Gs."+ cuentasCorrientes.GetConsultarSaldo());


Console.WriteLine(" ");
Console.WriteLine("Caja de Ahorro:");

Console.WriteLine("La tasa de interes es del: " + cajaDeAhorro.GetTasaDeInteres() + "%");
Console.WriteLine("La cuenta esta Vinculada con su: " +"Gs."+ cajaDeAhorro.GetVinculada());
cajaDeAhorro.Retirar();
Console.WriteLine("El saldo de su Caja de Ahorro es de: " +"Gs."+ cajaDeAhorro.GetConsultarSaldo());