using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T22023_Problema03
{
    public class GetEnviar
    {
        public static int getsuma()
        {
            int numero1 = Operaciones.getEntero("Numero 1: ");
            int numero2 = Operaciones.getEntero("Numero 2: ");
            return numerico.sumar(numero1, numero2);
        }
        public static int getResta()
        {
            int numero1 = Operaciones.getEntero("Numero 1: ");
            int numero2 = Operaciones.getEntero("Numero 2: ");
            return numerico.restar(numero1, numero2);
        }

        public static int getMultiplicacion()
        {
            int numero1 = Operaciones.getEntero("Numero 1: ");
            int numero2 = Operaciones.getEntero("Numero 2: ");
            return numerico.multiplicar(numero1, numero2);
        }

        public static int getDivision()
        {
            int numero1 = Operaciones.getEntero("Numero 1: ");
            int numero2 = Operaciones.getEntero("Numero 2: ");
            return numerico.dividir(numero1, numero2);
        }

        public static void cabeceraDeP(string texto)
        {
            Console.Write("" +
                                    "===========================================\n" +
                                    texto +
                                    "===========================================\n");
        }

        public static void pieDeP()
        {
            Console.Write("============================================\n" +
                                    "1: Limpiar | 2: Regresar Menú |\n" +
                                    "============================================\n" +
                                    "Ingresa una opción: ");
        }

        public static int getOpcion()
        {
            string opcionTexto = Console.ReadLine();
            return int.Parse(opcionTexto);
        }
    }
}
