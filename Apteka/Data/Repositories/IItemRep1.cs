using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apteka.Models;

namespace Apteka.Data.Repositories
{
    public interface IItemRep1
    {
         Task<AItem> GetItem(int itemId);

         Task<AItem> GetItem(string itemName);

          Task<int> AddItem(AItem item);

         Task<List<AItem>> GetItems();

         Task<List<AItem>> GetItemsbyName(string name);
         Task UpdateItem(AItem item);
         Task RemoveItem(AItem item);
    }
}
