using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T22023_Problema03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = GetInicio.menuP();
            do
            {
                Console.Clear();
                switch (opcion)
                {
                    case 0:
                        opcion = GetInicio.menuP();
                        break;
                    case 1:
                        opcion = GetInicio.sumar();
                        break;
                    case 2:
                        opcion = GetInicio.restar();
                        break;
                    case 3:
                        opcion = GetInicio.multiplicar();
                        break;
                    case 4:
                        opcion = GetInicio.dividir();
                        break;
                }
            } while (opcion != 5);

        }
    }
}
