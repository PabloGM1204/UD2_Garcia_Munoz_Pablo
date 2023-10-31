using System;

namespace UD2T2GarcíaMuñozPablo
{
    ///////////////////////////////////////////

    // Tarea: UD2T2

    // Alumno/a: Pablo García Muñoz

    // Curso: 2023/2024

    ///////////////////////////////////////////
    internal class Program
    {
        static void Main(string[] args){
            // Poder mostrar el simbolo del euro
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Variable que guarda la opción seleccionada y en el caso salir del bucle
            int op = 0;
            // Empleado
            Empleados empleados = new Empleados();
            do
            {
                // Mostrar el menú de opciones de la consola al iniciar el programa
                Console.Write("0 - Salir\n" +
                              "1 - Crear empleado\n" +
                              "2 - Actualizar salario\n" +
                              "3 - Mostrar Nombre\n" +
                              "4 - Mostrar Edad\n" +
                              "5 - Mostrar empleado\n" +
                              "6 - Mostrar empleados\n" +
                              "7 - Borrar empleado\n" +
                              "Introduzca su opción: ");

                // Lee la opción que elige el usuario
                op = int.Parse(Console.ReadLine());
                // Switch para que haga una cosa u otra dependiendo del número
                switch (op)
                {
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
                        Console.Write("Primer apellido: ");
                        string apellido1 = Console.ReadLine();
                        Console.Write("Segundo apellido: ");
                        string apellido2 = Console.ReadLine();
                        Console.Write("Edad: ");
                        int edad = int.Parse(Console.ReadLine());
                        Console.Write("NIF: ");
                        string nif = Console.ReadLine();
                        Console.Write("Salario: ");
                        double salario = double.Parse(Console.ReadLine());
                        empleados.NuevoEmpleado(nombre, apellido1, apellido2, edad, nif, salario);
                        NuevaIteracion();
                        break;

                    // Caso para actualizar el salario
                    case 2:
                        Console.WriteLine("********Actualización de salario********");
                        Console.Write("Escriba el NIF: ");
                        nif = Console.ReadLine();
                        Console.Write("Escriba su nuevo salario: ");
                        double actSalar = double.Parse(Console.ReadLine());
                        empleados.ActualizarSalario(nif, actSalar);
                        NuevaIteracion();
                        break;

                    // Caso para mostrar el nombre
                    case 3:
                        Console.WriteLine("********Mostrar Nombre********");
                        Console.Write("Escriba el NIF: ");
                        nif = Console.ReadLine();
                        empleados.MostrarNombreEmpleado(nif);
                        NuevaIteracion();
                        break;

                    // Caso para mostrar la Edad
                    case 4:
                        Console.WriteLine("********Mostrar Nombre********");
                        Console.Write("Escriba el NIF: ");
                        nif = Console.ReadLine();
                        empleados.MostrarEdadEmpleado(nif);
                        NuevaIteracion();
                        break;

                    // Caso para mostrar el empleado
                    case 5:
                        Console.WriteLine("********Mostrar Empleado********");
                        Console.Write("Escriba el NIF: ");
                        nif = Console.ReadLine();
                        empleados.MostrarUnEmpleado(nif);
                        NuevaIteracion();
                        break;

                    // Caso para mostrar la lista de empleados
                    case 6:
                        empleados.MostrarEmpleados();
                        NuevaIteracion();
                        break;

                    // Caso para borrar un empleado
                    case 7:
                        Console.WriteLine("********Eliminar Empleado********");
                        Console.Write("Escriba el NIF: ");
                        nif = Console.ReadLine();
                        empleados.BorrarEmpleado(nif);
                        NuevaIteracion();
                        break;
                }
            } while (op != 0);

            
            void NuevaIteracion(){
                Console.Write("Pulsa INTRO para continuar");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}