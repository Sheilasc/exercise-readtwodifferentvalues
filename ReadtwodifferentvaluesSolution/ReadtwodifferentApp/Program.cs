//Leer dos valores distintos y almacenarlos en dos variables de nombre `x' e `y' y determinar cuál es el mayor dejando el resultado en una tercera variable de nombre `z'
internal class Program
{
    private static void Main(string[] args)
    {
        int x = Leer("Ingrese Numero 1: ");
    int y = Leer("Ingrese Numero 2: ");
    int z;
    if (x > y)
    {
      z = x;
      Console.WriteLine ("El mayor es: "+z);  
    }
    else  
    {
      z=y;
      Console.WriteLine ("El mayor es: "+z);
      }
    }

    public static int Leer(string mensaje)
  {
    for (int intentos = 0; intentos < 3; intentos++)
    {
        Console.WriteLine(mensaje);
            string numeroComoString = Console.ReadLine();
            int valorReal = 0;
            bool sePuedeConvertir = Int32.TryParse(numeroComoString, out valorReal);

            if (sePuedeConvertir)
            {
                return valorReal;
            }
            else
            {
                Console.WriteLine("valor ingresado invalido, intente de nuevo ...");
            }
    }
    throw new Exception("No se pude leer nada");
  }
}