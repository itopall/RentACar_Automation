using RentACar.Data.Context;
using RentACar.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Data.UnitOfWork
{
    public class UnitOfWorkRepositoryGeneric : IDisposable
    {
        #region Veriable
        private readonly RentACarEntities _racContext;

        #endregion

        #region Ctor
        public UnitOfWorkRepositoryGeneric()
        {
            _racContext = new RentACarEntities();
        }
        #endregion

        #region Repository
        public RepositoryGeneric<T> GetRepository<T>() where T : class
        {
            return new RepositoryGeneric<T>(_racContext);
        }
        #endregion

        #region Transaction
        public void BeginTransaction()
        {
            _racContext.Database.BeginTransaction();
        }
        public void CommitTransaction()
        {
            _racContext.Database.CurrentTransaction.Commit();
        }
        public void RollbackTransaction()
        {
            _racContext.Database.CurrentTransaction.Rollback();
        }
        public int SaveChanges()
        {
            try
            {
                return _racContext.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
        #endregion

        #region Disposable
        bool disposed = false;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            disposed = true;
        }

        ~UnitOfWorkRepositoryGeneric()
        {
            Dispose(false);
        }
        #endregion

    }
}
