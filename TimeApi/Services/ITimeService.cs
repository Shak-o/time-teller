using TimeApi.Models;

namespace TimeApi.Services
{
    public interface ITimeService
    {
        public ResultModel GetTime();
        public string GetTimeByZone(string zone);
    }
}
