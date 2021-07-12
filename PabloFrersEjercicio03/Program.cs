// De una lista de X temperaturas en grados Celsius se desea ir conociendo su equivalente
// en grados Fahrenheit a medida que se van ingresando. Al finalizar el ingreso de datos
// informar:

using System;

namespace PabloFrersEjercicio03
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int Xcontador = 5;
            int gradosCelcius, mayorTemperatura=0, promedioTemperatura;
            int sumaGradosCelcius = 0;

            do
            {
                Console.WriteLine("ingrese temperatura en grados celcius");
                gradosCelcius = Convert.ToInt32(Console.ReadLine());

                // verifica que la temperatura se encuentre en el rango correcto

                    if (gradosCelcius >= -70 & gradosCelcius <= 60)
                    {
                        sumaGradosCelcius += gradosCelcius;

                        if (gradosCelcius > mayorTemperatura)
                            mayorTemperatura = gradosCelcius;

                        Console.WriteLine("{0} grados Celcius equivalen a {1} grados Fahrenheit", gradosCelcius, obtenerGradosFahrenheit(gradosCelcius));

                        Xcontador--;
                    }
                    else
                    Console.WriteLine("temperatura fuera de rango (-70, +60)");
            }
            while (Xcontador >= 1);

            promedioTemperatura = (sumaGradosCelcius / 5);

            Console.WriteLine("El promedio de temperaturas ingresadas fue de {0}", promedioTemperatura);
            Console.WriteLine("La mayor temperatura registrada fue de {0}", mayorTemperatura);

                    
        }

        private static int obtenerGradosFahrenheit(int gradosCelcius)
        {
            int gradosFahrenheit;

            gradosFahrenheit = Convert.ToInt32(1.8 * gradosCelcius + 32);
            return gradosFahrenheit;
        }
    }
}
