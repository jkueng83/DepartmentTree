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
            UpdateWindow();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Departments2 AddDepartment = new Departments2();
            AddDepartment.Name = tbDepartment.Text;

            Departments2 parentDepartment = _departments.FirstOrDefault(x => x.Name == cBoxParent.Text); //  Where(x => x.Name == "verkauf").Select(x => x)
            
            if (parentDepartment.Id > 0)
            {
                AddDepartment.Parent_Id = parentDepartment.Id  ;
            }
            else
            {
                AddDepartment.Parent_Id = null;
            }          

            _departmentTreeLogic.AddDepartment(AddDepartment);

            UpdateWindow();
        }

        private void UpdateWindow()
        {
            LoadDepartments();
            LoadParantDepartments();
            LoadDepertmentTreeView();
        }

        private void LoadDepartments()
        {
            _departments = _departmentTreeLogic.Departments();
        }

        private void LoadParantDepartments()
        {
            cBoxParent.Items.Clear();
            cBoxParent.Items.AddRange(_departments.OrderBy(x => x.Name).Select(a => a.Name.ToString()).ToArray());
        }

        private void LoadDepertmentTreeView()
        {
            tViewDepartments.Nodes.Clear();
            tViewDepartments.BeginUpdate();

            var departmentsWithoutParent = _departments.Select(x => x).Where(x => x.Parent_Id == 0 || x.Parent_Id == null).OrderBy(x => x.Name);
            
            foreach (var department in departmentsWithoutParent)
            {
                TreeNode node = new TreeNode(department.Name);
                tViewDepartments.Nodes.Add(node);
                AddChildDepartment(department.Id, ref node);
            }

            tViewDepartments.EndUpdate();
        }

        private void AddChildDepartment(int parentId , ref TreeNode treeNode)
        {
            var selectedDepartments = _departments.Select(x => x).Where(x => x.Parent_Id == parentId).OrderBy(x => x.Name);

            foreach (var department in selectedDepartments)
            {
                TreeNode node = new TreeNode(department.Name);
                treeNode.Nodes.Add(node);
                AddChildDepartment(department.Id, ref node);
            }
        }
    }
}
