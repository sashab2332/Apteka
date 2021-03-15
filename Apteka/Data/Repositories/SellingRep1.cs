using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apteka.Models;
using Microsoft.EntityFrameworkCore;

namespace Apteka.Data.Repositories
{
    public class SellingRep1 : ISellingRep1
    {
        private readonly DataContext1 _context;
        public SellingRep1(DataContext1 context)
        {
            _context = context;
        }
        public async Task<int> AddSelling(ASelling selling)
        {
            await _context.Sellings1.AddAsync(selling);
            await _context.SaveChangesAsync();
            return selling.SellingId1;
        }
        public Task<List<ASelling>> GetSellings() =>
            _context.Sellings1.ToListAsync();
        public Task<ASelling> GetSelling(int sellingId) =>
             _context.Sellings1.FirstOrDefaultAsync(x => x.SellingId1 == sellingId);
        public Task RemoveSelling(ASelling selling)
        {
            _context.Sellings1.Remove(selling);
            return _context.SaveChangesAsync();
        }


    }
}
