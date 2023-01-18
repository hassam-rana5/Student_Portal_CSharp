
namespace STUDENTPORTAL_PROJECT.GUI
{
    partial class MarkAssesment
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
            this.studentlistview = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_totalMarks = new System.Windows.Forms.Label();
            this.lb_Name = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_studentid = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_obtained = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentlistview)).BeginInit();
            this.SuspendLayout();
            // 
            // studentlistview
            // 
            this.studentlistview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentlistview.Location = new System.Drawing.Point(522, 12);
            this.studentlistview.Name = "studentlistview";
            this.studentlistview.RowHeadersWidth = 51;
            this.studentlistview.RowTemplate.Height = 29;
            this.studentlistview.Size = new System.Drawing.Size(300, 533);
            this.studentlistview.TabIndex = 0;
            this.studentlistview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentlistview_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // lb_totalMarks
            // 
            this.lb_totalMarks.AutoSize = true;
            this.lb_totalMarks.Location = new System.Drawing.Point(217, 255);
            this.lb_totalMarks.Name = "lb_totalMarks";
            this.lb_totalMarks.Size = new System.Drawing.Size(105, 20);
            this.lb_totalMarks.TabIndex = 3;
            this.lb_totalMarks.Text = "________________";
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Location = new System.Drawing.Point(217, 207);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(105, 20);
            this.lb_Name.TabIndex = 4;
            this.lb_Name.Text = "________________";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Obtained";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Total Marks";
            // 
            // lb_studentid
            // 
            this.lb_studentid.AutoSize = true;
            this.lb_studentid.Location = new System.Drawing.Point(217, 159);
            this.lb_studentid.Name = "lb_studentid";
            this.lb_studentid.Size = new System.Drawing.Size(105, 20);
            this.lb_studentid.TabIndex = 7;
            this.lb_studentid.Text = "________________";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(142, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(212, 28);
            this.label8.TabIndex = 8;
            this.label8.Text = "Mark Student Grades";
            // 
            // txt_obtained
            // 
            this.txt_obtained.Location = new System.Drawing.Point(217, 302);
            this.txt_obtained.Name = "txt_obtained";
            this.txt_obtained.Size = new System.Drawing.Size(67, 27);
            this.txt_obtained.TabIndex = 9;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(164, 403);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(94, 29);
            this.btn_submit.TabIndex = 10;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // MarkAssesment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 557);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.txt_obtained);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lb_studentid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_Name);
            this.Controls.Add(this.lb_totalMarks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentlistview);
            this.Name = "MarkAssesment";
            this.Text = "MarkAssesment";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MarkAssesment_FormClosed);
            this.Load += new System.EventHandler(this.MarkAssesment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentlistview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView studentlistview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_totalMarks;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_studentid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_obtained;
        private System.Windows.Forms.Button btn_submit;
    }
}