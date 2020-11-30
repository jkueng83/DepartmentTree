using DepartmentTreeData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentTreeLogic
{
    public class DepartmentTreeLogic
    {
        DepartmentTreeEntities _departmentTreeEntities;

        public DepartmentTreeLogic()
        {
            _departmentTreeEntities = new DepartmentTreeEntities();
        }

        public void AddDepartment(Departments2 department)
        {
            _departmentTreeEntities.Departments2.Add(department);
            _departmentTreeEntities.SaveChanges();
        }

        public List<Departments2> Departments()
        {
            List<Departments2> departments = new List<Departments2>();

            departments = _departmentTreeEntities.Departments2.Select(d => d).ToList();


            return departments;
        }



    }
}
