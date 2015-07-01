namespace Segment_5
{
    partial class main_menu
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
            this.txtExit = new System.Windows.Forms.Button();
            this.txtNewregistration = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtExit
            // 
            this.txtExit.Location = new System.Drawing.Point(94, 220);
            this.txtExit.Name = "txtExit";
            this.txtExit.Size = new System.Drawing.Size(185, 23);
            this.txtExit.TabIndex = 0;
            this.txtExit.Text = "Exit";
            this.txtExit.UseVisualStyleBackColor = true;
            // 
            // txtNewregistration
            // 
            this.txtNewregistration.Location = new System.Drawing.Point(94, 146);
            this.txtNewregistration.Name = "txtNewregistration";
            this.txtNewregistration.Size = new System.Drawing.Size(185, 23);
            this.txtNewregistration.TabIndex = 1;
            this.txtNewregistration.Text = "New Registration";
            this.txtNewregistration.UseVisualStyleBackColor = true;
            this.txtNewregistration.Click += new System.EventHandler(this.txtNewregistration_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Queens\'s University ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // main_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 330);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNewregistration);
            this.Controls.Add(this.txtExit);
            this.Name = "main_menu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txtExit;
        private System.Windows.Forms.Button txtNewregistration;
        private System.Windows.Forms.Label label1;
    }
}

