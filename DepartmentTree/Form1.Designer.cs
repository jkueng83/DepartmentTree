
namespace DepartmentTree
{
    partial class FormDepartments
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tViewDepartments = new System.Windows.Forms.TreeView();
            this.tbDepartment = new System.Windows.Forms.TextBox();
            this.lbParent = new System.Windows.Forms.Label();
            this.lbDepartment = new System.Windows.Forms.Label();
            this.cBoxParent = new System.Windows.Forms.ComboBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tViewDepartments
            // 
            this.tViewDepartments.Location = new System.Drawing.Point(56, 67);
            this.tViewDepartments.Name = "tViewDepartments";
            this.tViewDepartments.Size = new System.Drawing.Size(261, 247);
            this.tViewDepartments.TabIndex = 0;
            // 
            // tbDepartment
            // 
            this.tbDepartment.Location = new System.Drawing.Point(487, 122);
            this.tbDepartment.Name = "tbDepartment";
            this.tbDepartment.Size = new System.Drawing.Size(121, 20);
            this.tbDepartment.TabIndex = 1;
            // 
            // lbParent
            // 
            this.lbParent.AutoSize = true;
            this.lbParent.Location = new System.Drawing.Point(356, 67);
            this.lbParent.Name = "lbParent";
            this.lbParent.Size = new System.Drawing.Size(38, 13);
            this.lbParent.TabIndex = 2;
            this.lbParent.Text = "Parent";
            // 
            // lbDepartment
            // 
            this.lbDepartment.AutoSize = true;
            this.lbDepartment.Location = new System.Drawing.Point(356, 125);
            this.lbDepartment.Name = "lbDepartment";
            this.lbDepartment.Size = new System.Drawing.Size(62, 13);
            this.lbDepartment.TabIndex = 3;
            this.lbDepartment.Text = "Department";
            // 
            // cBoxParent
            // 
            this.cBoxParent.FormattingEnabled = true;
            this.cBoxParent.Location = new System.Drawing.Point(487, 64);
            this.cBoxParent.Name = "cBoxParent";
            this.cBoxParent.Size = new System.Drawing.Size(121, 21);
            this.cBoxParent.TabIndex = 4;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(487, 173);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(121, 23);
            this.btAdd.TabIndex = 5;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(487, 252);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // FormDepartments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.cBoxParent);
            this.Controls.Add(this.lbDepartment);
            this.Controls.Add(this.lbParent);
            this.Controls.Add(this.tbDepartment);
            this.Controls.Add(this.tViewDepartments);
            this.Name = "FormDepartments";
            this.Text = "Departments";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tViewDepartments;
        private System.Windows.Forms.TextBox tbDepartment;
        private System.Windows.Forms.Label lbParent;
        private System.Windows.Forms.Label lbDepartment;
        private System.Windows.Forms.ComboBox cBoxParent;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

