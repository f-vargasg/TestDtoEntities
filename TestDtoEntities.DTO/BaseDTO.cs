using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TestDtoEntities.DTO
{
    public class BaseDTO
    {
        // public EntityIdValues entityId { get; set; }
        public int idEntity;

        public string Mensaje { get; set; }
    }
}
