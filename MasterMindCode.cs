using System;

namespace MasterMindApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var generator = new RandomGenerator();
            var randomNumber = generator.FourDigitNumber(1111, 6666);
            randomNumber = Convert.ToInt32(randomNumber);

            //loop to process results
            int i = 0;
            while (i < 10)
            {
            Console.WriteLine("Enter a four digit number with digits between 1 and 6:");
            int userInput = Convert.ToInt32(Console.ReadLine());

            //split automated solution into array
            randomNumber = Math.Abs(randomNumber);
            int length1 = randomNumber.ToString().Length;
            int[] solutionArr = new int[length1];
            do
            {
                solutionArr[--length1] = randomNumber % 10;
                randomNumber /= 10;
            } while (randomNumber != 0);

            //split user guess into array
            userInput = Math.Abs(userInput);
            int length2 = userInput.ToString().Length;
            int[] userArr = new int[length2];
            do
            {
                userArr[--length2] = userInput % 10;
                userInput /= 10;
            } while (userInput != 0);
                i++;

                //correct answer
                if (userArr[0] == solutionArr[0] &&
                       userArr[1] == solutionArr[1] &&
                       userArr[2] == solutionArr[2] &&
                       userArr[3] == solutionArr[3]) { Console.WriteLine("That is the correct answer, you win!"); }
                else
                {
                    //position 1
                    if (userArr[0] == solutionArr[0])
                    {
                        Console.WriteLine("Position 1: +");
                    }
                    else if (userArr[0] == solutionArr[1])
                    {
                        Console.WriteLine("Position 1: -");
                    }
                    else if (userArr[0] == solutionArr[2])
                    {
                        Console.WriteLine("Position 1: -");
                    }
                    else if (userArr[0] == solutionArr[3])
                    {
                        Console.WriteLine("Position 1: -");
                    }
                    else
                    {
                        Console.WriteLine("Position 1: ");
                    }

                    //position 2
                    if (userArr[1] == solutionArr[1])
                    {
                        Console.WriteLine("Postion 2: +");
                    }
                    else if (userArr[1] == solutionArr[0])
                    {
                        Console.WriteLine("Postion 2: -");
                    }
                    else if (userArr[1] == solutionArr[2])
                    {
                        Console.WriteLine("Postion 2: -");
                    }
                    else if (userArr[1] == solutionArr[3])
                    {
                        Console.WriteLine("Postion 2: -");
                    }
                    else
                    {
                        Console.WriteLine("Postion 2: ");
                    }

                    //position 3
                    if (userArr[2] == solutionArr[2])
                    {
                        Console.WriteLine("Position 3: +");
                    }
                    else if (userArr[2] == solutionArr[0])
                    {
                        Console.WriteLine("Position 3: -");
                    }
                    else if (userArr[2] == solutionArr[1])
                    {
                        Console.WriteLine("Position 3: -");
                    }
                    else if (userArr[2] == solutionArr[3])
                    {
                        Console.WriteLine("Position 3: -");
                    }
                    else
                    {
                        Console.WriteLine("Position 3: ");
                    }

                    //position 4
                    if (userArr[3] == solutionArr[3])
                    {
                        Console.WriteLine("Position 4: +");
                    }
                    else if (userArr[3] == solutionArr[0])
                    {
                        Console.WriteLine("Position 4: -");
                    }
                    else if (userArr[3] == solutionArr[1])
                    {
                        Console.WriteLine("Position 4: -");
                    }
                    else if (userArr[3] == solutionArr[2])
                    {
                        Console.WriteLine("Position 4: -");
                    }
                    else
                    {
                        Console.WriteLine("Position 4: ");
                    }
                }//end check position value 
            }//end while loop
                Console.WriteLine("Sorry, you used all attempts to guess the correct answer, you lose. Try again!");
            }

    }
    public class RandomGenerator
    {
        //create random integer
        private readonly Random random = new Random();

        // Generates a random number within a range.      
        public int FourDigitNumber(int min, int max) => random.Next(min, max);

        //get digits from automated combination

    }
}

