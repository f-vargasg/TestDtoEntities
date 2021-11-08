namespace TestDtoEntities.DTO
{
    public class FieldValue
    {
        public string FldType { get; set; }
        public object FldValue { get; set; }

        public FieldValue()
        {

        }

        public FieldValue(string pFieldType,
                           object pFieldValue)
        {
            this.FldType = pFieldType;
            this.FldValue = pFieldValue;
        }
    }
}