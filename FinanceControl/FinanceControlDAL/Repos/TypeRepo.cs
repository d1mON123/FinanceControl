using System.Data.Entity;
using System.Threading.Tasks;

namespace FinanceControlDAL.Repos
{
    public class TypeRepo : BaseRepo<Models.Type>, IRepo<Models.Type>
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
