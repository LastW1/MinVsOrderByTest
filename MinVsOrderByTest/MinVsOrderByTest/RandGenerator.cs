using System;
using System.Collections.Generic;

namespace MinVsOrderByTest
{
    public static class RandGenerator
    {
        public static List<string> GenerateRandomStringList(int listItemCount)
        {
            const int MinLength = 5;
            const int MaxLength = 30;

            var result = new List<string>();

            for (var i = 0; i < listItemCount; i++)
            {
                result.Add(RandGenerator.RandomStringInRange(MinLength, MaxLength));
            }

            return result;
        }

        private static string RandomStringInRange(int minLength, int maxLength)
        {
            var random = new Random();
            return RandomString(random.Next(minLength, maxLength));
        }

        private static string RandomString(int length)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[length];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new string(stringChars);
            return finalString;
        }
    }
}
