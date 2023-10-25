namespace UD2T1GarcíaMuñozPablo{
    ///////////////////////////////////////////
    // Tarea: UD2T1
    // Alumno: Pablo García Muñoz
    // Curso: 2023/2024
    ///////////////////////////////////////////
    internal class Program{
        static void Main(string[] args){
            // Poder mostrar el simbolo del euro
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Variable que guarda la opción seleccionada y en el caso salir del bucle
            int op = 0;
            // Empleado
            Empleado empleado = new Empleado();
            do{
                // Mostrar el menú de opciones de la consola al iniciar el programa
                Console.Write("0 - Salir\n" +
                              "1 - Crear empleado\n" +
                              "2 - Actualizar salario\n" +
                              "3 - Mostrar Nombre\n" +
                              "4 - Mostrar NIF\n" +
                              "5 - Actualizar NIF\n" +
                              "6 - Mostrar edad\n" +
                              "7 - Mostrar empleado\n" +
                              "Introduzca su opción: ");

            // Lee la opción que elige el usuario
            op = int.Parse(Console.ReadLine());
            // Switch para que haga una cosa u otra dependiendo del número
                switch (op){
                    // En el caso de ser 0 nos salimos del programa
                    case 0:
                        Console.WriteLine("Saliendo del programa.");
                        // Para salir del programa
                        break;
                    // Caso para crear un nuevo empleado
                    case 1:
                        // Preguntar al profesor por la creación
                        Console.WriteLine("********Creación de empleado********");
                        Console.Write("Nombre: ");
                        string nombre = Console.ReadLine();
                        empleado.Nombre = nombre;
                        Console.Write("Primer apellido: ");
                        string apellido1 = Console.ReadLine();
                        empleado.Apellido1 = apellido1;
                        Console.Write("Segundo apellido: ");
                        string apellido2 = Console.ReadLine();
                        empleado.Apellido2 = apellido2;
                        Console.Write("Edad: ");
                        int edad = int.Parse(Console.ReadLine());
                        empleado.Edad = edad;
                        Console.Write("NIF: ");
                        string nif = Console.ReadLine();
                        empleado.Nif = nif;
                        Console.Write("Salario: ");
                        double salario = double.Parse(Console.ReadLine());
                        empleado.Salario = salario;
                        empleado.MostrarEmpleado(empleado);
                        break;

                    // Caso para actualizar el salario
                    case 2:
                        Console.WriteLine("********Actualización de salario********");
                        Console.Write("Escriba su nuevo salario: ");
                        double actSalar = double.Parse(Console.ReadLine());
                        empleado.ActualizarSalario(actSalar);
                        break;
                    
                    // Caso para mostrar el nombre
                    case 3:
                        Console.WriteLine("El nombre es: " + empleado.MostrarNombre(empleado));
                        break;

                    // Caso para mostrar el NIF
                    case 4:
                        empleado.MostrarNif(empleado);
                        break;

                    // Caso para actualizar el NIF
                    case 5:
                        empleado.ActualizarNif(empleado);
                        break;

                    // Caso para mostrar la edad
                    case 6:
                        empleado.MostrarEdad(empleado);
                        break;

                    // Caso para mostrar todos los datos del empleado
                    case 7:
                        empleado.MostrarEmpleado(empleado);
                        break;
                }
            } while (op != 0);
        }
    }
}