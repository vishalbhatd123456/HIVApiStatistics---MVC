
public class HivStatisticsService : IHivStatisticsService
{
    public async Task<HivStatistic> GetHivStatisticAsync(DateTime date)
    {
        //Mock 
        return await Task.FromResult(new HivStatistic{Date = date, Count = 42});
    }
}