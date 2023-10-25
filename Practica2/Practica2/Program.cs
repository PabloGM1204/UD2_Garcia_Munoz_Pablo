namespace Practica2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int PUEDE_CONDUCIR = 18;
            const string TIENE_CARNET = "S";
            Console.WriteLine("Vamos a evaluar si puedes conducir");
            Console.WriteLine("Introduce tu edad, por favor");
            int edad = Int32.Parse(Console.ReadLine());
            if (PUEDE_CONDUCIR <= edad){ 
                Console.WriteLine("¿Tienes carnet? (S/N)");
                string carnet = Console.ReadLine().ToUpper();
                if (carnet.Equals("S"))
                {
                    Console.WriteLine("Puedes conducir");
                } else {
                    Console.WriteLine("No puedes conducir");
                }
            } else {
                Console.WriteLine("No puedes conducir");
            }
        }
    }
}