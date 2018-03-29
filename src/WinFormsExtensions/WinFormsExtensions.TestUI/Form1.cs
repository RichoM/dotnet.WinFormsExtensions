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
    }
}
