using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSaA_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Word you want to Spell: ");
            string userInput  = Console.ReadLine();
            Console.Write("================================================");
            string[] table = new string[26];

            for (int k = 0; k < table.Length; k++)
            {
                int inRow = 0;
                int space = 0;
                for (int i = 0; i < userInput.Length; i++)
                {
                    
                    int rowVal = 0;

                    if (((int)(userInput[i]) - 96) < 0)
                        rowVal = ((int)(userInput[i]) - 64);

                    else
                        rowVal = ((int)(userInput[i]) - 96);

                    if (k == rowVal)
                    {
                        if (inRow != rowVal)
                        {
                            for (int j = 0; j < space; j++)
                                Console.Write(" ");
                        }

                        Console.Write(userInput[i]);
                        inRow = rowVal;
                    }
                    else
                    {
                        space++;
                    }
                }
                Console.WriteLine();
                
            }

        }
    }
}



//Console.WriteLine(userInput[i]);