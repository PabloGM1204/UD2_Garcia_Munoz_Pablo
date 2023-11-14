using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD2T4GarcíaMuñozPablo{
    internal class Circulo: Figura{
        // Variable de la clase circulo.
        private float radio;

        /// <summary>
        /// Constructor del círculo.
        /// </summary>
        /// <param name="radio">Radio del círculo.</param>
        public Circulo(float radio) {
            this.radio = radio;
        }

        /// <summary>
        /// Sobrescrito el método que calcula el perimetro del círculo.
        /// </summary>
        /// <returns>Valor float del perímetro del círculo.</returns>
        public override float Perimetro() {
            return (float)(2 * Math.PI * radio);
        }

        /// <summary>
        /// Sobrescrito el método que calcula el área del círculo.
        /// </summary>
        /// <returns>Valor float del área del círculo.</returns>
        public override float Area() {
            return (float)(Math.PI * radio * radio);
        }
    }
}
