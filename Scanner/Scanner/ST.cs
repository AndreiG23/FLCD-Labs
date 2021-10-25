using System;
using System.Collections.Generic;
using System.Text;

namespace Scanner
{
    public class ST
    {
        public int Capacity { get; set; }
        public string[] table { get; set; }

        public ST(int capacity)
        {
            this.Capacity = capacity;
            this.table = new string[capacity];
        }

        public bool Add(string key)
        {
            int h = hashFunction(key);

            while (table[h] != null)
            {
                if (table[h] == key)
                {
                    return false;
                }

                h++;
            }

            table[h] = key;
            return true;
        }

        public int Search(string key)
        {
            int h = hashFunction(key);

            while (table[h] != null)
            {
                if (table[h] == key)
                {
                    return h;
                }

                h++;
            }

            return -1;
        }

        private int hashFunction(string key)
        {
            int sum = 0;
            byte[] asciiBytes = Encoding.ASCII.GetBytes(key);
            foreach (byte b in asciiBytes)
            {
                sum += b;
            }
            return sum % Capacity;
        }
    }
}
