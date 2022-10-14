namespace TimeApi.Services
{
    public interface ITimeService
    {
        public string GetTime();
        public string GetTimeByZone(string zone);
    }
}
