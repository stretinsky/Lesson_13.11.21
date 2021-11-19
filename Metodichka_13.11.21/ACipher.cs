using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodichka_13._11._21
{
    class ACipher : ICipher
    {
        const string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ"; // а - 0    А - 33
        string ICipher.encode(string s)
        {
            string output = "";
            foreach (var c in s)
            {
                int index = alphabet.IndexOf(c);
                if (index < 0)
                {
                    output += c;
                }
                else
                {
                    if (index == 32)
                    {
                        output += alphabet[0];
                    }
                    else if (index == 65)
                    {
                        output += alphabet[33];
                    }
                    else
                    {
                        output += alphabet[index + 1];
                    }
                }
            }
            return output;
        }
        string ICipher.decode(string s)
        {
            string output = "";
            foreach (var c in s)
            {
                int index = alphabet.IndexOf(c);
                if (index < 0)
                {
                    output += c;
                }
                else
                {
                    if (index == 0)
                    {
                        output += alphabet[32];
                    }
                    else if (index == 33)
                    {
                        output += alphabet[65];
                    }
                    else
                    {
                        output += alphabet[index - 1];
                    }
                }
            }
            return output;
        }
    }
}
