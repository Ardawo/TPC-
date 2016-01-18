using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace IO
{
    class Strings
    {
        static bool is_printable(char c)
        {
            return ((int)c>=20 && (int)c<=127);
        }
        public static string strings(string path)
        {
            string result = "";

            System.IO.FileStream fs = new System.IO.FileStream(path, System.IO.FileMode.Open, System.IO.FileAccess.Read);
            System.IO.BinaryReader br = new System.IO.BinaryReader(fs, Encoding.ASCII);
            while (br.PeekChar() != -1)
            {
                char c = br.ReadChar();
                if (is_printable (c))
                {
                    if (c=='\\')
                    {
                        result += '\n';
                    }
                    else
                    {
                    result+= c;
                    }
                }
            }
            Console.WriteLine(result);
            return result;
        }
    }
}
