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
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelStudents = new System.Windows.Forms.Label();
            this.labelGrades = new System.Windows.Forms.Label();
            this.labelCourses = new System.Windows.Forms.Label();
            this.labelSceduledCourses = new System.Windows.Forms.Label();
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
            this.grvStudents.Location = new System.Drawing.Point(22, 92);
            this.grvStudents.Name = "grvStudents";
            this.grvStudents.RowTemplate.Height = 25;
            this.grvStudents.Size = new System.Drawing.Size(932, 130);
            this.grvStudents.TabIndex = 0;
            this.grvStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvStudents_CellContentClick);
            // 
            // grvGrades
            // 
            this.grvGrades.BackgroundColor = System.Drawing.Color.Linen;
            this.grvGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvGrades.Location = new System.Drawing.Point(22, 264);
            this.grvGrades.Name = "grvGrades";
            this.grvGrades.RowTemplate.Height = 25;
            this.grvGrades.Size = new System.Drawing.Size(932, 130);
            this.grvGrades.TabIndex = 1;
            // 
            // grvCourses
            // 
            this.grvCourses.BackgroundColor = System.Drawing.Color.Linen;
            this.grvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvCourses.Location = new System.Drawing.Point(22, 437);
            this.grvCourses.Name = "grvCourses";
            this.grvCourses.RowTemplate.Height = 25;
            this.grvCourses.Size = new System.Drawing.Size(932, 130);
            this.grvCourses.TabIndex = 2;
            // 
            // grvScheduledCourses
            // 
            this.grvScheduledCourses.BackgroundColor = System.Drawing.Color.Linen;
            this.grvScheduledCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvScheduledCourses.Location = new System.Drawing.Point(22, 610);
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
            this.btnLoad.Location = new System.Drawing.Point(22, 22);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(83, 30);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Navy;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.btnSave.FlatAppearance.BorderSize = 10;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.Snow;
            this.btnSave.Location = new System.Drawing.Point(871, 746);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 30);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelHeader.ForeColor = System.Drawing.Color.Snow;
            this.labelHeader.Location = new System.Drawing.Point(376, 20);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(201, 29);
            this.labelHeader.TabIndex = 6;
            this.labelHeader.Text = "University Records";
            // 
            // labelStudents
            // 
            this.labelStudents.AutoSize = true;
            this.labelStudents.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelStudents.ForeColor = System.Drawing.Color.Snow;
            this.labelStudents.Location = new System.Drawing.Point(22, 71);
            this.labelStudents.Name = "labelStudents";
            this.labelStudents.Size = new System.Drawing.Size(63, 18);
            this.labelStudents.TabIndex = 7;
            this.labelStudents.Text = "Students";
            // 
            // labelGrades
            // 
            this.labelGrades.AutoSize = true;
            this.labelGrades.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGrades.ForeColor = System.Drawing.Color.Snow;
            this.labelGrades.Location = new System.Drawing.Point(22, 243);
            this.labelGrades.Name = "labelGrades";
            this.labelGrades.Size = new System.Drawing.Size(52, 18);
            this.labelGrades.TabIndex = 8;
            this.labelGrades.Text = "Grades";
            // 
            // labelCourses
            // 
            this.labelCourses.AutoSize = true;
            this.labelCourses.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCourses.ForeColor = System.Drawing.Color.Snow;
            this.labelCourses.Location = new System.Drawing.Point(22, 416);
            this.labelCourses.Name = "labelCourses";
            this.labelCourses.Size = new System.Drawing.Size(57, 18);
            this.labelCourses.TabIndex = 9;
            this.labelCourses.Text = "Courses";
            // 
            // labelSceduledCourses
            // 
            this.labelSceduledCourses.AutoSize = true;
            this.labelSceduledCourses.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSceduledCourses.ForeColor = System.Drawing.Color.Snow;
            this.labelSceduledCourses.Location = new System.Drawing.Point(22, 589);
            this.labelSceduledCourses.Name = "labelSceduledCourses";
            this.labelSceduledCourses.Size = new System.Drawing.Size(117, 18);
            this.labelSceduledCourses.TabIndex = 10;
            this.labelSceduledCourses.Text = "Sceduled Courses";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(980, 796);
            this.Controls.Add(this.labelSceduledCourses);
            this.Controls.Add(this.labelCourses);
            this.Controls.Add(this.labelGrades);
            this.Controls.Add(this.labelStudents);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.grvScheduledCourses);
            this.Controls.Add(this.grvCourses);
            this.Controls.Add(this.grvGrades);
            this.Controls.Add(this.grvStudents);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvGrades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvScheduledCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView grvStudents;
        private DataGridView grvGrades;
        private DataGridView grvCourses;
        private DataGridView grvScheduledCourses;
        private Button btnLoad;
        private Button btnSave;
        private Label labelHeader;
        private Label labelStudents;
        private Label labelGrades;
        private Label labelCourses;
        private Label labelSceduledCourses;
    }
}