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

            Console.WriteLine(7 + 18 + 5 + "10");

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
        }
    }
}