namespace Session_16 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnTestDatabase = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnStoreManagement = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.lbStoreManagement = new System.Windows.Forms.Label();
            this.lbEmployees = new System.Windows.Forms.Label();
            this.lbCustomers = new System.Windows.Forms.Label();
            this.lbOrders = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTestDatabase
            // 
            this.btnTestDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTestDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnTestDatabase.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnTestDatabase.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTestDatabase.Location = new System.Drawing.Point(12, 604);
            this.btnTestDatabase.Name = "btnTestDatabase";
            this.btnTestDatabase.Size = new System.Drawing.Size(161, 26);
            this.btnTestDatabase.TabIndex = 0;
            this.btnTestDatabase.Text = "Test Database Connection";
            this.btnTestDatabase.UseVisualStyleBackColor = false;
            this.btnTestDatabase.Click += new System.EventHandler(this.btnTestDatabase_Click);
            // 
            // picLogo
            // 
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(1272, 278);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // btnStoreManagement
            // 
            this.btnStoreManagement.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStoreManagement.BackgroundImage")));
            this.btnStoreManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStoreManagement.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStoreManagement.FlatAppearance.BorderSize = 10;
            this.btnStoreManagement.Location = new System.Drawing.Point(408, 330);
            this.btnStoreManagement.Name = "btnStoreManagement";
            this.btnStoreManagement.Size = new System.Drawing.Size(91, 79);
            this.btnStoreManagement.TabIndex = 2;
            this.btnStoreManagement.UseVisualStyleBackColor = true;
            this.btnStoreManagement.Click += new System.EventHandler(this.btnStoreManagement_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEmployees.BackgroundImage")));
            this.btnEmployees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEmployees.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEmployees.FlatAppearance.BorderSize = 10;
            this.btnEmployees.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEmployees.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEmployees.Location = new System.Drawing.Point(599, 330);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(91, 79);
            this.btnEmployees.TabIndex = 3;
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCustomers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCustomers.BackgroundImage")));
            this.btnCustomers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCustomers.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCustomers.FlatAppearance.BorderSize = 10;
            this.btnCustomers.Location = new System.Drawing.Point(789, 330);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(91, 79);
            this.btnCustomers.TabIndex = 4;
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrders.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOrders.BackgroundImage")));
            this.btnOrders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOrders.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOrders.FlatAppearance.BorderSize = 10;
            this.btnOrders.Location = new System.Drawing.Point(599, 486);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(91, 79);
            this.btnOrders.TabIndex = 5;
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // lbStoreManagement
            // 
            this.lbStoreManagement.AutoSize = true;
            this.lbStoreManagement.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbStoreManagement.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbStoreManagement.Location = new System.Drawing.Point(371, 421);
            this.lbStoreManagement.Name = "lbStoreManagement";
            this.lbStoreManagement.Size = new System.Drawing.Size(163, 23);
            this.lbStoreManagement.TabIndex = 6;
            this.lbStoreManagement.Text = "Store Management";
            // 
            // lbEmployees
            // 
            this.lbEmployees.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbEmployees.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbEmployees.Location = new System.Drawing.Point(599, 421);
            this.lbEmployees.Name = "lbEmployees";
            this.lbEmployees.Size = new System.Drawing.Size(96, 23);
            this.lbEmployees.TabIndex = 7;
            this.lbEmployees.Text = "Employees";
            // 
            // lbCustomers
            // 
            this.lbCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCustomers.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCustomers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCustomers.Location = new System.Drawing.Point(789, 421);
            this.lbCustomers.Name = "lbCustomers";
            this.lbCustomers.Size = new System.Drawing.Size(95, 23);
            this.lbCustomers.TabIndex = 8;
            this.lbCustomers.Text = "Customers";
            // 
            // lbOrders
            // 
            this.lbOrders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbOrders.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbOrders.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbOrders.Location = new System.Drawing.Point(612, 579);
            this.lbOrders.Name = "lbOrders";
            this.lbOrders.Size = new System.Drawing.Size(65, 23);
            this.lbOrders.TabIndex = 9;
            this.lbOrders.Text = "Orders";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1272, 642);
            this.Controls.Add(this.lbOrders);
            this.Controls.Add(this.lbCustomers);
            this.Controls.Add(this.lbEmployees);
            this.Controls.Add(this.lbStoreManagement);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.btnStoreManagement);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnTestDatabase);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fur Ever Friends Pet Shop";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnTestDatabase;
        private PictureBox picLogo;
        private Button btnStoreManagement;
        private Button btnEmployees;
        private Button btnCustomers;
        private Button btnOrders;
        private Label lbStoreManagement;
        private Label lbEmployees;
        private Label lbCustomers;
        private Label lbOrders;
    }
}