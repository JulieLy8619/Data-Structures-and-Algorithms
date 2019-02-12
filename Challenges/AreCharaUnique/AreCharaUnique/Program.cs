﻿using System;

namespace AreCharaUnique
{
    class Program
    {
        static void Main(string[] args)
        {
            bool mainAnswer1 = AreCharactersUnique("tes");
            Console.WriteLine("tes is " + mainAnswer1);
            bool mainAnswer2 = AreCharactersUnique("test");
            Console.WriteLine("test is " + mainAnswer2);
            bool mainAnswer3 = AreCharactersUnique("`~234g");
            Console.WriteLine("`~234g is " + mainAnswer3);

            Console.ReadLine(); // so it doesn't auto quit
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool AreCharactersUnique(string input)
        {
            if (input.Length > 0)
            {
                string shortenString = input;
                for (int i = 1; i < input.Length; i++)
                {
                    if (input[0] == input[i])
                    {
                        return false;
                    }
                }
                if (input != null)
                {

                    shortenString = input.TrimStart(input[0]);
                }
                bool answer = AreCharactersUnique(shortenString);
                return answer;
            }
            else
            {
                return true; //technically it is neither if it is null
            }
        }
    }
}
