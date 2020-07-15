namespace ClassLibrary
{
    public class LightCars
    {
        public int Id { get; set; }
        public QuantitativeComposition Contract { get; set; }
        public string Number { get; set; }
        public string Brand { get; set; }
        public ushort Length { get; set; }
        public ushort Width { get; set; }
        public ushort Height { get; set; }
        public ushort YearManufacture { get; set; }
        public Engines Engine { get; set; }
        public string TypeTransmission { get; set; }
        public byte NumberGears { get; set; }
        public string BodyType { get; set; }
        public byte Capacity { get; set; }
    }
}
