using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = "C:\\Users\\Alumno\\Desktop\\repos\\tup_prog_1_2025_guia8\\EJ1\\EJ1\\bin\\Debug\net8.0-Windows\\vehiculos.csv";
            string[] lineas  = File.ReadAllLines(path); 

            OpenFileDialog ofd 
            
            foreach (string line in lineas)
            {
                string [] s = line.Split(';');
                textBox1.Text += s[0] +"  "+ s[1] + "\r \n";

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
