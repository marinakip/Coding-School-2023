namespace FuelStation.Winforms {
    partial class ManagerForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.btnTransactions = new System.Windows.Forms.Button();
            this.btnItems = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTransactions
            // 
            this.btnTransactions.BackColor = System.Drawing.Color.Transparent;
            this.btnTransactions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTransactions.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTransactions.FlatAppearance.BorderSize = 2;
            this.btnTransactions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTransactions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactions.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTransactions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTransactions.Location = new System.Drawing.Point(325, 281);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(107, 39);
            this.btnTransactions.TabIndex = 7;
            this.btnTransactions.Text = "Transactions";
            this.btnTransactions.UseVisualStyleBackColor = false;
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // btnItems
            // 
            this.btnItems.BackColor = System.Drawing.Color.Transparent;
            this.btnItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnItems.FlatAppearance.BorderColor = System.Drawing.Color.PeachPuff;
            this.btnItems.FlatAppearance.BorderSize = 2;
            this.btnItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItems.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnItems.ForeColor = System.Drawing.Color.PeachPuff;
            this.btnItems.Location = new System.Drawing.Point(177, 281);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(107, 39);
            this.btnItems.TabIndex = 6;
            this.btnItems.Text = "Items";
            this.btnItems.UseVisualStyleBackColor = false;
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCustomers.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite;
            this.btnCustomers.FlatAppearance.BorderSize = 2;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCustomers.ForeColor = System.Drawing.Color.Snow;
            this.btnCustomers.Location = new System.Drawing.Point(33, 281);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(107, 39);
            this.btnCustomers.TabIndex = 5;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(365, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(101, 42);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(469, 351);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnTransactions);
            this.Controls.Add(this.btnItems);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fuel Pulse Station - Manager";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnTransactions;
        private Button btnItems;
        private Button btnCustomers;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}