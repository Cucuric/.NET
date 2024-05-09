namespace PomodoroTimerApp
{
    partial class fInput
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.cbRepeat = new System.Windows.Forms.CheckBox();
            this.tbTimeInput = new System.Windows.Forms.TextBox();
            this.lblWork = new System.Windows.Forms.Label();
            this.lblRest = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Lime;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Location = new System.Drawing.Point(262, 181);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(107, 54);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Red;
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Location = new System.Drawing.Point(262, 269);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(107, 54);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(12, 19);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(357, 146);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "00:00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTime.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbRepeat
            // 
            this.cbRepeat.AutoSize = true;
            this.cbRepeat.Location = new System.Drawing.Point(12, 287);
            this.cbRepeat.Name = "cbRepeat";
            this.cbRepeat.Size = new System.Drawing.Size(74, 20);
            this.cbRepeat.TabIndex = 4;
            this.cbRepeat.Text = "Repeat";
            this.cbRepeat.UseVisualStyleBackColor = true;
            this.cbRepeat.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tbTimeInput
            // 
            this.tbTimeInput.Location = new System.Drawing.Point(12, 197);
            this.tbTimeInput.Name = "tbTimeInput";
            this.tbTimeInput.Size = new System.Drawing.Size(192, 22);
            this.tbTimeInput.TabIndex = 5;
            // 
            // lblWork
            // 
            this.lblWork.AutoSize = true;
            this.lblWork.Location = new System.Drawing.Point(12, 178);
            this.lblWork.Name = "lblWork";
            this.lblWork.Size = new System.Drawing.Size(71, 16);
            this.lblWork.TabIndex = 6;
            this.lblWork.Text = "Work (min)";
            // 
            // lblRest
            // 
            this.lblRest.AutoSize = true;
            this.lblRest.Location = new System.Drawing.Point(12, 236);
            this.lblRest.Name = "lblRest";
            this.lblRest.Size = new System.Drawing.Size(67, 16);
            this.lblRest.TabIndex = 7;
            this.lblRest.Text = "Rest (min)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 255);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 22);
            this.textBox1.TabIndex = 8;
            // 
            // fInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 335);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblRest);
            this.Controls.Add(this.lblWork);
            this.Controls.Add(this.tbTimeInput);
            this.Controls.Add(this.cbRepeat);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStart);
            this.Name = "fInput";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.CheckBox cbRepeat;
        private System.Windows.Forms.TextBox tbTimeInput;
        private System.Windows.Forms.Label lblWork;
        private System.Windows.Forms.Label lblRest;
        private System.Windows.Forms.TextBox textBox1;
    }
}

