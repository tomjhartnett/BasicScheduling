using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicScheduling
{
    public partial class RepeatedTaskForm : Form
    {
        /*
         * This form represents the creation of a new form that allows the user to make a new task.
         * Specifically, these tasks will repeat, and require the days of the 
         */

        private MainTaskForm form;
        //To add: allow tasks to have a choice for every other day events, etc, allow selection of a set number of days before the next event
        public RepeatedTaskForm(MainTaskForm Form)
        {
            InitializeComponent();
            form = Form;
            taskNameBox.Focus();
            taskNameBox.Text = "Go shopping today";
            taskNameBox.SelectAll();
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            addTask();
        }

        private void RepeatedTaskForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                addTask();
            }
        }

        private void addTask()
        {
            if (taskNameBox.Text.Length > 0)
            {
                List<Event> days = new List<Event>();
                days.Add(new Event(Day.Friday));

                form.addTask(new Task(taskNameBox.Text, days));
                form.redrawTasks();

                Close();
            }
        }

        private void taskNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                addTask();
            }
        }
    }
}
