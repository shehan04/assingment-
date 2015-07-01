namespace Segment_5
{
    partial class student_details
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
            this.gvStudent = new System.Windows.Forms.DataGridView();
            this.txtAddnew = new System.Windows.Forms.Button();
            this.txtSave = new System.Windows.Forms.Button();
            this.lbMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // gvStudent
            // 
            this.gvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvStudent.Location = new System.Drawing.Point(12, 145);
            this.gvStudent.Name = "gvStudent";
            this.gvStudent.Size = new System.Drawing.Size(634, 150);
            this.gvStudent.TabIndex = 0;
            // 
            // txtAddnew
            // 
            this.txtAddnew.Location = new System.Drawing.Point(86, 104);
            this.txtAddnew.Name = "txtAddnew";
            this.txtAddnew.Size = new System.Drawing.Size(75, 23);
            this.txtAddnew.TabIndex = 1;
            this.txtAddnew.Text = "Add New";
            this.txtAddnew.UseVisualStyleBackColor = true;
            this.txtAddnew.Click += new System.EventHandler(this.txtAddnew_Click);
            // 
            // txtSave
            // 
            this.txtSave.Location = new System.Drawing.Point(194, 103);
            this.txtSave.Name = "txtSave";
            this.txtSave.Size = new System.Drawing.Size(75, 23);
            this.txtSave.TabIndex = 2;
            this.txtSave.Text = "Save";
            this.txtSave.UseVisualStyleBackColor = true;
            this.txtSave.Click += new System.EventHandler(this.txtSave_Click);
            // 
            // lbMsg
            // 
            this.lbMsg.AutoSize = true;
            this.lbMsg.Location = new System.Drawing.Point(206, 310);
            this.lbMsg.Name = "lbMsg";
            this.lbMsg.Size = new System.Drawing.Size(0, 13);
            this.lbMsg.TabIndex = 3;
            // 
            // student_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 335);
            this.Controls.Add(this.lbMsg);
            this.Controls.Add(this.txtSave);
            this.Controls.Add(this.txtAddnew);
            this.Controls.Add(this.gvStudent);
            this.Name = "student_details";
            this.Text = "Student Details";
            this.Load += new System.EventHandler(this.student_details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txtAddnew;
        private System.Windows.Forms.Button txtSave;
        public System.Windows.Forms.DataGridView gvStudent;
        private System.Windows.Forms.Label lbMsg;
    }
}