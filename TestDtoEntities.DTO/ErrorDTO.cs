using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TestDtoEntities.DTO
{

    [DataContract]
    public class ErrorDTO : BaseDTO
    {
        public int CodigoError { get; set; }

        public string MensajeError { get; set; }
    }
}
