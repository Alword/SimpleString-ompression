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
            stringCompressor = new ValidationCompressor((text) => StringValidator.IsValid(text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textInput.Text = string.Empty;
            textOutput.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            textOutput.Text = string.Empty;

            try
            {
                textOutput.Text = stringCompressor.Compress(textInput.Text);
            }
            catch (ArgumentOutOfRangeException exection)
            {
                MessageBox.Show(exection.Message);
                textOutput.Text = string.Empty;
            }

        }
    }
}
