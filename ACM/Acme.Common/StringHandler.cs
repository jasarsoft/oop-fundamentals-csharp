using System;

namespace Acme.Common
{
    public static class StringHandler
    {
        /// <summary>
        /// Inserts spaces before each capital letter in a string
        /// </summary>
        /// <param name="soruce"></param>
        /// <returns></returns>

        public static string InsertSpaces(this string soruce)
        {
            var result = string.Empty;
            if (!String.IsNullOrEmpty(soruce))
            {
                foreach (var letter in soruce)
                {
                    if (char.IsUpper((letter)))
                    {
                        result = result.Trim();
                        result += " ";
                    }

                    result += letter;
                }
            }

            return result.Trim();
        }
    }
}
