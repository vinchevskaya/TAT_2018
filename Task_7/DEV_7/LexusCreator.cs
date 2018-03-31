
namespace DEV_7
{
    public class LexusCreator : ICreator
    {
        /// <summary>
        /// This class creates Lexus cars.
        /// </summary>
        string mark;
        string model;
        string bodyType;
        string transmissionType;
        string engineType;
        string amount;
        string power;
        string climateControl;
        string interiorType;

        public LexusCreator(string mark, string model, string bodyType, string transmissionType, string engineType, string amount,
          string power, string climateControl, string interiorType)
        {
            this.mark = mark;
            this.model = model;
            this.bodyType = bodyType;
            this.transmissionType = transmissionType;
            this.engineType = engineType;
            this.amount = amount;
            this.power = power;
            this.climateControl = climateControl;
            this.interiorType = interiorType;
        }

        public ICars CarsCreator()
        {
            return new Lexus(mark, model, bodyType, transmissionType, engineType, amount, power, climateControl, interiorType);
        }
    }
}
