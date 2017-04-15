using FinanceControlDAL.Models;
using System.Data.Entity;
using System.Threading.Tasks;

namespace FinanceControlDAL.Repos
{
    public class IncomeRepo : BaseRepo<Income>, IRepo<Income>
    {
        public IncomeRepo()
        {
            Table = Context.Incomes;
        }

        public int Delete(int id)
        {
            Context.Entry(new Income() { ID = id}).State = EntityState.Deleted;
            return SaveChanges();
        }

        public Task<int> DeleteAsync(int id)
        {
            Context.Entry(new Income() { ID = id}).State = EntityState.Deleted;
            return SaveChangesAsync();
        }
    }
}
