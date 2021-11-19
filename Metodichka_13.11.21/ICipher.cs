using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodichka_13._11._21
{
    interface ICipher
    {
        string encode(string s);
        string decode(string s);
    }
}
