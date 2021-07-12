// 1. Desarrolle la resolución para hallar el perímetro y la superficie de un triángulo
// rectángulo sabiendo la medida de sus catetos.

using System;

namespace PabloFrersEjercicio01
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int catetoA, catetoB;
            double hipotenusa, superficie, perimetro;

            Console.WriteLine("ingrese cateto A del triangulo");
            catetoA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese cateto B del triangulo");
            catetoB = Convert.ToInt32(Console.ReadLine());

            hipotenusa = obtenerHipotenusa(catetoA, catetoB);
            superficie = obtenerSuperficie(catetoA, catetoB);
            perimetro = obtenerPerimetro(catetoA, catetoB, hipotenusa);

            Console.WriteLine("El perimetro del triangulo es de: {0}", perimetro);
            Console.WriteLine("La superficie del triangulo es de : {0}", superficie);

        }

        private static double obtenerPerimetro(int catetoA, int catetoB, double hipotenusa)
        {
            double perimetro;

            perimetro = catetoA + catetoB + hipotenusa;

            return perimetro;
        }

        private static double obtenerSuperficie(int catetoA, int catetoB)
        {
            double superficie;

            superficie = (catetoA + catetoB) / 2;

            return superficie;
        }

        private static double obtenerHipotenusa(int catetoA, int catetoB)
        {
            double hipotenusa;

            hipotenusa = Math.Sqrt((Math.Pow(catetoA, 2)) + (Math.Pow(catetoB, 2)));

            return hipotenusa;
        }
    }
}
