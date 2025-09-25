using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ1.Models
{
    internal class PatenteException : ApplicationException
    {
        public PatenteException() : base("patente invalida") { }

        public PatenteException(string message) : base(message) { }
    }
}
