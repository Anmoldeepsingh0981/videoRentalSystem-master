namespace videoRentalSystem
{
    partial class Form1
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
            System.Windows.Forms.Label cusIDLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label midLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label ratingLabel;
            System.Windows.Forms.Label yearLabel;
            System.Windows.Forms.Label genreLabel;
            System.Windows.Forms.Label rMIDLabel;
            System.Windows.Forms.Label dateRentedLabel;
            System.Windows.Forms.Label dateReturnedLabel;
            System.Windows.Forms.Label firstNameLabel1;
            System.Windows.Forms.Label lastNameLabel1;
            this.videoRentalDataSet = new videoRentalSystem.videoRentalDataSet();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new videoRentalSystem.videoRentalDataSetTableAdapters.customerTableAdapter();
            this.tableAdapterManager = new videoRentalSystem.videoRentalDataSetTableAdapters.TableAdapterManager();
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.videoRentalDataSet1 = new videoRentalSystem.videoRentalDataSet();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.videoRentalDataSet3 = new videoRentalSystem.videoRentalDataSet3();
            this.CusID = new System.Windows.Forms.Label();
            this.cus_delete = new System.Windows.Forms.Button();
            this.cus_update = new System.Windows.Forms.Button();
            this.cus_add = new System.Windows.Forms.Button();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.moviesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moviesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.yearDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.mid = new System.Windows.Forms.Label();
            this.delete_movie = new System.Windows.Forms.Button();
            this.update_movie = new System.Windows.Forms.Button();
            this.Add_movie = new System.Windows.Forms.Button();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rentalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.videoRentalDataSet11 = new videoRentalSystem.videoRentalDataSet1();
            this.dateRentedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateReturnedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cidrent = new System.Windows.Forms.TextBox();
            this.midrent = new System.Windows.Forms.TextBox();
            this.rentalsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.moviesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.videoRentalDataSet2 = new videoRentalSystem.videoRentalDataSet2();
            this.moviesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter1 = new videoRentalSystem.videoRentalDataSet1TableAdapters.customerTableAdapter();
            this.tableAdapterManager1 = new videoRentalSystem.videoRentalDataSet1TableAdapters.TableAdapterManager();
            this.moviesTableAdapter = new videoRentalSystem.videoRentalDataSet1TableAdapters.moviesTableAdapter();
            this.rentalsTableAdapter = new videoRentalSystem.videoRentalDataSet1TableAdapters.rentalsTableAdapter();
            this.moviesTableAdapter1 = new videoRentalSystem.videoRentalDataSet2TableAdapters.moviesTableAdapter();
            this.tableAdapterManager2 = new videoRentalSystem.videoRentalDataSet2TableAdapters.TableAdapterManager();
            this.customerTableAdapter2 = new videoRentalSystem.videoRentalDataSet3TableAdapters.customerTableAdapter();
            this.tableAdapterManager3 = new videoRentalSystem.videoRentalDataSet3TableAdapters.TableAdapterManager();
            this.moviesTableAdapter2 = new videoRentalSystem.videoRentalDataSet3TableAdapters.moviesTableAdapter();
            this.issue = new System.Windows.Forms.Button();
            this.m_return = new System.Windows.Forms.Button();
            this.rmid = new System.Windows.Forms.Label();
            cusIDLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            midLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            ratingLabel = new System.Windows.Forms.Label();
            yearLabel = new System.Windows.Forms.Label();
            genreLabel = new System.Windows.Forms.Label();
            rMIDLabel = new System.Windows.Forms.Label();
            dateRentedLabel = new System.Windows.Forms.Label();
            dateReturnedLabel = new System.Windows.Forms.Label();
            firstNameLabel1 = new System.Windows.Forms.Label();
            lastNameLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.videoRentalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoRentalDataSet1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoRentalDataSet3)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentalsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoRentalDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoRentalDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cusIDLabel
            // 
            cusIDLabel.AutoSize = true;
            cusIDLabel.Location = new System.Drawing.Point(27, 302);
            cusIDLabel.Name = "cusIDLabel";
            cusIDLabel.Size = new System.Drawing.Size(53, 17);
            cusIDLabel.TabIndex = 1;
            cusIDLabel.Text = "Cus ID:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(273, 302);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(80, 17);
            firstNameLabel.TabIndex = 3;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(571, 302);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(80, 17);
            lastNameLabel.TabIndex = 5;
            lastNameLabel.Text = "Last Name:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(27, 355);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(64, 17);
            addressLabel.TabIndex = 7;
            addressLabel.Text = "Address:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(27, 408);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(53, 17);
            phoneLabel.TabIndex = 9;
            phoneLabel.Text = "Phone:";
            // 
            // midLabel
            // 
            midLabel.AutoSize = true;
            midLabel.Location = new System.Drawing.Point(23, 315);
            midLabel.Name = "midLabel";
            midLabel.Size = new System.Drawing.Size(34, 17);
            midLabel.TabIndex = 1;
            midLabel.Text = "mid:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(264, 315);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(39, 17);
            titleLabel.TabIndex = 3;
            titleLabel.Text = "Title:";
            // 
            // ratingLabel
            // 
            ratingLabel.AutoSize = true;
            ratingLabel.Location = new System.Drawing.Point(20, 358);
            ratingLabel.Name = "ratingLabel";
            ratingLabel.Size = new System.Drawing.Size(53, 17);
            ratingLabel.TabIndex = 5;
            ratingLabel.Text = "Rating:";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new System.Drawing.Point(264, 358);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new System.Drawing.Size(102, 17);
            yearLabel.TabIndex = 7;
            yearLabel.Text = "ReleasedDate:";
            // 
            // genreLabel
            // 
            genreLabel.AutoSize = true;
            genreLabel.Location = new System.Drawing.Point(521, 361);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new System.Drawing.Size(52, 17);
            genreLabel.TabIndex = 11;
            genreLabel.Text = "Genre:";
            // 
            // rMIDLabel
            // 
            rMIDLabel.AutoSize = true;
            rMIDLabel.Location = new System.Drawing.Point(59, 318);
            rMIDLabel.Name = "rMIDLabel";
            rMIDLabel.Size = new System.Drawing.Size(46, 17);
            rMIDLabel.TabIndex = 1;
            rMIDLabel.Text = "RMID:";
            // 
            // dateRentedLabel
            // 
            dateRentedLabel.AutoSize = true;
            dateRentedLabel.Location = new System.Drawing.Point(408, 320);
            dateRentedLabel.Name = "dateRentedLabel";
            dateRentedLabel.Size = new System.Drawing.Size(92, 17);
            dateRentedLabel.TabIndex = 3;
            dateRentedLabel.Text = "Date Rented:";
            // 
            // dateReturnedLabel
            // 
            dateReturnedLabel.AutoSize = true;
            dateReturnedLabel.Location = new System.Drawing.Point(59, 360);
            dateReturnedLabel.Name = "dateReturnedLabel";
            dateReturnedLabel.Size = new System.Drawing.Size(105, 17);
            dateReturnedLabel.TabIndex = 5;
            dateReturnedLabel.Text = "Date Returned:";
            
            // 
            // firstNameLabel1
            // 
            firstNameLabel1.AutoSize = true;
            firstNameLabel1.Location = new System.Drawing.Point(59, 404);
            firstNameLabel1.Name = "firstNameLabel1";
            firstNameLabel1.Size = new System.Drawing.Size(49, 17);
            firstNameLabel1.TabIndex = 7;
            firstNameLabel1.Text = "CusID:";
            
            // 
            // lastNameLabel1
            // 
            lastNameLabel1.AutoSize = true;
            lastNameLabel1.Location = new System.Drawing.Point(408, 360);
            lastNameLabel1.Name = "lastNameLabel1";
            lastNameLabel1.Size = new System.Drawing.Size(36, 17);
            lastNameLabel1.TabIndex = 9;
            lastNameLabel1.Text = "MID:";
            // 
            // videoRentalDataSet
            // 
            this.videoRentalDataSet.DataSetName = "videoRentalDataSet";
            this.videoRentalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.videoRentalDataSet;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.customerTableAdapter = this.customerTableAdapter;
            this.tableAdapterManager.UpdateOrder = videoRentalSystem.videoRentalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataMember = "customer";
            this.customerBindingSource1.DataSource = this.videoRentalDataSet;
            // 
            // videoRentalDataSet1
            // 
            this.videoRentalDataSet1.DataSetName = "videoRentalDataSet";
            this.videoRentalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(862, 517);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.customerDataGridView);
            this.tabPage1.Controls.Add(this.CusID);
            this.tabPage1.Controls.Add(this.cus_delete);
            this.tabPage1.Controls.Add(this.cus_update);
            this.tabPage1.Controls.Add(this.cus_add);
            this.tabPage1.Controls.Add(cusIDLabel);
            this.tabPage1.Controls.Add(firstNameLabel);
            this.tabPage1.Controls.Add(this.firstNameTextBox);
            this.tabPage1.Controls.Add(lastNameLabel);
            this.tabPage1.Controls.Add(this.lastNameTextBox);
            this.tabPage1.Controls.Add(addressLabel);
            this.tabPage1.Controls.Add(this.addressTextBox);
            this.tabPage1.Controls.Add(phoneLabel);
            this.tabPage1.Controls.Add(this.phoneTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(854, 488);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.AutoGenerateColumns = false;
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.customerDataGridView.DataSource = this.customerBindingSource3;
            this.customerDataGridView.Location = new System.Drawing.Point(15, 6);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.RowHeadersWidth = 51;
            this.customerDataGridView.RowTemplate.Height = 24;
            this.customerDataGridView.Size = new System.Drawing.Size(833, 271);
            this.customerDataGridView.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CusID";
            this.dataGridViewTextBoxColumn1.HeaderText = "CusID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn2.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn3.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn4.HeaderText = "Address";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn5.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // customerBindingSource3
            // 
            this.customerBindingSource3.DataMember = "customer";
            this.customerBindingSource3.DataSource = this.videoRentalDataSet3;
            // 
            // videoRentalDataSet3
            // 
            this.videoRentalDataSet3.DataSetName = "videoRentalDataSet3";
            this.videoRentalDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CusID
            // 
            this.CusID.AutoSize = true;
            this.CusID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource3, "CusID", true));
            this.CusID.Location = new System.Drawing.Point(115, 306);
            this.CusID.Name = "CusID";
            this.CusID.Size = new System.Drawing.Size(0, 17);
            this.CusID.TabIndex = 14;
            // 
            // cus_delete
            // 
            this.cus_delete.Location = new System.Drawing.Point(737, 408);
            this.cus_delete.Name = "cus_delete";
            this.cus_delete.Size = new System.Drawing.Size(92, 33);
            this.cus_delete.TabIndex = 13;
            this.cus_delete.Text = "Delete";
            this.cus_delete.UseVisualStyleBackColor = true;
            this.cus_delete.Click += new System.EventHandler(this.cus_delete_Click);
            // 
            // cus_update
            // 
            this.cus_update.Location = new System.Drawing.Point(606, 408);
            this.cus_update.Name = "cus_update";
            this.cus_update.Size = new System.Drawing.Size(92, 33);
            this.cus_update.TabIndex = 12;
            this.cus_update.Text = "Update";
            this.cus_update.UseVisualStyleBackColor = true;
            this.cus_update.Click += new System.EventHandler(this.cus_update_Click);
            // 
            // cus_add
            // 
            this.cus_add.Location = new System.Drawing.Point(475, 408);
            this.cus_add.Name = "cus_add";
            this.cus_add.Size = new System.Drawing.Size(92, 33);
            this.cus_add.TabIndex = 11;
            this.cus_add.Text = "Add";
            this.cus_add.UseVisualStyleBackColor = true;
            this.cus_add.Click += new System.EventHandler(this.addCustomer_Click);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource3, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(390, 302);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(165, 22);
            this.firstNameTextBox.TabIndex = 4;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource3, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(693, 302);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(136, 22);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource3, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(115, 355);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(714, 22);
            this.addressTextBox.TabIndex = 8;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource3, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(115, 408);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(291, 22);
            this.phoneTextBox.TabIndex = 10;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.moviesDataGridView);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.yearDateTimePicker);
            this.tabPage2.Controls.Add(this.mid);
            this.tabPage2.Controls.Add(this.delete_movie);
            this.tabPage2.Controls.Add(this.update_movie);
            this.tabPage2.Controls.Add(this.Add_movie);
            this.tabPage2.Controls.Add(midLabel);
            this.tabPage2.Controls.Add(titleLabel);
            this.tabPage2.Controls.Add(this.titleTextBox);
            this.tabPage2.Controls.Add(ratingLabel);
            this.tabPage2.Controls.Add(this.ratingTextBox);
            this.tabPage2.Controls.Add(yearLabel);
            this.tabPage2.Controls.Add(genreLabel);
            this.tabPage2.Controls.Add(this.genreTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(854, 488);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Movies";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // moviesDataGridView
            // 
            this.moviesDataGridView.AutoGenerateColumns = false;
            this.moviesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.moviesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.moviesDataGridView.DataSource = this.moviesBindingSource2;
            this.moviesDataGridView.Location = new System.Drawing.Point(6, 16);
            this.moviesDataGridView.Name = "moviesDataGridView";
            this.moviesDataGridView.RowHeadersWidth = 51;
            this.moviesDataGridView.RowTemplate.Height = 24;
            this.moviesDataGridView.Size = new System.Drawing.Size(842, 273);
            this.moviesDataGridView.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "mid";
            this.dataGridViewTextBoxColumn6.HeaderText = "mid";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn7.HeaderText = "Title";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Rating";
            this.dataGridViewTextBoxColumn8.HeaderText = "Rating";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Year";
            this.dataGridViewTextBoxColumn9.HeaderText = "Year";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "RentalCost";
            this.dataGridViewTextBoxColumn10.HeaderText = "RentalCost";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Genre";
            this.dataGridViewTextBoxColumn11.HeaderText = "Genre";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // moviesBindingSource2
            // 
            this.moviesBindingSource2.DataMember = "movies";
            this.moviesBindingSource2.DataSource = this.videoRentalDataSet3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Genre:";
            // 
            // yearDateTimePicker
            // 
            this.yearDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.moviesBindingSource2, "Year", true));
            this.yearDateTimePicker.Location = new System.Drawing.Point(391, 358);
            this.yearDateTimePicker.Name = "yearDateTimePicker";
            this.yearDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.yearDateTimePicker.TabIndex = 17;
            // 
            // mid
            // 
            this.mid.AutoSize = true;
            this.mid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.moviesBindingSource2, "mid", true));
            this.mid.Location = new System.Drawing.Point(111, 314);
            this.mid.Name = "mid";
            this.mid.Size = new System.Drawing.Size(0, 17);
            this.mid.TabIndex = 16;
            // 
            // delete_movie
            // 
            this.delete_movie.Location = new System.Drawing.Point(675, 400);
            this.delete_movie.Name = "delete_movie";
            this.delete_movie.Size = new System.Drawing.Size(88, 37);
            this.delete_movie.TabIndex = 15;
            this.delete_movie.Text = "Delete";
            this.delete_movie.UseVisualStyleBackColor = true;
            this.delete_movie.Click += new System.EventHandler(this.delete_movie_Click);
            // 
            // update_movie
            // 
            this.update_movie.Location = new System.Drawing.Point(542, 400);
            this.update_movie.Name = "update_movie";
            this.update_movie.Size = new System.Drawing.Size(88, 37);
            this.update_movie.TabIndex = 14;
            this.update_movie.Text = "Update";
            this.update_movie.UseVisualStyleBackColor = true;
            this.update_movie.Click += new System.EventHandler(this.update_movie_Click);
            // 
            // Add_movie
            // 
            this.Add_movie.Location = new System.Drawing.Point(401, 400);
            this.Add_movie.Name = "Add_movie";
            this.Add_movie.Size = new System.Drawing.Size(88, 37);
            this.Add_movie.TabIndex = 13;
            this.Add_movie.Text = "Add";
            this.Add_movie.UseVisualStyleBackColor = true;
            this.Add_movie.Click += new System.EventHandler(this.Add_movie_Click);
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.moviesBindingSource2, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(325, 312);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(485, 22);
            this.titleTextBox.TabIndex = 4;
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.moviesBindingSource2, "Rating", true));
            this.ratingTextBox.Location = new System.Drawing.Point(111, 355);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.Size = new System.Drawing.Size(100, 22);
            this.ratingTextBox.TabIndex = 6;
            // 
            // genreTextBox
            // 
            this.genreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.moviesBindingSource2, "Genre", true));
            this.genreTextBox.Location = new System.Drawing.Point(111, 407);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(195, 22);
            this.genreTextBox.TabIndex = 12;
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.rmid);
            this.tabPage3.Controls.Add(this.m_return);
            this.tabPage3.Controls.Add(this.issue);
            this.tabPage3.Controls.Add(rMIDLabel);
            this.tabPage3.Controls.Add(dateRentedLabel);
            this.tabPage3.Controls.Add(this.dateRentedDateTimePicker);
            this.tabPage3.Controls.Add(dateReturnedLabel);
            this.tabPage3.Controls.Add(this.dateReturnedDateTimePicker);
            this.tabPage3.Controls.Add(firstNameLabel1);
            this.tabPage3.Controls.Add(this.cidrent);
            this.tabPage3.Controls.Add(lastNameLabel1);
            this.tabPage3.Controls.Add(this.midrent);
            this.tabPage3.Controls.Add(this.rentalsDataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(854, 488);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Rentals";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // rentalsBindingSource
            // 
            this.rentalsBindingSource.DataMember = "rentals";
            this.rentalsBindingSource.DataSource = this.videoRentalDataSet11;
            // 
            // videoRentalDataSet11
            // 
            this.videoRentalDataSet11.DataSetName = "videoRentalDataSet1";
            this.videoRentalDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateRentedDateTimePicker
            // 
            this.dateRentedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.rentalsBindingSource, "DateRented", true));
            this.dateRentedDateTimePicker.Location = new System.Drawing.Point(506, 321);
            this.dateRentedDateTimePicker.Name = "dateRentedDateTimePicker";
            this.dateRentedDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateRentedDateTimePicker.TabIndex = 4;
            // 
            // dateReturnedDateTimePicker
            // 
            this.dateReturnedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.rentalsBindingSource, "DateReturned", true));
            this.dateReturnedDateTimePicker.Location = new System.Drawing.Point(170, 358);
            this.dateReturnedDateTimePicker.Name = "dateReturnedDateTimePicker";
            this.dateReturnedDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateReturnedDateTimePicker.TabIndex = 6;
           
            // 
            // cidrent
            // 
            this.cidrent.Location = new System.Drawing.Point(170, 399);
            this.cidrent.Name = "cidrent";
            this.cidrent.Size = new System.Drawing.Size(200, 22);
            this.cidrent.TabIndex = 8;
            // 
            // midrent
            // 
            this.midrent.Location = new System.Drawing.Point(506, 360);
            this.midrent.Name = "midrent";
            this.midrent.Size = new System.Drawing.Size(200, 22);
            this.midrent.TabIndex = 10;
            // 
            // rentalsDataGridView
            // 
            this.rentalsDataGridView.AutoGenerateColumns = false;
            this.rentalsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentalsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18});
            this.rentalsDataGridView.DataSource = this.rentalsBindingSource;
            this.rentalsDataGridView.Location = new System.Drawing.Point(15, 16);
            this.rentalsDataGridView.Name = "rentalsDataGridView";
            this.rentalsDataGridView.RowHeadersWidth = 51;
            this.rentalsDataGridView.RowTemplate.Height = 24;
            this.rentalsDataGridView.Size = new System.Drawing.Size(824, 283);
            this.rentalsDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "RMID";
            this.dataGridViewTextBoxColumn12.HeaderText = "RMID";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "DateRented";
            this.dataGridViewTextBoxColumn13.HeaderText = "DateRented";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "DateReturned";
            this.dataGridViewTextBoxColumn14.HeaderText = "DateReturned";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 125;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn15.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 125;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn16.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 125;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn17.HeaderText = "Title";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 125;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "RentalCost";
            this.dataGridViewTextBoxColumn18.HeaderText = "RentalCost";
            this.dataGridViewTextBoxColumn18.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Width = 125;
            // 
            // customerBindingSource2
            // 
            this.customerBindingSource2.DataMember = "customer";
            this.customerBindingSource2.DataSource = this.videoRentalDataSet11;
            // 
            // moviesBindingSource1
            // 
            this.moviesBindingSource1.DataMember = "movies";
            this.moviesBindingSource1.DataSource = this.videoRentalDataSet2;
            // 
            // videoRentalDataSet2
            // 
            this.videoRentalDataSet2.DataSetName = "videoRentalDataSet2";
            this.videoRentalDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // moviesBindingSource
            // 
            this.moviesBindingSource.DataMember = "movies";
            this.moviesBindingSource.DataSource = this.videoRentalDataSet11;
            // 
            // customerTableAdapter1
            // 
            this.customerTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.customerTableAdapter = this.customerTableAdapter1;
            this.tableAdapterManager1.moviesTableAdapter = this.moviesTableAdapter;
            this.tableAdapterManager1.UpdateOrder = videoRentalSystem.videoRentalDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // moviesTableAdapter
            // 
            this.moviesTableAdapter.ClearBeforeFill = true;
            // 
            // rentalsTableAdapter
            // 
            this.rentalsTableAdapter.ClearBeforeFill = true;
            // 
            // moviesTableAdapter1
            // 
            this.moviesTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.customerTableAdapter = null;
            this.tableAdapterManager2.moviesTableAdapter = this.moviesTableAdapter1;
            this.tableAdapterManager2.rentalsTableAdapter = null;
            this.tableAdapterManager2.UpdateOrder = videoRentalSystem.videoRentalDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customerTableAdapter2
            // 
            this.customerTableAdapter2.ClearBeforeFill = true;
            // 
            // tableAdapterManager3
            // 
            this.tableAdapterManager3.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager3.customerTableAdapter = this.customerTableAdapter2;
            this.tableAdapterManager3.moviesTableAdapter = this.moviesTableAdapter2;
            this.tableAdapterManager3.rentalsTableAdapter = null;
            this.tableAdapterManager3.UpdateOrder = videoRentalSystem.videoRentalDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // moviesTableAdapter2
            // 
            this.moviesTableAdapter2.ClearBeforeFill = true;
            // 
            // issue
            // 
            this.issue.Location = new System.Drawing.Point(411, 404);
            this.issue.Name = "issue";
            this.issue.Size = new System.Drawing.Size(169, 51);
            this.issue.TabIndex = 11;
            this.issue.Text = "Issue Movie";
            this.issue.UseVisualStyleBackColor = true;
            this.issue.Click += new System.EventHandler(this.issue_Click);
            // 
            // m_return
            // 
            this.m_return.Location = new System.Drawing.Point(612, 404);
            this.m_return.Name = "m_return";
            this.m_return.Size = new System.Drawing.Size(169, 51);
            this.m_return.TabIndex = 12;
            this.m_return.Text = "Return Movie";
            this.m_return.UseVisualStyleBackColor = true;
            this.m_return.Click += new System.EventHandler(this.m_return_Click);
            // 
            // rmid
            // 
            this.rmid.AutoSize = true;
            this.rmid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rentalsBindingSource, "RMID", true));
            this.rmid.Location = new System.Drawing.Point(170, 317);
            this.rmid.Name = "rmid";
            this.rmid.Size = new System.Drawing.Size(0, 17);
            this.rmid.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 552);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.videoRentalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoRentalDataSet1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoRentalDataSet3)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentalsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoRentalDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoRentalDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private videoRentalDataSet videoRentalDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private videoRentalDataSetTableAdapters.customerTableAdapter customerTableAdapter;
        private videoRentalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private videoRentalDataSet videoRentalDataSet1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private videoRentalDataSet1 videoRentalDataSet11;
        private System.Windows.Forms.BindingSource customerBindingSource2;
        private videoRentalDataSet1TableAdapters.customerTableAdapter customerTableAdapter1;
        private videoRentalDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private videoRentalDataSet1TableAdapters.moviesTableAdapter moviesTableAdapter;
        private System.Windows.Forms.BindingSource moviesBindingSource;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox ratingTextBox;
        private System.Windows.Forms.TextBox genreTextBox;
        private videoRentalDataSet1TableAdapters.rentalsTableAdapter rentalsTableAdapter;
        private System.Windows.Forms.BindingSource rentalsBindingSource;
        private System.Windows.Forms.DateTimePicker dateRentedDateTimePicker;
        private System.Windows.Forms.DateTimePicker dateReturnedDateTimePicker;
        private System.Windows.Forms.TextBox cidrent;
        private System.Windows.Forms.TextBox midrent;
        private System.Windows.Forms.DataGridView rentalsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.Button cus_add;
        private System.Windows.Forms.Button cus_delete;
        private System.Windows.Forms.Button cus_update;
        private System.Windows.Forms.Label CusID;
        private System.Windows.Forms.Button delete_movie;
        private System.Windows.Forms.Button update_movie;
        private System.Windows.Forms.Button Add_movie;
        private System.Windows.Forms.Label mid;
        private videoRentalDataSet2 videoRentalDataSet2;
        private System.Windows.Forms.BindingSource moviesBindingSource1;
        private videoRentalDataSet2TableAdapters.moviesTableAdapter moviesTableAdapter1;
        private videoRentalDataSet2TableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.DateTimePicker yearDateTimePicker;
        private System.Windows.Forms.Label label1;
        private videoRentalDataSet3 videoRentalDataSet3;
        private System.Windows.Forms.BindingSource customerBindingSource3;
        private videoRentalDataSet3TableAdapters.customerTableAdapter customerTableAdapter2;
        private videoRentalDataSet3TableAdapters.TableAdapterManager tableAdapterManager3;
        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private videoRentalDataSet3TableAdapters.moviesTableAdapter moviesTableAdapter2;
        private System.Windows.Forms.BindingSource moviesBindingSource2;
        private System.Windows.Forms.DataGridView moviesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Button m_return;
        private System.Windows.Forms.Button issue;
        private System.Windows.Forms.Label rmid;
    }
}

