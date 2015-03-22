namespace ProjectProg
{
    partial class AddTransactionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTransactionForm));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxTransaction = new System.Windows.Forms.GroupBox();
            this.buttonCreateTransaction = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCustomerID = new System.Windows.Forms.ComboBox();
            this.comboBoxStaffID = new System.Windows.Forms.ComboBox();
            this.textBoxTransactionID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxFindID = new System.Windows.Forms.GroupBox();
            this.textBoxInputStaffName = new System.Windows.Forms.TextBox();
            this.listBoxStaffID = new System.Windows.Forms.ListBox();
            this.listBoxCustID = new System.Windows.Forms.ListBox();
            this.textBoxInputCustName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBoxTrDetail = new System.Windows.Forms.GroupBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.buttonRemoveDetail = new System.Windows.Forms.Button();
            this.buttonAddDetail = new System.Windows.Forms.Button();
            this.textBoxServiceName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBoxCustTransaction = new System.Windows.Forms.ListBox();
            this.listBoxServiceID = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBoxTr = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.buttonCreateTr = new System.Windows.Forms.Button();
            this.cmbCustID = new System.Windows.Forms.ComboBox();
            this.cmbStaffID = new System.Windows.Forms.ComboBox();
            this.textBoxTrID = new System.Windows.Forms.TextBox();
            this.labelError = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBoxTransaction.SuspendLayout();
            this.groupBoxFindID.SuspendLayout();
            this.groupBoxTrDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxTr.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Transaction";
            // 
            // groupBoxTransaction
            // 
            this.groupBoxTransaction.Controls.Add(this.buttonCreateTransaction);
            this.groupBoxTransaction.Controls.Add(this.dateTimePicker1);
            this.groupBoxTransaction.Controls.Add(this.comboBoxCustomerID);
            this.groupBoxTransaction.Controls.Add(this.comboBoxStaffID);
            this.groupBoxTransaction.Controls.Add(this.textBoxTransactionID);
            this.groupBoxTransaction.Controls.Add(this.label6);
            this.groupBoxTransaction.Controls.Add(this.label5);
            this.groupBoxTransaction.Controls.Add(this.label4);
            this.groupBoxTransaction.Controls.Add(this.label3);
            this.groupBoxTransaction.Controls.Add(this.label2);
            this.groupBoxTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTransaction.Location = new System.Drawing.Point(13, 54);
            this.groupBoxTransaction.Name = "groupBoxTransaction";
            this.groupBoxTransaction.Size = new System.Drawing.Size(336, 302);
            this.groupBoxTransaction.TabIndex = 1;
            this.groupBoxTransaction.TabStop = false;
            this.groupBoxTransaction.Text = "Transaction";
            // 
            // buttonCreateTransaction
            // 
            this.buttonCreateTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateTransaction.Location = new System.Drawing.Point(154, 196);
            this.buttonCreateTransaction.Name = "buttonCreateTransaction";
            this.buttonCreateTransaction.Size = new System.Drawing.Size(136, 23);
            this.buttonCreateTransaction.TabIndex = 9;
            this.buttonCreateTransaction.Text = "Create Transaction";
            this.buttonCreateTransaction.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(154, 46);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(173, 22);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // comboBoxCustomerID
            // 
            this.comboBoxCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCustomerID.FormattingEnabled = true;
            this.comboBoxCustomerID.Location = new System.Drawing.Point(154, 112);
            this.comboBoxCustomerID.Name = "comboBoxCustomerID";
            this.comboBoxCustomerID.Size = new System.Drawing.Size(173, 24);
            this.comboBoxCustomerID.TabIndex = 7;
            // 
            // comboBoxStaffID
            // 
            this.comboBoxStaffID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStaffID.FormattingEnabled = true;
            this.comboBoxStaffID.Location = new System.Drawing.Point(154, 79);
            this.comboBoxStaffID.Name = "comboBoxStaffID";
            this.comboBoxStaffID.Size = new System.Drawing.Size(173, 24);
            this.comboBoxStaffID.TabIndex = 6;
            // 
            // textBoxTransactionID
            // 
            this.textBoxTransactionID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTransactionID.Location = new System.Drawing.Point(154, 14);
            this.textBoxTransactionID.Name = "textBoxTransactionID";
            this.textBoxTransactionID.Size = new System.Drawing.Size(173, 22);
            this.textBoxTransactionID.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(7, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Error Label";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Customer ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Staff ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Transaction Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Transaction ID :";
            // 
            // groupBoxFindID
            // 
            this.groupBoxFindID.Controls.Add(this.textBoxInputStaffName);
            this.groupBoxFindID.Controls.Add(this.listBoxStaffID);
            this.groupBoxFindID.Controls.Add(this.listBoxCustID);
            this.groupBoxFindID.Controls.Add(this.textBoxInputCustName);
            this.groupBoxFindID.Controls.Add(this.label10);
            this.groupBoxFindID.Controls.Add(this.label9);
            this.groupBoxFindID.Controls.Add(this.label8);
            this.groupBoxFindID.Controls.Add(this.label7);
            this.groupBoxFindID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFindID.Location = new System.Drawing.Point(365, 54);
            this.groupBoxFindID.Name = "groupBoxFindID";
            this.groupBoxFindID.Size = new System.Drawing.Size(342, 302);
            this.groupBoxFindID.TabIndex = 2;
            this.groupBoxFindID.TabStop = false;
            this.groupBoxFindID.Text = "Find ID";
            // 
            // textBoxInputStaffName
            // 
            this.textBoxInputStaffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInputStaffName.Location = new System.Drawing.Point(181, 168);
            this.textBoxInputStaffName.Name = "textBoxInputStaffName";
            this.textBoxInputStaffName.Size = new System.Drawing.Size(155, 22);
            this.textBoxInputStaffName.TabIndex = 7;
            this.textBoxInputStaffName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxInputStaffName_KeyUp);
            // 
            // listBoxStaffID
            // 
            this.listBoxStaffID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxStaffID.FormattingEnabled = true;
            this.listBoxStaffID.ItemHeight = 16;
            this.listBoxStaffID.Location = new System.Drawing.Point(181, 196);
            this.listBoxStaffID.Name = "listBoxStaffID";
            this.listBoxStaffID.Size = new System.Drawing.Size(155, 100);
            this.listBoxStaffID.TabIndex = 6;
            // 
            // listBoxCustID
            // 
            this.listBoxCustID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCustID.FormattingEnabled = true;
            this.listBoxCustID.ItemHeight = 16;
            this.listBoxCustID.Location = new System.Drawing.Point(181, 57);
            this.listBoxCustID.Name = "listBoxCustID";
            this.listBoxCustID.Size = new System.Drawing.Size(155, 100);
            this.listBoxCustID.TabIndex = 5;
            // 
            // textBoxInputCustName
            // 
            this.textBoxInputCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInputCustName.Location = new System.Drawing.Point(181, 26);
            this.textBoxInputCustName.Name = "textBoxInputCustName";
            this.textBoxInputCustName.Size = new System.Drawing.Size(155, 22);
            this.textBoxInputCustName.TabIndex = 4;
            this.textBoxInputCustName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxInputCustName_KeyUp);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "Staff ID :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Input Staff Name :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Customer ID :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Input Customer Name :";
            // 
            // groupBoxTrDetail
            // 
            this.groupBoxTrDetail.Controls.Add(this.buttonCancel);
            this.groupBoxTrDetail.Controls.Add(this.buttonFinish);
            this.groupBoxTrDetail.Controls.Add(this.buttonRemoveDetail);
            this.groupBoxTrDetail.Controls.Add(this.buttonAddDetail);
            this.groupBoxTrDetail.Controls.Add(this.textBoxServiceName);
            this.groupBoxTrDetail.Controls.Add(this.pictureBox1);
            this.groupBoxTrDetail.Controls.Add(this.listBoxCustTransaction);
            this.groupBoxTrDetail.Controls.Add(this.listBoxServiceID);
            this.groupBoxTrDetail.Controls.Add(this.label13);
            this.groupBoxTrDetail.Controls.Add(this.label12);
            this.groupBoxTrDetail.Controls.Add(this.label11);
            this.groupBoxTrDetail.Enabled = false;
            this.groupBoxTrDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTrDetail.Location = new System.Drawing.Point(13, 362);
            this.groupBoxTrDetail.Name = "groupBoxTrDetail";
            this.groupBoxTrDetail.Size = new System.Drawing.Size(694, 255);
            this.groupBoxTrDetail.TabIndex = 3;
            this.groupBoxTrDetail.TabStop = false;
            this.groupBoxTrDetail.Text = "Transaction Detail";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(362, 211);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(117, 28);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonFinish
            // 
            this.buttonFinish.Location = new System.Drawing.Point(362, 177);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(117, 28);
            this.buttonFinish.TabIndex = 9;
            this.buttonFinish.Text = "Finish";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
            // 
            // buttonRemoveDetail
            // 
            this.buttonRemoveDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveDetail.Location = new System.Drawing.Point(361, 93);
            this.buttonRemoveDetail.Name = "buttonRemoveDetail";
            this.buttonRemoveDetail.Size = new System.Drawing.Size(118, 28);
            this.buttonRemoveDetail.TabIndex = 8;
            this.buttonRemoveDetail.Text = "Remove Detail";
            this.buttonRemoveDetail.UseVisualStyleBackColor = true;
            this.buttonRemoveDetail.Click += new System.EventHandler(this.buttonRemoveDetail_Click);
            // 
            // buttonAddDetail
            // 
            this.buttonAddDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddDetail.Location = new System.Drawing.Point(362, 59);
            this.buttonAddDetail.Name = "buttonAddDetail";
            this.buttonAddDetail.Size = new System.Drawing.Size(117, 28);
            this.buttonAddDetail.TabIndex = 7;
            this.buttonAddDetail.Text = "Add Detail";
            this.buttonAddDetail.UseVisualStyleBackColor = true;
            this.buttonAddDetail.Click += new System.EventHandler(this.buttonAddDetail_Click);
            // 
            // textBoxServiceName
            // 
            this.textBoxServiceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxServiceName.Location = new System.Drawing.Point(361, 27);
            this.textBoxServiceName.Name = "textBoxServiceName";
            this.textBoxServiceName.Size = new System.Drawing.Size(118, 22);
            this.textBoxServiceName.TabIndex = 6;
            this.textBoxServiceName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxServiceName_KeyUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(205, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // listBoxCustTransaction
            // 
            this.listBoxCustTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCustTransaction.FormattingEnabled = true;
            this.listBoxCustTransaction.ItemHeight = 16;
            this.listBoxCustTransaction.Location = new System.Drawing.Point(507, 59);
            this.listBoxCustTransaction.Name = "listBoxCustTransaction";
            this.listBoxCustTransaction.Size = new System.Drawing.Size(171, 180);
            this.listBoxCustTransaction.TabIndex = 4;
            this.listBoxCustTransaction.Click += new System.EventHandler(this.listBoxCustTransaction_Click);
            // 
            // listBoxServiceID
            // 
            this.listBoxServiceID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxServiceID.FormattingEnabled = true;
            this.listBoxServiceID.ItemHeight = 16;
            this.listBoxServiceID.Location = new System.Drawing.Point(14, 59);
            this.listBoxServiceID.Name = "listBoxServiceID";
            this.listBoxServiceID.Size = new System.Drawing.Size(169, 180);
            this.listBoxServiceID.TabIndex = 3;
            this.listBoxServiceID.Click += new System.EventHandler(this.listBoxServiceID_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(504, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(139, 16);
            this.label13.TabIndex = 2;
            this.label13.Text = "Customer Transaction";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(202, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 16);
            this.label12.TabIndex = 1;
            this.label12.Text = "Service Name :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(11, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Service ID";
            // 
            // groupBoxTr
            // 
            this.groupBoxTr.Controls.Add(this.dateTimePicker2);
            this.groupBoxTr.Controls.Add(this.buttonCreateTr);
            this.groupBoxTr.Controls.Add(this.cmbCustID);
            this.groupBoxTr.Controls.Add(this.cmbStaffID);
            this.groupBoxTr.Controls.Add(this.textBoxTrID);
            this.groupBoxTr.Controls.Add(this.labelError);
            this.groupBoxTr.Controls.Add(this.label15);
            this.groupBoxTr.Controls.Add(this.label16);
            this.groupBoxTr.Controls.Add(this.label17);
            this.groupBoxTr.Controls.Add(this.label18);
            this.groupBoxTr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTr.Location = new System.Drawing.Point(13, 54);
            this.groupBoxTr.Name = "groupBoxTr";
            this.groupBoxTr.Size = new System.Drawing.Size(336, 302);
            this.groupBoxTr.TabIndex = 1;
            this.groupBoxTr.TabStop = false;
            this.groupBoxTr.Text = "Transaction";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(154, 61);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(173, 22);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // buttonCreateTr
            // 
            this.buttonCreateTr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateTr.Location = new System.Drawing.Point(177, 184);
            this.buttonCreateTr.Name = "buttonCreateTr";
            this.buttonCreateTr.Size = new System.Drawing.Size(136, 28);
            this.buttonCreateTr.TabIndex = 9;
            this.buttonCreateTr.Text = "Create Transaction";
            this.buttonCreateTr.UseVisualStyleBackColor = true;
            this.buttonCreateTr.Click += new System.EventHandler(this.buttonCreateTr_Click);
            // 
            // cmbCustID
            // 
            this.cmbCustID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCustID.FormattingEnabled = true;
            this.cmbCustID.Location = new System.Drawing.Point(154, 117);
            this.cmbCustID.Name = "cmbCustID";
            this.cmbCustID.Size = new System.Drawing.Size(173, 24);
            this.cmbCustID.TabIndex = 7;
            // 
            // cmbStaffID
            // 
            this.cmbStaffID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStaffID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStaffID.FormattingEnabled = true;
            this.cmbStaffID.Location = new System.Drawing.Point(154, 87);
            this.cmbStaffID.Name = "cmbStaffID";
            this.cmbStaffID.Size = new System.Drawing.Size(173, 24);
            this.cmbStaffID.TabIndex = 6;
            // 
            // textBoxTrID
            // 
            this.textBoxTrID.Enabled = false;
            this.textBoxTrID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTrID.Location = new System.Drawing.Point(154, 26);
            this.textBoxTrID.Name = "textBoxTrID";
            this.textBoxTrID.Size = new System.Drawing.Size(173, 22);
            this.textBoxTrID.TabIndex = 5;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(6, 263);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(74, 16);
            this.labelError.TabIndex = 4;
            this.labelError.Text = "Error Label";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(7, 120);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 16);
            this.label15.TabIndex = 3;
            this.label15.Text = "Customer ID :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(7, 90);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 16);
            this.label16.TabIndex = 2;
            this.label16.Text = "Staff ID :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(7, 62);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(117, 16);
            this.label17.TabIndex = 1;
            this.label17.Text = "Transaction Date :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(6, 29);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(101, 16);
            this.label18.TabIndex = 0;
            this.label18.Text = "Transaction ID :";
            // 
            // AddTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(719, 621);
            this.Controls.Add(this.groupBoxTrDetail);
            this.Controls.Add(this.groupBoxFindID);
            this.Controls.Add(this.groupBoxTr);
            this.Controls.Add(this.groupBoxTransaction);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddTransactionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTransactionForm";
            this.Load += new System.EventHandler(this.AddTransactionForm_Load);
            this.groupBoxTransaction.ResumeLayout(false);
            this.groupBoxTransaction.PerformLayout();
            this.groupBoxFindID.ResumeLayout(false);
            this.groupBoxFindID.PerformLayout();
            this.groupBoxTrDetail.ResumeLayout(false);
            this.groupBoxTrDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxTr.ResumeLayout(false);
            this.groupBoxTr.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxTransaction;
        private System.Windows.Forms.Button buttonCreateTransaction;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxCustomerID;
        private System.Windows.Forms.ComboBox comboBoxStaffID;
        private System.Windows.Forms.TextBox textBoxTransactionID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxFindID;
        private System.Windows.Forms.TextBox textBoxInputStaffName;
        private System.Windows.Forms.ListBox listBoxStaffID;
        private System.Windows.Forms.ListBox listBoxCustID;
        private System.Windows.Forms.TextBox textBoxInputCustName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBoxTrDetail;
        private System.Windows.Forms.Button buttonRemoveDetail;
        private System.Windows.Forms.Button buttonAddDetail;
        private System.Windows.Forms.TextBox textBoxServiceName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBoxCustTransaction;
        private System.Windows.Forms.ListBox listBoxServiceID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBoxTr;
        private System.Windows.Forms.Button buttonCreateTr;
        private System.Windows.Forms.ComboBox cmbCustID;
        private System.Windows.Forms.ComboBox cmbStaffID;
        private System.Windows.Forms.TextBox textBoxTrID;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonFinish;
    }
}