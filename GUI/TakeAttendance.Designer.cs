
namespace STUDENTPORTAL_PROJECT.GUI
{
    partial class TakeAttendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TakeAttendance));
            this.label1 = new System.Windows.Forms.Label();
            this.studentlist = new System.Windows.Forms.DataGridView();
            this.lb_id = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_present = new System.Windows.Forms.Button();
            this.btn_absent = new System.Windows.Forms.Button();
            this.lb_status = new System.Windows.Forms.Label();
            this.lb_studentname = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.studentlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(520, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "TAKE ATTENDANCE";
            // 
            // studentlist
            // 
            this.studentlist.BackgroundColor = System.Drawing.Color.White;
            this.studentlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentlist.Location = new System.Drawing.Point(87, 36);
            this.studentlist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.studentlist.Name = "studentlist";
            this.studentlist.RowHeadersWidth = 51;
            this.studentlist.RowTemplate.Height = 29;
            this.studentlist.Size = new System.Drawing.Size(413, 367);
            this.studentlist.TabIndex = 2;
            this.studentlist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentlist_CellClick);
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(726, 98);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(87, 15);
            this.lb_id.TabIndex = 3;
            this.lb_id.Text = "________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(551, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Student ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(533, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Student Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(573, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Status";
            // 
            // btn_present
            // 
            this.btn_present.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_present.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_present.Location = new System.Drawing.Point(609, 340);
            this.btn_present.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_present.Name = "btn_present";
            this.btn_present.Size = new System.Drawing.Size(99, 52);
            this.btn_present.TabIndex = 8;
            this.btn_present.Text = "Present";
            this.btn_present.UseVisualStyleBackColor = false;
            this.btn_present.Click += new System.EventHandler(this.btn_present_Click);
            // 
            // btn_absent
            // 
            this.btn_absent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_absent.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_absent.Location = new System.Drawing.Point(744, 340);
            this.btn_absent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_absent.Name = "btn_absent";
            this.btn_absent.Size = new System.Drawing.Size(93, 52);
            this.btn_absent.TabIndex = 9;
            this.btn_absent.Text = "Absent";
            this.btn_absent.UseVisualStyleBackColor = false;
            this.btn_absent.Click += new System.EventHandler(this.btn_absent_Click);
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Location = new System.Drawing.Point(726, 227);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(87, 15);
            this.lb_status.TabIndex = 11;
            this.lb_status.Text = "________________";
            // 
            // lb_studentname
            // 
            this.lb_studentname.AutoSize = true;
            this.lb_studentname.Location = new System.Drawing.Point(726, 168);
            this.lb_studentname.Name = "lb_studentname";
            this.lb_studentname.Size = new System.Drawing.Size(87, 15);
            this.lb_studentname.TabIndex = 12;
            this.lb_studentname.Text = "________________";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(912, 452);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // TakeAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 451);
            this.Controls.Add(this.lb_studentname);
            this.Controls.Add(this.lb_status);
            this.Controls.Add(this.btn_absent);
            this.Controls.Add(this.btn_present);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.studentlist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TakeAttendance";
            this.Text = "TakeAttendance";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TakeAttendance_FormClosed);
            this.Load += new System.EventHandler(this.TakeAttendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView studentlist;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_present;
        private System.Windows.Forms.Button btn_absent;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.Label lb_studentname;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}