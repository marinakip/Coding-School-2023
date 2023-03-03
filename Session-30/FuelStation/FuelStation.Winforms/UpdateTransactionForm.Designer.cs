namespace FuelStation.Winforms {
    partial class UpdateTransactionForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateTransactionForm));
            this.comboBoxPaymentMethod = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTotalValue = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxEmployeeName = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxEmployeeSurname = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxCustomerName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxCustomerSurname = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxPaymentMethod
            // 
            this.comboBoxPaymentMethod.FormattingEnabled = true;
            this.comboBoxPaymentMethod.Location = new System.Drawing.Point(409, 200);
            this.comboBoxPaymentMethod.Name = "comboBoxPaymentMethod";
            this.comboBoxPaymentMethod.Size = new System.Drawing.Size(140, 23);
            this.comboBoxPaymentMethod.TabIndex = 72;
            this.comboBoxPaymentMethod.SelectedIndexChanged += new System.EventHandler(this.comboBoxPaymentMethod_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(251, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 19);
            this.label7.TabIndex = 71;
            this.label7.Text = "Payment Method:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(296, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 19);
            this.label4.TabIndex = 64;
            this.label4.Text = "Total Value:";
            // 
            // textBoxTotalValue
            // 
            this.textBoxTotalValue.Location = new System.Drawing.Point(412, 250);
            this.textBoxTotalValue.Name = "textBoxTotalValue";
            this.textBoxTotalValue.Size = new System.Drawing.Size(137, 23);
            this.textBoxTotalValue.TabIndex = 63;
            this.textBoxTotalValue.TextChanged += new System.EventHandler(this.textBoxTotalValue_TextChanged);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.DarkBlue;
            this.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnOK.FlatAppearance.BorderSize = 2;
            this.btnOK.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOK.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnOK.Location = new System.Drawing.Point(677, 275);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(91, 29);
            this.btnOK.TabIndex = 60;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.FlatAppearance.BorderSize = 2;
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.Location = new System.Drawing.Point(774, 275);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 29);
            this.btnCancel.TabIndex = 59;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(353, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 26);
            this.label1.TabIndex = 58;
            this.label1.Text = "Update Transaction";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(769, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(105, 48);
            this.pictureBox2.TabIndex = 57;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxEmployeeName
            // 
            this.comboBoxEmployeeName.FormattingEnabled = true;
            this.comboBoxEmployeeName.Location = new System.Drawing.Point(591, 142);
            this.comboBoxEmployeeName.Name = "comboBoxEmployeeName";
            this.comboBoxEmployeeName.Size = new System.Drawing.Size(245, 23);
            this.comboBoxEmployeeName.TabIndex = 70;
            this.comboBoxEmployeeName.SelectedIndexChanged += new System.EventHandler(this.comboBoxEmployeeName_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(452, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 19);
            this.label6.TabIndex = 69;
            this.label6.Text = "Employee Name:";
            // 
            // comboBoxEmployeeSurname
            // 
            this.comboBoxEmployeeSurname.FormattingEnabled = true;
            this.comboBoxEmployeeSurname.Location = new System.Drawing.Point(191, 142);
            this.comboBoxEmployeeSurname.Name = "comboBoxEmployeeSurname";
            this.comboBoxEmployeeSurname.Size = new System.Drawing.Size(245, 23);
            this.comboBoxEmployeeSurname.TabIndex = 68;
            this.comboBoxEmployeeSurname.SelectedIndexChanged += new System.EventHandler(this.comboBoxEmployeeSurname_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(33, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 19);
            this.label3.TabIndex = 62;
            this.label3.Text = "Employee Surname:";
            // 
            // comboBoxCustomerName
            // 
            this.comboBoxCustomerName.FormattingEnabled = true;
            this.comboBoxCustomerName.Location = new System.Drawing.Point(591, 98);
            this.comboBoxCustomerName.Name = "comboBoxCustomerName";
            this.comboBoxCustomerName.Size = new System.Drawing.Size(245, 23);
            this.comboBoxCustomerName.TabIndex = 67;
            this.comboBoxCustomerName.SelectedIndexChanged += new System.EventHandler(this.comboBoxCustomerName_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(452, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 19);
            this.label2.TabIndex = 61;
            this.label2.Text = "Customer Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(33, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 19);
            this.label5.TabIndex = 66;
            this.label5.Text = "Customer Surname:";
            // 
            // comboBoxCustomerSurname
            // 
            this.comboBoxCustomerSurname.FormattingEnabled = true;
            this.comboBoxCustomerSurname.Location = new System.Drawing.Point(191, 98);
            this.comboBoxCustomerSurname.Name = "comboBoxCustomerSurname";
            this.comboBoxCustomerSurname.Size = new System.Drawing.Size(245, 23);
            this.comboBoxCustomerSurname.TabIndex = 65;
            this.comboBoxCustomerSurname.SelectedIndexChanged += new System.EventHandler(this.comboBoxCustomerSurname_SelectedIndexChanged);
            // 
            // UpdateTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(876, 316);
            this.Controls.Add(this.comboBoxPaymentMethod);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxEmployeeName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxEmployeeSurname);
            this.Controls.Add(this.comboBoxCustomerName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxCustomerSurname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxTotalValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UpdateTransactionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fuel Pulse Station - Update Transaction";
            this.Load += new System.EventHandler(this.UpdateTransactionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBoxPaymentMethod;
        private Label label7;
        private Label label4;
        private TextBox textBoxTotalValue;
        private Button btnOK;
        private Button btnCancel;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private ComboBox comboBoxEmployeeName;
        private Label label6;
        private ComboBox comboBoxEmployeeSurname;
        private Label label3;
        private ComboBox comboBoxCustomerName;
        private Label label2;
        private Label label5;
        private ComboBox comboBoxCustomerSurname;
    }
}