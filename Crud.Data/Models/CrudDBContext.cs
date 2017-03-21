using System.Data.Entity;

namespace Crud.Data.Models
{
    public class CrudDBContext : DbContext
    {
        public CrudDBContext()
            :base("name=CrudDBContext")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public virtual DbSet<Customer> Customer { get; set; }

    }
}
