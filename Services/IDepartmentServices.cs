using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorUTS.Services
{
    public interface IDepartmentServices
    {
        Task<IEnumerable<Department>> GetAll();
        Task<Department> GetById(int id);
    }
}