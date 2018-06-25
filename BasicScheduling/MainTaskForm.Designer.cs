namespace BasicScheduling
{
    partial class MainTaskForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.taskPanel = new System.Windows.Forms.Panel();
            this.repeatTaskBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.titleLabel.Location = new System.Drawing.Point(244, 34);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(300, 46);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Daily Scheduler";
            // 
            // taskPanel
            // 
            this.taskPanel.Location = new System.Drawing.Point(85, 161);
            this.taskPanel.Name = "taskPanel";
            this.taskPanel.Size = new System.Drawing.Size(632, 598);
            this.taskPanel.TabIndex = 1;
            // 
            // repeatTaskBtn
            // 
            this.repeatTaskBtn.Location = new System.Drawing.Point(127, 108);
            this.repeatTaskBtn.Name = "repeatTaskBtn";
            this.repeatTaskBtn.Size = new System.Drawing.Size(111, 23);
            this.repeatTaskBtn.TabIndex = 2;
            this.repeatTaskBtn.Text = "Add repeatable task";
            this.repeatTaskBtn.UseVisualStyleBackColor = true;
            this.repeatTaskBtn.Click += new System.EventHandler(this.repeatTaskBtn_Click);
            // 
            // MainTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 788);
            this.Controls.Add(this.repeatTaskBtn);
            this.Controls.Add(this.taskPanel);
            this.Controls.Add(this.titleLabel);
            this.Name = "MainTaskForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainTaskForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel taskPanel;
        private System.Windows.Forms.Button repeatTaskBtn;
    }
}