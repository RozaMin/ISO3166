namespace RozaMin.ISO3166
{
    public partial class Country
    {
        internal Country(string name, string twoLetterCode, string threeLetterCode, string numericCode)
        {
            Name = name;
            TwoLetterCode = twoLetterCode;
            ThreeLetterCode = threeLetterCode;
            NumericCode = numericCode;
        }

        public string Name { get; private set; }
        public string TwoLetterCode { get; private set; }
        public string ThreeLetterCode { get; private set; }
        public string NumericCode { get; private set; }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Country other = obj as Country;
            if (other == null) return false;

            return ThreeLetterCode.Equals(other.ThreeLetterCode);
        }

        public override int GetHashCode()
        {
            return ThreeLetterCode.GetHashCode();
        }
    }
}
