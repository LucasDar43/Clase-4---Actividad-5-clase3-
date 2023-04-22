namespace actividad5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitamos al usuario el número máximo para calcular primos en ese rango
            int maximo = PedirEnteroPositivo("Ingrese el número máximo para calcular la cantidad de números primos en ese rango:");

            // Calculamos y mostramos los números primos en el rango de 2 a maximo
            Calcular(maximo);
        }

        // Método para validar que el usuario ingrese un entero positivo
        static int PedirEnteroPositivo(string mensaje)
        {
            while (true)
            {
                Console.Write(mensaje);
                if (int.TryParse(Console.ReadLine(), out int numero) && numero > 0)
                {
                    return numero;
                }
                Console.WriteLine("Error: debe ingresar un número entero positivo.");
            }
        }

        static void Calcular(int maximo)
        {
            for (int i = 2; i <= maximo; i++)
            {
                bool esPrimo = true;

                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }

                if (esPrimo)
                {
                    Console.WriteLine(i + " es primo.");
                }
            }
        }
    }
}
