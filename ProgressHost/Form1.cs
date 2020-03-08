using System;
using System.Windows.Forms;

namespace ProgressHost
{
    public partial class Form1 : Form
    {
        #region Fields

        private Timer timer;

        #endregion

        #region Constructors

        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        #region Events

        private void Form1_Load(object sender, EventArgs e)
        {
            this.timer = new Timer {Interval = 1000};
            this.timer.Tick += this.Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.userControlProgress.PerformStep();

            if (this.userControlProgress.Maximum == this.userControlProgress.Value)
            {
                this.timer.Enabled = false;
                this.buttonStart.Enabled = true;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            this.timer.Enabled = false;

            this.userControlProgress.Value = 0;
            this.userControlProgress.Maximum = 20;
            this.userControlProgress.Step = 1;

            this.timer.Enabled = true;
            this.buttonStart.Enabled = false;
        }

        #endregion
    }
}
