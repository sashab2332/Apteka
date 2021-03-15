using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apteka.Models;
using Microsoft.EntityFrameworkCore;

namespace Apteka.Data.Repositories
{
    public class ItemRep : IItemRep
    {
        private readonly DataContext _context;
        public ItemRep(DataContext context)
        {
            _context = context;
        }

        public Task<Item> GetItem(int itemId) =>
             _context.Items.FirstOrDefaultAsync(x => x.Id == itemId);

        public Task<Item> GetItem(string itemName)=>
            _context.Items.FirstOrDefaultAsync(x => x.ItemName == itemName);

        public async Task<int> AddItem(Item item)
        {
            await _context.Items.AddAsync(item);
            await _context.SaveChangesAsync();
            return item.Id;
        }

        public Task<List<Item>> GetItems() =>
            _context.Items.ToListAsync();

        public Task<List<Item>> GetItemsbyName(string name) =>
            _context.Items.Where(x => x.ItemName == name).ToListAsync();
        public Task UpdateItem(Item item)
        {
            _context.Items.Update(item);
            return _context.SaveChangesAsync();
        }
        public Task RemoveItem(Item item)
        {
            _context.Items.Remove(item);
            return _context.SaveChangesAsync();
        }
    }
}
