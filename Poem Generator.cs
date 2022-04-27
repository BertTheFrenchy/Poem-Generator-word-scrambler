using System;
using System.Collections.Generic;

namespace PoemGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
                  
            Console.WriteLine("Hello and welcome to the poem generator.\nPlease enter some words or a sentence: ");
            string userInput = "";            
            userInput = Console.ReadLine();
            string[] words = userInput.Split(' ');
            List<string> original = new List<string>();
            Random rnd = new Random();
            int length = words.Length;
            
            Console.WriteLine("You have entered the following words: ");
            foreach (string word in words)
            {
                original.Add(word);
                Console.Write(word + ", ");
            }
            for (int count = 0; count < length; count++)
            {
                int randNum = rnd.Next(length);
                string temp = words[randNum];
                words[randNum] = words[count];
                words[count] = temp;
            }
            Console.WriteLine();

            Console.WriteLine("Please enter a number for how often you want a new line (out of 100): ");
            int chance = 0;
            bool valid = false;
            do
            {
                try
                {
                    chance = Convert.ToInt32(Console.ReadLine());
                    if (chance <= 100 || chance > 0)
                    {
                        valid = true;
                    }
                }
                catch
                {
                    Console.WriteLine("You did not enter a valid number");
                }
            } while (!valid);
            Console.WriteLine("It has now been shuffled to read the following: ");
            foreach (string word in words)
            {
                
                if(rnd.Next(100) >= chance)
                {
                    Console.WriteLine();
                }
                Console.Write(word + " ");
            }
            Console.ReadLine();
        }
    }
}
