namespace MyCalendar
{
    partial class EventForm
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
            this.EventSubmit = new System.Windows.Forms.Button();
            this.EventBox = new System.Windows.Forms.TextBox();
            this.DateBox = new System.Windows.Forms.TextBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.EventLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EventSubmit
            // 
            this.EventSubmit.Location = new System.Drawing.Point(134, 174);
            this.EventSubmit.Name = "EventSubmit";
            this.EventSubmit.Size = new System.Drawing.Size(75, 23);
            this.EventSubmit.TabIndex = 4;
            this.EventSubmit.Text = "Submit";
            this.EventSubmit.UseVisualStyleBackColor = true;
            this.EventSubmit.Click += new System.EventHandler(this.EventSubmit_Click);
            // 
            // EventBox
            // 
            this.EventBox.Location = new System.Drawing.Point(81, 124);
            this.EventBox.Name = "EventBox";
            this.EventBox.Size = new System.Drawing.Size(100, 20);
            this.EventBox.TabIndex = 5;
            // 
            // DateBox
            // 
            this.DateBox.Location = new System.Drawing.Point(81, 58);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(100, 20);
            this.DateBox.TabIndex = 6;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(78, 42);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(30, 13);
            this.DateLabel.TabIndex = 7;
            this.DateLabel.Text = "Date";
            // 
            // EventLabel
            // 
            this.EventLabel.AutoSize = true;
            this.EventLabel.Location = new System.Drawing.Point(78, 108);
            this.EventLabel.Name = "EventLabel";
            this.EventLabel.Size = new System.Drawing.Size(35, 13);
            this.EventLabel.TabIndex = 8;
            this.EventLabel.Text = "Event";
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 209);
            this.Controls.Add(this.EventLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.EventBox);
            this.Controls.Add(this.EventSubmit);
            this.Name = "EventForm";
            this.Text = "EventForm";
            this.Load += new System.EventHandler(this.EventForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button EventSubmit;
        private System.Windows.Forms.TextBox EventBox;
        private System.Windows.Forms.TextBox DateBox;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label EventLabel;
    }
}