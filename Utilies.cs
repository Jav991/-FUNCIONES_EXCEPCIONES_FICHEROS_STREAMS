 /* Ejercicio 1 Primera función 😎*/
public class Saludar
{
   public static void mostrarMensaje()
    {
        Console.WriteLine("Bienvenido al programa");
    }
}

/* Ejercicio 2*/
 public class Parametro
{
   public static void Saludar(string nombre)
    {
        Console.WriteLine("Introduzca su nombre");
        String n = Console.ReadLine()!;
        Console.WriteLine($"Hola tu nombre es {n}");
    }
}

/* Ejercicio 3*/
public class Operaciones
{
    public static int Sumar(int a, int b)
    {
        int sumar = a + b; 
        return sumar;
    }
}

/*Ejercicio 4*/


public class Media
{
    public static double Calculo(double a, double b, double c)
    {
        return (a+b+c)/3;
    }
}