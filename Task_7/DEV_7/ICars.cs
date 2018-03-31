using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_7
{
    public interface ICars
    {
        string Mark { get; set; }
        string Model { get; set; }
        string BodyType { get; set; }
        string TransmissionType { get; set; }
        string EngineType { get; set; }
        string Amount { get; set; }
        string Power { get; set; }
        string ClimateControl { get; set; }
        string InteriorType { get; set; }
    }
}
