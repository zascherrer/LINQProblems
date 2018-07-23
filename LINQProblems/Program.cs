using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1:

            //List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics"};

            //var wordsWithTh = words.Where(w => w.Contains("th"));
            //foreach (var word in wordsWithTh)
            //{
            //    Console.WriteLine(word);
            //}

            //Console.ReadLine();


            //Question 2:

            //List<string> names = new List<string>() { "Mike", "Dan", "Scott", "Nick", "Mike"};

            //var namesWithoutDuplicates = names.Distinct();
            //foreach (var name in namesWithoutDuplicates)
            //{
            //    Console.WriteLine(name);
            //}

            //Console.ReadLine();


            //Question 3:

            //List<string> classGrades = new List<string>()
            //{
            //    "80,100,92,89,65",
            //    "93,81,78,84,69",
            //    "73,88,83,99,64",
            //    "98,100,66,74,55"
            //};

            //var averagedGradesWithoutLowestGrade = classGrades.Average(c => c.Split(',').Where(s => s != c.Split(',').Min()).Select(x => int.Parse(x)).Average());

            //Console.WriteLine(averagedGradesWithoutLowestGrade);

            //Console.ReadLine();


            //Question 4:

            string word = "Terrill";

            var charList = word.ToLower().ToList();
            charList.Sort();
            var letterFrequencyOfWord = charList.GroupBy(c => c).Select(c => c.Concat(c.Count().ToString()));

            foreach (var enumerable in letterFrequencyOfWord)
            {
                foreach (var character in enumerable)
                {
                    Console.Write(character);
                }
            }

            Console.ReadLine();

        }
    }
}
