using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apteka.Models;

namespace Apteka.Data.Repositories
{
    public interface ISellingContentsRep1
    {
        Task<int> AddSC(ASellingContents sellingContents);
        Task<List<ASellingContents>> GetSCs();
        Task<List<ASellingContents>> GetItemsbySellingId(int sId);
    }
}
