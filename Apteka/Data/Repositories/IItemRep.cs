using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apteka.Models;

namespace Apteka.Data.Repositories
{
    public interface IItemRep
    {
         Task<Item> GetItem(int itemId);

         Task<Item> GetItem(string itemName);

          Task<int> AddItem(Item item);

         Task<List<Item>> GetItems();

         Task<List<Item>> GetItemsbyName(string name);
         Task UpdateItem(Item item);
         Task RemoveItem(Item item);
    }
}
