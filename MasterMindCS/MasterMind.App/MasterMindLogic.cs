using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MasterMind.App
{
    public class MasterMindLogic
    {
        public static string ReceiveCode(int level)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 4; i++)
            {
                sb.Append((char)('A' + new Random().Next(level + 2)));
            }

            string code = sb.ToString();
            return code;
        }

        public static string GetGuessFeedback(string code, string input)
        {
            throw new NotImplementedException("The logic for getting feedback for a guess is not implemented. Try to apply TDD practices to implement it.");
        }
    }
}
