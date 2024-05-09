using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PomodoroTimerApp
{
    public partial class FormPomodoroApp : Form
    {
        private int totalSeconds;
        private bool working;
        private bool repeat;
        int numOfRepeats = 0;

        public FormPomodoroApp()
        {
            InitializeComponent();
            totalSeconds = 1;
            working = false;
            repeat = true;
        }

        private void UpdateClockLabel()
        {
            int minutes = totalSeconds / 60;
            int seconds = totalSeconds % 60;
            string formattedTime = string.Format("{0:00}:{1:00}", minutes, seconds);
            lblTime.Text = formattedTime;
        }

        private void UpdateClock() {
            var workTime = int.Parse(tbWork.Text) * 60;
            var restTime = int.Parse(tbRest.Text) * 60;

            numOfRepeats++;

            if (numOfRepeats >= workTime + restTime && repeat)
            {
                numOfRepeats = 0;
                ResetClock();
            }

            totalSeconds--;


            if (totalSeconds <= 0)
            {
                if (working)
                {
                    totalSeconds = restTime;
                }
                else
                {
                    totalSeconds = workTime;
                }

                working = !working;
            }
        }

        private void ResetClock()
        {
            timerClock.Enabled = false;
            totalSeconds = 0;
            working = false;
            lblTime.Text = "Set timer";
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            UpdateClock();
            UpdateClockLabel(); 
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timerClock.Enabled = !timerClock.Enabled;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetClock();
        }

        private void cbRepeat_CheckedChanged(object sender, EventArgs e)
        {
            repeat = !repeat;
        }


    }
}
