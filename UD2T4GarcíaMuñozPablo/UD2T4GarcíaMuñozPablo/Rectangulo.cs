using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD2T4GarcíaMuñozPablo{
    internal class Rectangulo: Figura{
        // Variables para los lados del rectángulo.
        private float lado1;
        private float lado2;

        /// <summary>
        /// Constructor que recibe el valor de los dos lados y lo guarda.
        /// </summary>
        /// <param name="lado1">1º lado de un rectángulo.</param>
        /// <param name="lado2">2º lado de un rectángulo.</param>
        public Rectangulo(float lado1, float lado2) {
            this.lado1 = lado1;
            this.lado2 = lado2;
        }

        /// <summary>
        /// Sobrescrito el método que calcula el perímetro del rectángulo.
        /// </summary>
        /// <returns>Valor float del perímetro del rectángulo.</returns>
        public override float Perimetro(){
            return 2 * (lado1 + lado2);
        }

        /// <summary>
        /// Sobrescrito el método que calcula el área del rectángulo.
        /// </summary>
        /// <returns>Valor float del área del rectángulo.</returns>
        public override float Area(){
            return lado1 * lado2;
        }

    }
}
