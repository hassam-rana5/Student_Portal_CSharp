
namespace STUDENTPORTAL_PROJECT.GUI
{
    partial class TeacherGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherGUI));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_date = new System.Windows.Forms.TextBox();
            this.btn_create = new System.Windows.Forms.Button();
            this.txt_lectureno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_createAssement = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.radioexam = new System.Windows.Forms.RadioButton();
            this.radioquiz = new System.Windows.Forms.RadioButton();
            this.radioAssignment = new System.Windows.Forms.RadioButton();
            this.txt_assessname = new System.Windows.Forms.TextBox();
            this.txt_ttlmarks = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.studentgrade = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_view = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_studentid = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentgrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(910, 451);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_date);
            this.tabPage1.Controls.Add(this.btn_create);
            this.tabPage1.Controls.Add(this.txt_lectureno);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(902, 423);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create Lecture";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(618, 163);
            this.txt_date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(208, 23);
            this.txt_date.TabIndex = 24;
            // 
            // btn_create
            // 
            this.btn_create.Font = new System.Drawing.Font("Ink Free", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_create.Location = new System.Drawing.Point(728, 253);
            this.btn_create.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(98, 39);
            this.btn_create.TabIndex = 23;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // txt_lectureno
            // 
            this.txt_lectureno.Location = new System.Drawing.Point(618, 101);
            this.txt_lectureno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_lectureno.Name = "txt_lectureno";
            this.txt_lectureno.Size = new System.Drawing.Size(208, 23);
            this.txt_lectureno.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Font = new System.Drawing.Font("Ink Free", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(461, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(337, 36);
            this.label6.TabIndex = 17;
            this.label6.Text = "CREATE NEW LECTURE";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(414, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(414, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Lecture no.";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.btn_createAssement);
            this.tabPage2.Controls.Add(this.btn_clear);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.radioexam);
            this.tabPage2.Controls.Add(this.radioquiz);
            this.tabPage2.Controls.Add(this.radioAssignment);
            this.tabPage2.Controls.Add(this.txt_assessname);
            this.tabPage2.Controls.Add(this.txt_ttlmarks);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(902, 423);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mark Grades";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Font = new System.Drawing.Font("Ink Free", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(373, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(374, 36);
            this.label10.TabIndex = 11;
            this.label10.Text = "CREATE AN ASSESSMENT";
            // 
            // btn_createAssement
            // 
            this.btn_createAssement.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_createAssement.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_createAssement.Location = new System.Drawing.Point(600, 279);
            this.btn_createAssement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_createAssement.Name = "btn_createAssement";
            this.btn_createAssement.Size = new System.Drawing.Size(82, 44);
            this.btn_createAssement.TabIndex = 10;
            this.btn_createAssement.Text = "Create ";
            this.btn_createAssement.UseVisualStyleBackColor = false;
            this.btn_createAssement.Click += new System.EventHandler(this.btn_createAssement_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_clear.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_clear.Location = new System.Drawing.Point(721, 279);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(82, 44);
            this.btn_clear.TabIndex = 9;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(483, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 26);
            this.label8.TabIndex = 8;
            this.label8.Text = "Type";
            // 
            // radioexam
            // 
            this.radioexam.AutoSize = true;
            this.radioexam.BackColor = System.Drawing.Color.WhiteSmoke;
            this.radioexam.Checked = true;
            this.radioexam.Location = new System.Drawing.Point(749, 207);
            this.radioexam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioexam.Name = "radioexam";
            this.radioexam.Size = new System.Drawing.Size(54, 19);
            this.radioexam.TabIndex = 1;
            this.radioexam.TabStop = true;
            this.radioexam.Text = "Exam";
            this.radioexam.UseVisualStyleBackColor = false;
            // 
            // radioquiz
            // 
            this.radioquiz.AutoSize = true;
            this.radioquiz.BackColor = System.Drawing.Color.WhiteSmoke;
            this.radioquiz.Location = new System.Drawing.Point(600, 209);
            this.radioquiz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioquiz.Name = "radioquiz";
            this.radioquiz.Size = new System.Drawing.Size(49, 19);
            this.radioquiz.TabIndex = 2;
            this.radioquiz.Text = "Quiz";
            this.radioquiz.UseVisualStyleBackColor = false;
            // 
            // radioAssignment
            // 
            this.radioAssignment.AutoSize = true;
            this.radioAssignment.BackColor = System.Drawing.Color.WhiteSmoke;
            this.radioAssignment.Location = new System.Drawing.Point(655, 209);
            this.radioAssignment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioAssignment.Name = "radioAssignment";
            this.radioAssignment.Size = new System.Drawing.Size(88, 19);
            this.radioAssignment.TabIndex = 3;
            this.radioAssignment.Text = "Assignment";
            this.radioAssignment.UseVisualStyleBackColor = false;
            // 
            // txt_assessname
            // 
            this.txt_assessname.Location = new System.Drawing.Point(582, 117);
            this.txt_assessname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_assessname.Name = "txt_assessname";
            this.txt_assessname.Size = new System.Drawing.Size(207, 23);
            this.txt_assessname.TabIndex = 7;
            // 
            // txt_ttlmarks
            // 
            this.txt_ttlmarks.Location = new System.Drawing.Point(582, 164);
            this.txt_ttlmarks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ttlmarks.Name = "txt_ttlmarks";
            this.txt_ttlmarks.Size = new System.Drawing.Size(207, 23);
            this.txt_ttlmarks.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(483, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 26);
            this.label9.TabIndex = 3;
            this.label9.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(416, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 26);
            this.label7.TabIndex = 1;
            this.label7.Text = "Total Marks";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(264, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 26);
            this.label5.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.studentgrade);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.btn_view);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.txt_studentid);
            this.tabPage3.Controls.Add(this.pictureBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(902, 423);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "View Grades";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // studentgrade
            // 
            this.studentgrade.BackgroundColor = System.Drawing.Color.White;
            this.studentgrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentgrade.Location = new System.Drawing.Point(81, 96);
            this.studentgrade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.studentgrade.Name = "studentgrade";
            this.studentgrade.RowHeadersWidth = 51;
            this.studentgrade.RowTemplate.Height = 29;
            this.studentgrade.Size = new System.Drawing.Size(400, 302);
            this.studentgrade.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Font = new System.Drawing.Font("Ink Free", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(285, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(363, 36);
            this.label12.TabIndex = 12;
            this.label12.Text = "VIEW STUDENT GRADES";
            // 
            // btn_view
            // 
            this.btn_view.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_view.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_view.Location = new System.Drawing.Point(765, 157);
            this.btn_view.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(82, 45);
            this.btn_view.TabIndex = 2;
            this.btn_view.Text = "View";
            this.btn_view.UseVisualStyleBackColor = false;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(534, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 23);
            this.label11.TabIndex = 1;
            this.label11.Text = "Student ID";
            // 
            // txt_studentid
            // 
            this.txt_studentid.Location = new System.Drawing.Point(682, 96);
            this.txt_studentid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_studentid.Name = "txt_studentid";
            this.txt_studentid.Size = new System.Drawing.Size(165, 23);
            this.txt_studentid.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(906, 424);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(906, 415);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-3, -1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(902, 424);
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // TeacherGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 451);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TeacherGUI";
            this.Text = "TeacherGUI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TeacherGUI_FormClosed);
            this.Load += new System.EventHandler(this.TeacherGUI_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentgrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txt_lectureno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_createAssement;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioexam;
        private System.Windows.Forms.RadioButton radioquiz;
        private System.Windows.Forms.RadioButton radioAssignment;
        private System.Windows.Forms.TextBox txt_assessname;
        private System.Windows.Forms.TextBox txt_ttlmarks;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_studentid;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_date;
        private System.Windows.Forms.DataGridView studentgrade;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}