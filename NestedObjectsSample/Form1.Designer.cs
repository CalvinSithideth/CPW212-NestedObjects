namespace NestedObjectsSample
{
    partial class Form1
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
            this.LstInstructors = new System.Windows.Forms.ListBox();
            this.LstCourses = new System.Windows.Forms.ListBox();
            this.LstStudents = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LstInstructors
            // 
            this.LstInstructors.FormattingEnabled = true;
            this.LstInstructors.Location = new System.Drawing.Point(13, 13);
            this.LstInstructors.Name = "LstInstructors";
            this.LstInstructors.Size = new System.Drawing.Size(245, 407);
            this.LstInstructors.TabIndex = 0;
            // 
            // LstCourses
            // 
            this.LstCourses.FormattingEnabled = true;
            this.LstCourses.Location = new System.Drawing.Point(278, 12);
            this.LstCourses.Name = "LstCourses";
            this.LstCourses.Size = new System.Drawing.Size(245, 407);
            this.LstCourses.TabIndex = 1;
            // 
            // LstStudents
            // 
            this.LstStudents.FormattingEnabled = true;
            this.LstStudents.Location = new System.Drawing.Point(543, 12);
            this.LstStudents.Name = "LstStudents";
            this.LstStudents.Size = new System.Drawing.Size(245, 407);
            this.LstStudents.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LstStudents);
            this.Controls.Add(this.LstCourses);
            this.Controls.Add(this.LstInstructors);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LstInstructors;
        private System.Windows.Forms.ListBox LstCourses;
        private System.Windows.Forms.ListBox LstStudents;
    }
}

