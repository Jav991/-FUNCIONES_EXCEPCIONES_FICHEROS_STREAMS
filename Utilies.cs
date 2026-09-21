 /* Ejercicio 1 Primera función 😎*/
public class Utilies
{
    //Ejercicio 1
   public void mostrarMensaje()
    {
        Console.WriteLine("Bienvenido al programa");
    }

    //Ejercicio 2
    public void Saludar(string nombre)
    {
        Console.WriteLine("Introduzca su nombre");
        String n = Console.ReadLine()!;
        Console.WriteLine($"Hola tu nombre es {n}");
    }

    //Ejercicio 3
    public int Sumar(int a, int b)
    {
        int sumar = a + b; 
        return sumar;
    }

    //Ejercicio 4
    public double Calculo(double a, double b, double c)
    {
        return (a+b+c)/3;
    }

    public void funcion()
    {
        string variable = "Calor espabila";
    }

    /* Bloque 2 🥱*/
    /* Ejercicio 6*/

    public void cambiar(int numero)
    {
        numero = 100;
    }
}

