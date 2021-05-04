using System;

//Фельдман Семён
//Архитектура и шаблоны проектирования на C#
//Дз 1.3

namespace HomeWork
{
    class InputProcessing
    {
        private int userInputValue;
        public int UserInputValue
        {
            get { return userInputValue; }
        }

        public InputProcessing(string userInput)
        {
            if(userInput == "q") { System.Environment.Exit(1); }
            userInputValue = Int32.Parse(userInput);
        }
    }

    class MathMethods
    {
        public int CalculateFactorial(int input)
        {
            int count = 1;
            for(int i = 1; i <= input; i++)
            {
                count *= i;
            }
            return count;
        }

        public int CalculateSum(int input)
        {
            int count = 0;
            for (int i = 1; i <= input; i++)
            {
                count += i;
            }
            return count;
        }

        public int CalculateMaxEvenNumber(int input)
        {
            int count = 0;
            for (int i = 1; i <= input; i++)
            {
                if(i % 2 == 0)
                {
                    count = i;
                }
            }
            return count;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте вас приветствует математическая программа");
            Console.WriteLine("пажалуйста введите число. ");


            InputProcessing userInput = new InputProcessing(Console.ReadLine());
            MathMethods calculating = new MathMethods();
            int factorial = calculating.CalculateFactorial(userInput.UserInputValue);
            int sum = calculating.CalculateSum(userInput.UserInputValue);
            int maxEvenNumber = calculating.CalculateMaxEvenNumber(userInput.UserInputValue);

            /*String userInput = Console.ReadLine();

            if (userInput == "q")
            {
                return;
            }
            int M = Int32.Parse(userInput);
            int c1 = 1; int c2 = 0;
            int c3 = 0;
            for (int i = 1; i <= M; i++)
            {
                c1 = c1 * i;
                c2 = c2 + i;
                if (i % 2 == 0)
                {
                    c3 = i;
                }
            }*/
            Console.WriteLine("Факториал равен " + factorial); 
            Console.WriteLine("Сума от 1 до N равна " + sum);
            Console.WriteLine("максимальное четное число меньше N равно " + maxEvenNumber);
            Console.ReadLine();
        }
    }


}
