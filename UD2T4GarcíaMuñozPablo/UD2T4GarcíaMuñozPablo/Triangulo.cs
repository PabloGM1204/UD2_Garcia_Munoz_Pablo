using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD2T4GarcíaMuñozPablo{
    internal class Triangulo: Figura{
        // Variables del triángulo (base al ser una palabra reservada he puesto cimiento).
        private float cimiento;
        private float altura;

        /// <summary>
        /// Constructor de la clase de Triángulo.
        /// </summary>
        /// <param name="cimiento">Es la medida de la base del triángulo.</param>
        /// <param name="altura">Es la medida de la altura del triángulo.</param>
        public Triangulo(float cimiento, float altura) {
            this.cimiento = cimiento;
            this.altura = altura;
        }

        /// <summary>
        /// Sobrescrito el método que calcula el perimetro del triángulo.
        /// </summary>
        /// <returns>Valor float del perímetro del triángulo.</returns>
        public override float Perimetro(){
            float a = cimiento / 2;
            float b = (float)Math.Sqrt(Math.Pow(altura, 2)+Math.Pow(a, 2));
            return (a * 2 + cimiento);
        }

        /// <summary>
        /// Método sobreescrito que calcula el área del triángulo.
        /// </summary>
        /// <returns>Valor float del área del triángulo.</returns>
        public override float Area() {
            return ((cimiento + altura)/2);
        }
    }
}
