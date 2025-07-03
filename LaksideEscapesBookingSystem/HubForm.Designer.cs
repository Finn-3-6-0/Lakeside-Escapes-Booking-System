
namespace LaksideEscapesBookingSystem
{
    partial class HubForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.GetMostPopularPodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetMostPopPods = new LaksideEscapesBookingSystem.DataSetMostPopPods();
            this.GetMostPopularCoursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetMostPopCourses = new LaksideEscapesBookingSystem.DataSetMostPopCourses();
            this.CalculateMonthlyRevenue_2024BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetMR = new LaksideEscapesBookingSystem.DataSetMR();
            this.BookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetMostPopularPod = new LaksideEscapesBookingSystem.MostPopularPod();
            this.BookingTableAdapter = new LaksideEscapesBookingSystem.MostPopularPodTableAdapters.BookingTableAdapter();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.GetMostPopularPodsTableAdapter = new LaksideEscapesBookingSystem.DataSetMostPopPodsTableAdapters.GetMostPopularPodsTableAdapter();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.GetMostPopularCoursesTableAdapter = new LaksideEscapesBookingSystem.DataSetMostPopCoursesTableAdapters.GetMostPopularCoursesTableAdapter();
            this.monthlyRevenueViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CalculateMonthlyRevenue_2024TableAdapter = new LaksideEscapesBookingSystem.DataSetMRTableAdapters.CalculateMonthlyRevenue_2024TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.GetMostPopularPodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetMostPopPods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetMostPopularCoursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetMostPopCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CalculateMonthlyRevenue_2024BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetMR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetMostPopularPod)).BeginInit();
            this.SuspendLayout();
            // 
            // GetMostPopularPodsBindingSource
            // 
            this.GetMostPopularPodsBindingSource.DataMember = "GetMostPopularPods";
            this.GetMostPopularPodsBindingSource.DataSource = this.DataSetMostPopPods;
            // 
            // DataSetMostPopPods
            // 
            this.DataSetMostPopPods.DataSetName = "DataSetMostPopPods";
            this.DataSetMostPopPods.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GetMostPopularCoursesBindingSource
            // 
            this.GetMostPopularCoursesBindingSource.DataMember = "GetMostPopularCourses";
            this.GetMostPopularCoursesBindingSource.DataSource = this.DataSetMostPopCourses;
            // 
            // DataSetMostPopCourses
            // 
            this.DataSetMostPopCourses.DataSetName = "DataSetMostPopCourses";
            this.DataSetMostPopCourses.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CalculateMonthlyRevenue_2024BindingSource
            // 
            this.CalculateMonthlyRevenue_2024BindingSource.DataMember = "CalculateMonthlyRevenue_2024";
            this.CalculateMonthlyRevenue_2024BindingSource.DataSource = this.DataSetMR;
            // 
            // DataSetMR
            // 
            this.DataSetMR.DataSetName = "DataSetMR";
            this.DataSetMR.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BookingBindingSource
            // 
            this.BookingBindingSource.DataMember = "Booking";
            this.BookingBindingSource.DataSource = this.DataSetMostPopularPod;
            // 
            // DataSetMostPopularPod
            // 
            this.DataSetMostPopularPod.DataSetName = "MostPopularPod";
            this.DataSetMostPopularPod.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BookingTableAdapter
            // 
            this.BookingTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer2
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.GetMostPopularPodsBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "LaksideEscapesBookingSystem.Report2.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(12, 12);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(464, 295);
            this.reportViewer2.TabIndex = 1;
            // 
            // GetMostPopularPodsTableAdapter
            // 
            this.GetMostPopularPodsTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer3
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.GetMostPopularCoursesBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "LaksideEscapesBookingSystem.Report3.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(482, 12);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(470, 295);
            this.reportViewer3.TabIndex = 2;
            // 
            // GetMostPopularCoursesTableAdapter
            // 
            this.GetMostPopularCoursesTableAdapter.ClearBeforeFill = true;
            // 
            // monthlyRevenueViewer
            // 
            reportDataSource3.Name = "DataSetMRev";
            reportDataSource3.Value = this.CalculateMonthlyRevenue_2024BindingSource;
            this.monthlyRevenueViewer.LocalReport.DataSources.Add(reportDataSource3);
            this.monthlyRevenueViewer.LocalReport.ReportEmbeddedResource = "LaksideEscapesBookingSystem.monthlyRevenueReport.rdlc";
            this.monthlyRevenueViewer.Location = new System.Drawing.Point(12, 313);
            this.monthlyRevenueViewer.Name = "monthlyRevenueViewer";
            this.monthlyRevenueViewer.ServerReport.BearerToken = null;
            this.monthlyRevenueViewer.Size = new System.Drawing.Size(940, 299);
            this.monthlyRevenueViewer.TabIndex = 3;
            // 
            // CalculateMonthlyRevenue_2024TableAdapter
            // 
            this.CalculateMonthlyRevenue_2024TableAdapter.ClearBeforeFill = true;
            // 
            // HubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 641);
            this.Controls.Add(this.monthlyRevenueViewer);
            this.Controls.Add(this.reportViewer3);
            this.Controls.Add(this.reportViewer2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HubForm";
            this.Text = "HubForm";
            this.Load += new System.EventHandler(this.HubForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GetMostPopularPodsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetMostPopPods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetMostPopularCoursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetMostPopCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CalculateMonthlyRevenue_2024BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetMR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetMostPopularPod)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource BookingBindingSource;
        private MostPopularPod DataSetMostPopularPod;
        private MostPopularPodTableAdapters.BookingTableAdapter BookingTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource GetMostPopularPodsBindingSource;
        private DataSetMostPopPods DataSetMostPopPods;
        private DataSetMostPopPodsTableAdapters.GetMostPopularPodsTableAdapter GetMostPopularPodsTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.BindingSource GetMostPopularCoursesBindingSource;
        private DataSetMostPopCourses DataSetMostPopCourses;
        private DataSetMostPopCoursesTableAdapters.GetMostPopularCoursesTableAdapter GetMostPopularCoursesTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer monthlyRevenueViewer;
        private DataSetMR DataSetMR;
        private DataSetMRTableAdapters.CalculateMonthlyRevenue_2024TableAdapter CalculateMonthlyRevenue_2024TableAdapter;
        private System.Windows.Forms.BindingSource CalculateMonthlyRevenue_2024BindingSource;
    }
}