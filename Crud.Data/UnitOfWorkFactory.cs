using Crud.Data.Models;
using IData.Interfaces;
using System.Data.Entity.Validation;

namespace Crud.Data
{
    public class UnitOfWorkFactory: IUnitOfWorkFactory
    {
        private readonly CrudDBContext _dbContext;

        public UnitOfWorkFactory(CrudDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void SaveChanges()
        {
            try
            {
                _dbContext.SaveChanges();
            }
            catch(DbEntityValidationException)
            {
                
            }
        }
    }
}
