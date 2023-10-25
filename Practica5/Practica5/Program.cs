namespace Practica5
{
    internal class Program
    {
        static void Main()
        {
            // Declaración de constantes
            const string PATH = @"C: \Users\daque\Proyectos\practica4.txt";
            // Declaración de variables
            System.IO.StreamReader archivo = null;
            string linea = string.Empty;
            try
            {
                archivo = new System.IO.StreamReader(PATH);
                linea = archivo.ReadLine();
                while (!String.IsNullOrEmpty(linea))
                {
                    Console.WriteLine(linea);
                    linea = archivo.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (archivo != null)
                {
                    archivo.Close();
                }
                Console.WriteLine("Conexión con el fichero cerrada");
            }
        }
    }
}