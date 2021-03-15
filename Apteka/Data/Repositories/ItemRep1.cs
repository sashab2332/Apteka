using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apteka.Models;
using Microsoft.EntityFrameworkCore;

namespace Apteka.Data.Repositories
{
    public class ItemRep1 : IItemRep1
    {
        private readonly DataContext1 _context;
        public ItemRep1(DataContext1 context)
        {
            _context = context;
        }

        public Task<AItem> GetItem(int itemId) =>
             _context.Items1.FirstOrDefaultAsync(x => x.Id1 == itemId);

        public Task<AItem> GetItem(string itemName)=>
            _context.Items1.FirstOrDefaultAsync(x => x.ItemName1 == itemName);

        public async Task<int> AddItem(AItem item)
        {
            await _context.Items1.AddAsync(item);
            await _context.SaveChangesAsync();
            return item.Id1;
        }

        public Task<List<AItem>> GetItems() =>
            _context.Items1.ToListAsync();

        public Task<List<AItem>> GetItemsbyName(string name) =>
            _context.Items1.Where(x => x.ItemName1 == name).ToListAsync();
        public Task UpdateItem(AItem item)
        {
            _context.Items1.Update(item);
            return _context.SaveChangesAsync();
        }
        public Task RemoveItem(AItem item)
        {
            _context.Items1.Remove(item);
            return _context.SaveChangesAsync();
        }
    }
}
