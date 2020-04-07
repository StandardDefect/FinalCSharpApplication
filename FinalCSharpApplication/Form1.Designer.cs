namespace FinalCSharpApplication
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
            this.cboxStudent = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.textDateofBirth = new System.Windows.Forms.TextBox();
            this.textSex = new System.Windows.Forms.TextBox();
            this.textMajor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textCourseName = new System.Windows.Forms.TextBox();
            this.textCreditHours = new System.Windows.Forms.TextBox();
            this.textCollege = new System.Windows.Forms.TextBox();
            this.textOnline = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textSection = new System.Windows.Forms.TextBox();
            this.textStartDate = new System.Windows.Forms.TextBox();
            this.textEndDate = new System.Windows.Forms.TextBox();
            this.textTime = new System.Windows.Forms.TextBox();
            this.textClassSize = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lboxCourse = new System.Windows.Forms.ListBox();
            this.dgvRegistration = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistration)).BeginInit();
            this.SuspendLayout();
            // 
            // cboxStudent
            // 
            this.cboxStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxStudent.FormattingEnabled = true;
            this.cboxStudent.Location = new System.Drawing.Point(40, 43);
            this.cboxStudent.Name = "cboxStudent";
            this.cboxStudent.Size = new System.Drawing.Size(121, 21);
            this.cboxStudent.TabIndex = 0;
            this.cboxStudent.SelectedIndexChanged += new System.EventHandler(this.cboxStudent_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Student:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Date of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Sex";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Major";
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(108, 215);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(100, 20);
            this.textFirstName.TabIndex = 7;
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(108, 249);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(100, 20);
            this.textLastName.TabIndex = 8;
            // 
            // textDateofBirth
            // 
            this.textDateofBirth.Location = new System.Drawing.Point(108, 284);
            this.textDateofBirth.Name = "textDateofBirth";
            this.textDateofBirth.Size = new System.Drawing.Size(100, 20);
            this.textDateofBirth.TabIndex = 9;
            // 
            // textSex
            // 
            this.textSex.Location = new System.Drawing.Point(108, 320);
            this.textSex.Name = "textSex";
            this.textSex.Size = new System.Drawing.Size(100, 20);
            this.textSex.TabIndex = 10;
            // 
            // textMajor
            // 
            this.textMajor.Location = new System.Drawing.Point(108, 356);
            this.textMajor.Name = "textMajor";
            this.textMajor.Size = new System.Drawing.Size(100, 20);
            this.textMajor.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(272, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Course Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(272, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Credit Hours";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(272, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "College";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(272, 323);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Online?";
            // 
            // textCourseName
            // 
            this.textCourseName.Location = new System.Drawing.Point(383, 215);
            this.textCourseName.Name = "textCourseName";
            this.textCourseName.Size = new System.Drawing.Size(100, 20);
            this.textCourseName.TabIndex = 16;
            // 
            // textCreditHours
            // 
            this.textCreditHours.Location = new System.Drawing.Point(383, 249);
            this.textCreditHours.Name = "textCreditHours";
            this.textCreditHours.Size = new System.Drawing.Size(100, 20);
            this.textCreditHours.TabIndex = 17;
            // 
            // textCollege
            // 
            this.textCollege.Location = new System.Drawing.Point(383, 284);
            this.textCollege.Name = "textCollege";
            this.textCollege.Size = new System.Drawing.Size(100, 20);
            this.textCollege.TabIndex = 18;
            // 
            // textOnline
            // 
            this.textOnline.Location = new System.Drawing.Point(383, 320);
            this.textOnline.Name = "textOnline";
            this.textOnline.Size = new System.Drawing.Size(100, 20);
            this.textOnline.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(559, 218);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Section";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(559, 252);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Start Date";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(559, 287);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "End Date";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(559, 323);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Time";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(559, 359);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "Class Size";
            // 
            // textSection
            // 
            this.textSection.Location = new System.Drawing.Point(652, 215);
            this.textSection.Name = "textSection";
            this.textSection.Size = new System.Drawing.Size(100, 20);
            this.textSection.TabIndex = 25;
            // 
            // textStartDate
            // 
            this.textStartDate.Location = new System.Drawing.Point(652, 249);
            this.textStartDate.Name = "textStartDate";
            this.textStartDate.Size = new System.Drawing.Size(100, 20);
            this.textStartDate.TabIndex = 26;
            // 
            // textEndDate
            // 
            this.textEndDate.Location = new System.Drawing.Point(652, 284);
            this.textEndDate.Name = "textEndDate";
            this.textEndDate.Size = new System.Drawing.Size(100, 20);
            this.textEndDate.TabIndex = 27;
            // 
            // textTime
            // 
            this.textTime.Location = new System.Drawing.Point(652, 320);
            this.textTime.Name = "textTime";
            this.textTime.Size = new System.Drawing.Size(100, 20);
            this.textTime.TabIndex = 28;
            // 
            // textClassSize
            // 
            this.textClassSize.Location = new System.Drawing.Point(652, 356);
            this.textClassSize.Name = "textClassSize";
            this.textClassSize.Size = new System.Drawing.Size(100, 20);
            this.textClassSize.TabIndex = 29;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(546, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "Registration List:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(281, 24);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 13);
            this.label17.TabIndex = 31;
            this.label17.Text = "Select Course:";
            // 
            // lboxCourse
            // 
            this.lboxCourse.FormattingEnabled = true;
            this.lboxCourse.Location = new System.Drawing.Point(284, 43);
            this.lboxCourse.Name = "lboxCourse";
            this.lboxCourse.Size = new System.Drawing.Size(180, 95);
            this.lboxCourse.TabIndex = 32;
            this.lboxCourse.SelectedIndexChanged += new System.EventHandler(this.lboxCourse_SelectedIndexChanged);
            // 
            // dgvRegistration
            // 
            this.dgvRegistration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistration.Location = new System.Drawing.Point(549, 43);
            this.dgvRegistration.Name = "dgvRegistration";
            this.dgvRegistration.Size = new System.Drawing.Size(475, 151);
            this.dgvRegistration.TabIndex = 33;
            this.dgvRegistration.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistration_CellContentClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1043, 43);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 59);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(1124, 43);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 59);
            this.btnInsert.TabIndex = 35;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1205, 43);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 59);
            this.btnDelete.TabIndex = 36;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(1076, 356);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 59);
            this.btnRefresh.TabIndex = 37;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1182, 356);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 59);
            this.btnExit.TabIndex = 38;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 431);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvRegistration);
            this.Controls.Add(this.lboxCourse);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textClassSize);
            this.Controls.Add(this.textTime);
            this.Controls.Add(this.textEndDate);
            this.Controls.Add(this.textStartDate);
            this.Controls.Add(this.textSection);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textOnline);
            this.Controls.Add(this.textCollege);
            this.Controls.Add(this.textCreditHours);
            this.Controls.Add(this.textCourseName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textMajor);
            this.Controls.Add(this.textSex);
            this.Controls.Add(this.textDateofBirth);
            this.Controls.Add(this.textLastName);
            this.Controls.Add(this.textFirstName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxStudent);
            this.Name = "Form1";
            this.Text = "ISYS 4283 C# Assignment- Samuel Lipson";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.TextBox textDateofBirth;
        private System.Windows.Forms.TextBox textSex;
        private System.Windows.Forms.TextBox textMajor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textCourseName;
        private System.Windows.Forms.TextBox textCreditHours;
        private System.Windows.Forms.TextBox textCollege;
        private System.Windows.Forms.TextBox textOnline;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textSection;
        private System.Windows.Forms.TextBox textStartDate;
        private System.Windows.Forms.TextBox textEndDate;
        private System.Windows.Forms.TextBox textTime;
        private System.Windows.Forms.TextBox textClassSize;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ListBox lboxCourse;
        private System.Windows.Forms.DataGridView dgvRegistration;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnExit;
    }
}

