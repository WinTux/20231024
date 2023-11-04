

namespace PrimerosEjemplos.ConexionConDDBB
{
    internal class Pepe
    {
        public void hablar() { 
            
        }
    }
}

namespace OtrasCosas
{
    using Cosas;
    using System.Diagnostics;

    public class Algo : UnaClaseDeCosas
    {
        public void mostrar() {
            Debug.WriteLine("Mensaje de debug.");
        }
    }
    namespace CosasInternas {
        public class AlgoInterno() {
            public int atributo;
        }
    }
}