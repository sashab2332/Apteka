using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apteka.Models;
using Microsoft.EntityFrameworkCore;

namespace Apteka.Data.Repositories
{
    public class SellingRep : ISellingRep
    {
        private readonly DataContext _context;
        public SellingRep(DataContext context)
        {
            _context = context;
        }
        public async Task<int> AddSelling(Selling selling)
        {
            await _context.Sellings.AddAsync(selling);
            await _context.SaveChangesAsync();
            return selling.SellingId;
        }
        public Task<List<Selling>> GetSellings() =>
            _context.Sellings.ToListAsync();
        public Task<Selling> GetSelling(int sellingId) =>
             _context.Sellings.FirstOrDefaultAsync(x => x.SellingId == sellingId);
        public Task RemoveSelling(Selling selling)
        {
            _context.Sellings.Remove(selling);
            return _context.SaveChangesAsync();
        }


    }
}
