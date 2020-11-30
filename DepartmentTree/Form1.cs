using DepartmentTreeData;
using DepartmentTreeLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DepartmentTree
{
    public partial class FormDepartments : Form
    {
        DepartmentTreeLogic.DepartmentTreeLogic _departmentTreeLogic;
        List<Departments2> _departments;
        public FormDepartments()
        {            
            InitializeComponent();

            _departmentTreeLogic = new DepartmentTreeLogic.DepartmentTreeLogic();
            LoadDepartments();
            LoadParantDepartments();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Departments2 department = new Departments2();
            department.Name = tbDepartment.Text;
            Departments2 parentDepartment = _departments.FirstOrDefault(x => x.Name == cBoxParent.Text); //  Where(x => x.Name == "verkauf").Select(x => x)
            /// hier weiter
            if (parentDepartment.Id > 0)
            {
                department.Parent_Id = parentDepartment.Id  ;
            }
            else
            {
                department.Parent_Id = null;
            }
            

            _departmentTreeLogic.AddDepartment(department);

            var d = _departmentTreeLogic.Departments();


        }

        private void LoadDepartments()
        {
            _departments = _departmentTreeLogic.Departments();
        }

        private void LoadParantDepartments()
        {
            cBoxParent.Items.AddRange(_departments.Select(a => a.Name.ToString()).ToArray());
            
           
        }
    }
}
