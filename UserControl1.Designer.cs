namespace MyCalendar
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ucDayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ucDayLabel
            // 
            this.ucDayLabel.AutoSize = true;
            this.ucDayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ucDayLabel.Location = new System.Drawing.Point(1, 1);
            this.ucDayLabel.Name = "ucDayLabel";
            this.ucDayLabel.Size = new System.Drawing.Size(2, 15);
            this.ucDayLabel.TabIndex = 0;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucDayLabel);
            this.Name = "UserControl1";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Size = new System.Drawing.Size(100, 100);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ucDayLabel;
    }
}
