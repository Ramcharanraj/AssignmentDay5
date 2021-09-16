using System;

namespace FindingVowels
{
    class Program
    {
        static void Main(string[] args)
        { 
           
           Console.WriteLine("Enter any Alphabet: ");

            //Ask for the Alphabet
            char ch = Convert.ToChar(Console.ReadLine());

            //Vowel Logic
            if ((ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U'))
            {
                Console.WriteLine("It's is a Vowel");
            }
            else
            {
                Console.WriteLine("It's is a Consonant");
              }
            }
        }

    }
