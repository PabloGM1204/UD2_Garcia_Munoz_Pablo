namespace UD2T4GarcíaMuñozPablo
{
    ///////////////////////////////////////////
    // Tarea: UD2T2
    // Alumno/a: Pablo García Muñoz
    // Curso: 2023/2024
    ///////////////////////////////////////////
    internal class Program{
        static void Main(string[] args)
        {
            // Variable que guarda la opción.
            int op = 0;
            do{
                // Lista de posibilidades.
                Console.Write("- MENÚ PRINCIPAL -\n"+
                                "0 - Salir\n"+
                                "1 - Rectángulo\n"+ 
                                "2 - Círculo\n"+
                                "3 - Triángulo\n");
                // Lee la opción.
                try {
                    Console.Write("Introduzca su opción: ");
                    op = int.Parse(Console.ReadLine());
                }catch (FormatException) {
                    op = -1;
                }
                // Switch que decide que cosa hacer.
                switch (op) {
                    // En el caso de querer salir del programa.
                    case 0:
                        Console.WriteLine("Saliendo del programa");
                    break;

                    // En el caso del rectángulo.
                    case 1:
                        Rectangulo();
                    break;
                        
                    // En el caso del círculo.
                    case 2:
                        Circulo();
                    break;

                    // En el caso del triángulo.
                    case 3:
                        Triangulo();
                    break;

                    // Caso por defecto para cuando ocurra la expcepción o se escriba un número distinto a lo que pedimos
                    default:
                        Console.WriteLine("Debe escribir correctamente la opción");
                        NuevaIteracion();
                    break;
                }
            // Este bucle se repita mientra el valor op sea distinto a 0
            } while (op != 0);
        }

        /// <summary>
        /// Método para cada vez que se compléte una opción pida el intro y limpie la consola.
        /// </summary>
        public static void NuevaIteracion() {
            Console.Write("Pulsa INTRO para continuar");
            Console.ReadLine();
            Console.Clear();
        }

        /// <summary>
        /// Método para el caso del rectángulo para que pida, cree y pregunte que hacer sobre lo que podemos hacer con el rectángulo.
        /// </summary>
        public static void Rectangulo() {
            try
            {
                Console.Write("Dime el valor para el lado 1: ");
                float lado1 = float.Parse(Console.ReadLine());
                Console.Write("Dime el valor para el lado 2: ");
                float lado2 = float.Parse(Console.ReadLine());
                Rectangulo rectangulo = new Rectangulo(lado1, lado2);
                Console.WriteLine("El perímetro de un rectángulo es: " + rectangulo.Perimetro());
                Console.WriteLine("El área de un rectángulo es: " + rectangulo.Area());
            }
            catch (FormatException)
            {
                Console.WriteLine("Debe ingresar un número válido");
            }
            catch (OverflowException)
            {
                Console.WriteLine("El número es demasiado grande");
            }
            finally
            {
                NuevaIteracion();
            }
        }

        /// <summary>
        /// Método para el caso del triángulo para que pida, cree y pregunte que hacer sobre lo que podemos hacer con el triángulo.
        /// </summary>
        public static void Triangulo() {
            try { 
            Console.Write("Dime el valor para la base: ");
            float cimiento = float.Parse(Console.ReadLine());
            Console.Write("Dime el valor para la altura: ");
            float altura = float.Parse(Console.ReadLine());
            Triangulo triangulo = new Triangulo(cimiento, altura);
            Console.WriteLine("El perímetro de un triángulo es: " + triangulo.Perimetro());
            Console.WriteLine("El área de un triángulo es: " + triangulo.Area());
            }
            catch (FormatException)
            {
                Console.WriteLine("Debe ingresar un número válido");
            }
            catch (OverflowException)
            {
                Console.WriteLine("El número es demasiado grand");
            }
            finally
            {
                NuevaIteracion();
            }
        }

        /// <summary>
        /// Método para el caso del círculo para que pida, cree y pregunte que hacer sobre lo que podemos hacer con el círculo.
        /// </summary>
        public static void Circulo() {
            try {
                Console.Write("Dime el valor para la radio: ");
                float radio = float.Parse(Console.ReadLine());
                Circulo circulo = new Circulo(radio);
                Console.WriteLine("El perímetro de un círculo es: " + circulo.Perimetro());
                Console.WriteLine("El área de un círculo es: " + circulo.Area());
            }
            catch (FormatException)
            {
                Console.WriteLine("Debe ingresar un número válido");
            }
            catch (OverflowException)
            {
                Console.WriteLine("El número es demasiado grand");
            }
            finally
            {
                NuevaIteracion();
            }
        }
    }
}