namespace ProjectProg
{
    partial class AddAppointmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAppointmentForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.textBoxAppointmentID = new System.Windows.Forms.TextBox();
            this.dateTimeAppointment = new System.Windows.Forms.DateTimePicker();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.ScmbFirstHour = new System.Windows.Forms.ComboBox();
            this.EcmbFirstHour = new System.Windows.Forms.ComboBox();
            this.ScmbSecondHour = new System.Windows.Forms.ComboBox();
            this.EcmbSecondHour = new System.Windows.Forms.ComboBox();
            this.cmbStaffID = new System.Windows.Forms.ComboBox();
            this.ScmbFirstMinute = new System.Windows.Forms.ComboBox();
            this.EcmbFirstMinute = new System.Windows.Forms.ComboBox();
            this.ScmbSecondMinute = new System.Windows.Forms.ComboBox();
            this.EcmbSecondMinute = new System.Windows.Forms.ComboBox();
            this.cmbCustID = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Appointment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Appointment ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Start Time :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "End Time :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Customer ID :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Staff ID :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Description :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(233, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(233, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = ":";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(349, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "WIB";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(349, 146);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "WIB";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(23, 275);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(74, 16);
            this.labelError.TabIndex = 12;
            this.labelError.Text = "Error Label";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(168, 316);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 13;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // textBoxAppointmentID
            // 
            this.textBoxAppointmentID.Enabled = false;
            this.textBoxAppointmentID.Location = new System.Drawing.Point(133, 66);
            this.textBoxAppointmentID.Name = "textBoxAppointmentID";
            this.textBoxAppointmentID.Size = new System.Drawing.Size(210, 20);
            this.textBoxAppointmentID.TabIndex = 14;
            // 
            // dateTimeAppointment
            // 
            this.dateTimeAppointment.Location = new System.Drawing.Point(133, 92);
            this.dateTimeAppointment.Name = "dateTimeAppointment";
            this.dateTimeAppointment.Size = new System.Drawing.Size(210, 20);
            this.dateTimeAppointment.TabIndex = 15;
            this.dateTimeAppointment.Value = new System.DateTime(2013, 5, 29, 0, 0, 0, 0);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(133, 226);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(210, 20);
            this.textBoxDescription.TabIndex = 16;
            // 
            // ScmbFirstHour
            // 
            this.ScmbFirstHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ScmbFirstHour.FormattingEnabled = true;
            this.ScmbFirstHour.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.ScmbFirstHour.Location = new System.Drawing.Point(133, 118);
            this.ScmbFirstHour.Name = "ScmbFirstHour";
            this.ScmbFirstHour.Size = new System.Drawing.Size(44, 21);
            this.ScmbFirstHour.TabIndex = 17;
            // 
            // EcmbFirstHour
            // 
            this.EcmbFirstHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EcmbFirstHour.FormattingEnabled = true;
            this.EcmbFirstHour.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.EcmbFirstHour.Location = new System.Drawing.Point(133, 145);
            this.EcmbFirstHour.Name = "EcmbFirstHour";
            this.EcmbFirstHour.Size = new System.Drawing.Size(44, 21);
            this.EcmbFirstHour.TabIndex = 18;
            // 
            // ScmbSecondHour
            // 
            this.ScmbSecondHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ScmbSecondHour.FormattingEnabled = true;
            this.ScmbSecondHour.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.ScmbSecondHour.Location = new System.Drawing.Point(183, 118);
            this.ScmbSecondHour.Name = "ScmbSecondHour";
            this.ScmbSecondHour.Size = new System.Drawing.Size(44, 21);
            this.ScmbSecondHour.TabIndex = 19;
            // 
            // EcmbSecondHour
            // 
            this.EcmbSecondHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EcmbSecondHour.FormattingEnabled = true;
            this.EcmbSecondHour.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.EcmbSecondHour.Location = new System.Drawing.Point(183, 145);
            this.EcmbSecondHour.Name = "EcmbSecondHour";
            this.EcmbSecondHour.Size = new System.Drawing.Size(44, 21);
            this.EcmbSecondHour.TabIndex = 20;
            // 
            // cmbStaffID
            // 
            this.cmbStaffID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStaffID.FormattingEnabled = true;
            this.cmbStaffID.Location = new System.Drawing.Point(133, 199);
            this.cmbStaffID.Name = "cmbStaffID";
            this.cmbStaffID.Size = new System.Drawing.Size(210, 21);
            this.cmbStaffID.TabIndex = 22;
            // 
            // ScmbFirstMinute
            // 
            this.ScmbFirstMinute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ScmbFirstMinute.FormattingEnabled = true;
            this.ScmbFirstMinute.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.ScmbFirstMinute.Location = new System.Drawing.Point(249, 118);
            this.ScmbFirstMinute.Name = "ScmbFirstMinute";
            this.ScmbFirstMinute.Size = new System.Drawing.Size(44, 21);
            this.ScmbFirstMinute.TabIndex = 23;
            // 
            // EcmbFirstMinute
            // 
            this.EcmbFirstMinute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EcmbFirstMinute.FormattingEnabled = true;
            this.EcmbFirstMinute.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.EcmbFirstMinute.Location = new System.Drawing.Point(249, 145);
            this.EcmbFirstMinute.Name = "EcmbFirstMinute";
            this.EcmbFirstMinute.Size = new System.Drawing.Size(44, 21);
            this.EcmbFirstMinute.TabIndex = 24;
            // 
            // ScmbSecondMinute
            // 
            this.ScmbSecondMinute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ScmbSecondMinute.FormattingEnabled = true;
            this.ScmbSecondMinute.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.ScmbSecondMinute.Location = new System.Drawing.Point(299, 118);
            this.ScmbSecondMinute.Name = "ScmbSecondMinute";
            this.ScmbSecondMinute.Size = new System.Drawing.Size(44, 21);
            this.ScmbSecondMinute.TabIndex = 25;
            // 
            // EcmbSecondMinute
            // 
            this.EcmbSecondMinute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EcmbSecondMinute.FormattingEnabled = true;
            this.EcmbSecondMinute.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.EcmbSecondMinute.Location = new System.Drawing.Point(299, 145);
            this.EcmbSecondMinute.Name = "EcmbSecondMinute";
            this.EcmbSecondMinute.Size = new System.Drawing.Size(44, 21);
            this.EcmbSecondMinute.TabIndex = 26;
            // 
            // cmbCustID
            // 
            this.cmbCustID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustID.FormattingEnabled = true;
            this.cmbCustID.Location = new System.Drawing.Point(133, 172);
            this.cmbCustID.Name = "cmbCustID";
            this.cmbCustID.Size = new System.Drawing.Size(210, 21);
            this.cmbCustID.TabIndex = 21;
            // 
            // AddAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(402, 359);
            this.Controls.Add(this.EcmbSecondMinute);
            this.Controls.Add(this.ScmbSecondMinute);
            this.Controls.Add(this.EcmbFirstMinute);
            this.Controls.Add(this.ScmbFirstMinute);
            this.Controls.Add(this.cmbStaffID);
            this.Controls.Add(this.cmbCustID);
            this.Controls.Add(this.EcmbSecondHour);
            this.Controls.Add(this.ScmbSecondHour);
            this.Controls.Add(this.EcmbFirstHour);
            this.Controls.Add(this.ScmbFirstHour);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.dateTimeAppointment);
            this.Controls.Add(this.textBoxAppointmentID);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddAppointmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Appointment";
            this.Load += new System.EventHandler(this.AddAppointmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.TextBox textBoxAppointmentID;
        private System.Windows.Forms.DateTimePicker dateTimeAppointment;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.ComboBox ScmbFirstHour;
        private System.Windows.Forms.ComboBox EcmbFirstHour;
        private System.Windows.Forms.ComboBox ScmbSecondHour;
        private System.Windows.Forms.ComboBox EcmbSecondHour;
        private System.Windows.Forms.ComboBox cmbStaffID;
        private System.Windows.Forms.ComboBox ScmbFirstMinute;
        private System.Windows.Forms.ComboBox EcmbFirstMinute;
        private System.Windows.Forms.ComboBox ScmbSecondMinute;
        private System.Windows.Forms.ComboBox EcmbSecondMinute;
        private System.Windows.Forms.ComboBox cmbCustID;
    }
}