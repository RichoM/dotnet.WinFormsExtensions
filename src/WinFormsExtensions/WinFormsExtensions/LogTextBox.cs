using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Windows.Forms
{
    public partial class LogTextBox : UserControl
    {
        private int indent = 0;

        public LogTextBox()
        {
            InitializeComponent();

            TextColor = Color.Black;
            IndentText = "  ";
        }

        public Color TextColor { get; set; }
        public string IndentText { get; set; }
        
        public void Log(string str, params object[] args)
        {
            Log(string.Format(str, args));
        }

        public void Log(string str)
        {
            this.Invoke(() =>
            {
                foreach (var line in str.Split(new[] { "\n", "\r\n" }, StringSplitOptions.None))
                {
                    // INFO(Richo): Code for text coloring taken from: https://stackoverflow.com/a/1926822
                    textBox.SelectionStart = textBox.TextLength;
                    textBox.SelectionLength = 0;
                    textBox.SelectionColor = TextColor;
                    for (int i = 0; i < indent; i++)
                    {
                        textBox.AppendText(IndentText);
                    }
                    textBox.AppendText(line);
                    textBox.AppendText(Environment.NewLine);
                }
                textBox.ScrollToCaret();
            });
        }

        public void LogError(Exception ex)
        {
            LogError("ERROR!", ex);
        }

        public void LogError(string message, Exception ex)
        {
            WithTextColor(Color.Red, () =>
            {
                Log(message);
                Log(ex.ToString());
            });
        }

        public void Indent(Action action)
        {
            Indent(1, action);
        }

        public void Indent(int level, Action action)
        {
            if (level <= 0) { level = 0; }

            indent += level;
            try
            {
                action();
            }
            finally
            {
                indent -= level;
            }
        }

        public void NewLine()
        {
            Log("");
        }

        public void Clear()
        {
            this.Invoke(textBox.Clear);
        }

        public void WithTextColor(Color color, Action action)
        {
            Color old = TextColor;
            try
            {
                TextColor = color;
                action();
            }
            finally
            {
                TextColor = old;
            }
        }
    }
}
