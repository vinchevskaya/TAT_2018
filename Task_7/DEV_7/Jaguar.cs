

namespace DEV_7
{
    public class Jaguar : ICars 
    {
        public string Mark { get; set; }
        public string Model { get; set; }
        public string BodyType { get; set; }
        public string TransmissionType { get; set; }
        public string EngineType { get; set; }
        public string Amount { get; set; }
        public string Power { get; set; }
        public string ClimateControl { get; set; }
        public string InteriorType { get; set; }

        public Jaguar(string mark, string model, string bodyType, string transmissionType, string engineType, string amount,
          string power, string climateControl, string interiorType)
        {
            Mark = mark;
            Model = model;
            BodyType = bodyType;
            TransmissionType = transmissionType;
            EngineType = engineType;
            Amount = amount;
            Power = power;
            ClimateControl = climateControl;
            InteriorType = interiorType;
        }
    }
}
