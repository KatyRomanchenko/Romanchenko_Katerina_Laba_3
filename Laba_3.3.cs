using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* ✔Дана послідовність цілих чисел.
 * ✔Витягти з неї всі додатні 
 * ✔двозначні числа, 
 * ✔відсортувавши їх по зростанню. (2)
 - Where, TakeWhile, SkipWhile, Take, Skip (фільтрація);
- OrderBy, OrderByDescending, ThenBy, ThenByDescending (сортування);
- Distinct, Reverse (видалення дублікатів та інвертування);
- Union, Intersect, Except (операції з множинами).

 */

namespace Laba_3._3_0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 19, 92, -12, 32, -23, 12, 234, 10 };
            printList(numbers);

            IEnumerable<int> MoreThan9 = numbers.Where(n => n > 9);
            IEnumerable<int> LessThan100 = MoreThan9.Where(n => n < 100);
            printIEnumerable(LessThan100);

            IEnumerable<int> Done = LessThan100.OrderBy(n => n);
            printIEnumerable(Done);

            Console.ReadKey();
        }


        static void printList(List<int> name)
        {
            Console.WriteLine();
            foreach (int v in name)
            {
                Console.Write(v + " ");
            }
        }
        static void printIEnumerable(IEnumerable<int> n)
        {
            Console.WriteLine();
            foreach (int v in n)
            {
                Console.Write(v + " ");
            }
        }
    }
}
