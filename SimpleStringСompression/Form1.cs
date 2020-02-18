using SimpleStringCompression.BusinessLogic;
using SimpleStringCompression.BusinessLogic.Abstractions;
using System;
using System.Windows.Forms;

namespace SimpleStringСompression
{
    public partial class Form1 : Form
    {
        private readonly IStringCompressor stringCompressor;

        public Form1()
        {
            InitializeComponent();
            stringCompressor = new SimpleTextCompressor();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textInput.Text = "";
            textOutput.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (StringValidator.IsTooShort(textInput.Text))
            {
                MessageBox.Show($"Строка должна содержать минимум 2 символа");
                textOutput.Text = "";
            }
            else if (StringValidator.IsTooLong(textInput.Text))
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
