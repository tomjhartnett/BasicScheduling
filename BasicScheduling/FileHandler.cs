using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicScheduling
{
    public abstract class FileHandler
    {
        //task save path
        public static string path = @"..\\..\\tasks.txt";

        public static List<Task> loadTasks()
        {
            List<Task> ret = new List<Task>();
            try
            {
                string[] tasks = File.ReadAllLines(path);
                foreach (string s in tasks)
                    ret.Add(new Task(s));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().FullName);
                Console.WriteLine(ex.Message);
            }
            return ret;
        }

        public static bool writeToFile(string[] text)
        {
            File.WriteAllLines(path, text);
            return true;
        }
    }
}
