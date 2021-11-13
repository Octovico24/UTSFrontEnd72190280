using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorUTS.Pages
{
    public partial class DetailDepartment
    {
        [Parameter]
        public string id {get;set;}

        [Inject]
        public Department Department {get;set;}
        public DepartmentServices DepartmentServices {get;set;}

        protected override async Task OnInitializedAsync(){
            id=id ?? "1";
            Department = await DepartmentService.GetById(int.Parse(id));
        }
    }
}