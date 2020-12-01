
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
            this.lbDepartments = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tViewDepartments
            // 
            this.tViewDepartments.Location = new System.Drawing.Point(51, 90);
            this.tViewDepartments.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tViewDepartments.Name = "tViewDepartments";
            this.tViewDepartments.Size = new System.Drawing.Size(347, 303);
            this.tViewDepartments.TabIndex = 0;
            // 
            // tbDepartment
            // 
            this.tbDepartment.Location = new System.Drawing.Point(560, 144);
            this.tbDepartment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDepartment.Name = "tbDepartment";
            this.tbDepartment.Size = new System.Drawing.Size(160, 22);
            this.tbDepartment.TabIndex = 1;
            // 
            // lbParent
            // 
            this.lbParent.AutoSize = true;
            this.lbParent.Location = new System.Drawing.Point(451, 90);
            this.lbParent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbParent.Name = "lbParent";
            this.lbParent.Size = new System.Drawing.Size(50, 17);
            this.lbParent.TabIndex = 2;
            this.lbParent.Text = "Parent";
            // 
            // lbDepartment
            // 
            this.lbDepartment.AutoSize = true;
            this.lbDepartment.Location = new System.Drawing.Point(451, 145);
            this.lbDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDepartment.Name = "lbDepartment";
            this.lbDepartment.Size = new System.Drawing.Size(82, 17);
            this.lbDepartment.TabIndex = 3;
            this.lbDepartment.Text = "Department";
            // 
            // cBoxParent
            // 
            this.cBoxParent.FormattingEnabled = true;
            this.cBoxParent.Location = new System.Drawing.Point(560, 90);
            this.cBoxParent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBoxParent.Name = "cBoxParent";
            this.cBoxParent.Size = new System.Drawing.Size(160, 24);
            this.cBoxParent.TabIndex = 4;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(559, 202);
            this.btAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(161, 28);
            this.btAdd.TabIndex = 5;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // lbDepartments
            // 
            this.lbDepartments.AutoSize = true;
            this.lbDepartments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDepartments.Location = new System.Drawing.Point(46, 33);
            this.lbDepartments.Name = "lbDepartments";
            this.lbDepartments.Size = new System.Drawing.Size(134, 25);
            this.lbDepartments.TabIndex = 6;
            this.lbDepartments.Text = "Departments";
            this.lbDepartments.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(449, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Add Department";
            // 
            // FormDepartments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 428);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbDepartments);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.cBoxParent);
            this.Controls.Add(this.lbDepartment);
            this.Controls.Add(this.lbParent);
            this.Controls.Add(this.tbDepartment);
            this.Controls.Add(this.tViewDepartments);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label lbDepartments;
        private System.Windows.Forms.Label label1;
    }
}

