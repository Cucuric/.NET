namespace PomodoroTimerApp
{
    partial class FormPomodoroApp
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
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.cbRepeat = new System.Windows.Forms.CheckBox();
            this.tbWork = new System.Windows.Forms.TextBox();
            this.lblWork = new System.Windows.Forms.Label();
            this.lblRest = new System.Windows.Forms.Label();
            this.tbRest = new System.Windows.Forms.TextBox();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.gbSetup = new System.Windows.Forms.GroupBox();
            this.gbSetup.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Lime;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Location = new System.Drawing.Point(328, 187);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(191, 64);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Red;
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Location = new System.Drawing.Point(328, 290);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(191, 64);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(12, 19);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(507, 143);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "Set timer";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbRepeat
            // 
            this.cbRepeat.AutoSize = true;
            this.cbRepeat.Location = new System.Drawing.Point(20, 137);
            this.cbRepeat.Name = "cbRepeat";
            this.cbRepeat.Size = new System.Drawing.Size(74, 20);
            this.cbRepeat.TabIndex = 4;
            this.cbRepeat.Text = "Repeat";
            this.cbRepeat.UseVisualStyleBackColor = true;
            this.cbRepeat.CheckedChanged += new System.EventHandler(this.cbRepeat_CheckedChanged);
            // 
            // tbWork
            // 
            this.tbWork.Location = new System.Drawing.Point(116, 38);
            this.tbWork.Name = "tbWork";
            this.tbWork.Size = new System.Drawing.Size(144, 22);
            this.tbWork.TabIndex = 5;
            this.tbWork.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblWork
            // 
            this.lblWork.AutoSize = true;
            this.lblWork.Location = new System.Drawing.Point(17, 41);
            this.lblWork.Name = "lblWork";
            this.lblWork.Size = new System.Drawing.Size(71, 16);
            this.lblWork.TabIndex = 6;
            this.lblWork.Text = "Work (min)";
            // 
            // lblRest
            // 
            this.lblRest.AutoSize = true;
            this.lblRest.Location = new System.Drawing.Point(17, 92);
            this.lblRest.Name = "lblRest";
            this.lblRest.Size = new System.Drawing.Size(67, 16);
            this.lblRest.TabIndex = 7;
            this.lblRest.Text = "Rest (min)";
            // 
            // tbRest
            // 
            this.tbRest.Location = new System.Drawing.Point(116, 89);
            this.tbRest.Name = "tbRest";
            this.tbRest.Size = new System.Drawing.Size(144, 22);
            this.tbRest.TabIndex = 8;
            this.tbRest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timerClock
            // 
            this.timerClock.Interval = 10;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // gbSetup
            // 
            this.gbSetup.Controls.Add(this.tbRest);
            this.gbSetup.Controls.Add(this.cbRepeat);
            this.gbSetup.Controls.Add(this.tbWork);
            this.gbSetup.Controls.Add(this.lblRest);
            this.gbSetup.Controls.Add(this.lblWork);
            this.gbSetup.Location = new System.Drawing.Point(12, 181);
            this.gbSetup.Name = "gbSetup";
            this.gbSetup.Size = new System.Drawing.Size(287, 173);
            this.gbSetup.TabIndex = 9;
            this.gbSetup.TabStop = false;
            this.gbSetup.Text = "Timer setup";
            // 
            // FormPomodoroApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 367);
            this.Controls.Add(this.gbSetup);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStart);
            this.Name = "FormPomodoroApp";
            this.Text = "Form1";
            this.gbSetup.ResumeLayout(false);
            this.gbSetup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.CheckBox cbRepeat;
        private System.Windows.Forms.TextBox tbWork;
        private System.Windows.Forms.Label lblWork;
        private System.Windows.Forms.Label lblRest;
        private System.Windows.Forms.TextBox tbRest;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.GroupBox gbSetup;
    }
}

