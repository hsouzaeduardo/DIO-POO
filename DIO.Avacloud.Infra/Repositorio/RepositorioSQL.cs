using DIO.Avacloud.Entidades;
using DIO.Avacloud.Entidades.Contrato;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DIO.Avacloud.Infra.Repositorio
{
    public class RepositorioSQL<T> : IRepository<T> where T : EntityBase
    {
        private readonly Contexto.AvaCloudDB _ctx;
        internal readonly DbSet<T> _tables;

        public RepositorioSQL(Contexto.AvaCloudDB ctx)
        {
            _ctx = ctx;
            _tables = _ctx.Set<T>();
        }

        public async Task<int> AddAsync(T entity)
        {
            _tables.Add(entity);
            await _ctx.SaveChangesAsync();
            return entity.Id;
        }

        public async Task<int> CountAsync()
        {
            return await _tables.CountAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _tables.Remove(entity);
            await _ctx.SaveChangesAsync();
        }

        public async Task EditAsync(T entity)
        {
            _tables.Update(entity);
            await _ctx.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
             return await _tables.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _tables.FindAsync(id);
        }
    }
}
