using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorUTS.Services
{
    public class DepartmentServices : IDepartmentServices
    {
        private HttpClient _httpClient;
        public DepartmentServices(HttpClient httpClient){
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<Department>> GetAll(){
            var results = await _httpClient.GetFromJsonAsync<IEnumerable<Department>>("api/Departments");
            return results;
        }
        public Task<Department> GetById(int id){
            var results = await _httpClient.GetFromJsonAsync<Department>($"api/Departments/{id}");
            return results;
        }
    }
}