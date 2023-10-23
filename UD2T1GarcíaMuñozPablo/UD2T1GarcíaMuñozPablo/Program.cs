namespace UD2T1GarcíaMuñozPablo
{
    ///////////////////////////////////////////
    // Tarea: UD2T1
    // Alumno: Pablo García Muñoz
    // Curso: 2023/2024
    ///////////////////////////////////////////
    internal class Program
    {
        static void Main(string[] args){
            // Variable que guarda la opción seleccionada y en el caso salir del bucle
            int op = 0;
            // Empleado
            Empleado empleado = new Empleado();
            do{
            // Mostrar el menú de opciones de la consola al iniciar el programa
            Console.WriteLine("Elige una de las siguientes opciones: \n" +
                                "0 - Salir\n" +
                                "1 - Crear empleado\n" +
                                "2 - Actualizar salario\n" +
                                "3 - Nombre completo\n" +
                                "4 - Obtener NIF\n" +
                                "5 - Actualizar NIF\n" +
                                "6 - Obtener Edad\n" +
                                "7 - Mostrar\n");
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
                        Console.WriteLine("********Creación de empleado********");
                        Console.WriteLine("Nombre: ");
                        string nombre = Console.ReadLine();
                        empleado.Nombre = nombre;
                        Console.WriteLine("Primer apellido: ");
                        string apellido1 = Console.ReadLine();
                        empleado.Apellido1 = apellido1;
                        Console.WriteLine("Segundo apellido: ");
                        string apellido2 = Console.ReadLine();
                        empleado.Apellido2 = apellido2;
                        Console.WriteLine("Edad: ");
                        int edad = int.Parse(Console.ReadLine());
                        empleado.Edad = edad;
                        Console.WriteLine("NIF: ");
                        string nif = Console.ReadLine();
                        empleado.Nif = nif;
                        Console.WriteLine("Salario: ");
                        double salario = double.Parse(Console.ReadLine());
                        empleado.Salario = salario;
                        empleado.ResumenEmpleado();
                        break;

                    // Caso para actualizar el salario
                    case 2:
                        empleado.ActualizarSalario();
                        break;
                    
                    // Caso para mostrar el nombre
                    case 3:
                        string nom = empleado.MostrarNombre();
                        Console.WriteLine("Su nombre es: "+nom + "\n");
                        break;

                    // Caso para mostrar el NIF
                    case 4:
                        Console.WriteLine("Su NIF es:"+empleado.Nif + "\n");
                        break;

                    // Caso para actualizar el NIF
                    case 5:
                        empleado.ActualizarNif();
                        break;

                    // Caso para mostrar la edad
                    case 6:
                        Console.WriteLine("Su edad es:"+empleado.Edad+"\n");
                        break;

                    // Caso para mostrar todos los datos del empleado
                    case 7:
                        empleado.ResumenEmpleado();
                        break;
                }
            } while (op != 0);
        }
    }




    // Clase del empleado el cual usaremos
    class Empleado{
        // ---------Variables de un empleado---------
        string nombre;
        string apellido1;
        string apellido2;
        int edad;
        string nif;
        double salario;

        // ---------Constructores---------
        public Empleado() { } // Constructor vacio
        public Empleado(string nombre, string apellido1, string apellido2, int edad, string nif, double salario){ // Constructor para recibir parametros
            this.nombre = nombre;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.edad = edad;
            this.salario = salario;
            this.nif = nif;
        }

        // ---------Getters y Setters---------
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public int Edad { get; set; }
        public string Nif { get; set; }
        public double Salario { get; set; }

        // ---------Métodos---------
        public void ResumenEmpleado(){ // Muestra un resumen de los datos introducidos del empleado
            Console.WriteLine("********Resumen********\n" +
                $"Nombre: {Nombre} {Apellido1} {Apellido2}\n" +
                $"Edad: {Edad}\n" +
                $"NIF: {Nif}\n"+
                $"Salario: {Salario}\n");
        }

        public void ActualizarSalario(){ // Pide un dato para actulizar el salario
            Console.WriteLine("Dígame su salario: ");
            Salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Salario actualizado");
        }

        public void ActualizarNif(){ // Pide un dato para actulizar el NIF
            Console.WriteLine("Dígame su NIF: ");
            Nif = Console.ReadLine();
            Console.WriteLine("NIF actualizado");
        }

        public string MostrarNombre(){ // Muestra el nombre completo del empleado
            return(Nombre+" "+Apellido1+" "+Apellido2+"\n");
        }



    }
}