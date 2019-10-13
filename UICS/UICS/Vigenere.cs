using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UICS
{
    static class Vigenere
    {
        static private string alphabet = "abcdefghijklmnopqrstuvwxyz";
        static private string alphabetRUS = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

        static public string Cipher(string FileText, string key)
        {
            string text = SomeInstruments.DeleteUnnecessarySymbols(FileText.ToLower());
            string result = "";
            text.ToLower();
            // create a key            
            int _priLenKey = key.Length;
            while (key.Length < text.Length)
                key += alphabet[(alphabet.IndexOf(key[key.Length - _priLenKey]) + 1) % 26];
            // create chiphertext
            int _index;
            for (int i = 0; i < text.Length; i++)
            {
                _index = (alphabet.IndexOf(text[i]) + alphabet.IndexOf(key[i])) % 26;
                result += alphabet[_index];
            }
            return SomeInstruments.CreateText(FileText, result);
        }

        static public string CipherRUS(string FileText, string key)
        {
            string text = SomeInstruments.DeleteUnnecessaryRUSSymbols(FileText.ToLower());
            string result = "";
            text.ToLower();
            // create a key            
            int _priLenKey = key.Length;
            while (key.Length < text.Length)
                key += alphabetRUS[(alphabetRUS.IndexOf(key[key.Length - _priLenKey]) + 1) % 33];
            // create chiphertext
            int _index;
            for (int i = 0; i < text.Length; i++)
            {
                _index = (alphabetRUS.IndexOf(text[i]) + alphabetRUS.IndexOf(key[i])) % 33;
                result += alphabetRUS[_index];
            }
            return SomeInstruments.CreateTextRUS(FileText, result);
        }

        static public string DeCipher(string FileText, string key)
        {
            string text = SomeInstruments.DeleteUnnecessarySymbols(FileText.ToLower());
            string result = "";
            text.ToLower();
            // create a key            
            int _priLenKey = key.Length;
            while (key.Length < text.Length)
                key += alphabet[(alphabet.IndexOf(key[key.Length - _priLenKey]) + 1) % 26];
            // create chiphertext
            int _index;
            for (int i = 0; i < text.Length; i++)
            {
                _index = (alphabet.IndexOf(text[i]) + 26 - alphabet.IndexOf(key[i])) % 26;
                result += alphabet[_index];
            }
            
            return SomeInstruments.CreateText(FileText, result);            
        }

        static public string DeCipherRUS(string FileText, string key)
        {
            string text = SomeInstruments.DeleteUnnecessaryRUSSymbols(FileText.ToLower());
            string result = "";
            text.ToLower();
            // create a key            
            int _priLenKey = key.Length;
            while (key.Length < text.Length)
                key += alphabetRUS[(alphabetRUS.IndexOf(key[key.Length - _priLenKey]) + 1) % 26];
            // create chiphertext
            int _index;
            for (int i = 0; i < text.Length; i++)
            {
                _index = (alphabetRUS.IndexOf(text[i]) + 33 - alphabetRUS.IndexOf(key[i])) % 33;
                result += alphabetRUS[_index];
            }
            return SomeInstruments.CreateTextRUS(FileText, result);
        }
    }
}
