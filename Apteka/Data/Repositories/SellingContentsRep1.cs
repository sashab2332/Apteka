using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apteka.Models;
using Microsoft.EntityFrameworkCore;

namespace Apteka.Data.Repositories
{
    class SellingContentsRep1 : ISellingContentsRep1
    {
        private readonly DataContext1 _context;

        public SellingContentsRep1(DataContext1 context)
        {
            _context = context;
        }

        public async Task<int> AddSC(ASellingContents sellingContents)
        {
            await _context.SellingContents1.AddAsync(sellingContents);
            await _context.SaveChangesAsync();
            return sellingContents.SellingContentsId1;
        }

        public Task<List<ASellingContents>> GetSCs() =>
           _context.SellingContents1.ToListAsync();

        public Task<List<ASellingContents>> GetItemsbySellingId (int sId) =>
            _context.SellingContents1.Where(x => x.SellingId1 == sId).ToListAsync();

        
    }
}
