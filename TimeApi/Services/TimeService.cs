using System.Globalization;

namespace TimeApi.Services
{
    public class TimeService : ITimeService
    {
        public string GetTime()
        {
            var now = DateTime.UtcNow;

            return now.ToString(CultureInfo.InvariantCulture);
        }

        public string GetTimeByZone(string zone)
        {
            throw new NotImplementedException();
        }
    }
}
