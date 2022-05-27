using System;

namespace MinVsOrderByTest
{
    public static class RandGenerator
    {
        public static string RandomString(int length)
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

        public static string RandomStringInRange(int minLength, int maxLength)
        {
            var random = new Random();
            return RandomString(random.Next(minLength, maxLength));
        }
    }
}
