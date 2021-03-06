﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Historial
    {
        public int Id { get; set; }
        public string TipoDeTransaccion { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Borrado { get; set; }

        public Historial() {
            this.Usuario = "demo";
            this.TipoDeTransaccion = "TipoDemo";
            this.Descripcion = "DescripcionDemo";
            this.Fecha = DateTime.Now;
            this.FechaCreacion = DateTime.Now;
            this.Borrado = true;
        }
    }
}
