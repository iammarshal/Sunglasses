using Microsoft.EntityFrameworkCore;
using Sunglasses_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses_Repository
{
    public class RepositoryBase<T> where T : class
    {
        Sunglasses2023DBContext dbContext;
        DbSet<T> sunglasses;

        public RepositoryBase()
        {
            dbContext = new Sunglasses2023DBContext();
            sunglasses = dbContext.Set<T>();
        }

        public async Task Add(T item)
        {
            _ = await sunglasses.AddAsync(item);
            _ = await dbContext.SaveChangesAsync();
        }

        public async Task Delete(T item)
        {
            _ = sunglasses.Remove(item);
            _ = await dbContext.SaveChangesAsync();
        }

        public List<T> GetAll()
        {
            return sunglasses.ToList();
        }

        public async Task Update(T item)
        {
            _ = sunglasses.Update(item);
            _ = await dbContext.SaveChangesAsync();
        }
    }
}
