using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerosEjemplos
{
    public class Personita
    {
        public string nombre { get; set; }
        private int edad;
        private int _estatura;
        public int estatura {
            get {
                return _estatura;
            }
            set { 
                if(value > 0)
                    _estatura = value;
            }
        }

        public Personita(string nombre, int edad) {
            this.nombre = nombre;
            this.edad = edad;
            estatura = 180;//cm
        }
        public Personita() {
            nombre = "N/A";
            edad = 1;
            estatura = 160;
        }
        public Personita(string nom, int estat, int ed) {
            nombre = nom;
            estatura = estat;
        }
        public Personita(int estat, string nom )
        {
            nombre = nom;
            estatura = estat;
        }
        public void presentarse() {
            //Console.WriteLine("Hola, me llamo " + nombre +" y tengo " + edad + " años.");
            Console.WriteLine($"Hola, me llamo {nombre} y tengo {edad} años.");
        }

        public void cambiarEdad(int edad) {
            if (edad >= 0)
                this.edad = edad;
            else
                Console.WriteLine($"Valor de edad incorrecto {edad}; se mantiene el original {this.edad}");
        }

        public int calcularIndice() {
            int res = div(multiplicar(edad, estatura), 2);
            return res;
        }
        private int multiplicar(int a, int b) {
            return a * b;
        }
        private int div(int x, int y) {
            return x / y;
        }
    }

    public class Humano {
        public string nombre;
    }
}
