using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tiempo_y_Espacio
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;

            Console.WriteLine("Ingrese año");
            year = int.Parse(Console.ReadLine());

            TimeAndSpace.LeapYear(year);
        }
    }
}
/*
1. A partir de cualquier fecha en formato DD/MM/YYYY, presentar por pantalla los dias restantes del año en formato juliano.
2. A partir de cualquier fecha en formato DD/MM/YYYY, presentar el próximo día, incluyendo un cambio de año y/o si es bisiesto.

Puntos a evaluar y observaciones :

1. Funcionalidad de Programa y las validaciones correspondientes a cada escenario : El programa debe hacer los solicitado sin importar la eficiencia del código

2. Nombres de las clases y métodos :  Un buen nombre da mucha más información que cualquier otra cosa.Para conseguir buenos nombres hay que usar nombres descriptivos y claros.Deben ser legibles y evitar codificaciones complejas.

3. Métodos y/o Funciones : Una buena función es aquella de la que se puede inferir su comportamiento de un solo vistazo.Para ello deben ser cortas, hacer una única cosa y mantenerse dentro del mismo nivel de abstracción. Es importante usar buenos nombres y reducir al mínimo el número de argumentos.

4. Formateo : El formateo afecta directamente a la legibilidad del código.El código se lee de arriba abajo y de izquierda a derecha. Los espacios verticales y horizontales permiten separar ideas y conceptos distintos.Se debe mantener un estilo uniforme, y para ello se debe consensuar con todo el equipo las reglas de formateo. Las reglas elegidas no son tan importantes como el hecho de que todo el mundo se atenga a ellas.

5.Manejo de Errores :
El código de manejo de errores oculta la verdadera funcionalidad del código. Hay que mantenerlo lo más separado posible de la lógica de negocio para no dificultar la comprensión de ésta última.  Para no complicar el manejo de errores hay que escribir los bloques try-catch-finally en primer lugar permite identificar los puntos del programa en los cuáles se puede producir una excepción.Se deben usar excepciones en lugar de códigos de retorno. Las excepciones deben proporcionar suficiente información sobre el error y el momento en que se ha producido.Además, las excepciones no comprobadas son menos invasivas a nivel de código.También se debe evitar pasar null como parámetro de una llamada a un método o devolverlo como valor de retorno. Esto introduce complejidad adicional debido a las comprobaciones necesarias.

6. Clases : Las clases se deben organizar situando en primer lugar las constantes públicas, después las variables estáticas privadas, variables de instancia privadas y, a continuación, los métodos. Los métodos privados se encuentran junto a los métodos públicos que los usan.Se debe mantener la encapsulación de las clases. Las clases deben ser pequeñas y con un número reducido de responsabilidades. Se consigue una alta cohesión si todos los métodos de una clase hacen uso de todas sus variables privadas.
*/