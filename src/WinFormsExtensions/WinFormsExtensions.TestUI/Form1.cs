using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsExtensions.TestUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void testInputBoxButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yo soy: " + InputBox.Ask("Quién soy?"));
        }

        private void testLogTextBoxButton_Click(object sender, EventArgs e)
        {
            logger.Log("Prueba...");
            for (int i = 0; i < 45; i++)
            {
                logger.WithTextColor(i % 2 == 0 ? Color.Blue : Color.Red, () =>
                {
                    logger.Log("{0}) Indent level {1}", DateTime.Now, i);
                    logger.Indent(i, () =>
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            logger.Log("{0}", j + i);
                        }
                    });
                    logger.LogNewLine();
                });
            }
        }
    }
}
