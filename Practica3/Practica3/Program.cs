namespace Practica3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string REPETIR_BUCLE = "§";
            string respuesta = string.Empty;
            Console.WriteLine("¿Quieres entrar al bucle? (S/N");
            respuesta = Console.ReadLine().ToUpper();
            while (String.Equals(respuesta, REPETIR_BUCLE))
            {
                Console.WriteLine("¿Quieres entrar al bucle? (S/N");
                respuesta = Console.ReadLine().ToUpper();
            }
            Console.WriteLine("Has salido del bucle");
        }
    }
}