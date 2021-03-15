using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apteka.Models;

namespace Apteka.Data.Repositories
{
    public interface ISellingRep
    {
        Task<int> AddSelling(Selling selling);
        Task<List<Selling>> GetSellings();
        Task<Selling> GetSelling(int sellingId);
        Task RemoveSelling(Selling selling);
    }
}
