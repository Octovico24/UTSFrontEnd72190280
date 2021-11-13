using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorUTS.Pages
{
    public class DepartmentPage
    {
        public List<Department> Departments {get; set;} = new List<Department>();
        
        [Inject]
        public IDepartmentServices DepartmentServices {get; set;}
        protected override async Task OnInitializedAsync(){
            Departments = (await DepartmentService.getAll()).ToList();
        }
    }
}