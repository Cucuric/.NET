using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PomodoroTimerApp
{
    public partial class FormPomodoroApp : Form
    {
        private int totalSeconds; //Varijable
        private bool working;
        private bool repeat;

        public FormPomodoroApp() //Konstruktor
        {
            InitializeComponent();
            totalSeconds = 0;
            working = false;
            repeat = false;
        }

        //Metode
        private void UpdateClockLabel()
        {
            int minutes = totalSeconds / 60;
            int seconds = totalSeconds % 60;
            lblTime.Text =  string.Format("{0}:{1}",minutes,seconds);
        }

        private void UpdateClock() {
            var workTime = int.Parse(tbWork.Text) * 60;
            var restTime = int.Parse(tbRest.Text) * 60;

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
            lblTime.Text = "Set timer";
        }

        private void cbRepeat_CheckedChanged(object sender, EventArgs e)
        {
            repeat = !repeat;
        }
    }
}
