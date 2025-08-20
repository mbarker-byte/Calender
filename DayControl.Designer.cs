namespace MyCalendar
{
    partial class DayControl
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
            this.components = new System.ComponentModel.Container();
            this.DayLabel = new System.Windows.Forms.Label();
            this.ShowEvent = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // DayLabel
            // 
            this.DayLabel.AutoSize = true;
            this.DayLabel.Location = new System.Drawing.Point(3, 9);
            this.DayLabel.Name = "DayLabel";
            this.DayLabel.Size = new System.Drawing.Size(19, 13);
            this.DayLabel.TabIndex = 0;
            this.DayLabel.Text = "00";
            // 
            // ShowEvent
            // 
            this.ShowEvent.AutoSize = true;
            this.ShowEvent.Location = new System.Drawing.Point(42, 51);
            this.ShowEvent.Name = "ShowEvent";
            this.ShowEvent.Size = new System.Drawing.Size(0, 13);
            this.ShowEvent.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DayControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.ShowEvent);
            this.Controls.Add(this.DayLabel);
            this.Name = "DayControl";
            this.Size = new System.Drawing.Size(100, 100);
            this.Load += new System.EventHandler(this.DayControl_Load);
            this.Click += new System.EventHandler(this.DayControl_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DayLabel;
        private System.Windows.Forms.Label ShowEvent;
        private System.Windows.Forms.Timer timer1;
    }
}
