namespace BinanceP2P.Models
{
    public class Field
    {
        public string fieldId { get; set; }
        public string fieldName { get; set; }
        public string fieldContentType { get; set; }
        public object sequence { get; set; }
        public int restrictionType { get; set; }
        public int lengthLimit { get; set; }
        public bool isRequired { get; set; }
        public bool isCopyable { get; set; }
        public string hintWord { get; set; }
        public string fieldValue { get; set; }
    }
}
