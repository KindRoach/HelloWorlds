using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormHelloWorld
{
    public partial class SayHelloForm : Form
    {
        public SayHelloForm()
        {
            InitializeComponent();
        }

        private void SayHelloButton_Click(object sender, EventArgs e)
        {
            SayHelloTextBox.Text = "Hello World!";

        }
    }
}
