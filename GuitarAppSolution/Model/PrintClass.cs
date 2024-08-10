using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarAppSolution.Model
{
    public class PrintClass
    {
        public static void PrintGuitar(Guitar guitar)
        {
            Console.WriteLine($"Id: {guitar.GuitarSerialNo}" +
                $"\nPrice: {guitar.GuitarPrice}" +
                $"\nBuilder:{guitar.GuitarSpec.GuitarBuilder}" +
                $"\nModel: {guitar.GuitarSpec.GuitarBuilder}" +
                $"\nType: {guitar.GuitarSpec.GuitarType}" +
                $"\nBackWood: {guitar.GuitarSpec.GuitarBackWood}" +
                $"\nTopWood: {guitar.GuitarSpec.GuitarTopWood}");
;                
        }
        public static void PrintGuitar(List<Guitar> guitars)
        {
            foreach(var guitar in guitars)
            {
                Console.WriteLine("One of the option is:");
                PrintGuitar(guitar);
                Console.WriteLine();
            }
        }
    }
}
