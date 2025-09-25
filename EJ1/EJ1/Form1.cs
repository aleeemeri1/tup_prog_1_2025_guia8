using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EJ1.Models;


namespace EJ1
{
    public partial class Form1 : Form
    {
         List<Vehiculo> vehiculos = new List<Vehiculo>();   
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos CSV|*.csv|Todos los archivos| *.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = null;
                StreamReader sr = null;
                string name = ofd.FileName;

                try
                {
                    fs = new FileStream(name, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);
                    sr.ReadLine();
                     while (sr.EndOfStream != true)
                     {
                        string cadena = sr.ReadLine();
                        string[] separator = cadena.Split(';');
                        string patente = separator[0];
                        double importe = Convert.ToDouble(separator[1]);
                        Vehiculo vehiculo = new Vehiculo(patente, importe);

                        vehiculos.Add(vehiculo);

                     }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (sr != null) sr.Close();
                    if (fs != null) fs.Close();
                }

            }
       
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Archivos CSV|*.csv|Todos los archivos| *.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string name = sfd.FileName;
                FileStream fs = null;
                StreamWriter sw = null;
                try
                {
                    fs = new FileStream(name, FileMode.OpenOrCreate, FileAccess.Write);
                    sw = new StreamWriter(fs);
                    foreach (Vehiculo v in vehiculos)
                    {
                        string cadena = v.Exportar();
                        sw.WriteLine(cadena);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (sw != null) sw.Close();
                    if (fs != null) fs.Close();
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string path = "C:\\Users\\Alumno\\Desktop\\repos\\tup_prog_1_2025_guia8\\EJ1\\EJ1\\bin\\Debug\\net8.0-Windows\\vehiculos.csv";
            string[] lineas = File.ReadAllLines(path);
        }
    }
}
