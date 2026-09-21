namespace FUNCIONES_EXCEPCIONES_FICHEROS_STREAMS
{
    public class FUNCIONES_EXCEPCIONES_FICHEROS_STREAMS{

        public static void Main(string[] args)
        {
            /* Ejercicio 1*/
            Saludar.mostrarMensaje();
            
            /*Ejercicio 2*/
            string nombre = "";
            Parametro.Saludar(nombre); /* Ejecución del ejercicio 2*/

            /*Los métodos estáticos pertenecen a la clase Operaciones, 
            no a una instancia. C# no permite llamarlos desde una variable*/
          int resultado = Operaciones.Sumar(10, 5); /*Ejecución del ejércicio 3*/
            Console.WriteLine($"El resultado de la suma es: {resultado}");
        }
    }
}