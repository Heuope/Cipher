using System.Collections.Generic;

namespace UICS
{
    static class SomeInstruments
    {
        static private string[] symbols = { ",", ".", ";", "\r", "\n", ":", "[", "]", " ", "\t", "-" };
        static private string[] numbers = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
        static private string[] what = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0",
                                         ",", ".", ";", "\r", "\n", ":", "[", "]", " ", "\t",
                                         "-", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j",
                                         "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u",
                                         "v", "w", "x", "y", "z"};
        static private string[] whatRUS = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0",
                                         ",", ".", ";", "\r", "\n", ":", "[", "]", " ", "\t",
                                         "-", "а", "б", "в", "г", "д", "е", "ё", "ж", "з", "и",
                                         "й", "к", "л", "м", "н", "о", "п", "р", "с", "е", "у",
                                         "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я"};

        static private string alphabet = "abcdefghijklmnopqrstuvwxyz";
        static private string alphabetRUS = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

        static public string DelSym(string str)
        {                        
            foreach (var item in symbols)
                str = str.Replace(item, "");
            return str;
        }

        static public string DelNum(string str)
        {
            foreach (var item in numbers)
                str = str.Replace(item, "");
            return str;
        }

        static public string DelAlp(string str)
        {
            foreach (var item in alphabet.ToCharArray())
                str = str.Replace(item.ToString(), "");
            return str;
        }

        static public string DelAlpRUS(string str)
        {
            foreach (var item in alphabetRUS.ToCharArray())
                str = str.Replace(item.ToString(), "");
            return str;
        }

        static public string ForText(string str)
        {
            foreach (var item in symbols)
                str = str.Replace(item.ToString(), "");
            foreach (var item in numbers)
                str = str.Replace(item.ToString(), "");
            foreach (var item in alphabetRUS.ToCharArray())
                str = str.Replace(item.ToString(), "");
            return str;
        }

        static public string ForTextRUS(string str)
        {
            foreach (var item in symbols)
                str = str.Replace(item.ToString(), "");
            foreach (var item in numbers)
                str = str.Replace(item.ToString(), "");
            foreach (var item in alphabet.ToCharArray())
                str = str.Replace(item.ToString(), "");
            return str;
        }

        static public string CreateText(string from, string to)
        {            
            int index = 0; // index in "to"
            string result = "";
            var h = new HashSet<string>(whatRUS);
            if (from.Length > to.Length)
                for (int i = 0; i < from.Length - to.Length; i++)
                    to += " ";

            for (int i = 0; i < from.Length; i++)
                if (!h.Contains(from[i].ToString()))
                    result += to[index++];
                else
                    result += from[i];
            result += to.Substring(index);            
            return result;
        }

        static public string CreateTextRUS(string from, string to)
        {
            int index = 0; // index in "to"
            string result = "";
            var h = new HashSet<string>(what);
            if (from.Length > to.Length)
                for (int i = 0; i < from.Length - to.Length; i++)
                    to += " ";

            for (int i = 0; i < from.Length; i++)
                if (!h.Contains(from[i].ToString()))
                    result += to[index++];
                else
                    result += from[i];
            result += to.Substring(index);
            return result;
        }

        static public string TakeFromFile(string FileName)
        {
            return System.IO.File.ReadAllText(FileName);
        }

        static public void SaveInFile(string FileName, string Text)
        {            
            System.IO.File.WriteAllText(FileName, Text);
        }
    }
}
