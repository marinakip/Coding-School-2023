namespace Session_10 {
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
            this.grvStudents = new System.Windows.Forms.DataGridView();
            this.grvGrades = new System.Windows.Forms.DataGridView();
            this.grvCourses = new System.Windows.Forms.DataGridView();
            this.grvScheduledCourses = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvGrades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvScheduledCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // grvStudents
            // 
            this.grvStudents.BackgroundColor = System.Drawing.Color.Linen;
            this.grvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvStudents.Location = new System.Drawing.Point(22, 59);
            this.grvStudents.Name = "grvStudents";
            this.grvStudents.RowTemplate.Height = 25;
            this.grvStudents.Size = new System.Drawing.Size(932, 130);
            this.grvStudents.TabIndex = 0;
            // 
            // grvGrades
            // 
            this.grvGrades.BackgroundColor = System.Drawing.Color.Linen;
            this.grvGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvGrades.Location = new System.Drawing.Point(22, 195);
            this.grvGrades.Name = "grvGrades";
            this.grvGrades.RowTemplate.Height = 25;
            this.grvGrades.Size = new System.Drawing.Size(932, 130);
            this.grvGrades.TabIndex = 1;
            // 
            // grvCourses
            // 
            this.grvCourses.BackgroundColor = System.Drawing.Color.Linen;
            this.grvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvCourses.Location = new System.Drawing.Point(22, 331);
            this.grvCourses.Name = "grvCourses";
            this.grvCourses.RowTemplate.Height = 25;
            this.grvCourses.Size = new System.Drawing.Size(932, 130);
            this.grvCourses.TabIndex = 2;
            // 
            // grvScheduledCourses
            // 
            this.grvScheduledCourses.BackgroundColor = System.Drawing.Color.Linen;
            this.grvScheduledCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvScheduledCourses.Location = new System.Drawing.Point(22, 467);
            this.grvScheduledCourses.Name = "grvScheduledCourses";
            this.grvScheduledCourses.RowTemplate.Height = 25;
            this.grvScheduledCourses.Size = new System.Drawing.Size(932, 130);
            this.grvScheduledCourses.TabIndex = 3;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Teal;
            this.btnLoad.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.btnLoad.FlatAppearance.BorderSize = 10;
            this.btnLoad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLoad.ForeColor = System.Drawing.Color.Snow;
            this.btnLoad.Location = new System.Drawing.Point(22, 23);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(83, 30);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Navy;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.btnSave.FlatAppearance.BorderSize = 10;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.Snow;
            this.btnSave.Location = new System.Drawing.Point(871, 603);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 30);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(980, 648);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.grvScheduledCourses);
            this.Controls.Add(this.grvCourses);
            this.Controls.Add(this.grvGrades);
            this.Controls.Add(this.grvStudents);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvGrades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvScheduledCourses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView grvStudents;
        private DataGridView grvGrades;
        private DataGridView grvCourses;
        private DataGridView grvScheduledCourses;
        private Button btnLoad;
        private Button btnSave;
    }
}