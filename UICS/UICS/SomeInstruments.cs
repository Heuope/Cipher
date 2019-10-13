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
            foreach (char item in alphabet)
                str = str.Replace(item.ToString(), "");
            return str;
        }

        static public string DelAlpRUS(string str)
        {
            foreach (var item in alphabetRUS.ToCharArray())
                str = str.Replace(item.ToString(), "");
            return str;
        }

        static public string DeleteUnnecessarySymbols(string str, bool isRus = true)
        {
            foreach (string item in symbols)
                str = str.Replace(item, "");
            foreach (string item in numbers)
                str = str.Replace(item, "");

            string defaultAlphabet = isRus ? alphabetRUS : alphabet;

            // string можно итерировать просто так
            foreach (char item in defaultAlphabet)
                str = str.Replace(item.ToString(), "");
            return str;
        }

        // прекраснейший принцип DRY - Don't Repeat Yourself
        static public string DeleteUnnecessaryRUSSymbols(string str)
        {
            return DeleteUnnecessarySymbols(str, false);
        }

        static public string CreateText(string from, string to, bool isRus = true)
        {            
            int toIndex = 0;
            string result = "";

            string[] defaultWhat = isRus ? whatRUS : what;

            var whatHashSet = new HashSet<string>(defaultWhat);
            if (from.Length > to.Length)
                for (int i = 0; i < from.Length - to.Length; i++)
                    to += " ";

            for (int i = 0; i < from.Length; i++)
                if (!whatHashSet.Contains(from[i].ToString()))
                    result += to[toIndex++];
                else
                    result += from[i];
            result += to.Substring(toIndex);            
            return result;
        }

        static public string CreateTextRUS(string from, string to)
        {
            return CreateText(from, to, false);
        }

        static public string ReadFromFile(string fileName)
        {
            return System.IO.File.ReadAllText(fileName);
        }

        static public void SaveInFile(string fileName, string Text)
        {            
            System.IO.File.WriteAllText(fileName, Text);
        }
    }
}
