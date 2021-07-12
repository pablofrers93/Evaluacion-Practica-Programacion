// Sabiendo las medidas de los 3 lados de un triángulo, informar si se trata de un triángulo
// equilátero, escaleno o isósceles.
// Verificación si es un triángulo: ladoA+ladoB>ladoC y ladoB+ladoC>ladoA y
// ladoA + ladoC > ladoB.


using System;

namespace PabloFrersEjercicio02
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int lado1, lado2, lado3;

           
            Console.WriteLine("Ingrese lado 1");
            lado1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese lado 2");
            lado2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese lado 3");
            lado3 = Convert.ToInt32(Console.ReadLine());

            if (((lado1 + lado2) > lado3) & ((lado2 + lado3) > lado1) && ((lado1 + lado3) > lado2))
            {
                if ((lado1 == lado2) & (lado2 == lado3))
                    Console.WriteLine("Triangulo equilatero");
                else
                // verifica todas las opciones de triangulos isosceles

                    if ((lado1 == lado2) & (lado3 != lado2) | (lado2 == lado3) & (lado1 != lado3) | (lado1 == lado3) & (lado3 != lado2))
                    Console.WriteLine("Triangulo isosceles");
                else
                    Console.WriteLine("Triangulo escaleno");                  
            }

            else
                Console.WriteLine("Los valores no corresponden a un triangulo");

        }
    }
}
