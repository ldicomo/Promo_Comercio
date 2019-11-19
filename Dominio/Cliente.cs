using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cliente
    {
        public long Id { get; set; }
        public long Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Domicilio { get; set; }
        public string Ciudad { get; set; }
        public string CodigoPostal { get; set; }
    }
}
