using SimpleStringCompression.BusinessLogic;
using SimpleStringCompression.BusinessLogic.Abstractions;
using System;
using System.Windows.Forms;

namespace SimpleStringСompression
{
    public partial class Form1 : Form
    {
        private readonly IStringValidator stringValidator;
        private readonly IStringCompressor stringCompressor;

        public Form1()
        {
            InitializeComponent();
            stringValidator = new StringValidator();
            stringCompressor = new SimpleTextCompressor();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textInput.Text = "";
            textOutput.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (stringValidator.IsTooShort(textInput.Text))
            {
                MessageBox.Show($"Строка не должны быть пустой");
                textOutput.Text = "";
            }
            else if (stringValidator.IsTooLong(textInput.Text))
            {
                MessageBox.Show($"Длина строки не должна превышать 30 символов (сейчас {textInput.Text.Length})");
                textOutput.Text = "";
            }
            else
            {
                textOutput.Text = stringCompressor.Compress(textInput.Text);
            }
        }
    }
}
