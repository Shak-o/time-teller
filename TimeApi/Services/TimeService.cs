using System.Globalization;
using TimeApi.Models;

namespace TimeApi.Services
{
    public class TimeService : ITimeService
    {
        public ResultModel GetTime()
        {
            var now = DateTime.UtcNow;

            var toReturn = new ResultModel
            {
                wYear = now.Year,
                wMonth = now.Month,
                wDay = now.Day,
                wHour = now.Hour,
                wMinute = now.Minute,
                wSecond = now.Second,
                wMilliseconds = now.Millisecond
            };
            return toReturn;
        }

        public string GetTimeByZone(string zone)
        {
            throw new NotImplementedException();
        }
    }
}
