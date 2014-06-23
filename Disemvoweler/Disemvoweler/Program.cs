using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disemvoweler
{
    class Program
    {
        //ALL CODE MUST BE COMMENTED
        static void Main(string[] args)
        {
            
            //Call Functions Here
            Console.WriteLine("CALLING FUNCTIONS*******");
            //the disemvoweler function
            Console.WriteLine("DISEMVOWELER");
            Disemvoweler("Nickleback is my favorite band. Their songwriting can't be beat!");
            Console.WriteLine();
            Disemvoweler("How many bears could bear grylls grill if bear grylls could grill bears?");
            Console.WriteLine();
            Disemvoweler("I'm a code ninja, baby. I make the functions and I make the calls.");
            Console.WriteLine();

            //the next function


            //keeps console open until key is pressed
            Console.ReadKey();
        }
        
        //Declare Functions Here
        static void Disemvoweler(string input)
        {
            //declare function variables
            List<char> inputList = new List<char> {};
            string inputUpper = input.ToUpper();
            List<char> disemvoweledList = new List<char> { };
            List<char> vowelList = new List<char> { };

            for(int i = 0; i < input.Length; i++)
            {
             inputList.Add(inputUpper[i]);
                //Console.WriteLine(inputList[i]);
            }
            
            

            //code to make changes to variables
            for(int i = 0; i < inputList.Count; i++)
            {
                //variable to check individual letter
                char inputLetter = inputList[i];

                //check to see if letter is vowel
                if (inputLetter == 'A' || inputLetter == 'E' || inputLetter == 'I' || inputLetter == 'O' || inputLetter == 'U')
                {
                    vowelList.Add(inputList[i]);
                }
                else if (inputLetter == ' ' || inputLetter == '\'' || inputLetter == ',' || inputLetter == '.' || inputLetter == '!' || inputLetter == '?' || inputLetter == '\"')
                {

                }
                else
                {
                    disemvoweledList.Add(inputList[i]);
                }

            }
            

           /* //for loop to separate characters into a list
            for (int i = 0; i < numberString.Length; i++)
            {
                char numberChar = numberString[i];
                numberStringList.Add(numberChar);
            }
            //for loop to work the math for adding a hyphen into the list
            for (int i = 0; i < numberStringList.Count; i++)
            {
                //this is necessary because of numberStringList[i + 1], its to keep it from continuing 
                //before it goes outside of the upper limit: i < numberStringList.Count
                if (i == numberStringList.Count - 1)
                {
                    break;
                }
                    //change the index of the list to int to do some math
                    int numberChar2 = Convert.ToInt32(numberStringList[i]);
                    int numberChar3 = Convert.ToInt32(numberStringList[i + 1]);
                //do some math and character checks
                    if (numberChar2 != '-' && numberChar3 != '-' && numberChar2 > 0 && numberChar3 > 0 && numberChar2 % 2 > 0 && numberChar3 % 2 > 0)
                    {
                        numberStringList.Insert(i + 1, '-');
                    }
                    
                
            }*/
            //join list items into a string after all the changes are made to the list
          string disemvoweled = string.Join("", disemvoweledList);
            //Write the output to the console
            Console.WriteLine("Original: " + input);
            Console.WriteLine("Disemvoweled: " + disemvoweled);
        }
    }
}
