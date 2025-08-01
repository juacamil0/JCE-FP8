namespace _1.InicioVisualStudio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion e inicializacion de variables
            string nombre="Juan C";
            const string iva = "19%";
            string apellidos = "Escobar Vanegas";
            Console.Write(nombre+" Bienvenido al curso de fundamentos de programacion\n");
            nombre = "Camilo";
            //iva = "20%"; NO puedo cambiar el valor de iva por ser una constante
            Console.Write("\t" + nombre + " " +apellidos + " " + iva);
            Console.ReadKey();
        }
    }
}
