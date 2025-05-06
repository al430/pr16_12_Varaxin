
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace pr16_2_Varaxin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите название файла:");
            string file = Console.ReadLine();
            if (File.Exists(file))
            {
                Console.WriteLine("Введите слово, которое хотите найти");
                string answer = Console.ReadLine();
                answer = answer.ToLower();

                string allText = File.ReadAllText(file);
                allText = allText.ToLower();
                string text = "";

                for (int i = 0; i < allText.Length; i++)
                {
                    if (Char.IsPunctuation(allText[i]))
                    {
                        text += ' ';
                    }
                    else
                    {
                        text += allText[i];
                    }
                }

                string[] strings = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                int count = strings.Count(p => p == answer);

                Console.WriteLine($"Найдено {count} вхождений поискового запроса \"{answer}\"");
            }
        }
    }
}