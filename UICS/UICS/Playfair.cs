using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UICS
{
    class Playfair
    {
        static private string alphabet = "abcdefghijklmnopqrstuvwxyz";
        
        static private string CreateKey(string key)
        {            
            string _result = "";
            for (int i = 0; i < key.Length; i++)
                if (_result.IndexOf(key[i]) == -1)
                    _result += key[i];
            for (int i = 0; i < 26; i++)
                if (_result.IndexOf(alphabet[i]) == -1)
                    _result += alphabet[i];            
            return _result.Replace("j", "");            
        }

        static private string[] PrepString(string str)
        {            
            string _result = str[0].ToString();
            for (int i = 1; i < str.Length; i++)
                if (str[i] == _result[_result.Length - 1])
                    _result += "x" + str[i];
                else
                    _result += str[i];
            if (_result.Length % 2 != 0)
                _result += "x";
            _result = _result.Replace("j", "i");
            var result = new string[_result.Length / 2];
            for (int i = 0; i < _result.Length; i += 2)
                result[i / 2] = _result.Substring(i, 2);
            return result;
        }

        static public string Cipher(string FileText, string key)
        {
            key = key.ToLower();            
            var _text = SomeInstruments.ForText(FileText.ToLower());
            var _bigRam = new List<string>();
            var _resBigRam = new List<string>();

            foreach (var item in PrepString(_text))
                _bigRam.Add(item);
            
            string temp, _key = CreateKey(key);
            int _first, _second, dif;
            foreach (var item in _bigRam)
            {                
                if (_key.IndexOf(item[0]) / 5 == _key.IndexOf(item[1]) / 5) // one row
                {
                    _first  = (_key.IndexOf(item[0]) + 1) % 5 == 0 ? _key.IndexOf(item[0]) - 4 : _key.IndexOf(item[0]) + 1;
                    _second = (_key.IndexOf(item[1]) + 1) % 5 == 0 ? _key.IndexOf(item[1]) - 4 : _key.IndexOf(item[1]) + 1;
                    temp    = _key[_first].ToString() + _key[_second].ToString();
                }
                else if (_key.IndexOf(item[0]) % 5 == _key.IndexOf(item[1]) % 5) // one column
                {
                    _first  = (_key.IndexOf(item[0]) + 5) % 25;
                    _second = (_key.IndexOf(item[1]) + 5) % 25;
                    temp    = _key[_first].ToString() + _key[_second].ToString();
                }
                else // dif angle square
                {
                    dif = _key.IndexOf(item[0]) % 5 - _key.IndexOf(item[1]) % 5;
                    _first = _key.IndexOf(item[0]) - dif;
                    _second = _key.IndexOf(item[1]) + dif;
                    temp = _key[_first].ToString() + _key[_second].ToString();
                }
                _resBigRam.Add(temp);
            }
            string _result = "";
            foreach (var item in _resBigRam)
                _result += item;
            _result = SomeInstruments.CreateText(FileText, _result);
            return _result;
        }

        static public string DeCipher(string FileText, string key)
        {
            key = key.ToLower();
            var _text = SomeInstruments.ForText(FileText.ToLower());
            var _bigRam = new List<string>();
            var _resBigRam = new List<string>();

            foreach (var item in PrepString(_text))
                _bigRam.Add(item);

            string temp, _key = CreateKey(key);
            int _first, _second, dif;
            foreach (var item in _bigRam)
            {
                if (_key.IndexOf(item[0]) / 5 == _key.IndexOf(item[1]) / 5) // one row
                {
                    _first = _key.IndexOf(item[0]) % 5 == 0 ? _key.IndexOf(item[0]) + 4 : _key.IndexOf(item[0]) - 1;
                    _second = _key.IndexOf(item[1]) % 5 == 0 ? _key.IndexOf(item[1]) + 4 : _key.IndexOf(item[1]) - 1;
                    temp = _key[_first].ToString() + _key[_second].ToString();
                }
                else if (_key.IndexOf(item[0]) % 5 == _key.IndexOf(item[1]) % 5) // one column
                {
                    _first = _key.IndexOf(item[0]) - 5 < 0 ? 25 - 5 + _key.IndexOf(item[0]) : _key.IndexOf(item[0]) - 5;
                    _second = _key.IndexOf(item[1]) - 5 < 0 ? 25 - 5 + _key.IndexOf(item[1]) : _key.IndexOf(item[1]) - 5;
                    temp = _key[_first].ToString() + _key[_second].ToString();
                }
                else // dif angle square
                {
                    dif = _key.IndexOf(item[0]) % 5 - _key.IndexOf(item[1]) % 5;
                    _first = _key.IndexOf(item[0]) - dif;
                    _second = _key.IndexOf(item[1]) + dif;
                    temp = _key[_first].ToString() + _key[_second].ToString();
                }
                _resBigRam.Add(temp);
            }
            string _result = "";
            foreach (var item in _resBigRam)
                _result += item;

            if (_result[_result.Length - 1] == 'x')
                _result = _result.Substring(0, _result.Length - 1);

            string _temp = "";
            for (int i = 0; i < _result.Length; i++)
                if (!(_result[i] == 'x' && _result[i - 1] == _result[i + 1]))
                    _temp += _result[i];

            _result = SomeInstruments.CreateText(FileText, _temp);
            return _result;
        }
    }
}
