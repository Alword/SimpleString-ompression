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

        private void textInput_TextChanged(object sender, EventArgs e)
        {
            textOutput.Text = stringCompressor.Compress(textInput.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textInput.Text = "";
            textOutput.Text = "";
        }
    }
}
