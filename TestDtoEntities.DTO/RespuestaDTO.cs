using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TestDtoEntities.DTO
{

    [DataContract]
    public class RespuestaDTO : BaseDTO
    {
        public int CodigoRespuesta { get; set; }

        public object ContenidoRespuesta { get; set; }
    }
}
