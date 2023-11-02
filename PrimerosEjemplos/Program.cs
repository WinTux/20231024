using HerramientasGeometricas;
namespace PrimerosEjemplos
{
    internal class Program
    {
        static int x = 6;

        static void Main(string[] args)
        {
            Console.WriteLine("Cantidad de argumentos: " + args.Length);


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
            Console.WriteLine("14" + x);
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


            string[] mascotas = { };

            //Llamada a un método
            magico(args);

            //POO (OOP)
            // Pilares de la POO
            Personita pers = new Personita("Pepe", 21);
            pers.presentarse();
            pers.nombre = "Ana";
            pers.cambiarEdad(-5);
            pers.estatura = -28;
            pers.presentarse();
            


            Console.WriteLine(pers.nombre);
            Console.WriteLine(pers.estatura);

            Console.WriteLine("El índice es: " + pers.calcularIndice());

            

            Humano hum = new Humano();

            Cliente cl1 = new Cliente();
            cl1.nombre = "Rocky";
            cl1.cambiarEdad(29);
            cl1.correo = "rocky@apolo.com";
            cl1.presentarse();

            // Sobre polimorfismo
            FiguraGeometrica cuad = new HerramientasGeometricas.Cuadrado();
            ((HerramientasGeometricas.Cuadrado)cuad).calcularArea();
            Console.WriteLine(
                ((HerramientasGeometricas.Cuadrado)cuad).mostrar()
            );

            Triangulo tri = new Triangulo();
            HerramientasGeometricas.Cuadrado cuad2 = new HerramientasGeometricas.Cuadrado();

            FiguraGeometrica[] misFiguras = { cuad,tri,cuad2};
        }

        string nombre = "";

        public static void magico(string[] y) {
            int cantidadArgs = y.Length;
            //Condicionales
            if (cantidadArgs == 0)//No hay argumentos
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Modo de uso: -version [ENTER]");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else { // Sí hay argumentos
                if (y[0].Equals("-version"))
                    Console.WriteLine("PrimerosEjemplos v. 1.0 (c)2023");
                else
                    Console.WriteLine("Comando no reconocido: "+ y[0]);
            }
            Console.WriteLine(x+ 5);
        }
    }
}