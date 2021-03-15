using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apteka.Models;

namespace Apteka.Data.Repositories
{
    public interface ISellingRep1
    {
        Task<int> AddSelling(ASelling selling);
        Task<List<ASelling>> GetSellings();
        Task<ASelling> GetSelling(int sellingId);
        Task RemoveSelling(ASelling selling);
    }
}
