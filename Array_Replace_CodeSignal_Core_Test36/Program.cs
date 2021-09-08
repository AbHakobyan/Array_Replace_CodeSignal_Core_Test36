using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Replace_CodeSignal_Core_Test36
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 1, 2, 3, 4, 5, };
            int[] array = arrayReplace(input, 3, 6);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        static int[] arrayReplace(int[] inputArray, int elemToReplace, int substitutionElem)
        {
            List<int> list = inputArray.ToList();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == elemToReplace)
                {
                    list[i] = substitutionElem;
                }
            }
            int[] array = list.ToArray();
            return array;

        }

    }
}
