using LaZonaSV.ClienteBlazor.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaZonaSV.ClienteBlazor.Services
{
    public interface IProductosServices
    {
        Task<IEnumerable<Productos>> GetAll();
        Task<Productos> GetById(int id);
    }
}
