using RentACar.Data.Context;
using RentACar.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Data.UnitOfWork
{
    public class UnitOfWork : IDisposable
    {
        #region Veriable
        private readonly RentACarEntities _context;
        #endregion

        #region Ctor
        public UnitOfWork()
        {
            _context = new RentACarEntities();
        }
        #endregion

        #region Repository
        public Repository<T> GetRepository<T>() where T : class
        {
            return new Repository<T>(_context);
        }
        #endregion

        #region Transaction

        public void BeginTransaction()
        {
            _context.Database.BeginTransaction();
        }

        public void CommitTransaction()
        {
            _context.Database.CurrentTransaction.Commit();
        }
        public void RollbackTransaction()
        {
            _context.Database.CurrentTransaction.Rollback();
        }
        public int SaveChanges()
        {
            try
            {
                return _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        #endregion

        #region Dispose
        bool dispose = false;

        protected virtual void Dispose(bool disposing)
        {
            if (dispose)
                return;

            dispose = true;
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        ~UnitOfWork()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion

    }
}
