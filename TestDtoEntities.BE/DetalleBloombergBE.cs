﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDtoEntities.Modelo
{
    public class DetalleBloombergBE
    {
        public string CodEncabloombergV { get; set; }
        public string CodFieldV { get; set; }
        public DateTime FecTransaccion { get; set; }
        public double ValBloombergN { get; set; }
        public int CodEstadoN { get; set; }
        public decimal CodRegistroN { get; set; }
    }
}
