namespace BasicScheduling
{
    partial class RepeatedTaskForm
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
            this.addTaskButton = new System.Windows.Forms.Button();
            this.taskNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addTaskButton
            // 
            this.addTaskButton.Location = new System.Drawing.Point(357, 417);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(75, 23);
            this.addTaskButton.TabIndex = 1;
            this.addTaskButton.Text = "Add Task";
            this.addTaskButton.UseVisualStyleBackColor = true;
            this.addTaskButton.Click += new System.EventHandler(this.addTaskButton_Click);
            // 
            // taskNameBox
            // 
            this.taskNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.taskNameBox.Location = new System.Drawing.Point(276, 160);
            this.taskNameBox.Name = "taskNameBox";
            this.taskNameBox.Size = new System.Drawing.Size(224, 30);
            this.taskNameBox.TabIndex = 0;
            this.taskNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.taskNameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.taskNameBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(239, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "What do you need to do?";
            // 
            // RepeatedTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 717);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.taskNameBox);
            this.Controls.Add(this.addTaskButton);
            this.Name = "RepeatedTaskForm";
            this.Text = "New Task";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RepeatedTaskForm_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addTaskButton;
        private System.Windows.Forms.TextBox taskNameBox;
        private System.Windows.Forms.Label label1;
    }
}