
namespace LaksideEscapesBookingSystem
{
    partial class CourseForm
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
            this.components = new System.ComponentModel.Container();
            this.courseIDLBL = new System.Windows.Forms.Label();
            this.courseCostPerPersonLBL = new System.Windows.Forms.Label();
            this.courseNameLBL = new System.Windows.Forms.Label();
            this.corseCostPerPersonTB = new System.Windows.Forms.TextBox();
            this.courseIDTB = new System.Windows.Forms.TextBox();
            this.courseNameTB = new System.Windows.Forms.TextBox();
            this.addBTN = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.courseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseCostPerPersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courses = new LaksideEscapesBookingSystem.Courses();
            this.courseTableAdapter = new LaksideEscapesBookingSystem.CoursesTableAdapters.CourseTableAdapter();
            this.deleteBTN = new System.Windows.Forms.Button();
            this.deleteComboBox = new System.Windows.Forms.ComboBox();
            this.updateBTN = new System.Windows.Forms.Button();
            this.courseManagerLBL = new System.Windows.Forms.Label();
            this.deleteCourseLBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courses)).BeginInit();
            this.SuspendLayout();
            // 
            // courseIDLBL
            // 
            this.courseIDLBL.AutoSize = true;
            this.courseIDLBL.Location = new System.Drawing.Point(675, 541);
            this.courseIDLBL.Name = "courseIDLBL";
            this.courseIDLBL.Size = new System.Drawing.Size(51, 13);
            this.courseIDLBL.TabIndex = 0;
            this.courseIDLBL.Text = "CourseID";
            this.courseIDLBL.Visible = false;
            // 
            // courseCostPerPersonLBL
            // 
            this.courseCostPerPersonLBL.AutoSize = true;
            this.courseCostPerPersonLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseCostPerPersonLBL.Location = new System.Drawing.Point(18, 134);
            this.courseCostPerPersonLBL.Name = "courseCostPerPersonLBL";
            this.courseCostPerPersonLBL.Size = new System.Drawing.Size(219, 24);
            this.courseCostPerPersonLBL.TabIndex = 1;
            this.courseCostPerPersonLBL.Text = "Course Cost (PerPerson)";
            // 
            // courseNameLBL
            // 
            this.courseNameLBL.AutoSize = true;
            this.courseNameLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseNameLBL.Location = new System.Drawing.Point(18, 86);
            this.courseNameLBL.Name = "courseNameLBL";
            this.courseNameLBL.Size = new System.Drawing.Size(127, 24);
            this.courseNameLBL.TabIndex = 2;
            this.courseNameLBL.Text = "Course Name";
            // 
            // corseCostPerPersonTB
            // 
            this.corseCostPerPersonTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.corseCostPerPersonTB.Location = new System.Drawing.Point(247, 134);
            this.corseCostPerPersonTB.Name = "corseCostPerPersonTB";
            this.corseCostPerPersonTB.Size = new System.Drawing.Size(149, 29);
            this.corseCostPerPersonTB.TabIndex = 3;
            // 
            // courseIDTB
            // 
            this.courseIDTB.Location = new System.Drawing.Point(757, 541);
            this.courseIDTB.Name = "courseIDTB";
            this.courseIDTB.Size = new System.Drawing.Size(100, 20);
            this.courseIDTB.TabIndex = 4;
            this.courseIDTB.Visible = false;
            // 
            // courseNameTB
            // 
            this.courseNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseNameTB.Location = new System.Drawing.Point(247, 86);
            this.courseNameTB.Name = "courseNameTB";
            this.courseNameTB.Size = new System.Drawing.Size(149, 29);
            this.courseNameTB.TabIndex = 5;
            // 
            // addBTN
            // 
            this.addBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBTN.Location = new System.Drawing.Point(225, 186);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(83, 35);
            this.addBTN.TabIndex = 6;
            this.addBTN.Text = "ADD";
            this.addBTN.UseVisualStyleBackColor = true;
            this.addBTN.Click += new System.EventHandler(this.addBTN_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseIDDataGridViewTextBoxColumn,
            this.courseNameDataGridViewTextBoxColumn,
            this.courseCostPerPersonDataGridViewTextBoxColumn,
            this.Update});
            this.dataGridView1.DataSource = this.courseBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(217, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(458, 303);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // courseIDDataGridViewTextBoxColumn
            // 
            this.courseIDDataGridViewTextBoxColumn.DataPropertyName = "CourseID";
            this.courseIDDataGridViewTextBoxColumn.HeaderText = "CourseID";
            this.courseIDDataGridViewTextBoxColumn.Name = "courseIDDataGridViewTextBoxColumn";
            this.courseIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseNameDataGridViewTextBoxColumn
            // 
            this.courseNameDataGridViewTextBoxColumn.DataPropertyName = "CourseName";
            this.courseNameDataGridViewTextBoxColumn.HeaderText = "CourseName";
            this.courseNameDataGridViewTextBoxColumn.Name = "courseNameDataGridViewTextBoxColumn";
            this.courseNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseCostPerPersonDataGridViewTextBoxColumn
            // 
            this.courseCostPerPersonDataGridViewTextBoxColumn.DataPropertyName = "CourseCostPerPerson";
            this.courseCostPerPersonDataGridViewTextBoxColumn.HeaderText = "CourseCostPerPerson";
            this.courseCostPerPersonDataGridViewTextBoxColumn.Name = "courseCostPerPersonDataGridViewTextBoxColumn";
            this.courseCostPerPersonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Update
            // 
            this.Update.HeaderText = "Update";
            this.Update.Name = "Update";
            this.Update.ReadOnly = true;
            this.Update.Text = "Update";
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.courses;
            // 
            // courses
            // 
            this.courses.DataSetName = "Courses";
            this.courses.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // deleteBTN
            // 
            this.deleteBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBTN.Location = new System.Drawing.Point(517, 185);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(93, 36);
            this.deleteBTN.TabIndex = 8;
            this.deleteBTN.Text = "DELETE";
            this.deleteBTN.UseVisualStyleBackColor = true;
            this.deleteBTN.Click += new System.EventHandler(this.deleteBTN_Click);
            // 
            // deleteComboBox
            // 
            this.deleteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deleteComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteComboBox.FormattingEnabled = true;
            this.deleteComboBox.Location = new System.Drawing.Point(480, 134);
            this.deleteComboBox.Name = "deleteComboBox";
            this.deleteComboBox.Size = new System.Drawing.Size(167, 32);
            this.deleteComboBox.TabIndex = 9;
            // 
            // updateBTN
            // 
            this.updateBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBTN.Location = new System.Drawing.Point(314, 188);
            this.updateBTN.Name = "updateBTN";
            this.updateBTN.Size = new System.Drawing.Size(97, 33);
            this.updateBTN.TabIndex = 10;
            this.updateBTN.Text = "UPDATE";
            this.updateBTN.UseVisualStyleBackColor = true;
            this.updateBTN.Click += new System.EventHandler(this.updateBTN_Click);
            // 
            // courseManagerLBL
            // 
            this.courseManagerLBL.AutoSize = true;
            this.courseManagerLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseManagerLBL.Location = new System.Drawing.Point(12, 9);
            this.courseManagerLBL.Name = "courseManagerLBL";
            this.courseManagerLBL.Size = new System.Drawing.Size(384, 55);
            this.courseManagerLBL.TabIndex = 11;
            this.courseManagerLBL.Text = "Course Manager";
            // 
            // deleteCourseLBL
            // 
            this.deleteCourseLBL.AutoSize = true;
            this.deleteCourseLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCourseLBL.Location = new System.Drawing.Point(453, 91);
            this.deleteCourseLBL.Name = "deleteCourseLBL";
            this.deleteCourseLBL.Size = new System.Drawing.Size(222, 24);
            this.deleteCourseLBL.TabIndex = 12;
            this.deleteCourseLBL.Text = "Select a Course to Delete";
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 641);
            this.Controls.Add(this.deleteCourseLBL);
            this.Controls.Add(this.courseManagerLBL);
            this.Controls.Add(this.updateBTN);
            this.Controls.Add(this.deleteComboBox);
            this.Controls.Add(this.deleteBTN);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addBTN);
            this.Controls.Add(this.courseNameTB);
            this.Controls.Add(this.courseIDTB);
            this.Controls.Add(this.corseCostPerPersonTB);
            this.Controls.Add(this.courseNameLBL);
            this.Controls.Add(this.courseCostPerPersonLBL);
            this.Controls.Add(this.courseIDLBL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CourseForm";
            this.Text = "CourseForm";
            this.Load += new System.EventHandler(this.CourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label courseIDLBL;
        private System.Windows.Forms.Label courseCostPerPersonLBL;
        private System.Windows.Forms.Label courseNameLBL;
        private System.Windows.Forms.TextBox corseCostPerPersonTB;
        private System.Windows.Forms.TextBox courseIDTB;
        private System.Windows.Forms.TextBox courseNameTB;
        private System.Windows.Forms.Button addBTN;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Courses courses;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private CoursesTableAdapters.CourseTableAdapter courseTableAdapter;
        private System.Windows.Forms.Button deleteBTN;
        private System.Windows.Forms.ComboBox deleteComboBox;
        private System.Windows.Forms.Button updateBTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseCostPerPersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.Label courseManagerLBL;
        private System.Windows.Forms.Label deleteCourseLBL;
    }
}