using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T22023_Problema03
{
    public class GetInicio
    {
        public static int menuP() {
            Console.Write("" +
                        "======================\n" +
                        "Las cuatro operaciones\n" +
                        "======================\n" +
                        "1: Suma\n" +
                        "2: Resta\n" +
                        "3: Multiplicación\n" +
                        "4: División\n" +
                        "5: Salir\n" +
                        "======================\n" +
                        "Ingresa una opción: ");


            return getOpcion();
        }
        public static int sumar()
        {

            GetEnviar.cabeceraDeP("Sumando ...\n");
            int suma = GetEnviar.getsuma();
            Console.Write("============\n" +
                        "Resultado " + suma + "\n");
            GetEnviar.pieDeP();

            int opcion = getOpcion();

            if (opcion == 2) return 0;
            return opcion;
        }


        public static int restar()
        {

            GetEnviar.cabeceraDeP("Restando ...\n");
            int resta = GetEnviar.getResta();
            Console.Write("============\n" +
                        "Resultado " + resta + "\n");

            GetEnviar.pieDeP();

            int opcion = getOpcion();
            if (opcion == 1) return 2;
            if (opcion == 2) return 0;
            return opcion;
        }

        public static int multiplicar()
        {

            GetEnviar.cabeceraDeP("Multiplicando ...\n");

            int producto = GetEnviar.getMultiplicacion();

            Console.Write("============\n" +
                        "Resultado " + producto + "\n");

            GetEnviar.pieDeP();

            int opcion = getOpcion();
            if (opcion == 1) return 3;
            if (opcion == 2) return 0;
            return opcion;
        }

        public static int dividir()
        {

            GetEnviar.cabeceraDeP("Dividiendo ...\n");
            int cociente = GetEnviar.getDivision();
            Console.Write("============\n" +
                        "Resultado " + cociente + "\n");
            GetEnviar.pieDeP();
            int opcion = getOpcion();
            if (opcion == 1) return 4;
            if (opcion == 2) return 0;
            return opcion;
        }

       


        public static int getOpcion()
        {
            string opcionTexto = Console.ReadLine();
            return int.Parse(opcionTexto);
        }
    }
}
