using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerosEjemplos
{
    internal class Personita
    {
        public string nombre;
        public int edad;
        public int estatura;

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
    }

    public class Humano {
        public string nombre;
    }
}
