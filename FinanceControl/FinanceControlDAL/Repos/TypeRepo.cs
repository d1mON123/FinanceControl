using System.Data.Entity;
using System.Threading.Tasks;
using FinanceControlDAL.Models;

namespace FinanceControlDAL.Repos
{
    public class TypeRepo : BaseRepo<Type>, IRepo<Type>
    {
        public TypeRepo()
        {
            Table = Context.Types;
        }

        public int Delete(int id)
        {
            Context.Entry(new Models.Type() { ID = id}).State = EntityState.Deleted;
            return SaveChanges();
        }

        public Task<int> DeleteAsync(int id)
        {
            Context.Entry(new Models.Type() { ID = id}).State = EntityState.Deleted;
            return SaveChangesAsync();
        }
    }
}
