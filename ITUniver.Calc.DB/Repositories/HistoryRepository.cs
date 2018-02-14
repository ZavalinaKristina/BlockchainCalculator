using ITUniver.Calc.DB.Modules;

namespace ITUniver.Calc.DB.Repositories
{
    public class HistoryRepository : BaseRepository<HistoryItem>, IHistoryRepository
    {
        public HistoryRepository() : base("History")
        {
           
        }
    }
}
