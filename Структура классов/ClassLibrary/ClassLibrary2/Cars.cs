namespace ClassLibrary2
{
    public struct Size
    {
        public ushort Length;
        public ushort Width;
        public ushort Height;
    }

    public class Cars
    {
        public QuantitativeComposition Contract { get; set; }
        public string Number { get; set; }
        public string Brand { get; set; }
        public Size Size { get; set; }
        public ushort YearManufacture { get; set; }
        public Engines Engine { get; set; }
        public string TypeTransmission { get; set; }
        public byte NumberGears { get; set; }
    }
}
