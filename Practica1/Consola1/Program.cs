/// <summary>
/// Realiza un programa de consola llamado Consola1 que muestre un mensaje en el que se pida al
/// usuario que introduzca la medida de un radio y muestre como resultado el área de ese círculo.
/// </summary>
namespace Practica1 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("------Start the program------");
            Console.WriteLine("Dime el radio de un ciruclo en cm : ");
            double radio = double.Parse(Console.ReadLine());
            const double PI = 3.14;
            Console.WriteLine("El circulo tiene un area de " + (PI * (Math.Pow(radio,2))) + "cm");

        }
    }
}