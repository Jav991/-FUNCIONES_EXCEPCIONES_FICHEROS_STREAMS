/*Console.WriteLine("Hello, World!");*/

/* Ejercicio 1 Primera función 😎*/
/*class Program
{
   static void Main(string[] args)
    {
        mostrarMensaje();
    }
    static void mostrarMensaje()
    {
        Console.WriteLine("Bienvenido al programa");
    }
}*/

/*Ejercicio 2*/

class Parametro
{
    static void Main(string[] args)
    {
        String nombre = "";
        Saludar(nombre);
    }

    static void Saludar(string nombre)
    {
        Console.WriteLine("Introduzca su nombre");
        String n = Console.ReadLine()!;
        Console.WriteLine($"Hola tu nombre es {n}");
    }
}