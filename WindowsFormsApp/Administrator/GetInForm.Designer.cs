namespace WindowsFormsApp.Administrator
{
    partial class GetInForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.roomReservationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet14 = new WindowsFormsApp.hotelDataSet14();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.roomReservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet13 = new WindowsFormsApp.hotelDataSet13();
            this.roomReservationTableAdapter = new WindowsFormsApp.hotelDataSet13TableAdapters.RoomReservationTableAdapter();
            this.roomReservationTableAdapter1 = new WindowsFormsApp.hotelDataSet14TableAdapters.RoomReservationTableAdapter();
            this.hotelDataSet22 = new WindowsFormsApp.hotelDataSet22();
            this.roomReservationBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.roomReservationTableAdapter2 = new WindowsFormsApp.hotelDataSet22TableAdapters.RoomReservationTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ldate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientFname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.roomReservationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomReservationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomReservationBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.roomReservationBindingSource1;
            this.listBox1.DisplayMember = "Id";
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(800, 95);
            this.listBox1.TabIndex = 0;
            this.listBox1.ValueMember = "Id";
            // 
            // roomReservationBindingSource1
            // 
            this.roomReservationBindingSource1.DataMember = "RoomReservation";
            this.roomReservationBindingSource1.DataSource = this.hotelDataSet14;
            // 
            // hotelDataSet14
            // 
            this.hotelDataSet14.DataSetName = "hotelDataSet14";
            this.hotelDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(800, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "Заселить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.RoomId,
            this.Fdate,
            this.Ldate,
            this.ClientFname});
            this.dataGridView1.DataSource = this.roomReservationBindingSource2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(800, 301);
            this.dataGridView1.TabIndex = 2;
            // 
            // roomReservationBindingSource
            // 
            this.roomReservationBindingSource.DataMember = "RoomReservation";
            this.roomReservationBindingSource.DataSource = this.hotelDataSet13;
            // 
            // hotelDataSet13
            // 
            this.hotelDataSet13.DataSetName = "hotelDataSet13";
            this.hotelDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomReservationTableAdapter
            // 
            this.roomReservationTableAdapter.ClearBeforeFill = true;
            // 
            // roomReservationTableAdapter1
            // 
            this.roomReservationTableAdapter1.ClearBeforeFill = true;
            // 
            // hotelDataSet22
            // 
            this.hotelDataSet22.DataSetName = "hotelDataSet22";
            this.hotelDataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomReservationBindingSource2
            // 
            this.roomReservationBindingSource2.DataMember = "RoomReservation";
            this.roomReservationBindingSource2.DataSource = this.hotelDataSet22;
            // 
            // roomReservationTableAdapter2
            // 
            this.roomReservationTableAdapter2.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // RoomId
            // 
            this.RoomId.DataPropertyName = "RoomId";
            this.RoomId.HeaderText = "Номер";
            this.RoomId.Name = "RoomId";
            this.RoomId.ReadOnly = true;
            // 
            // Fdate
            // 
            this.Fdate.DataPropertyName = "Fdate";
            this.Fdate.HeaderText = "Дата заселения";
            this.Fdate.Name = "Fdate";
            this.Fdate.ReadOnly = true;
            // 
            // Ldate
            // 
            this.Ldate.DataPropertyName = "Ldate";
            this.Ldate.HeaderText = "Дата выселения";
            this.Ldate.Name = "Ldate";
            this.Ldate.ReadOnly = true;
            // 
            // ClientFname
            // 
            this.ClientFname.DataPropertyName = "ClientFname";
            this.ClientFname.HeaderText = "ФИО клиента";
            this.ClientFname.Name = "ClientFname";
            this.ClientFname.ReadOnly = true;
            // 
            // GetInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Name = "GetInForm";
            this.Text = "GetInForm";
            this.Load += new System.EventHandler(this.GetInForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomReservationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomReservationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomReservationBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private hotelDataSet13 hotelDataSet13;
        private System.Windows.Forms.BindingSource roomReservationBindingSource;
        private hotelDataSet13TableAdapters.RoomReservationTableAdapter roomReservationTableAdapter;
        private hotelDataSet14 hotelDataSet14;
        private System.Windows.Forms.BindingSource roomReservationBindingSource1;
        private hotelDataSet14TableAdapters.RoomReservationTableAdapter roomReservationTableAdapter1;
        private hotelDataSet22 hotelDataSet22;
        private System.Windows.Forms.BindingSource roomReservationBindingSource2;
        private hotelDataSet22TableAdapters.RoomReservationTableAdapter roomReservationTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ldate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientFname;
    }
}