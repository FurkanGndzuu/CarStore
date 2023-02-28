using Microsoft.EntityFrameworkCore;
using RentACarAPI.Application.Repositories;
using RentACarAPI.Domain.Entities;
using RentACarAPI.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RentACarAPI.Persistance.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        readonly RenACarDbContext context;
        public ReadRepository(RenACarDbContext _context)
        {
            context = _context;
        }
        public DbSet<T> Table => context.Set<T>();

        DbSet<T> IRepository<T>.Table => throw new NotImplementedException();

        public IQueryable<T> GetAll(bool tracking = true)
        {

            var querry = Table.AsQueryable();
            if (!tracking)
            {
                querry = querry.AsNoTracking();
            }
            return querry;

        }


        public async Task<T> GetByIdAsync(string id, bool tracking = true)
        {
            var querry = Table.AsQueryable();

            if (!tracking)
            {
                querry = querry.AsNoTracking();
            }
            return await querry.FirstOrDefaultAsync(x => x.Id == Guid.Parse(id));
        }

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true)
        {
            var querry = Table.AsQueryable();
            if (!tracking)
            {
                querry = querry.AsNoTracking();
            }
            return await querry.FirstOrDefaultAsync(method);
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true)
        {
            var querry = Table.Where(method);
            if (!tracking)
            {
                querry = querry.AsNoTracking();
            }
            return querry.AsQueryable();
        }
    }
}
