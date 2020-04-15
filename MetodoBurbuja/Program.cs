using System;

namespace MetodoBurbuja
{
    class Program
    {
        static void Main(string[] args)
        {
            //se crea una variable temporal para la condicion IF
            int t;
            //agregamos un arreglo con numeros aleatorios
            int[] vector = new int[] { 20, 14, 3, 6, 7, 54, 8, 77 };
            //el bucle comienda desde el segundo indice del vector
            for (int a = 1; a < vector.Length; a++)
                //este bloque de for  inicia desde el indice 1, ya que en el intercambio de valores
                //del condicional if, se guardará el valor menor en el indice 0.
            {
                //el segundo bucle comienza desde el ultimo indice del vector en retroceso
                for (int b = vector.Length - 1; b >= a; b--)
                    // Este bloque de for irá guardando en el ultimo indice el numero mayor del arreglo
                    
                {
                    /* La condicion dice que si el penultimo indice que se esta ejecutando
                        es mayor al que lo sigue se guardara en la variable t */
                    if (vector[b - 1] > vector[b])
                    {
                        //el penultimo indice, que es mayor al ultimo, se guarda en t
                        t = vector[b - 1];
                        //el idice que lo sigue lo sobre escribe
                        vector[b - 1] = vector[b];
                        // y ahora t, que es el valor mayor, se guarda en el ultimo indice en ejecucion
                        vector[b] = t;
                        //lo que hace este bloque es voltear los valores entre el ultimo y penultimo indice
                        //siempre y cuando el penultimo sea mayor
                    }
                }
            }
            //se agrega un nuevo for para imprimir los valores finales
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine(vector[i]);
            }
        }
    }
}
