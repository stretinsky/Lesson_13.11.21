using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodichka_13._11._21
{
    class BCipher : ICipher
    {
        const string lowerAlphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        const string upperAlphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        string ICipher.encode(string s)
        {
            string output = "";
            foreach (var c in s)
            {
                if (char.IsLower(c))
                {
                    int index = lowerAlphabet.IndexOf(c);
                    output += lowerAlphabet[lowerAlphabet.Length - index - 1];
                }
                else if (char.IsUpper(c))
                {
                    int index = upperAlphabet.IndexOf(c);
                    output += upperAlphabet[upperAlphabet.Length - index - 1];
                }
                else
                {
                    output += c;
                }
            }
            return output;
        }
        string ICipher.decode(string s)
        {
            string output = "";
            foreach (var c in s)
            {
                if (char.IsLower(c))
                {
                    int index = lowerAlphabet.IndexOf(c);
                    output += lowerAlphabet[lowerAlphabet.Length - index - 1];

                }
                else if (char.IsUpper(c))
                {
                    int index = upperAlphabet.IndexOf(c);
                    output += upperAlphabet[upperAlphabet.Length - index - 1];
                }
                else
                {
                    output += c;
                }
            }
            return output;
        }
    }
}
