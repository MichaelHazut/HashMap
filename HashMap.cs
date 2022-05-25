using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blossom
{
    internal class HashMap
    {
        private Dictionary<string, string>[] Map { get; set; }

        
        public HashMap(int arrSize)
        {
            Map = new Dictionary<string, string>[arrSize];
            
            //UnNull every index in the Array
            for (int i = 0; i < arrSize; i++)
                Map[i] = new Dictionary<string, string>();
}
        
        public int Hash(string key)
        {   //Convert A Key to A Hash Number
            return BitConverter.ToInt32(Encoding.Default.GetBytes(key), 0);
        }
        
        public int Compress(int hash)
        {   //Compresses The Hash Number
            //To Fit Inside The Array
            return hash % Map.Length;
        }
        
        public void Assign(string key, string value)
        {
            if (key.Length < 4) return;
            
            //Generate A Hash Number And
            //Compress It To Get An Index
            int index = Compress(Hash(key));
            Map[index][key] = value;
        }
       
        public string Retrive(string key)
        {
            int index = Compress(Hash(key));
            return Map[index][key];
        }
    }
}
