using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDtoEntities.BE
{
    public class DetalleBloombergBE
    {
        string CodEncabloombergV { get; set; }
        string CodFieldV { get; set; }
        DateTime FecTransaccion { get; set; }
        double ValBloombergN { get; set; }
        int CodEstadoN { get; set; }
        int CodRegistroN { get; set; }
    }
}
