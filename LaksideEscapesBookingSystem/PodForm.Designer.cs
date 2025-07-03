
namespace LaksideEscapesBookingSystem
{
    partial class PodForm
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
            this.podIDLBL = new System.Windows.Forms.Label();
            this.baseCostPerNightLBL = new System.Windows.Forms.Label();
            this.capacityLBL = new System.Windows.Forms.Label();
            this.podTypeLBL = new System.Windows.Forms.Label();
            this.BaseCostPerNightTB = new System.Windows.Forms.TextBox();
            this.podIDTB = new System.Windows.Forms.TextBox();
            this.podTypeTB = new System.Windows.Forms.TextBox();
            this.podCapacityTB = new System.Windows.Forms.TextBox();
            this.addBTN = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.podIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.podTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baseCostPerNightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.podBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pods = new LaksideEscapesBookingSystem.Pods();
            this.deleteComboBox = new System.Windows.Forms.ComboBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.podTypeComboBox = new System.Windows.Forms.ComboBox();
            this.podTableAdapter = new LaksideEscapesBookingSystem.PodsTableAdapters.PodTableAdapter();
            this.updateBTN = new System.Windows.Forms.Button();
            this.podManagerLBL = new System.Windows.Forms.Label();
            this.deletePodLBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.podBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pods)).BeginInit();
            this.SuspendLayout();
            // 
            // podIDLBL
            // 
            this.podIDLBL.AutoSize = true;
            this.podIDLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.podIDLBL.Location = new System.Drawing.Point(19, 88);
            this.podIDLBL.Name = "podIDLBL";
            this.podIDLBL.Size = new System.Drawing.Size(66, 24);
            this.podIDLBL.TabIndex = 0;
            this.podIDLBL.Text = "Pod ID";
            this.podIDLBL.Visible = false;
            // 
            // baseCostPerNightLBL
            // 
            this.baseCostPerNightLBL.AutoSize = true;
            this.baseCostPerNightLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseCostPerNightLBL.Location = new System.Drawing.Point(18, 204);
            this.baseCostPerNightLBL.Name = "baseCostPerNightLBL";
            this.baseCostPerNightLBL.Size = new System.Drawing.Size(130, 24);
            this.baseCostPerNightLBL.TabIndex = 1;
            this.baseCostPerNightLBL.Text = "Cost Per Night";
            // 
            // capacityLBL
            // 
            this.capacityLBL.AutoSize = true;
            this.capacityLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capacityLBL.Location = new System.Drawing.Point(18, 142);
            this.capacityLBL.Name = "capacityLBL";
            this.capacityLBL.Size = new System.Drawing.Size(120, 24);
            this.capacityLBL.TabIndex = 2;
            this.capacityLBL.Text = "Pod Capacity";
            // 
            // podTypeLBL
            // 
            this.podTypeLBL.AutoSize = true;
            this.podTypeLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.podTypeLBL.Location = new System.Drawing.Point(18, 87);
            this.podTypeLBL.Name = "podTypeLBL";
            this.podTypeLBL.Size = new System.Drawing.Size(92, 24);
            this.podTypeLBL.TabIndex = 3;
            this.podTypeLBL.Text = "Pod Type";
            // 
            // BaseCostPerNightTB
            // 
            this.BaseCostPerNightTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaseCostPerNightTB.Location = new System.Drawing.Point(154, 204);
            this.BaseCostPerNightTB.Name = "BaseCostPerNightTB";
            this.BaseCostPerNightTB.Size = new System.Drawing.Size(161, 29);
            this.BaseCostPerNightTB.TabIndex = 4;
            // 
            // podIDTB
            // 
            this.podIDTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.podIDTB.Location = new System.Drawing.Point(154, 88);
            this.podIDTB.Name = "podIDTB";
            this.podIDTB.Size = new System.Drawing.Size(161, 29);
            this.podIDTB.TabIndex = 5;
            this.podIDTB.Visible = false;
            // 
            // podTypeTB
            // 
            this.podTypeTB.Location = new System.Drawing.Point(640, 407);
            this.podTypeTB.Name = "podTypeTB";
            this.podTypeTB.Size = new System.Drawing.Size(100, 20);
            this.podTypeTB.TabIndex = 6;
            this.podTypeTB.Visible = false;
            // 
            // podCapacityTB
            // 
            this.podCapacityTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.podCapacityTB.Location = new System.Drawing.Point(154, 142);
            this.podCapacityTB.Name = "podCapacityTB";
            this.podCapacityTB.Size = new System.Drawing.Size(161, 29);
            this.podCapacityTB.TabIndex = 7;
            // 
            // addBTN
            // 
            this.addBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBTN.Location = new System.Drawing.Point(144, 254);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(77, 29);
            this.addBTN.TabIndex = 8;
            this.addBTN.Text = "ADD";
            this.addBTN.UseVisualStyleBackColor = true;
            this.addBTN.Click += new System.EventHandler(this.addBTN_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.podIDDataGridViewTextBoxColumn,
            this.podTypeDataGridViewTextBoxColumn,
            this.capacityDataGridViewTextBoxColumn,
            this.baseCostPerNightDataGridViewTextBoxColumn,
            this.Update});
            this.dataGridView1.DataSource = this.podBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(154, 289);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(549, 312);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // podIDDataGridViewTextBoxColumn
            // 
            this.podIDDataGridViewTextBoxColumn.DataPropertyName = "PodID";
            this.podIDDataGridViewTextBoxColumn.HeaderText = "PodID";
            this.podIDDataGridViewTextBoxColumn.Name = "podIDDataGridViewTextBoxColumn";
            this.podIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // podTypeDataGridViewTextBoxColumn
            // 
            this.podTypeDataGridViewTextBoxColumn.DataPropertyName = "PodType";
            this.podTypeDataGridViewTextBoxColumn.HeaderText = "PodType";
            this.podTypeDataGridViewTextBoxColumn.Name = "podTypeDataGridViewTextBoxColumn";
            this.podTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // capacityDataGridViewTextBoxColumn
            // 
            this.capacityDataGridViewTextBoxColumn.DataPropertyName = "Capacity";
            this.capacityDataGridViewTextBoxColumn.HeaderText = "Capacity";
            this.capacityDataGridViewTextBoxColumn.Name = "capacityDataGridViewTextBoxColumn";
            this.capacityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // baseCostPerNightDataGridViewTextBoxColumn
            // 
            this.baseCostPerNightDataGridViewTextBoxColumn.DataPropertyName = "BaseCostPerNight";
            this.baseCostPerNightDataGridViewTextBoxColumn.HeaderText = "BaseCostPerNight";
            this.baseCostPerNightDataGridViewTextBoxColumn.Name = "baseCostPerNightDataGridViewTextBoxColumn";
            this.baseCostPerNightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Update
            // 
            this.Update.HeaderText = "Update";
            this.Update.Name = "Update";
            this.Update.ReadOnly = true;
            // 
            // podBindingSource
            // 
            this.podBindingSource.DataMember = "Pod";
            this.podBindingSource.DataSource = this.pods;
            // 
            // pods
            // 
            this.pods.DataSetName = "Pods";
            this.pods.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deleteComboBox
            // 
            this.deleteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deleteComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteComboBox.FormattingEnabled = true;
            this.deleteComboBox.Location = new System.Drawing.Point(400, 116);
            this.deleteComboBox.Name = "deleteComboBox";
            this.deleteComboBox.Size = new System.Drawing.Size(161, 32);
            this.deleteComboBox.TabIndex = 10;
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(434, 154);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(92, 29);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // podTypeComboBox
            // 
            this.podTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.podTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.podTypeComboBox.FormattingEnabled = true;
            this.podTypeComboBox.Items.AddRange(new object[] {
            "Standard",
            "Luxury"});
            this.podTypeComboBox.Location = new System.Drawing.Point(154, 87);
            this.podTypeComboBox.Name = "podTypeComboBox";
            this.podTypeComboBox.Size = new System.Drawing.Size(161, 32);
            this.podTypeComboBox.TabIndex = 12;
            // 
            // podTableAdapter
            // 
            this.podTableAdapter.ClearBeforeFill = true;
            // 
            // updateBTN
            // 
            this.updateBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBTN.Location = new System.Drawing.Point(227, 254);
            this.updateBTN.Name = "updateBTN";
            this.updateBTN.Size = new System.Drawing.Size(94, 29);
            this.updateBTN.TabIndex = 13;
            this.updateBTN.Text = "UPDATE";
            this.updateBTN.UseVisualStyleBackColor = true;
            this.updateBTN.Click += new System.EventHandler(this.updateBTN_Click);
            // 
            // podManagerLBL
            // 
            this.podManagerLBL.AutoSize = true;
            this.podManagerLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.podManagerLBL.Location = new System.Drawing.Point(12, 9);
            this.podManagerLBL.Name = "podManagerLBL";
            this.podManagerLBL.Size = new System.Drawing.Size(314, 55);
            this.podManagerLBL.TabIndex = 14;
            this.podManagerLBL.Text = "Pod Manager";
            // 
            // deletePodLBL
            // 
            this.deletePodLBL.AutoSize = true;
            this.deletePodLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePodLBL.Location = new System.Drawing.Point(384, 89);
            this.deletePodLBL.Name = "deletePodLBL";
            this.deletePodLBL.Size = new System.Drawing.Size(195, 24);
            this.deletePodLBL.TabIndex = 15;
            this.deletePodLBL.Text = "Select a Pod to Delete";
            // 
            // PodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 641);
            this.Controls.Add(this.deletePodLBL);
            this.Controls.Add(this.podManagerLBL);
            this.Controls.Add(this.updateBTN);
            this.Controls.Add(this.podTypeComboBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.deleteComboBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addBTN);
            this.Controls.Add(this.podCapacityTB);
            this.Controls.Add(this.podTypeTB);
            this.Controls.Add(this.podIDTB);
            this.Controls.Add(this.BaseCostPerNightTB);
            this.Controls.Add(this.podTypeLBL);
            this.Controls.Add(this.capacityLBL);
            this.Controls.Add(this.baseCostPerNightLBL);
            this.Controls.Add(this.podIDLBL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PodForm";
            this.Text = "PodForm";
            this.Load += new System.EventHandler(this.PodForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.podBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pods)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label podIDLBL;
        private System.Windows.Forms.Label baseCostPerNightLBL;
        private System.Windows.Forms.Label capacityLBL;
        private System.Windows.Forms.Label podTypeLBL;
        private System.Windows.Forms.TextBox BaseCostPerNightTB;
        private System.Windows.Forms.TextBox podIDTB;
        private System.Windows.Forms.TextBox podTypeTB;
        private System.Windows.Forms.TextBox podCapacityTB;
        private System.Windows.Forms.Button addBTN;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Pods pods;
        private System.Windows.Forms.BindingSource podBindingSource;
        private PodsTableAdapters.PodTableAdapter podTableAdapter;
        private System.Windows.Forms.ComboBox deleteComboBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ComboBox podTypeComboBox;
        private System.Windows.Forms.Button updateBTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn podIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn podTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baseCostPerNightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.Label podManagerLBL;
        private System.Windows.Forms.Label deletePodLBL;
    }
}