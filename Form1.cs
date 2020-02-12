using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaPrueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            int DNI = Convert.ToInt32(textBoxDNI.Text);
            char DNIletter = functionDNI(DNI);
            textBoxDNILetter.Text = DNIletter.ToString();
        }

        private char functionDNI(int DNI)
        {
            char DNIletter = 'A';

            return DNIletter;
            


        }

    }
}
