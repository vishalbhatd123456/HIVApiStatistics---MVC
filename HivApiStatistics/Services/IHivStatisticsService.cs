
public interface IHivStatisticsService{
    Task<HivStatistic> GetHivStatisticAsync(DateTime date);
}