using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomUs_MayorArray
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("¿Cuantos elementos tiene el array? ");

            int[] result_array = GetInputInt();


            MaxNum maxNum = new MaxNum(result_array);

            int result = maxNum.GetMaxArrayNum();

            Console.WriteLine($"El valor mayor es: {result}");

            Console.ReadLine();

        }

        public static int[] GetInputInt()
        {

            int inputint = 0, i = 0, array_size = 0;

            int[] int_array; 

            while (!int.TryParse(Console.ReadLine(), out array_size));

            // Creamos el array con el tamaño especificado
            int_array = new int[array_size];

            // Validacion Int
            while ( i < array_size)
            {
                Console.Write($"Numero {i + 1}: ");
                while(!int.TryParse(Console.ReadLine(), out inputint));

                // Asignamos el valor ingresado en el espacio siguiente del array
                int_array[i] = inputint;

                i++;
            };

            // Regresamos el array de int
            return int_array;   

        }
    }
}
