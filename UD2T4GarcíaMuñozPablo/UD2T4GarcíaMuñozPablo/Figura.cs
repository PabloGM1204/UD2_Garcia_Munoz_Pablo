using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD2T4GarcíaMuñozPablo{
    internal abstract class Figura{

        /// <summary>
        /// Método virtual para calcular el perímetro.
        /// </summary>
        /// <returns>Devuelve el valor del cálculo del area.</returns>
        /// <exception cref="NotImplementedException">En el caso de que en la clase que herede no este implementado.</exception>
        public virtual float Perimetro() {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Método virtual para calcular el área.
        /// </summary>
        /// <returns>Devuelve el valor del cálculo del area.</returns>
        /// <exception cref="NotImplementedException">En el caso de que en la clase que herede no este implementado.</exception>
        public virtual float Area() {  
            throw new NotImplementedException(); 
        }
    }
}



