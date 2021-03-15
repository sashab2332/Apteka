using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apteka.Models;

namespace Apteka.Data.Repositories
{
    public interface ISellingContentsRep
    {
        Task<int> AddSC(SellingContents sellingContents);
        Task<List<SellingContents>> GetSCs();
        Task<List<SellingContents>> GetItemsbySellingId(int sId);
    }
}
