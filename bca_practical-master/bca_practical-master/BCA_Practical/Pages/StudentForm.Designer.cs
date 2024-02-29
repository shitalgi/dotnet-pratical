
namespace BCA_Practical.Pages
{
    partial class StudentForm
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
            this.btnLoadStudent = new System.Windows.Forms.Button();
            this.dgStudent = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FatherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRowEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadStudent
            // 
            this.btnLoadStudent.Location = new System.Drawing.Point(247, 42);
            this.btnLoadStudent.Name = "btnLoadStudent";
            this.btnLoadStudent.Size = new System.Drawing.Size(101, 30);
            this.btnLoadStudent.TabIndex = 0;
            this.btnLoadStudent.Text = "Load Student";
            this.btnLoadStudent.UseVisualStyleBackColor = true;
            this.btnLoadStudent.Click += new System.EventHandler(this.btnLoadStudent_Click);
            // 
            // dgStudent
            // 
            this.dgStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.MiddleName,
            this.LastName,
            this.Gender,
            this.FatherName,
            this.btnRowEdit,
            this.Delete});
            this.dgStudent.Location = new System.Drawing.Point(12, 78);
            this.dgStudent.Name = "dgStudent";
            this.dgStudent.Size = new System.Drawing.Size(755, 288);
            this.dgStudent.TabIndex = 1;
            this.dgStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgStudent_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(17, 48);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(127, 20);
            this.txtFirstName.TabIndex = 3;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(150, 42);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(91, 30);
            this.btnAddStudent.TabIndex = 4;
            this.btnAddStudent.Text = "NEW";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.Name = "FirstName";
            // 
            // MiddleName
            // 
            this.MiddleName.DataPropertyName = "MiddleName";
            this.MiddleName.HeaderText = "MiddleName";
            this.MiddleName.Name = "MiddleName";
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "LastName";
            this.LastName.Name = "LastName";
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            // 
            // FatherName
            // 
            this.FatherName.DataPropertyName = "FatherName";
            this.FatherName.HeaderText = "FatherName";
            this.FatherName.Name = "FatherName";
            // 
            // btnRowEdit
            // 
            this.btnRowEdit.DataPropertyName = "btnRoEdit";
            this.btnRowEdit.HeaderText = "EDIT";
            this.btnRowEdit.Name = "btnRowEdit";
            this.btnRowEdit.ReadOnly = true;
            this.btnRowEdit.Text = "edit_student";
            this.btnRowEdit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 378);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgStudent);
            this.Controls.Add(this.btnLoadStudent);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadStudent;
        private System.Windows.Forms.DataGridView dgStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn FatherName;
        private System.Windows.Forms.DataGridViewButtonColumn btnRowEdit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}