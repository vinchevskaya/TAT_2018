using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using System.IO;


namespace DEV_7
{
    public class JSONreader
    {
            private ICreator creator;
            private ICars cars;
            private string stock;

            public JSONreader(string stock)
            {
                this.stock = stock;
            }

            /// <summary>
            /// This method reads json file.
            /// </summary>
            public ICreator ReadToObjectJson()
            {
                MemoryStream storage = new MemoryStream();
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(cars.GetType());
               // Dictionary<ICars, object> car = (Dictionary<string, object>) serializer.ReadObject(Reader);
                cars = (ICars)serializer.ReadObject(storage);
            if (cars.Mark == "Jaguar")
            {
                creator = new JaguarCreator(cars.Mark, cars.Model, cars.BodyType, cars.TransmissionType, cars.EngineType,
                  cars.Amount, cars.Power, cars.ClimateControl, cars.InteriorType);
            }
            else if (cars.Mark == "Lexus")
            {
                creator = new LexusCreator(cars.Mark, cars.Model, cars.BodyType, cars.TransmissionType, cars.EngineType,
                  cars.Amount, cars.Power, cars.ClimateControl, cars.InteriorType);
            }
                storage.Close();
                return creator;
            }
    }
}