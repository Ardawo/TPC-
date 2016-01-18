using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    class Splitter
    {
        public static void split(string input_path, string dir_path, int nb)
        {
            System.IO.FileStream inf = new System.IO.FileStream(input_path, System.IO.FileMode.Open, System.IO.FileAccess.Read);
            System.IO.BinaryReader reader = new System.IO.BinaryReader(inf);
            System.IO.BinaryWriter[] writers = new System.IO.BinaryWriter[nb];
            for (int x = 0; x < nb; x++)
            {
                writers[x] = new System.IO.BinaryWriter(new System.IO.FileStream(dir_path + "/part_" + (x + 1) + ".ACDC",
                                                                    System.IO.FileMode.Create,
                                                                    System.IO.FileAccess.Write));

            }
            int i = 0;
            while (reader.PeekChar() != -1)
            {

                writers[i % nb].Write(reader.ReadChar());

                i++;
            }
            for (int j=0; j<nb; j++)
            {
                writers[j].Close();
            }
            
        }

        public static void merge(string output_path, string dir_path, int nb)
        {
                System.IO.FileStream fs = new System.IO.FileStream(output_path, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                System.IO.BinaryWriter writer = new System.IO.BinaryWriter(fs);
                System.IO.BinaryReader[] readers = new System.IO.BinaryReader[nb];

            int x = 0;
            while ( x<nb && readers [x].PeekChar() != -1)
            {
                writer
            }

             //* split gives you a little hint about how to initialize readers

            // FIXME
        }
    }
}
