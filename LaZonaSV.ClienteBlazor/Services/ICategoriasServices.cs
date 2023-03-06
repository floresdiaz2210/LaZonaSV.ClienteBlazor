using LaZonaSV.ClienteBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaZonaSV.ClienteBlazor.Services
{
    public interface ICategoriasServices
    {
        Task<IEnumerable<Categorias>> GetAll();
        Task<Categorias> GetById(int id);
    }
}
