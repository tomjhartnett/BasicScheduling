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
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            List<Event> days = new List<Event>();
            days.Add(new Event(Day.Friday));

            form.addTask(new Task("test", days));
            form.redrawTasks();

            Close();
        }
    }
}
