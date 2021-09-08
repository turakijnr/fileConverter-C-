using System;
using System.IO;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
             var converter = new Converter();

             converter.Description = "convert to mkv";
             converter.ConverterName = "vlc";
             converter.VlcConverter("gfgfggh.png"); 
             
             Console.WriteLine(converter);

        }
    }
}
   