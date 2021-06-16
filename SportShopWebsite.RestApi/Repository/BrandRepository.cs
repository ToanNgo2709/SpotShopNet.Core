using Microsoft.EntityFrameworkCore;
using SportShopWebsite.RestApi.Models.Context;
using SportShopWebsite.RestApi.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportShopWebsite.RestApi.Repository
{
    public class BrandRepository : ICrudFeature<Brand>
    {
        private readonly SportDbContext _context = SportDbContext.GetInstance;

        public async Task<Brand> Add(Brand type)
        {
            _context.Brands.Add(type);
            await _context.SaveChangesAsync();
            return type;
        }

        public async Task Delete(int id)
        {
            var item = await _context.Brands.FindAsync(id);
            _context.Brands.Remove(item);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Brand>> GetAll()
        {
            return await Task.FromResult(_context.Brands.ToList());
        }

        public async Task<Brand> GetById(int id)
        {
            return await _context.Brands.FindAsync(id);
        }

        public async Task Update(Brand type)
        {
            _context.Entry(type).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
