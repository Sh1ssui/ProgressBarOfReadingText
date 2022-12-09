using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace ProgressBarOfReadingText
{
    public partial class Form1 : Form
    {
        string str;
        int length_read_text = 0;
        public Form1()
        {
            InitializeComponent();
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            string path = @"C:\Users\User\source\repos\ProgressBarOfReadingText\YourText.txt";
            if (File.Exists(path))
            {
                textBox1.Text = File.ReadAllText(path, Encoding.Default);
            }
            textBox1.Click += TextBox1_Click;
        }

        private void TextBox1_Click(object sender, EventArgs e)
        {
            for(int i=0;i<textBox1.Text.Length;i++)
            {
                str = textBox1.Text.Substring(textBox1.SelectionStart);
            }
            length_read_text = (textBox1.Text.Length - str.Length)*100 / textBox1.Text.Length;
            progressBar1.Value = length_read_text;
            label2.Text = length_read_text.ToString()+" %";
            progressBar1.PerformStep();
            label2.Visible = true;
        }
    }
}
