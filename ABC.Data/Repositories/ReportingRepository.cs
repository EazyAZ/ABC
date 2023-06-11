namespace ABC.Data.Repositories;

public partial class ReportingRepository : IReportingRepository
{
    private readonly ABCContext _context;

    public ReportingRepository(ABCContext context, ILogger<ReportingRepository> logger)
    {
        _context = context;
    }

    public List<XY<string, int>> SelectByRange(ReportingType reportingType, RangeType range)
    {
        throw new NotImplementedException();
    }

    public int SelectCount(ReportingType reportingType, string filter)
    {
        Random rnd = new Random();
        return rnd.Next(1, 1000);
    }
}
