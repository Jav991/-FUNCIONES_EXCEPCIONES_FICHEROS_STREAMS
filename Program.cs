using System.Runtime.CompilerServices;

namespace FUNCIONES_EXCEPCIONES_FICHEROS_STREAMS
{
    public class FUNCIONES_EXCEPCIONES_FICHEROS_STREAMS{

        public static void Main(string[] args)
        {
            Utilies u = new Utilies();
            /* Ejercicio 1*/
            u.mostrarMensaje();
            
            /*Ejercicio 2*/
            string nombre = "";
            u.Saludar(nombre); /* Ejecución del ejercicio 2*/

            /*Los métodos estáticos pertenecen a la clase uç, 
            no a una instancia. C# no permite llamarlos desde una variable*/
            int resultado = u.Sumar(10, 5); /*Ejecución del ejércicio 3*/
            Console.WriteLine($"El resultado de la suma es: {resultado}");

            /*Ejercicio 4 */

            double r = u.Calculo(5, 5, 5);
            Console.WriteLine($"El resultado de la media es: {r}");

            /* Ejercicio 5
            u.funcion();
           /* Console.WriteLine(variable);*/

            /* Bloque 2 🥱*/
            /* Ejercicio 6*/

            int numeroCambiado = 10;
            u.cambiar(numeroCambiado);
            Console.WriteLine($"El valor es: {numeroCambiado}");

            /*Ejercicio 7*/
             int numeroref = 10;
            u.Cambiar(ref numeroref);
            Console.WriteLine($"El valor es: {numeroref}");

            /* Ejercicio 8*/
            int doble, triple;
            u.ObtenerDobleYTriple(5, out doble, out triple);
            Console.WriteLine($"El doble es: {doble} y el triple es: {triple}");

            u.cuentAtras(5);
        }
    }
}