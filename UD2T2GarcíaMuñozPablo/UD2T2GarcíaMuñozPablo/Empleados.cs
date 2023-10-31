using System;

public class Empleados
{
    // ---------Variables de la clase---------
    List<Empleado> empleados = new List<Empleado>();

	// ---------Constructores---------
	public Empleados(){}

    // ---------Métodos---------
    /// <summary>
    /// Agrega un nuevo empleado a la lista de empleados con la información proporcionada.
    /// </summary>
    /// <param name="nombre">El nombre del nuevo empleado.</param>
    /// <param name="apellido1">El primer apellido del nuevo empleado.</param>
    /// <param name="apellido2">El segundo apellido del nuevo empleado.</param>
    /// <param name="edad">La edad del nuevo empleado.</param>
    /// <param name="nif">El NIF (Número de Identificación Fiscal) del nuevo empleado.</param>
    /// <param name="salario">El salario del nuevo empleado.</param>
    public void NuevoEmpleado(string nombre, string apellido1, string apellido2, int edad, string nif, double salario)
	{
		Empleado empleado = new Empleado{
			Nombre = nombre,
			Apellido1 = apellido1,
			Apellido2 = apellido2,
			Edad = edad,
			Nif = nif,
			Salario = salario
		};
		empleados.Add(empleado);
	}

    /// <summary>
    /// Actualiza el salario de un empleado identificado por su NIF.
    /// </summary>
    /// <param name="nif">El NIF del empleado cuyo salario se actualizará.</param>
    /// <param name="actSalar">El nuevo salario que se asignará al empleado.</param>
    public void ActualizarSalario(string nif, double actSalar)
    {
		Empleado empleado = ObtenerEmpleado(nif);
		if(empleado != null)
			empleado.Salario = actSalar;
    }

    /// <summary>
    /// Muestra el nombre completo de un empleado identificado por su NIF en la consola.
    /// </summary>
    /// <param name="nif">El NIF del empleado cuyo nombre se mostrará.</param>
    public void MostrarNombreEmpleado(string nif)
    {
		Empleado empleado = ObtenerEmpleado(nif);
		if (empleado != null)
			empleado.NombreCompleto();
    }

    /// <summary>
    /// Muestra la edad de un empleado identificado por su NIF en la consola.
    /// </summary>
    /// <param name="nif">El NIF del empleado cuya edad se mostrará.</param>
    public void MostrarEdadEmpleado(string nif)
    {
		Empleado empleado = ObtenerEmpleado(nif);
		if(empleado != null)
            Console.WriteLine("La edad del empleado es: " + empleado.Edad);
    }

    /// <summary>
    /// Muestra los detalles de un empleado identificado por su NIF en la consola.
    /// </summary>
    /// <param name="nif">El NIF del empleado cuyos detalles se mostrarán.</param>
    public void MostrarUnEmpleado(string nif)
    {
		Empleado empleado = ObtenerEmpleado(nif);
        Console.WriteLine(
            $"Nombre: " + empleado.Nombre + " " + empleado.Apellido1 + " " + empleado.Apellido2 + "\n" +
            $"Edad: " + empleado.Edad + " años\n" +
            $"NIF: " + empleado.Nif + "\n" +
            $"Salario: " + empleado.Salario + " €\n");
    }

    /// <summary>
    /// Muestra todos los empleados y sus detalles en la consola.
    /// </summary>
    public void MostrarEmpleados()
	{
        foreach (Empleado empleado in empleados)
        {
			MostrarUnEmpleado(empleado.Nif);
        }
    }

    /// <summary>
    /// Borra un empleado de la lista de empleados identificado por su NIF.
    /// </summary>
    /// <param name="nif">El NIF del empleado que se eliminará.</param>
    public void BorrarEmpleado(string nif)
	{
		Empleado empleado = ObtenerEmpleado(nif);
		empleados.Remove(empleado);
	}

    /// <summary>
    /// Obtiene un empleado por su NIF.
    /// </summary>
    /// <param name="nif">El NIF del empleado que se buscará.</param>
    /// <returns>El objeto Empleado correspondiente al NIF proporcionado o null si no se encuentra.</returns>

    public Empleado ObtenerEmpleado(string nif)
	{
		return empleados.FirstOrDefault(e => e.Nif == nif);
	}


}
