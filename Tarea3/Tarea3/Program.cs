using System;
using Tarea3.Entidades;
using Tarea3.Negocio;

namespace Tarea3
{
    class Program
    {
        static void Main(string[] args)
        {
            Numero numero = new Numero();
            ClsNumero clsnumero = new ClsNumero();
            Console.WriteLine("Numero minimo");
            numero.numeroMinino = int.Parse(Console.ReadLine());
            Console.WriteLine("Numero maximo");
            numero.numeroMaximo = int.Parse(Console.ReadLine());

            clsnumero.ImprimirPares(numero);
        }
    }
}
