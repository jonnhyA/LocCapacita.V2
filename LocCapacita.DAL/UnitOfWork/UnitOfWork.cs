using LocCapacita.DAL.Interfaces;
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Diagnostics;


namespace LocCapacita.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        protected readonly DbContext _context;

        public DbContext Context
        {
            get { return _context; }
        }

        public UnitOfWork()
        {
            _context = new LocCapacitaContext();
        }

        public void Commit()
        {
            try
            {
                if (_context != null)
                    _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                if (ex.Entries != null)
                {
                    foreach (var entry in ex.Entries)
                    {
                        Trace.WriteLine("Entidade: " + entry.Entity);
                        Trace.WriteLine("Operação/estado: " + entry.State);
                    }

                }
                Trace.WriteLine("SalvarAlteracoes DbUpdateException:" + ex.Entries);

                if (Context != null)
                    Context.Dispose();

                throw;
            }
            catch (DbEntityValidationException ex)
            {
                Trace.WriteLine("SalvarAlteracoes DbEntityValidationException:" + ex.Message);
                foreach (var dbEntityValidationResult in ex.EntityValidationErrors)
                {
                    Trace.WriteLine("Entidade:" + dbEntityValidationResult.Entry.Entity);
                    if (dbEntityValidationResult.Entry.State != EntityState.Added)
                    {
                        if (dbEntityValidationResult.Entry.CurrentValues != null)
                            Trace.WriteLine("Valor atual: " + dbEntityValidationResult.Entry.CurrentValues);

                        if (dbEntityValidationResult.Entry.OriginalValues != null)
                            Trace.WriteLine("Valor novo: " + dbEntityValidationResult.Entry.OriginalValues);
                    }
                    foreach (var dbValidationError in dbEntityValidationResult.ValidationErrors)
                    {
                        Trace.WriteLine("Propriedade: " + dbValidationError.PropertyName + " - Mensagem: " + dbValidationError.ErrorMessage);
                    }
                }
                Context.Dispose();

                throw;
            }
            catch (Exception ex)
            {
                Trace.WriteLine("SalvarAlteracoes Exception: " + ex.Message);
                Context.Dispose();

                throw;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
