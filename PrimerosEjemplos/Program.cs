namespace PrimerosEjemplos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, \nWorld\t!");
            Console.WriteLine(777);//entero (integer -> int)
            Console.WriteLine(80.50);//doble (double)
            Console.WriteLine(-70.50f);//flotante (float)
            Console.WriteLine(4+9);
            Console.WriteLine((4 + 8)* 7 / 5.0);
            Console.WriteLine(4 > 8);
            Console.WriteLine(4 <= 8 && (5 == 7 || 5 <= 10));
            Console.WriteLine(true);

            //Strings: concatenación
            Console.WriteLine("Hola " + "a todos.");
            Console.WriteLine("14" + 6);
            Console.WriteLine(7 + "14" + 9);

            Console.WriteLine(7 + 18 + 5 + "10" + (6 + 7));

            Console.WriteLine(7 + 18 * 5 - 10 / 2f);//para el ojo común: 57.5
            //  7 + 90 - 5
            // 92

            /*
                    ()
                    ^
                  * / %
                  +   -
                -------->
             */

            //Variables
            int primerNumero;

            int EsteEsElCoeficienteDeCrecimientoPorcentualMenualDeLaEmpresa;

            int a;
            int b;
            int h;

            string n;

            a = 56;

            string nombre = "Pepe";

            bool casado = false;

            var estatura = 1.72;

            estatura = 2;

            //Casteo
            b = (int)1.9999;
            Console.WriteLine("El valor de b es: "+b);

            //Arreglos unidimensionales
            string[] nombres = new string[4];
            string[] apellidos = {"Perales","Sosa","Rocha","Maldonado" };
            apellidos[3] = "665";
            Console.WriteLine(apellidos[3]);

            //Arreglos multi-dimensionales
            int[,] tablero = new int[2,5];//filas, columnas
            tablero[0, 4] = 75;

            bool[,,] cubo = new bool[2, 4, 3];//lado, alto, profundidad
            cubo[0, 2, 0] = true;

            string[,,,,,] algo = new string[3,5,3,6,4,7];
            algo[0, 0, 0, 4, 0, 0] = "Sofía";
        }
    }
}