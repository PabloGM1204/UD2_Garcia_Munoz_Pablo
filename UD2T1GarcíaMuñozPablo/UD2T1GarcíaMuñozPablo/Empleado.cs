using System;

public class Empleado{
    // ---------Variables de un empleado---------
    string nombre;
    string apellido1;
    string apellido2;
    int edad;
    string nif;
    double salario;

    // ---------Constructores---------
    public Empleado() { } // Constructor vacio
    public Empleado(string nombre, string apellido1, string apellido2, int edad, string nif, double salario)
    { // Constructor para recibir parametros
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

    // ---------Variables de la clase---------
    string euroSymbol = "\u20AC";

    // ---------Métodos---------
    public void MostrarEmpleado(Empleado empleado)
    { // Muestra un resumen de los datos introducidos del empleado
        Console.WriteLine("********Resumen********\n" +
            $"Nombre: " + empleado.Nombre + " " + empleado.Apellido1 + " " + empleado.Apellido2+"\n" +
            $"Edad: " + empleado.Edad + " años\n" +
            $"NIF: " + empleado.Nif + "\n" +
            $"Salario: " + empleado.Salario + " €\n");
    }

    public void ActualizarSalario(double actSalar)
    { // Recoge el valor del nuevo salario
        Salario = actSalar;
    }

    public void ActualizarNif(Empleado empleadoo)
    { // Pide un dato para actulizar el NIF
        Console.Write("Dígame su NIF: ");
        empleadoo.Nif = Console.ReadLine();
        Console.WriteLine("NIF actualizado");
    }

    public string MostrarNombre(Empleado empleado)
    { // Muestra el nombre completo del empleado
        string nombre = empleado.Nombre + " " + empleado.Apellido1 + " " + empleado.Apellido2;
        return nombre;
    }
    
    public void MostrarNif(Empleado empleado)
    { // Muestra el NIF del empleado
        Console.WriteLine("Su NIF es:" + empleado.Nif);
    }

    public void MostrarEdad(Empleado empleado)
    { // Muestra la edad del empleado
        Console.WriteLine("La edad del empleado es: " + empleado.Edad);
    }

}
