using FinanceControlDAL.Models;
using System.Data.Entity;
using System.Threading.Tasks;

namespace FinanceControlDAL.Repos
{
    public class AccountRepo : BaseRepo<Account>, IRepo<Account>
    {
        public AccountRepo()
        {
            Table = Context.Accounts;
        }

        public int Delete(int id)
        {
            Context.Entry(new Account() { ID = id }).State = EntityState.Deleted;
            return SaveChanges();
        }

        public Task<int> DeleteAsync(int id)
        {
            Context.Entry(new Account() { ID = id}).State = EntityState.Deleted;
            return SaveChangesAsync();
        }
    }
}
