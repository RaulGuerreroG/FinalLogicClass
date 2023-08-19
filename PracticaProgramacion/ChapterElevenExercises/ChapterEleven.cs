using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProgramacion.ChapterElevenExercises
{
    internal class ChapterEleven
    {
        ChapterElevenFuntions chapterElevenFuntions = new ChapterElevenFuntions();
        public void ExcercisesOne()
        {
            Console.WriteLine("Ingrese un Numero Entero: ");
            int digitedNumber = Convert.ToInt32(Console.ReadLine());

            int result = chapterElevenFuntions.GetLastDigit(digitedNumber);
            Console.WriteLine("El ultimo digito del numero es: " + result);

        }
    }
}
