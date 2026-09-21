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

    /*public void funcion()
    {
        string variable = "Calor espabila";
    } */

    /* Bloque 2 🥱*/
    /* Ejercicio 6*/

    public void cambiar(int numero)
    {
        numero = 100;
    }

    /*Ejercicio 7*/

    public void Cambiar(ref int numero)
    {
        numero = 100;
    }

    /* Ejercicio 8 */

    public void ObtenerDobleYTriple(int numero, out int doble, out int triple)
    {
        doble = numero * 2;
        triple = numero * 3;
        
    }

    /*Ejercicio 9*/

    public int cuentAtras(int numero)
    {
        for (int i = numero; i > 0; i--)
        {
            Console.WriteLine(i);
        }
        return 0;
    }

    /* Ejercicio 10*/
    public int Excepciones(string texto)
    {
        try
        {
            texto = "abc";
           int conversion = int.Parse(texto);
            return conversion;
        }
        catch (System.Exception)
        {  
            Console.WriteLine("No se puede covertir, ¡Sorry 😥😥!");
            return 0;
        }
    }

    public int edad()
    {
        Console.WriteLine("Introduzca su edad por favor: ");
        try
        {
          int edad = int.Parse(Console.ReadLine()!);
          Console.WriteLine($"La edad suya es: {edad}");
          return edad;
        }  
        catch (System.Exception)
        {
            Console.WriteLine("El valor introducido no es válido, ¡Sorry 😥😥!");
            return 0;
        };
    }
}




