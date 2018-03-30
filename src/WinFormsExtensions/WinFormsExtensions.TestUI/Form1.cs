using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
                    logger.NewLine();
                });
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                try
                {
                    Text = "Esto debería fallar!";
                }
                catch (Exception ex)
                {
                    logger.LogError("Excepción esperada", ex);
                }

                this.Invoke(() =>
                {
                    Text = "Esto no debería fallar porque está adentro del Invoke(..)";                    
                });

                logger.Log("{0}) Esperando 1 segundo...", DateTime.Now.ToString("o"));
                Thread.Sleep(1000);
                this.Invoke(() =>
                {
                    Text = Guid.NewGuid().ToString();
                });
                logger.Log("{0}) Espera finalizada", DateTime.Now.ToString("o"));
            });
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            logger.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            logger.Indent(3, () =>
            {
                logger.Log("Este es un texto con\nsaltos de línea en\r\ncualquier lugar.\n\r\nDebería andar bien la indentación.");
                logger.NewLine();
                logger.Log("Fin del comunicado");
            });
        }
    }
}
