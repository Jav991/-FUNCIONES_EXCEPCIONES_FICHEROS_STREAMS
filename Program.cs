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
/*
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
*/
/*Ejercicio 3*/
class Operaciones
{
    static void Main(string[] args)
    {
        int resultado = Sumar(10, 5);
        Console.WriteLine($"El resultado de la suma es de: {resultado}");
    }
    static int Sumar(int a, int b)
    {
        int sumar = a + b; 
        return sumar;
    }
}