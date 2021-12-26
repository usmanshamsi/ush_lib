using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ush_lib
{
    public static class Print
    {
        public static void Title(string title)
        {
            int len = title.Length;
            string dashes = new string('=', len);
            Console.WriteLine(dashes);
            Console.WriteLine(title);
            Console.WriteLine(dashes);
        }

        public static void Warning(string msg)
        {
            msg = "WARNING: " + msg;
            int len = msg.Length;
            string dashes = new string('-', len);
            Console.WriteLine(dashes);
            Console.WriteLine(msg);
            Console.WriteLine(dashes);
        }

        public static void Error(string msg)
        {
            msg = "ERROR: " + msg;
            int len = msg.Length;
            string dashes = new string('-', len);
            Console.WriteLine(dashes);
            Console.WriteLine(msg);
            Console.WriteLine(dashes);
        }

        public static void Info(string msg)
        {
            msg = "INFO: " + msg;
            int len = msg.Length;
            string dashes = new string('-', len);
            Console.WriteLine(dashes);
            Console.WriteLine(msg);
            Console.WriteLine(dashes);
        }
    }
}
