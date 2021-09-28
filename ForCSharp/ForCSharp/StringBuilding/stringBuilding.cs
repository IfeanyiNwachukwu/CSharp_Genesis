using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForCSharp.StringBuilding
{
    public static class stringBuilding
    {
        public static string CreateNewString(string word, int numberOfTimesToAppend)
        {
            StringBuilder stringBuilder = new();

            
            stringBuilder.AppendLine("Hello World");
            for (int i = 0; i < numberOfTimesToAppend; i++)
            {
                stringBuilder.AppendLine("thanks for entering...");
                stringBuilder.AppendLine(word);
            }
            var stringToReturn = stringBuilder.ToString();
            return stringToReturn;
        }
    }
}
