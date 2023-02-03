using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniJuegoAdivinarnumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numberToGuess = random.Next(1, 101);
            int guess;
            int tries = 0;

            Console.WriteLine("Adivina el número del 1 al 100:");

            do
            {
                Console.Write("Introduce un número: ");
                guess = Convert.ToInt32(Console.ReadLine());
                tries++;

                if (guess < numberToGuess)
                {
                    Console.WriteLine("El número que estás buscando es mayor.");
                }
                else if (guess > numberToGuess)
                {
                    Console.WriteLine("El número que estás buscando es menor.");
                }
            } while (guess != numberToGuess && tries < 3);

            if (guess == numberToGuess)
            {
                Console.WriteLine("¡Felicidades! ¡Has adivinado el número!");
            }
            else
            {
                Console.WriteLine("Lo siento, has agotado tus 3 intentos. El número era " + numberToGuess + ".");
            }


        }//end main
  
    
    
    
    
    
    
    }//end class
}// end namespace




