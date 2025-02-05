﻿using System;

namespace MorseGame
{
    static class User
    {
        public static bool Continue(string question)
        {
            Console.WriteLine(question);
            string userResponse = Console.ReadLine();
            string upperResponse = userResponse.ToUpper();
            bool boolResponse = false;

            switch (upperResponse)
            {
                case "Y":
                case "Ye":
                case "Yes":
                case "S":
                case "Si":
                case "Sim":
                    boolResponse = true;
                    break;
                default:
                case "N":
                case "Nao":
                case "No":
                    boolResponse = false;
                    break;
            }

            return boolResponse;
        }
        public static T Ask<T>(string question)
        {
            bool correctAnswer = false;
            dynamic returnAnswer = null;

            while (!correctAnswer)
            {
                Console.WriteLine(question);
                string answer = Console.ReadLine();
            
                try
                {
                    returnAnswer = (T)Convert.ChangeType(answer, typeof(T));
                    correctAnswer = true;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            return returnAnswer;
        }
        public static void CorrectAnswer()
        {
            Console.WriteLine("Congratulations, you answered correctly!");
        }
        public static void WrongAnswer()
        {
            Console.WriteLine("Oops ! Looks like you put wrong answer!");
        }
        public static void Comment(string comment)
        {
            Console.WriteLine(comment);
        }
    }
}
