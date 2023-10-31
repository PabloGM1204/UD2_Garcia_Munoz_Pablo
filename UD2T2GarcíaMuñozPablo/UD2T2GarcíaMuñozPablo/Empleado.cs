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
    /// <summary>
    /// Imprime el nombre completo de la persona en la consola.
    /// Combina las propiedades 'Nombre', 'Apellido1' y 'Apellido2' de la instancia actual y las muestra.
    /// </summary>
    public void NombreCompleto()
    {
        Console.WriteLine(this.Nombre + " " + this.Apellido1 + " " + this.Apellido2);
    }
}