using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Sergi Martinez Torres
namespace ProyectoPruebaGit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dni = Convert.ToInt32(TextBoxDNI.Text);

            char letter = functionDNI(dni);
            TextBoxLetter.Text = letter.ToString();

        }

        private char functionDNI(int dni)
        {
            char letter = 'A';
            
            return letter;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
