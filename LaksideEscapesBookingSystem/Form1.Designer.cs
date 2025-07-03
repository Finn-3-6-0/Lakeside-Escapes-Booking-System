
namespace LaksideEscapesBookingSystem
{
    partial class BookingMenu
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
            this.AddBookingBTN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bookingDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.guestIDTB = new System.Windows.Forms.TextBox();
            this.noOfOccupantsTB = new System.Windows.Forms.TextBox();
            this.courseIDTB = new System.Windows.Forms.TextBox();
            this.podIDTB = new System.Windows.Forms.TextBox();
            this.noOfDaysComboBox = new System.Windows.Forms.ComboBox();
            this.viewByBookingIDTB = new System.Windows.Forms.TextBox();
            this.bookingIDComboBox = new System.Windows.Forms.ComboBox();
            this.podIDComboBox = new System.Windows.Forms.ComboBox();
            this.courseIDComboBox = new System.Windows.Forms.ComboBox();
            this.dateOfStayLBL = new System.Windows.Forms.Label();
            this.lenghtOfStayLBL = new System.Windows.Forms.Label();
            this.guestStayingLBL = new System.Windows.Forms.Label();
            this.podIDLBL = new System.Windows.Forms.Label();
            this.courseIDLBL = new System.Windows.Forms.Label();
            this.noOfOccupantsLBL = new System.Windows.Forms.Label();
            this.guestIDComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bookingIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.podIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfOccupantsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkInDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkOutDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depositAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountPercentageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateBookedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bookingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.updatedBookingTable = new LaksideEscapesBookingSystem.updatedBookingTable();
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingTable = new LaksideEscapesBookingSystem.BookingTable();
            this.bookingTableAdapter = new LaksideEscapesBookingSystem.BookingTableTableAdapters.BookingTableAdapter();
            this.bookingIDsDeleteComboBox = new System.Windows.Forms.ComboBox();
            this.previewBookinglbl = new System.Windows.Forms.Label();
            this.previewBookinglbl2 = new System.Windows.Forms.Label();
            this.previewBookinglbl3 = new System.Windows.Forms.Label();
            this.updateBTN = new System.Windows.Forms.Button();
            this.bookingBuilderlbl = new System.Windows.Forms.Label();
            this.bookingTableAdapter1 = new LaksideEscapesBookingSystem.updatedBookingTableTableAdapters.BookingTableAdapter();
            this.bookingManagerLBL = new System.Windows.Forms.Label();
            this.deleteBookingLBL = new System.Windows.Forms.Label();
            this.depositLBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updatedBookingTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingTable)).BeginInit();
            this.SuspendLayout();
            // 
            // AddBookingBTN
            // 
            this.AddBookingBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBookingBTN.Location = new System.Drawing.Point(214, 298);
            this.AddBookingBTN.Name = "AddBookingBTN";
            this.AddBookingBTN.Size = new System.Drawing.Size(79, 34);
            this.AddBookingBTN.TabIndex = 0;
            this.AddBookingBTN.Text = "ADD";
            this.AddBookingBTN.UseVisualStyleBackColor = true;
            this.AddBookingBTN.Click += new System.EventHandler(this.AddBookingBTN_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(745, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "PAY DEPOSIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(770, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "DELETE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bookingDateTimePicker
            // 
            this.bookingDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingDateTimePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bookingDateTimePicker.Location = new System.Drawing.Point(214, 74);
            this.bookingDateTimePicker.MaximumSize = new System.Drawing.Size(200, 200);
            this.bookingDateTimePicker.MinimumSize = new System.Drawing.Size(200, 20);
            this.bookingDateTimePicker.Name = "bookingDateTimePicker";
            this.bookingDateTimePicker.Size = new System.Drawing.Size(200, 29);
            this.bookingDateTimePicker.TabIndex = 3;
            this.bookingDateTimePicker.ValueChanged += new System.EventHandler(this.bookingDateTimePicker_ValueChanged);
            // 
            // guestIDTB
            // 
            this.guestIDTB.Location = new System.Drawing.Point(688, 444);
            this.guestIDTB.Name = "guestIDTB";
            this.guestIDTB.Size = new System.Drawing.Size(100, 20);
            this.guestIDTB.TabIndex = 4;
            this.guestIDTB.Text = "gID";
            this.guestIDTB.Visible = false;
            // 
            // noOfOccupantsTB
            // 
            this.noOfOccupantsTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noOfOccupantsTB.Location = new System.Drawing.Point(214, 263);
            this.noOfOccupantsTB.Name = "noOfOccupantsTB";
            this.noOfOccupantsTB.Size = new System.Drawing.Size(200, 29);
            this.noOfOccupantsTB.TabIndex = 5;
            // 
            // courseIDTB
            // 
            this.courseIDTB.Location = new System.Drawing.Point(688, 328);
            this.courseIDTB.Name = "courseIDTB";
            this.courseIDTB.Size = new System.Drawing.Size(100, 20);
            this.courseIDTB.TabIndex = 6;
            this.courseIDTB.Text = "cID";
            this.courseIDTB.Visible = false;
            // 
            // podIDTB
            // 
            this.podIDTB.Location = new System.Drawing.Point(688, 367);
            this.podIDTB.Name = "podIDTB";
            this.podIDTB.Size = new System.Drawing.Size(100, 20);
            this.podIDTB.TabIndex = 7;
            this.podIDTB.Visible = false;
            // 
            // noOfDaysComboBox
            // 
            this.noOfDaysComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.noOfDaysComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noOfDaysComboBox.FormattingEnabled = true;
            this.noOfDaysComboBox.Items.AddRange(new object[] {
            "3",
            "5",
            "7",
            "14"});
            this.noOfDaysComboBox.Location = new System.Drawing.Point(214, 109);
            this.noOfDaysComboBox.Name = "noOfDaysComboBox";
            this.noOfDaysComboBox.Size = new System.Drawing.Size(200, 32);
            this.noOfDaysComboBox.TabIndex = 8;
            // 
            // viewByBookingIDTB
            // 
            this.viewByBookingIDTB.Location = new System.Drawing.Point(688, 418);
            this.viewByBookingIDTB.Name = "viewByBookingIDTB";
            this.viewByBookingIDTB.Size = new System.Drawing.Size(100, 20);
            this.viewByBookingIDTB.TabIndex = 9;
            this.viewByBookingIDTB.Visible = false;
            // 
            // bookingIDComboBox
            // 
            this.bookingIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bookingIDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingIDComboBox.FormattingEnabled = true;
            this.bookingIDComboBox.Location = new System.Drawing.Point(711, 86);
            this.bookingIDComboBox.Name = "bookingIDComboBox";
            this.bookingIDComboBox.Size = new System.Drawing.Size(200, 32);
            this.bookingIDComboBox.TabIndex = 10;
            this.bookingIDComboBox.SelectedIndexChanged += new System.EventHandler(this.bookingIDComboBox_SelectedIndexChanged);
            // 
            // podIDComboBox
            // 
            this.podIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.podIDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.podIDComboBox.FormattingEnabled = true;
            this.podIDComboBox.Location = new System.Drawing.Point(214, 183);
            this.podIDComboBox.Name = "podIDComboBox";
            this.podIDComboBox.Size = new System.Drawing.Size(200, 32);
            this.podIDComboBox.TabIndex = 11;
            this.podIDComboBox.SelectedIndexChanged += new System.EventHandler(this.podIDComboBox_SelectedIndexChanged);
            // 
            // courseIDComboBox
            // 
            this.courseIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.courseIDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseIDComboBox.FormattingEnabled = true;
            this.courseIDComboBox.Location = new System.Drawing.Point(214, 222);
            this.courseIDComboBox.Name = "courseIDComboBox";
            this.courseIDComboBox.Size = new System.Drawing.Size(200, 32);
            this.courseIDComboBox.TabIndex = 12;
            this.courseIDComboBox.SelectedIndexChanged += new System.EventHandler(this.courseIDComboBox_SelectedIndexChanged);
            // 
            // dateOfStayLBL
            // 
            this.dateOfStayLBL.AutoSize = true;
            this.dateOfStayLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfStayLBL.Location = new System.Drawing.Point(18, 79);
            this.dateOfStayLBL.Name = "dateOfStayLBL";
            this.dateOfStayLBL.Size = new System.Drawing.Size(105, 24);
            this.dateOfStayLBL.TabIndex = 13;
            this.dateOfStayLBL.Text = "Date of stay";
            // 
            // lenghtOfStayLBL
            // 
            this.lenghtOfStayLBL.AutoSize = true;
            this.lenghtOfStayLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lenghtOfStayLBL.Location = new System.Drawing.Point(18, 117);
            this.lenghtOfStayLBL.Name = "lenghtOfStayLBL";
            this.lenghtOfStayLBL.Size = new System.Drawing.Size(125, 24);
            this.lenghtOfStayLBL.TabIndex = 14;
            this.lenghtOfStayLBL.Text = "Length of stay";
            // 
            // guestStayingLBL
            // 
            this.guestStayingLBL.AutoSize = true;
            this.guestStayingLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestStayingLBL.Location = new System.Drawing.Point(18, 155);
            this.guestStayingLBL.Name = "guestStayingLBL";
            this.guestStayingLBL.Size = new System.Drawing.Size(122, 24);
            this.guestStayingLBL.TabIndex = 15;
            this.guestStayingLBL.Text = "Guest staying";
            // 
            // podIDLBL
            // 
            this.podIDLBL.AutoSize = true;
            this.podIDLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.podIDLBL.Location = new System.Drawing.Point(18, 191);
            this.podIDLBL.Name = "podIDLBL";
            this.podIDLBL.Size = new System.Drawing.Size(66, 24);
            this.podIDLBL.TabIndex = 16;
            this.podIDLBL.Text = "Pod ID";
            // 
            // courseIDLBL
            // 
            this.courseIDLBL.AutoSize = true;
            this.courseIDLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseIDLBL.Location = new System.Drawing.Point(18, 230);
            this.courseIDLBL.Name = "courseIDLBL";
            this.courseIDLBL.Size = new System.Drawing.Size(93, 24);
            this.courseIDLBL.TabIndex = 17;
            this.courseIDLBL.Text = "Course ID";
            // 
            // noOfOccupantsLBL
            // 
            this.noOfOccupantsLBL.AutoSize = true;
            this.noOfOccupantsLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noOfOccupantsLBL.Location = new System.Drawing.Point(18, 266);
            this.noOfOccupantsLBL.Name = "noOfOccupantsLBL";
            this.noOfOccupantsLBL.Size = new System.Drawing.Size(191, 24);
            this.noOfOccupantsLBL.TabIndex = 18;
            this.noOfOccupantsLBL.Text = "Number of occupants";
            // 
            // guestIDComboBox
            // 
            this.guestIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guestIDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestIDComboBox.FormattingEnabled = true;
            this.guestIDComboBox.Location = new System.Drawing.Point(214, 147);
            this.guestIDComboBox.Name = "guestIDComboBox";
            this.guestIDComboBox.Size = new System.Drawing.Size(200, 32);
            this.guestIDComboBox.TabIndex = 19;
            this.guestIDComboBox.SelectedIndexChanged += new System.EventHandler(this.guestIDComboBox_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookingIdDataGridViewTextBoxColumn,
            this.guestIDDataGridViewTextBoxColumn,
            this.podIDDataGridViewTextBoxColumn,
            this.courseIDDataGridViewTextBoxColumn,
            this.numberOfOccupantsDataGridViewTextBoxColumn,
            this.checkInDateDataGridViewTextBoxColumn,
            this.checkOutDateDataGridViewTextBoxColumn,
            this.bookingStatusDataGridViewTextBoxColumn,
            this.depositAmountDataGridViewTextBoxColumn,
            this.discountPercentageDataGridViewTextBoxColumn,
            this.totalAmountDataGridViewTextBoxColumn,
            this.dateBookedDataGridViewTextBoxColumn,
            this.Update});
            this.dataGridView1.DataSource = this.bookingBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(2, 334);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(960, 307);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // bookingIdDataGridViewTextBoxColumn
            // 
            this.bookingIdDataGridViewTextBoxColumn.DataPropertyName = "BookingId";
            this.bookingIdDataGridViewTextBoxColumn.HeaderText = "BookingId";
            this.bookingIdDataGridViewTextBoxColumn.Name = "bookingIdDataGridViewTextBoxColumn";
            this.bookingIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // guestIDDataGridViewTextBoxColumn
            // 
            this.guestIDDataGridViewTextBoxColumn.DataPropertyName = "GuestID";
            this.guestIDDataGridViewTextBoxColumn.HeaderText = "GuestID";
            this.guestIDDataGridViewTextBoxColumn.Name = "guestIDDataGridViewTextBoxColumn";
            this.guestIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // podIDDataGridViewTextBoxColumn
            // 
            this.podIDDataGridViewTextBoxColumn.DataPropertyName = "PodID";
            this.podIDDataGridViewTextBoxColumn.HeaderText = "PodID";
            this.podIDDataGridViewTextBoxColumn.Name = "podIDDataGridViewTextBoxColumn";
            this.podIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.podIDDataGridViewTextBoxColumn.Width = 20;
            // 
            // courseIDDataGridViewTextBoxColumn
            // 
            this.courseIDDataGridViewTextBoxColumn.DataPropertyName = "CourseID";
            this.courseIDDataGridViewTextBoxColumn.HeaderText = "CourseID";
            this.courseIDDataGridViewTextBoxColumn.Name = "courseIDDataGridViewTextBoxColumn";
            this.courseIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.courseIDDataGridViewTextBoxColumn.Width = 20;
            // 
            // numberOfOccupantsDataGridViewTextBoxColumn
            // 
            this.numberOfOccupantsDataGridViewTextBoxColumn.DataPropertyName = "NumberOfOccupants";
            this.numberOfOccupantsDataGridViewTextBoxColumn.HeaderText = "NumberOfOccupants";
            this.numberOfOccupantsDataGridViewTextBoxColumn.Name = "numberOfOccupantsDataGridViewTextBoxColumn";
            this.numberOfOccupantsDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberOfOccupantsDataGridViewTextBoxColumn.Width = 20;
            // 
            // checkInDateDataGridViewTextBoxColumn
            // 
            this.checkInDateDataGridViewTextBoxColumn.DataPropertyName = "CheckInDate";
            this.checkInDateDataGridViewTextBoxColumn.HeaderText = "CheckInDate";
            this.checkInDateDataGridViewTextBoxColumn.Name = "checkInDateDataGridViewTextBoxColumn";
            this.checkInDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // checkOutDateDataGridViewTextBoxColumn
            // 
            this.checkOutDateDataGridViewTextBoxColumn.DataPropertyName = "CheckOutDate";
            this.checkOutDateDataGridViewTextBoxColumn.HeaderText = "CheckOutDate";
            this.checkOutDateDataGridViewTextBoxColumn.Name = "checkOutDateDataGridViewTextBoxColumn";
            this.checkOutDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookingStatusDataGridViewTextBoxColumn
            // 
            this.bookingStatusDataGridViewTextBoxColumn.DataPropertyName = "BookingStatus";
            this.bookingStatusDataGridViewTextBoxColumn.HeaderText = "BookingStatus";
            this.bookingStatusDataGridViewTextBoxColumn.Name = "bookingStatusDataGridViewTextBoxColumn";
            this.bookingStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // depositAmountDataGridViewTextBoxColumn
            // 
            this.depositAmountDataGridViewTextBoxColumn.DataPropertyName = "DepositAmount";
            this.depositAmountDataGridViewTextBoxColumn.HeaderText = "DepositAmount";
            this.depositAmountDataGridViewTextBoxColumn.Name = "depositAmountDataGridViewTextBoxColumn";
            this.depositAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // discountPercentageDataGridViewTextBoxColumn
            // 
            this.discountPercentageDataGridViewTextBoxColumn.DataPropertyName = "DiscountPercentage";
            this.discountPercentageDataGridViewTextBoxColumn.HeaderText = "DiscountPercentage";
            this.discountPercentageDataGridViewTextBoxColumn.Name = "discountPercentageDataGridViewTextBoxColumn";
            this.discountPercentageDataGridViewTextBoxColumn.ReadOnly = true;
            this.discountPercentageDataGridViewTextBoxColumn.Width = 30;
            // 
            // totalAmountDataGridViewTextBoxColumn
            // 
            this.totalAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn.HeaderText = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn.Name = "totalAmountDataGridViewTextBoxColumn";
            this.totalAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateBookedDataGridViewTextBoxColumn
            // 
            this.dateBookedDataGridViewTextBoxColumn.DataPropertyName = "DateBooked";
            this.dateBookedDataGridViewTextBoxColumn.HeaderText = "DateBooked";
            this.dateBookedDataGridViewTextBoxColumn.Name = "dateBookedDataGridViewTextBoxColumn";
            this.dateBookedDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateBookedDataGridViewTextBoxColumn.Width = 20;
            // 
            // Update
            // 
            this.Update.HeaderText = "Update Record";
            this.Update.Name = "Update";
            this.Update.ReadOnly = true;
            this.Update.Text = "Update";
            this.Update.ToolTipText = "Click to update this record";
            this.Update.Width = 75;
            // 
            // bookingBindingSource1
            // 
            this.bookingBindingSource1.DataMember = "Booking";
            this.bookingBindingSource1.DataSource = this.updatedBookingTable;
            // 
            // updatedBookingTable
            // 
            this.updatedBookingTable.DataSetName = "updatedBookingTable";
            this.updatedBookingTable.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookingBindingSource
            // 
            this.bookingBindingSource.DataMember = "Booking";
            this.bookingBindingSource.DataSource = this.bookingTable;
            // 
            // bookingTable
            // 
            this.bookingTable.DataSetName = "BookingTable";
            this.bookingTable.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookingTableAdapter
            // 
            this.bookingTableAdapter.ClearBeforeFill = true;
            // 
            // bookingIDsDeleteComboBox
            // 
            this.bookingIDsDeleteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bookingIDsDeleteComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingIDsDeleteComboBox.FormattingEnabled = true;
            this.bookingIDsDeleteComboBox.Location = new System.Drawing.Point(711, 217);
            this.bookingIDsDeleteComboBox.Name = "bookingIDsDeleteComboBox";
            this.bookingIDsDeleteComboBox.Size = new System.Drawing.Size(200, 32);
            this.bookingIDsDeleteComboBox.TabIndex = 21;
            this.bookingIDsDeleteComboBox.SelectedIndexChanged += new System.EventHandler(this.bookingIDsDeleteComboBox_SelectedIndexChanged);
            // 
            // previewBookinglbl
            // 
            this.previewBookinglbl.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.previewBookinglbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previewBookinglbl.Location = new System.Drawing.Point(439, 74);
            this.previewBookinglbl.Name = "previewBookinglbl";
            this.previewBookinglbl.Size = new System.Drawing.Size(203, 95);
            this.previewBookinglbl.TabIndex = 22;
            // 
            // previewBookinglbl2
            // 
            this.previewBookinglbl2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.previewBookinglbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previewBookinglbl2.Location = new System.Drawing.Point(439, 255);
            this.previewBookinglbl2.Name = "previewBookinglbl2";
            this.previewBookinglbl2.Size = new System.Drawing.Size(203, 74);
            this.previewBookinglbl2.TabIndex = 23;
            this.previewBookinglbl2.Click += new System.EventHandler(this.previewBookinglbl2_Click);
            // 
            // previewBookinglbl3
            // 
            this.previewBookinglbl3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.previewBookinglbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previewBookinglbl3.Location = new System.Drawing.Point(439, 174);
            this.previewBookinglbl3.Name = "previewBookinglbl3";
            this.previewBookinglbl3.Size = new System.Drawing.Size(203, 77);
            this.previewBookinglbl3.TabIndex = 24;
            // 
            // updateBTN
            // 
            this.updateBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBTN.Location = new System.Drawing.Point(315, 298);
            this.updateBTN.Name = "updateBTN";
            this.updateBTN.Size = new System.Drawing.Size(99, 34);
            this.updateBTN.TabIndex = 25;
            this.updateBTN.Text = "UPDATE";
            this.updateBTN.UseVisualStyleBackColor = true;
            this.updateBTN.Click += new System.EventHandler(this.updateBTN_Click);
            // 
            // bookingBuilderlbl
            // 
            this.bookingBuilderlbl.BackColor = System.Drawing.Color.Transparent;
            this.bookingBuilderlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingBuilderlbl.Location = new System.Drawing.Point(448, 43);
            this.bookingBuilderlbl.Name = "bookingBuilderlbl";
            this.bookingBuilderlbl.Size = new System.Drawing.Size(183, 28);
            this.bookingBuilderlbl.TabIndex = 26;
            this.bookingBuilderlbl.Text = "Booking Builder";
            this.bookingBuilderlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bookingTableAdapter1
            // 
            this.bookingTableAdapter1.ClearBeforeFill = true;
            // 
            // bookingManagerLBL
            // 
            this.bookingManagerLBL.AutoSize = true;
            this.bookingManagerLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingManagerLBL.Location = new System.Drawing.Point(12, 9);
            this.bookingManagerLBL.Name = "bookingManagerLBL";
            this.bookingManagerLBL.Size = new System.Drawing.Size(402, 55);
            this.bookingManagerLBL.TabIndex = 27;
            this.bookingManagerLBL.Text = "Booking Manager";
            // 
            // deleteBookingLBL
            // 
            this.deleteBookingLBL.AutoSize = true;
            this.deleteBookingLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBookingLBL.Location = new System.Drawing.Point(699, 183);
            this.deleteBookingLBL.Name = "deleteBookingLBL";
            this.deleteBookingLBL.Size = new System.Drawing.Size(230, 24);
            this.deleteBookingLBL.TabIndex = 28;
            this.deleteBookingLBL.Text = "Select a Booking to Delete";
            // 
            // depositLBL
            // 
            this.depositLBL.AutoSize = true;
            this.depositLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositLBL.Location = new System.Drawing.Point(655, 47);
            this.depositLBL.Name = "depositLBL";
            this.depositLBL.Size = new System.Drawing.Size(297, 24);
            this.depositLBL.TabIndex = 29;
            this.depositLBL.Text = "Select a Booking to Pay its Deposit";
            // 
            // BookingMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 641);
            this.Controls.Add(this.depositLBL);
            this.Controls.Add(this.deleteBookingLBL);
            this.Controls.Add(this.bookingManagerLBL);
            this.Controls.Add(this.bookingBuilderlbl);
            this.Controls.Add(this.updateBTN);
            this.Controls.Add(this.previewBookinglbl3);
            this.Controls.Add(this.previewBookinglbl2);
            this.Controls.Add(this.previewBookinglbl);
            this.Controls.Add(this.bookingIDsDeleteComboBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.guestIDComboBox);
            this.Controls.Add(this.noOfOccupantsLBL);
            this.Controls.Add(this.courseIDLBL);
            this.Controls.Add(this.podIDLBL);
            this.Controls.Add(this.guestStayingLBL);
            this.Controls.Add(this.lenghtOfStayLBL);
            this.Controls.Add(this.dateOfStayLBL);
            this.Controls.Add(this.courseIDComboBox);
            this.Controls.Add(this.podIDComboBox);
            this.Controls.Add(this.bookingIDComboBox);
            this.Controls.Add(this.viewByBookingIDTB);
            this.Controls.Add(this.noOfDaysComboBox);
            this.Controls.Add(this.podIDTB);
            this.Controls.Add(this.courseIDTB);
            this.Controls.Add(this.noOfOccupantsTB);
            this.Controls.Add(this.guestIDTB);
            this.Controls.Add(this.bookingDateTimePicker);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddBookingBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookingMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookingMenu";
            this.Load += new System.EventHandler(this.BookingMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updatedBookingTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddBookingBTN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker bookingDateTimePicker;
        private System.Windows.Forms.TextBox guestIDTB;
        private System.Windows.Forms.TextBox noOfOccupantsTB;
        private System.Windows.Forms.TextBox courseIDTB;
        private System.Windows.Forms.TextBox podIDTB;
        private System.Windows.Forms.ComboBox noOfDaysComboBox;
        private System.Windows.Forms.TextBox viewByBookingIDTB;
        private System.Windows.Forms.ComboBox bookingIDComboBox;
        private System.Windows.Forms.ComboBox podIDComboBox;
        private System.Windows.Forms.ComboBox courseIDComboBox;
        private System.Windows.Forms.Label dateOfStayLBL;
        private System.Windows.Forms.Label lenghtOfStayLBL;
        private System.Windows.Forms.Label guestStayingLBL;
        private System.Windows.Forms.Label podIDLBL;
        private System.Windows.Forms.Label courseIDLBL;
        private System.Windows.Forms.Label noOfOccupantsLBL;
        private System.Windows.Forms.ComboBox guestIDComboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BookingTable bookingTable;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private BookingTableTableAdapters.BookingTableAdapter bookingTableAdapter;
        private System.Windows.Forms.ComboBox bookingIDsDeleteComboBox;
        private System.Windows.Forms.Label previewBookinglbl;
        private System.Windows.Forms.Label previewBookinglbl2;
        private System.Windows.Forms.Label previewBookinglbl3;
        private System.Windows.Forms.Button updateBTN;
        private System.Windows.Forms.Label bookingBuilderlbl;
        private updatedBookingTable updatedBookingTable;
        private System.Windows.Forms.BindingSource bookingBindingSource1;
        private updatedBookingTableTableAdapters.BookingTableAdapter bookingTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn podIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfOccupantsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkInDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkOutDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depositAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountPercentageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateBookedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.Label bookingManagerLBL;
        private System.Windows.Forms.Label deleteBookingLBL;
        private System.Windows.Forms.Label depositLBL;
    }
}

