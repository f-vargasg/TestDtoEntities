using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDtoEntities.DTO
{
    public class EntityIdValues
    {
        List<FieldValue> lstFldValues;

        public void AddValue(FieldValue fieldValue)
        {
            this.lstFldValues.Add(fieldValue);
        }

        FieldValue GetValue(int n)
        {
            return this.lstFldValues.Skip(n).First();
        }



    }
}
