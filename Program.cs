using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            Instruction.PrintInstructions();
            bool exit = false; // Указывает, следует ли завершать работу программы

            // Цикл до тех пор, пока пользователь не завершит работу
            while (!exit)
            {
                string input = Console.ReadLine(); // Вводимые данные
                if (input == "q") // Проверка на завершение программы
                {
                    exit = true;
                    continue;
                }
                double inputNumber;
                bool isDouble = double.TryParse(input, out inputNumber);

                if (isDouble)
                {
                    Calculator.ProcessInputNumber(inputNumber);
                }
                else
                {
                    Calculator.ProcessInputOperation(input);
                }
            }
        }     
    }
 
}