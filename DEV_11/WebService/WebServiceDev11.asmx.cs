using System;
using System.Web.Services;

namespace WebService
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]     
    // [System.Web.Script.Services.ScriptService]
    public class DateConverter : System.Web.Services.WebService
    {
        [WebMethod()]
        public int DaysCounter(int day, int month, int year)
        {
            DateTime dateValue;
            string dateString = day.ToString() + "/" + month.ToString() + "/" + year.ToString();
            if (DateTime.TryParse(dateString, out dateValue))
            {
                DateTime currentDate = new DateTime(year, month, day);
                return Convert.ToInt32((currentDate - DateTime.MinValue).TotalDays);
            }
            else
            {
                throw new ArgumentException("Invalid parameters");
            }
        }
    }
}
