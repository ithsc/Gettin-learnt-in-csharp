using System;
using System.Text.RegularExpressions;

namespace Exercises
{
    public class Validator
    {
        public static string GetString(string msg)
        {   
            try
            {
                Console.WriteLine(msg);
                string input = Console.ReadLine();
                return input;

            }
            catch(FormatException ex)
            { 
                Console.WriteLine(ex.Message);
                GetString(msg);
            }
            return "Hopefully it will never come to this";

        }

        public static bool CheckString(string input)
        {
            bool isValid = false;

            if (string.IsNullOrEmpty(input))
                isValid = false;
            else
            {
                isValid = Regex.IsMatch(input, @"^[a-zA-Z]+$");

                foreach (char c in input)
                {
                    if (!Char.IsLetter(c))
                        isValid = false;
                }
            }
            return isValid;
        }

        public static int HandleUserMenuChoises(string msg)
        {
            bool err = false;
            bool isValid = false;
            string str;

            while (!err || !isValid)
            {
                try
                {
                    str = GetString(msg);

                    try
                    {
                        IsNumber(str);
                        int number = Int32.Parse(str);
                        err = false;
                        return number;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                   
                } catch(FormatException ex) {
                    Console.WriteLine(ex.Message);               
                } 
            }
            return 200;
        }

        public static bool CheckInt(string input)
        {
            bool isValid = true;

            foreach (char c in input)
            {
                if (!Char.IsDigit(c))
                    isValid = false;
            }
            return isValid;
        }


        public static bool CheckDecimal(string input)
        {
            Match m = Regex.Match(input, @"^-?[0-9]*\.?[0-9]+$");
            return m.Success && m.Value != "";
        }

        public static bool IsNumber(string text)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(text);
        }
    }
}
