using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Beehive_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var job = new List<String>();
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Nectar collector", "Honey manufacturing", "2"});
            workers[1] = new Worker(new string[] { "Egg care", "Baby bee tutoring" });
            workers[2] = new Worker(new string[] { "Hive maintenance", "Sting patrol" });
            workers[3] = new Worker(new string[] { "Nectar collector", "Honey manufacturing",
                "Egg care", "Baby bee tutoring", "Hive maintenance", "Sting patrol", "13" });

            for (int i = 0; i < workers.Length; i++)
            {
                for (int j = 0; j < workers[i].getJobs().Length; j++)
                    job.Add(workers[i].getJobs()[j]);
 
            }
            job=job.Distinct().ToList();
            for (int i = 0; i < job.Count; i++)
                worker.Items.Add(job[i]);
            queen = new Queen(workers);
        }

        Queen queen;

        private void assignJob_Click(object sender, EventArgs e)
        {
            if (queen.AssignWork(worker.Text, (int)shifts.Value) == false)
                MessageBox.Show("Для этого задания рабочих нет ‘"
                    + worker.Text + "’", "Матка говорит...");
            else
                MessageBox.Show("Задание ‘" + worker.Text + "’ будет закончено через "
                    + shifts.Value + " смен", "Матка говорит...");
        }

        private void nextShift_Click(object sender, EventArgs e)
        {
            report.Text = queen.WorkTheNextShift();
        }
    }
}