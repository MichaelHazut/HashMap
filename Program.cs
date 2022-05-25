using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blossom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int HashMapSize = 20;
            HashMap hashMap = new HashMap(HashMapSize);

            hashMap.Assign("Key_Example", "Value_Example");
            //Fill Dictionary With Random 
            //Keys And Values
            for (int i = 0; i < 1000000; i++)
            {
                hashMap.Assign(GetRandomString(), GetRandomString());
            }

        }
        public static string GetRandomString()
        {
            string word = "";
            string letters = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";
            for(int i = new Random().Next(4,10); i > 0; i--)
            {
                word += letters[new Random().Next(0, letters.Length)];
            }
            return word;
        }
    }
}
