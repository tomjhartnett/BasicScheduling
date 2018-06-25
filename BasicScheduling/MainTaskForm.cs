using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicScheduling
{
    /*
     * This form displays all tasks due today, as well as allows the user to add new tasks.
     */ 
    public partial class MainTaskForm : Form
    {
        //list of tasks to do
        private List<Task> tasksToDo = new List<Task>();

        public MainTaskForm()
        {
            InitializeComponent();
            addTasks(FileHandler.loadTasks());
            redrawTasks();
        }

        //when the button to add a repeated task is clicked
        private void repeatTaskBtn_Click(object sender, EventArgs e)
        {
            new RepeatedTaskForm(this).Show();
        }

        //adds a task to the queue
        public void addTask(Task task)
        {
            tasksToDo.Add(task);
            redrawTasks();
        }

        public void addTasks(List<Task> tasks)
        {
            foreach (Task t in tasks)
                addTask(t);
        }

        //redraws the panel for the tasks
        public void redrawTasks()
        {
            FileHandler.writeToFile(getTaskText());
            taskPanel.Controls.Clear();

            Panel tempPanel;
            int startx = 0, starty = 0;
            foreach(Task tempTask in tasksToDo)
            {
                if (!tempTask.isFinished)
                {
                    tempPanel = tempTask.getPanel(taskButton_Click);
                    tempPanel.Location = new Point(startx, starty);
                    taskPanel.Controls.Add(tempPanel);
                    starty += tempPanel.Height;
                }
            }
        }

        //event to redraw tasks on finish task button click
        private void taskButton_Click(object sender, EventArgs e)
        {
            redrawTasks();
        }

        private string[] getTaskText()
        {
            List<string> ret = new List<string>();

            foreach (Task t in tasksToDo)
                if(!t.isFinished)
                    ret.Add(t.whatToDo);

            return ret.ToArray();
        }
    }
}
