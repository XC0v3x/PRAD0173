using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace PRAD0173.Models
{
    public class PagosModel
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [MaxLength(9)]
        public string Descripcion { get; set; }
        [MaxLength(200)]
        public double Monto { get; set; }
        public DateTime FechaRegistro { get; set; }
        public Byte[] Foto { get; set; }
    }
}
