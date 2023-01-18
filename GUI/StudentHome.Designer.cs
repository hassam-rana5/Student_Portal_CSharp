
namespace STUDENTPORTAL_PROJECT.GUI
{
    partial class StudentHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentHome));
            this.label1 = new System.Windows.Forms.Label();
            this.Attendence = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewAttendence = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Assesments = new System.Windows.Forms.TabPage();
            this.dataGridViewAssesments = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Attendence.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttendence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Assesments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssesments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Ink Free", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(155, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Student Pannel";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Attendence
            // 
            this.Attendence.Controls.Add(this.tabPage1);
            this.Attendence.Controls.Add(this.Assesments);
            this.Attendence.Location = new System.Drawing.Point(8, 2);
            this.Attendence.Margin = new System.Windows.Forms.Padding(2);
            this.Attendence.Name = "Attendence";
            this.Attendence.SelectedIndex = 0;
            this.Attendence.Size = new System.Drawing.Size(875, 486);
            this.Attendence.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewAttendence);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(867, 458);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Attendence";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAttendence
            // 
            this.dataGridViewAttendence.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewAttendence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAttendence.Location = new System.Drawing.Point(18, 117);
            this.dataGridViewAttendence.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewAttendence.Name = "dataGridViewAttendence";
            this.dataGridViewAttendence.RowHeadersWidth = 62;
            this.dataGridViewAttendence.RowTemplate.Height = 33;
            this.dataGridViewAttendence.Size = new System.Drawing.Size(429, 187);
            this.dataGridViewAttendence.TabIndex = 0;
            this.dataGridViewAttendence.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAttendence_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-375, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1237, 446);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Assesments
            // 
            this.Assesments.Controls.Add(this.label2);
            this.Assesments.Controls.Add(this.dataGridViewAssesments);
            this.Assesments.Controls.Add(this.pictureBox2);
            this.Assesments.Location = new System.Drawing.Point(4, 24);
            this.Assesments.Margin = new System.Windows.Forms.Padding(2);
            this.Assesments.Name = "Assesments";
            this.Assesments.Padding = new System.Windows.Forms.Padding(2);
            this.Assesments.Size = new System.Drawing.Size(867, 458);
            this.Assesments.TabIndex = 1;
            this.Assesments.Text = "Assesments";
            this.Assesments.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAssesments
            // 
            this.dataGridViewAssesments.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAssesments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAssesments.Location = new System.Drawing.Point(23, 91);
            this.dataGridViewAssesments.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewAssesments.Name = "dataGridViewAssesments";
            this.dataGridViewAssesments.RowHeadersWidth = 62;
            this.dataGridViewAssesments.RowTemplate.Height = 33;
            this.dataGridViewAssesments.Size = new System.Drawing.Size(454, 243);
            this.dataGridViewAssesments.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-344, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1215, 462);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Ink Free", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(129, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Assesments Marks";
            // 
            // StudentHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 488);
            this.Controls.Add(this.Attendence);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StudentHome";
            this.Text = "StudentHome";
            this.Load += new System.EventHandler(this.StudentHome_Load);
            this.Attendence.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttendence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Assesments.ResumeLayout(false);
            this.Assesments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssesments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl Attendence;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage Assesments;
        private System.Windows.Forms.DataGridView dataGridViewAttendence;
        private System.Windows.Forms.DataGridView dataGridViewAssesments;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
    }
}