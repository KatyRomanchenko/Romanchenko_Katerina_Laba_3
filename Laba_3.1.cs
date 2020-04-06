using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ✔Дано текст, необхідно 
 * ✔кожне слово (слова складаються з чисел і букв) помістити в колекцію, 
 * ✔вивести загальну кількість елементів колекції, 
 * ✔запросити ввести користувача порядковий номер елемента і напрямок руху по колекції, 
 * ✔згідно введеному напрямку вивести всі слова починаючи з заданого.*/

namespace Laba_3._1_0
{
    class Program
    {
        static void Main(string[] args)
        {
            const string Text = "dfs21fsd sfwe12sdf s32fsf sfsdf2dfs 32fsdfs";
            string[] words = Text.Split(' ');

            var words_collection = new List<string>();
            
            foreach (string word in words)
            {
                words_collection.Add(word);
            }
            foreach (var word_ in words_collection)
            {
                Console.Write(word_ + " ");
            }
            Console.WriteLine();
            Console.WriteLine(words_collection.Count);
            Console.Write("Введите число, с которого начнём перебор коллекции: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Введите в какую сторону двигаться(лево или право): ");
            string answer = Console.ReadLine();
            Console.WriteLine();
            if (answer== "лево")
            {
                for (var index = number - 1; index >= 0; index--)
                {
                    Console.Write(words_collection[index] + " ");
                }
            }
            else 
            {
                for (var index = number - 1; index < words_collection.Count; index++)
                {
                    Console.Write(words_collection[index] + " ");
                }
            }
            Console.ReadKey();
        }
    }
}
