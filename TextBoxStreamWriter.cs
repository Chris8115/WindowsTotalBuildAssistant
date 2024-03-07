using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WindowsTotalBuildAssistant
{
    public class TextBoxStreamWriter : TextWriter
    {
        TextBox textBox;

        public TextBoxStreamWriter(TextBox output)
        {
            textBox = output;
        }

        public override void Write(char value)
        {
            textBox.AppendText(value.ToString());
        }

        public override Encoding Encoding
        {
            get { return Encoding.UTF8; }
        }
    }
}
