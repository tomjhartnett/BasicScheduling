using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicScheduling
{
    /*
     * This represents a single event of a task. 
     * Currently our events can be the whole day (the task is displayed based on the day and no other info).
     * However, more info can be added to the event as needed (i.e. time, etc)
     */
    public class Event
    {
        //list of days to prompt the user about the event, currently all we need as we don't need a time component
        public Day dayToPrompt { get; private set; }

        public Event(Day DayToPrompt)
        {
            dayToPrompt = DayToPrompt;
        }
    }
}
