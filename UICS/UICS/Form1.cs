using System;
using System.Drawing;
using System.Windows.Forms;

namespace UICS
{
    public partial class Form1 : Form
    {
        private string loadPath;
        private string savePath;

        public Form1()
        {
            InitializeComponent();            
        }
        
        private string CheckThat(string key, string cipher)
        {
            string _result = SomeInstruments.DelSym(key);
            if (cipher == "Rail_Fence_ENG" || cipher == "Rail_Fence_ALL")
            {
                _result = SomeInstruments.DelAlp(_result);
                try
                {
                    int.Parse(_result);
                }
                catch (FormatException)
                {
                    _result = "";
                }
            }
            else if (cipher == "Playfair_ENG" || cipher == "Vigenere_ENG")
                _result = SomeInstruments.ForText(_result);            
            else
                _result = SomeInstruments.ForTextRUS(_result);
            return _result.ToLower();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lamp.BackColor = Color.Gray;
            lamp_Load.BackColor = Color.Gray;
            lamp_Save.BackColor = Color.Gray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string key = _textBox.Text;
            key = CheckThat(key, comboBox1.Text);

            if (key == "" || savePath == "" || loadPath == "" || key == "")
            {
                lamp.BackColor = Color.DarkRed;
                return;            
            }            
            string text = SomeInstruments.TakeFromFile(loadPath);            
            string code = "";
            if (checkBox1.Checked)
            {
                if (comboBox1.Text == "Vigenere_ENG")
                    code = Vigenere.Cipher(text, key);
                else if (comboBox1.Text == "Rail_Fence_ENG")
                    code = RailFence.CipherENG(text, int.Parse(key));
                else if (comboBox1.Text == "Rail_Fence_ALL")
                    code = RailFence.CipherALL(text, int.Parse(key));
                else if (comboBox1.Text == "Playfair_ENG")
                    code = Playfair.Cipher(text, key);
                else if (comboBox1.Text == "Vigenere_RUS")
                    code = Vigenere.CipherRUS(text, key);
            }
            else
            {
                if (comboBox1.Text == "Vigenere_ENG")
                    code = Vigenere.DeCipher(text, key);
                else if (comboBox1.Text == "Rail_Fence_ENG")
                    code = RailFence.DeCipherENG(text, int.Parse(key));
                else if (comboBox1.Text == "Playfair_ENG")
                    code = Playfair.DeCipher(text, key);
                else if (comboBox1.Text == "Rail_Fence_ALL")
                    code = RailFence.DeCipherALL(text, int.Parse(key));
                else if (comboBox1.Text == "Vigenere_RUS")
                    code = Vigenere.DeCipherRUS(text, key);
            }            
            SomeInstruments.SaveInFile(savePath, code.Trim());
            savePath = null;
            loadPath = null;
            lamp.BackColor = Color.DarkGreen;
            lamp_Load.BackColor = Color.Gray;
            lamp_Save.BackColor = Color.Gray;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lamp.BackColor = Color.Gray;            
            openFileDialog1.InitialDirectory = "Desktop";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                loadPath = openFileDialog1.FileName;
            }
            if (loadPath != null)
                lamp_Load.BackColor = Color.DarkGreen;
            else
                lamp_Load.BackColor = Color.DarkRed;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            lamp.BackColor = Color.Gray;
            saveFileDialog1.InitialDirectory = "Desktop";
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                savePath = saveFileDialog1.FileName;
            }
            if (savePath != null)
                lamp_Save.BackColor = Color.DarkGreen;
            else
                lamp_Save.BackColor = Color.DarkRed;
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
