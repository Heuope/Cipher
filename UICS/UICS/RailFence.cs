using System;

namespace UICS
{
    static public class RailFence
    {
        static public string DeCipherENG(string fileText, int key)
        {
            if (key == 0 || key == 1)
                return fileText;

            string text = SomeInstruments.DeleteUnnecessarySymbols(fileText.ToLower());
            int row;
            int period = 2 * (key - 1);
            int k = 0;
            var _DeChipherText = new char[text.Length];
            for (int j = 0; j < key; j++)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    row = key - 1 - Math.Abs(key - 1 - i % period);
                    if (row == j)
                        _DeChipherText[i] = text[k++];
                }
            }
            string result = SomeInstruments.CreateText(fileText, string.Join("", _DeChipherText));
            return result;
        }

        static public string DeCipherALL(string FileText, int key)
        {
            if (key == 0 || key == 1)
                return FileText;
            string text = FileText.ToLower();
            int row, period = 2 * (key - 1), k = 0;
            var a = new string[key, text.Length];
            var _DeChipherText = new char[text.Length];
            for (int j = 0; j < key; j++)
                for (int i = 0; i < text.Length; i++)
                {
                    row = key - 1 - Math.Abs(key - 1 - i % period);
                    if (row == j)
                        _DeChipherText[i] = text[k++];
                }
            string result = string.Join("", _DeChipherText);
            return result;
        }

        static public string CipherENG(string FileText, int key)
        {
            if (key == 0 || key == 1)
                return FileText;
            string text = SomeInstruments.DeleteUnnecessarySymbols(FileText.ToLower());
            var _CipherText = new string[key];
            int row, period = 2 * (key - 1);
            for (int i = 0; i < text.Length; i++)
            {
                row = key - 1 - Math.Abs(key - 1 - i % period);
                _CipherText[row] += text[i];
            }
            string result = SomeInstruments.CreateText(FileText, string.Join("", _CipherText));
            return result;
        }

        static public string CipherALL(string FileText, int key)
        {
            if (key == 0 || key == 1)
                return FileText;
            string text = FileText.ToLower();
            var _CipherText = new string[key];
            int row, period = 2 * (key - 1);
            for (int i = 0; i < text.Length; i++)
            {
                row = key - 1 - Math.Abs(key - 1 - i % period);
                _CipherText[row] += text[i];
            }
            string result = string.Join("", _CipherText);
            return result;
        }
    }
}
