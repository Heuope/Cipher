namespace UICS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._textBox = new System.Windows.Forms.TextBox();
            this._button = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lamp = new System.Windows.Forms.Button();
            this.lamp_Load = new System.Windows.Forms.Button();
            this.lamp_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _textBox
            // 
            this._textBox.Location = new System.Drawing.Point(184, 12);
            this._textBox.Name = "_textBox";
            this._textBox.Size = new System.Drawing.Size(147, 20);
            this._textBox.TabIndex = 5;
            // 
            // _button
            // 
            this._button.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._button.Location = new System.Drawing.Point(184, 38);
            this._button.Name = "_button";
            this._button.Size = new System.Drawing.Size(147, 63);
            this._button.TabIndex = 6;
            this._button.Text = "CIPHER";
            this._button.UseVisualStyleBackColor = true;
            this._button.Click += new System.EventHandler(this.button1_Click);
            // 
            // loadButton
            // 
            this.loadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadButton.Location = new System.Drawing.Point(57, 12);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(121, 39);
            this.loadButton.TabIndex = 7;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Vigenere_ENG",
            "Rail_Fence_ENG",
            "Playfair_ENG",
            "Vigenere_RUS",
            "Rail_Fence_ALL"});
            this.comboBox1.Location = new System.Drawing.Point(337, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBox1.Location = new System.Drawing.Point(349, 38);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(85, 28);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Cipher";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(57, 62);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(121, 39);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // lamp
            // 
            this.lamp.FlatAppearance.BorderSize = 0;
            this.lamp.Location = new System.Drawing.Point(374, 62);
            this.lamp.Name = "lamp";
            this.lamp.Size = new System.Drawing.Size(42, 39);
            this.lamp.TabIndex = 12;
            this.lamp.UseVisualStyleBackColor = true;
            // 
            // lamp_Load
            // 
            this.lamp_Load.Location = new System.Drawing.Point(12, 12);
            this.lamp_Load.Name = "lamp_Load";
            this.lamp_Load.Size = new System.Drawing.Size(39, 39);
            this.lamp_Load.TabIndex = 13;
            this.lamp_Load.UseVisualStyleBackColor = true;
            // 
            // lamp_Save
            // 
            this.lamp_Save.Location = new System.Drawing.Point(12, 62);
            this.lamp_Save.Name = "lamp_Save";
            this.lamp_Save.Size = new System.Drawing.Size(39, 38);
            this.lamp_Save.TabIndex = 14;
            this.lamp_Save.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(469, 116);
            this.Controls.Add(this.lamp_Save);
            this.Controls.Add(this.lamp_Load);
            this.Controls.Add(this.lamp);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this._button);
            this.Controls.Add(this._textBox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Hello world";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _textBox;
        private System.Windows.Forms.Button _button;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button lamp;
        private System.Windows.Forms.Button lamp_Load;
        private System.Windows.Forms.Button lamp_Save;
    }
}

