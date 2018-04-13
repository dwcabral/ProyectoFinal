using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, resultado;
            string nombre = "DOMINGO CABRAL,FRANCIS MONTERO,YSUAL MONTERO";
            string matricula = "08-EISN-032,13-EISM-1-021,13-EISM-1-035";

            Console.WriteLine("Escriba el primer numero:");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el segundo numero:");
            numero2 = int.Parse(Console.ReadLine());

            resultado = numero1 + numero2;

            while (resultado == 2500)
            {
                Console.WriteLine("La suma es :" + resultado);
            }

            for (int i = 0; i < numero1; i++)
            {
                Console.WriteLine("La suma es :" + resultado);
            }
            if (nombre == "DOMINGO CABRAL,FRANCIS MONTERO,YSUAL MONTERO")
            {
                Console.WriteLine("Nombre :" + nombre);
            }
            if (matricula == "08-EISN-032,13-EISM-1-021,13-EISM-1-035")
            {
                Console.WriteLine("Matricula :" + matricula);
            }

            Console.ReadKey();
        }
    }
}