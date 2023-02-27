using System;
using System.Collections.Generic;
using System.Text;
using Tarea3.Entidades;

namespace Tarea3.Negocio
{
    public class ClsNumero
    {
        public void ImprimirPares(Numero numeros)
        {
            for(int i = numeros.numeroMinino; i < numeros.numeroMaximo; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
