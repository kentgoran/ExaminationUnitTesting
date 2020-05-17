

namespace EmployeeInformation
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.empNoLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.adressLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.dateOfBirth = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.hobbiesLabel = new System.Windows.Forms.Label();
            this.mskTxtEmpNo = new System.Windows.Forms.MaskedTextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.lstState = new System.Windows.Forms.ListBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.chkLstHobbies = new System.Windows.Forms.CheckedListBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.detailsLabel = new System.Windows.Forms.Label();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.multiListBox = new System.Windows.Forms.ListBox();
            this.addTestDataButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.BackColor = System.Drawing.Color.Beige;
            this.headerLabel.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.Navy;
            this.headerLabel.Location = new System.Drawing.Point(213, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(334, 31);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Employee Information";
            // 
            // empNoLabel
            // 
            this.empNoLabel.AutoSize = true;
            this.empNoLabel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empNoLabel.ForeColor = System.Drawing.Color.Navy;
            this.empNoLabel.Location = new System.Drawing.Point(66, 61);
            this.empNoLabel.Name = "empNoLabel";
            this.empNoLabel.Size = new System.Drawing.Size(48, 16);
            this.empNoLabel.TabIndex = 1;
            this.empNoLabel.Text = "EmpNo";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.Navy;
            this.nameLabel.Location = new System.Drawing.Point(73, 95);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(40, 16);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name";
            // 
            // adressLabel
            // 
            this.adressLabel.AutoSize = true;
            this.adressLabel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adressLabel.ForeColor = System.Drawing.Color.Navy;
            this.adressLabel.Location = new System.Drawing.Point(57, 128);
            this.adressLabel.Name = "adressLabel";
            this.adressLabel.Size = new System.Drawing.Size(56, 16);
            this.adressLabel.TabIndex = 3;
            this.adressLabel.Text = "Adress";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.ForeColor = System.Drawing.Color.Navy;
            this.cityLabel.Location = new System.Drawing.Point(66, 240);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(40, 16);
            this.cityLabel.TabIndex = 4;
            this.cityLabel.Text = "City";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateLabel.ForeColor = System.Drawing.Color.Navy;
            this.stateLabel.Location = new System.Drawing.Point(58, 283);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(48, 16);
            this.stateLabel.TabIndex = 5;
            this.stateLabel.Text = "State";
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.AutoSize = true;
            this.dateOfBirth.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirth.ForeColor = System.Drawing.Color.Navy;
            this.dateOfBirth.Location = new System.Drawing.Point(1, 359);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(112, 16);
            this.dateOfBirth.TabIndex = 6;
            this.dateOfBirth.Text = "Date Of Birth";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLabel.ForeColor = System.Drawing.Color.Navy;
            this.ageLabel.Location = new System.Drawing.Point(80, 407);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(32, 16);
            this.ageLabel.TabIndex = 7;
            this.ageLabel.Text = "Age";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabel.ForeColor = System.Drawing.Color.Navy;
            this.genderLabel.Location = new System.Drawing.Point(57, 444);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(56, 16);
            this.genderLabel.TabIndex = 8;
            this.genderLabel.Text = "Gender";
            // 
            // hobbiesLabel
            // 
            this.hobbiesLabel.AutoSize = true;
            this.hobbiesLabel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hobbiesLabel.ForeColor = System.Drawing.Color.Navy;
            this.hobbiesLabel.Location = new System.Drawing.Point(47, 488);
            this.hobbiesLabel.Name = "hobbiesLabel";
            this.hobbiesLabel.Size = new System.Drawing.Size(64, 16);
            this.hobbiesLabel.TabIndex = 9;
            this.hobbiesLabel.Text = "Hobbies";
            // 
            // mskTxtEmpNo
            // 
            this.mskTxtEmpNo.Location = new System.Drawing.Point(122, 59);
            this.mskTxtEmpNo.Mask = "0000";
            this.mskTxtEmpNo.Name = "mskTxtEmpNo";
            this.mskTxtEmpNo.Size = new System.Drawing.Size(100, 20);
            this.mskTxtEmpNo.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(122, 97);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 11;
            // 
            // txtAdress
            // 
            this.txtAdress.AcceptsReturn = true;
            this.txtAdress.Location = new System.Drawing.Point(122, 130);
            this.txtAdress.Multiline = true;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(132, 72);
            this.txtAdress.TabIndex = 12;
            // 
            // cmbCity
            // 
            this.cmbCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCity.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCity.FormattingEnabled = true;
            //Following rows are generated by WinForms as a form of altering the row I wrote:
            //this.cmbCity.DataSource = Enum.GetValues(typeof(City));
            this.cmbCity.Items.AddRange(new object[] {
            EmployeeLibrary.City.Nagpur,
            EmployeeLibrary.City.Pune,
            EmployeeLibrary.City.Mumbai,
            EmployeeLibrary.City.Banglore,
            EmployeeLibrary.City.Nanded,
            EmployeeLibrary.City.Nainital});
            this.cmbCity.Location = new System.Drawing.Point(122, 235);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(121, 22);
            this.cmbCity.TabIndex = 13;
            this.cmbCity.Leave += new System.EventHandler(this.cmbCity_Leave);
            // 
            // lstState
            // 
            this.lstState.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstState.ForeColor = System.Drawing.Color.Navy;
            this.lstState.FormattingEnabled = true;
            this.lstState.ItemHeight = 14;
            //Following rows are generated by WinForms as a form of altering the row I wrote:
            //this.lstState.DataSource = Enum.GetValues(typeof(State));
            this.lstState.Items.AddRange(new object[] {
            EmployeeLibrary.State.Maharastra,
            EmployeeLibrary.State.MP,
            EmployeeLibrary.State.Punjab,
            EmployeeLibrary.State.Karnataka});
            this.lstState.Location = new System.Drawing.Point(122, 283);
            this.lstState.Name = "lstState";
            this.lstState.Size = new System.Drawing.Size(121, 60);
            this.lstState.TabIndex = 14;
            // 
            // dtpDOB
            // 
            this.dtpDOB.CalendarFont = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.CustomFormat = "dd/MM/yyyy";
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(121, 359);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(200, 20);
            this.dtpDOB.TabIndex = 15;
            this.dtpDOB.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // numAge
            // 
            this.numAge.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAge.ForeColor = System.Drawing.Color.Navy;
            this.numAge.Location = new System.Drawing.Point(121, 407);
            this.numAge.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numAge.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(120, 20);
            this.numAge.TabIndex = 16;
            this.numAge.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.radMale);
            this.flowLayoutPanel1.Controls.Add(this.radFemale);
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(121, 440);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(132, 25);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Location = new System.Drawing.Point(3, 3);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(53, 18);
            this.radMale.TabIndex = 0;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Location = new System.Drawing.Point(62, 3);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(67, 18);
            this.radFemale.TabIndex = 1;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Female";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // chkLstHobbies
            // 
            this.chkLstHobbies.CheckOnClick = true;
            this.chkLstHobbies.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLstHobbies.ForeColor = System.Drawing.Color.Navy;
            this.chkLstHobbies.FormattingEnabled = true;
            //Following rows are generated by WinForms as a form of altering the row I wrote:
            //this.chkLstHobbies.DataSource = Enum.GetValues(typeof(Hobby));
            //Also do note, that DataSource is a hidden property of checkListBox, but still accessible
            this.chkLstHobbies.Items.AddRange(new object[] {
            EmployeeLibrary.Hobby.Singing,
            EmployeeLibrary.Hobby.Dancing,
            EmployeeLibrary.Hobby.Painting,
            EmployeeLibrary.Hobby.Shopping,
            EmployeeLibrary.Hobby.Gardening,
            EmployeeLibrary.Hobby.Swimming,
            EmployeeLibrary.Hobby.Sleeping});
            this.chkLstHobbies.Location = new System.Drawing.Point(121, 488);
            this.chkLstHobbies.MultiColumn = true;
            this.chkLstHobbies.Name = "chkLstHobbies";
            this.chkLstHobbies.Size = new System.Drawing.Size(263, 79);
            this.chkLstHobbies.TabIndex = 18;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.detailsLabel);
            this.flowLayoutPanel2.Controls.Add(this.txtDetails);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(493, 43);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(247, 406);
            this.flowLayoutPanel2.TabIndex = 19;
            // 
            // detailsLabel
            // 
            this.detailsLabel.AutoSize = true;
            this.detailsLabel.Location = new System.Drawing.Point(3, 0);
            this.detailsLabel.Name = "detailsLabel";
            this.detailsLabel.Size = new System.Drawing.Size(39, 13);
            this.detailsLabel.TabIndex = 0;
            this.detailsLabel.Text = "Details";
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(10, 22);
            this.txtDetails.Margin = new System.Windows.Forms.Padding(10, 9, 3, 3);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.ReadOnly = true;
            this.txtDetails.Size = new System.Drawing.Size(227, 373);
            this.txtDetails.TabIndex = 1;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.btnSearch);
            this.flowLayoutPanel3.Controls.Add(this.btnReset);
            this.flowLayoutPanel3.Controls.Add(this.btnOK);
            this.flowLayoutPanel3.Controls.Add(this.btnExit);
            this.flowLayoutPanel3.Controls.Add(this.btnUpdate);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(494, 564);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(246, 71);
            this.flowLayoutPanel3.TabIndex = 20;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(3, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(3, 32);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(84, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(84, 32);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(165, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // multiListBox
            // 
            this.multiListBox.FormattingEnabled = true;
            this.multiListBox.Location = new System.Drawing.Point(503, 455);
            this.multiListBox.Name = "multiListBox";
            this.multiListBox.Size = new System.Drawing.Size(227, 95);
            this.multiListBox.TabIndex = 21;
            this.multiListBox.Visible = false;
            this.multiListBox.SelectedIndexChanged += new System.EventHandler(this.multiListBox_SelectedIndexChanged);
            // 
            // addTestDataButton
            // 
            this.addTestDataButton.AutoSize = true;
            this.addTestDataButton.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTestDataButton.Location = new System.Drawing.Point(632, 9);
            this.addTestDataButton.Name = "addTestDataButton";
            this.addTestDataButton.Size = new System.Drawing.Size(108, 24);
            this.addTestDataButton.TabIndex = 22;
            this.addTestDataButton.Text = "Add test data";
            this.addTestDataButton.UseVisualStyleBackColor = true;
            this.addTestDataButton.Click += new System.EventHandler(this.addTestDataButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(752, 651);
            this.Controls.Add(this.addTestDataButton);
            this.Controls.Add(this.multiListBox);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.chkLstHobbies);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.numAge);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.lstState);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.mskTxtEmpNo);
            this.Controls.Add(this.hobbiesLabel);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.dateOfBirth);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.adressLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.empNoLabel);
            this.Controls.Add(this.headerLabel);
            this.ForeColor = System.Drawing.Color.Navy;
            this.Name = "Form1";
            this.Text = "Employee Information";
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label empNoLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label adressLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label dateOfBirth;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label hobbiesLabel;
        private System.Windows.Forms.MaskedTextBox mskTxtEmpNo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.ListBox lstState;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.CheckedListBox chkLstHobbies;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label detailsLabel;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ListBox multiListBox;
        private System.Windows.Forms.Button addTestDataButton;
    }
}

