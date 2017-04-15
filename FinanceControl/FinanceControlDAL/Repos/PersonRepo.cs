using FinanceControlDAL.Models;
using System.Data.Entity;
using System.Threading.Tasks;

namespace FinanceControlDAL.Repos
{
    public class PersonRepo : BaseRepo<Person>, IRepo<Person>
    {
        public PersonRepo()
        {
            Table = Context.People;
        }

        public int Delete(int id)
        {
            Context.Entry(new Person() { ID = id}).State = EntityState.Deleted;
            return SaveChanges();
        }

        public Task<int> DeleteAsync(int id)
        {
            Context.Entry(new Person() { ID = id}).State = EntityState.Deleted;
            return SaveChangesAsync();
        }
    }
}
