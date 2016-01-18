using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    class Stegano
    {
        private static int get_bit(byte b, int index)
        {
            // FIXME
            // Returns the value of the bit at the specified index
            // 4 ===> 00000100, get_bit(0) = 0
            // 4 ===> 00000100, get_bit(5) = 1
            // Out of range always returns 0
            // 4 ===> 00000100, get_bit(-1) = 0
            // 4 ===> 00000100, get_bit(12) = 0
            return 0;
        }

        private static void set_next_coords(ref int x, ref int y, System.Drawing.Bitmap image)
        {
            // FIXME
            // (Increase x) or (Reset x to 0 and Increase y)
        }

        public static void hide(string path, string text)
        {
            System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(path);
            // Used to mark the end of the string
            text += '\0';
            // FIXME
            bmp.Save(path + "_out.bmp");
        }

        public static string reveal(string path)
        {
            string result = "";
            System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(path);
            // FIXME
            return result;
        }
    }
}
