using System;

namespace Acme.Common
{
    public class StringHandler
    {
        public string InsertSpaces(string soruce)
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
