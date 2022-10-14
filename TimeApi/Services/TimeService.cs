using System.Globalization;

namespace TimeApi.Services
{
    public class TimeService : ITimeService
    {
        public string GetTime()
        {
            var now = DateTime.UtcNow;

            var tbilisi = now.AddHours(4);

            return tbilisi.ToString(CultureInfo.InvariantCulture);
        }

        public string GetTimeByZone(string zone)
        {
            throw new NotImplementedException();
        }
    }
}
