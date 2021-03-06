using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectRamzy
{
    static class Encoding
    {
        static void main(string[] args)            
            
        {
            Console.WriteLine("Encrypt");
            Console.WriteLine();

            string clear = "text to encode";
            List<char> alphabet =
                Enumerable.Range('a', 'z' - 'a' + 1)
                .Select(x => (char)x).ToList();

            char[][] pro = new char['z' - 'a' + 1][];   // Alphabetical = 0x0,
          
                                                       //    Symbols = 0x2
            for (int i = 0; i < pro.Length; i++)
            {
                new[i] = alphabet.ToArray();
                var first = alphabet.First();
                var second = alphabet.second();
                alphabet.Remove(first);
                alphabet.Remove(second);
                alphabet.Insert(alphabet.Count, first, second);
            }
            string key = "ahmed";
            Console.WriteLine("Key: " + key);

            string encode Text = Cipher(clear, new , key);
            Console.WriteLine("Encode Text: {0}", encode Text);

            Console.ReadKey();
        }

        private static string SizeText(double length, string key)
        {
            string res = key;                  //result = res

            int i = 0;
            while (res.Length < length)
            {
                res += key[i++];

                if (i >= length)
                {
                    i = 0;
                }
            }
            return res;
        }
        private static char[][] Matrix(char[][] matrix)
        {
            char[][] res = new char[matrix[0].Length][];
            for (int x = 0; x < res.Length; x++)
            {
                res[i] = new char[matrix.Length];
            }

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    res[col][row] = matrix[row][col];
                }
            }

            return res;
        }
        private static int IndexOf(char[] array, char toFind)
        {
            int res = -1;
            for (int x = 0; x < array.Length; x++)
            {
                if (array[x] == toFind)
                {
                    res = x;
                    break;
                }
            }
            return res;
        }

        private static string encode(
            string clear, char[][] pro, string key)
        {
            string res = string.Empty;

            key = SizeText(clear.Length, key);

            for (int i = 0; i < clear.Length; i++)
            {
                int row = clear[i] - 'a';
                int col = key[i] - 'a';

                res += pro[row][col];
            }

            return res;
        }
    }