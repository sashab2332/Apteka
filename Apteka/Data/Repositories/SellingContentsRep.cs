using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apteka.Models;
using Microsoft.EntityFrameworkCore;

namespace Apteka.Data.Repositories
{
    class SellingContentsRep : ISellingContentsRep
    {
        private readonly DataContext _context;

        public SellingContentsRep(DataContext context)
        {
            _context = context;
        }

        public async Task<int> AddSC(SellingContents sellingContents)
        {
            await _context.SellingContents.AddAsync(sellingContents);
            await _context.SaveChangesAsync();
            return sellingContents.SellingContentsId;
        }

        public Task<List<SellingContents>> GetSCs() =>
           _context.SellingContents.ToListAsync();

        public Task<List<SellingContents>> GetItemsbySellingId (int sId) =>
            _context.SellingContents.Where(x => x.SellingId == sId).ToListAsync();

        
    }
}
