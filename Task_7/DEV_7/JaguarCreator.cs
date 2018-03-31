
namespace DEV_7
{
    public class JaguarCreator : ICreator
    {
        /// <summary>
        /// This class creates Jaguar cars.
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

        public JaguarCreator(string mark, string model, string bodyType, string transmissionType, string engineType, string amount,
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
            return new Jaguar(mark, model, bodyType, transmissionType, engineType, amount, power, climateControl, interiorType);
        }
    }
}
