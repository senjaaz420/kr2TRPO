using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;
using System.Text.RegularExpressions;


namespace ConsoleApplication1
{

    class ReadFile
    {
        public string st = "";
        public ReadFile()
        {
            FileStream file = new FileStream("D:\\wow.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file, Encoding.Default);
            st = reader.ReadToEnd();
            Console.WriteLine(st);
            reader.Close();
        }
    }
    class RegexDataInfo : ReadFile
    {
        public string regexData = @"(0[1-9]|1[012]).(0[1-9]|1[0-9]|2[0-9]|3[01]).[0-9]{4}";
        public RegexDataInfo()
        {
            Console.WriteLine("применение регярного выражения");
            StreamWriter sw = new StreamWriter("D:\\wiw.txt", false, Encoding.Default);
            Match match = Regex.Match(this.st, regexData);
            while (match.Success)
            {
                Console.WriteLine(match.Value);
                sw.WriteLine(match.Value);
                match = match.NextMatch();
            }
            sw.Close();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            RegexDataInfo regexDataInfo = new RegexDataInfo();
        }
    }
}
,