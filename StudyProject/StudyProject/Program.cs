using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PartialClassA.A1();
            PartialClassA.A2();
        }

        public static string RandomName(int length)
        {
            const string Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var randomString = new StringBuilder();
            var random = new Random();
            for (int i = 0; i < length; i++)
            {
                randomString.Append(Chars[random.Next(Chars.Length)]);
            }
            return randomString.ToString();
        }
    }
}
