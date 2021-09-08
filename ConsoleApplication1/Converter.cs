using System;
using System.Diagnostics;
using System.IO;

namespace ConsoleApplication1
{
    public class Converter
    {
        public  string ConverterName;
        public string Description;
        public string Converted;
       
        public string Mkvconverter(string path)
        {
            
            
            string target = Path.ChangeExtension(path, ".mkv");/*Convert file format */

            return target  ;

        }
       public  string VlcConverter(string path)
       {
            
            
           string target = Path.ChangeExtension(path, ".vlc");/*Convert file format */
           var converted = target + "_converted";
           return converted  ;

       }
    }
}
