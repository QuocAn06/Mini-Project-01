using System;
using System.Text.RegularExpressions;

namespace ContactManagerApp.Utils
{
    public static class InputHelper
    {
        public static string GetNonEmptyString(string prompt)
        {
            string? inputValue;
            do
            {
                Console.Write(prompt);
                inputValue = Console.ReadLine()?.Trim();
                if(string.IsNullOrWhiteSpace(inputValue))
                {
                    Console.WriteLine("Input cannot be empty. Please try again.");
                }

            } while (string.IsNullOrWhiteSpace(inputValue));

            return inputValue;
        }

        public static string GetValidPhone(string prompt)
        {
            string phonePattern = @"^\d{10,11}$"; // SĐT 10–11 chữ số
            string? inputValue;

            do
            {
                Console.Write(prompt);
                inputValue = Console.ReadLine()?.Trim();

                if (string.IsNullOrEmpty(inputValue) || !Regex.IsMatch(inputValue, phonePattern))
                {
                    Console.WriteLine("Invalid phone number. Please enter 10 or 11 digits.");
                    inputValue = null;
                }
                    
            } while (inputValue == null);

            return inputValue;
        }

        public static string GetValidEmail(string prompt)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            string? inputValue;
            do
            {
                Console.Write(prompt);
                inputValue = Console.ReadLine()?.Trim();
                if (string.IsNullOrEmpty(inputValue) || !Regex.IsMatch(inputValue, emailPattern))
                {
                    Console.WriteLine("Invalid email format. Please try again.");
                    inputValue = null;
                }

            } while (inputValue == null);

            return inputValue;
        }
    }
}