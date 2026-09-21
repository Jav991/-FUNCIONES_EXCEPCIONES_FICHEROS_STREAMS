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

            /* Ejercicio 5*/
            u.funcion();
           /* Console.WriteLine(variable);*/
        }
    }
}