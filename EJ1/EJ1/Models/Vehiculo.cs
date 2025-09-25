using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ1.Models
{
    internal class Vehiculo:IExportable
    {
        public string patente;
        public double importe;

        public Vehiculo(string patente, double importe)
        {
            patente = patente;
            importe = importe;
        }
        public void Importar(string cadena)
        {
            cadena = cadena.Trim();
            string[] separator = cadena.Split(';');
            string patente = separator[0];
            if (patente.Length == 6 || patente.Length == 7)
            {
                patente = patente;
            }
            else
            {
                throw new PatenteException();
            }
            importe = importe;
        }
        public override string ToString()
        {
            return $"patente:{patente}, importe: {importe}";
        }

        public string Exportar()
        {
            return $"patente:{patente}, importe: {importe}";
        }
    }
}
