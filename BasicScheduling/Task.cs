using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicScheduling
{
    /*
     * This represents a task to do. It contains a name or string objective, as well as the events when the task should be displayed.
     * Currently we only need to display the task based on the day of the week.
     */
    public class Task
    {
        //the name or string objective of the task
        public string whatToDo { get; private set; }
        //this can change as needed to include more info
        public List<Event> daysToShow { get; private set; }
        //bool that keeps track of task completion status
        public bool isFinished { get; private set; } = false;

        public Task(string WhatToDo, List<Event> DaysToShow)
        {
            whatToDo = WhatToDo;
            daysToShow = DaysToShow;
        }

        public Panel getPanel(EventHandler redraw)
        {
            Panel tempPanel = new Panel();
            tempPanel.AutoSize = true;

            Label titleLabel = new Label();
            titleLabel.AutoSize = true;
            titleLabel.Text = whatToDo;
            tempPanel.Controls.Add(titleLabel);

            Button completeButton = new Button();
            completeButton.AutoSize = true;
            completeButton.Height = titleLabel.Height;
            completeButton.Text = "Complete Task";
            completeButton.Click += CompleteButton_Click;
            //make sure to trigger redraw in main form
            completeButton.Click += redraw;
            completeButton.Location = new System.Drawing.Point(titleLabel.Location.X + titleLabel.Width, 0);
            tempPanel.Controls.Add(completeButton);

            return tempPanel;
        }

        //when the button is clicked to complete the task
        private void CompleteButton_Click(object sender, EventArgs e)
        {
            isFinished = true;
        }
    }
}
