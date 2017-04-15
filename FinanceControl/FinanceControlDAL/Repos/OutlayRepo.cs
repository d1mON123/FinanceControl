using FinanceControlDAL.Models;
using System.Data.Entity;
using System.Threading.Tasks;

namespace FinanceControlDAL.Repos
{
    public class OutlayRepo : BaseRepo<Outlay>, IRepo<Outlay>
    {
        public OutlayRepo()
        {
            Table = Context.Outlays;
        }

        public int Delete(int id)
        {
            Context.Entry(new Outlay() { ID = id}).State = EntityState.Deleted;
            return SaveChanges();
        }

        public Task<int> DeleteAsync(int id)
        {
            Context.Entry(new Outlay() { ID = id}).State = EntityState.Deleted;
            return SaveChangesAsync();
        }
    }
}
