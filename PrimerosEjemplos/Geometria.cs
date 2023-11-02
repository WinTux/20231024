

namespace HerramientasGeometricas
{

    public class FiguraGeometrica
    {
        protected string nombre { get; set; }
        protected float area { get; set; }
        protected float perimetro { get; set; }
        protected int cantidadLados { get; set; }
    }

    public class Cuadrado : FiguraGeometrica {
        private float lado_x, lado_y;
        public Cuadrado() {
            nombre = "Cuadrado";
            cantidadLados = 4;
            lado_x = lado_y = 1;
        }
        public void calcularArea() {
            area = lado_x * lado_y;
        }
        public string mostrar() {
            return $"Figura: {nombre}, lados: {cantidadLados}, area: {area}";
        }
    }
    public class Triangulo : FiguraGeometrica
    {
        private float lado_base, altura;
        public Triangulo()
        {
            nombre = "Triangulo";
            cantidadLados = 3;
            lado_base = altura = 1;
        }
        public void calcularArea()
        {
            area = (lado_base * altura) / 2;
        }
    }
}


namespace Cosas {
    public class UnaClaseDeCosas {
        int numero;
    }
}