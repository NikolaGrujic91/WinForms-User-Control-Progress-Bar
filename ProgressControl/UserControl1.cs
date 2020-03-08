using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

namespace ProgressControl
{
    public partial class UserControlProgress : UserControl
    {
        #region Constructors

        public UserControlProgress()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        [Description("The current value (between 0 and Maximum) which sets the position of the progress bar"),
         Category("Behavior"), DefaultValue(0)]
        public int Value
        {
            get { return this.progressBar.Value; }
            set
            {
                this.progressBar.Value = value;
                this.UpdateLabel();
            }
        }

        public int Maximum
        {
            get { return this.progressBar.Maximum; }
            set { this.progressBar.Maximum = value; }
        }

        public int Step
        {
            get { return this.progressBar.Step; }
            set { this.progressBar.Step = value; }
        }

        #endregion

        #region Methods

        public void PerformStep()
        {
            this.progressBar.PerformStep();
            this.UpdateLabel();
        }

        private void UpdateLabel()
        {
            this.labelProgress.Text = (Math.Round((decimal)(this.progressBar.Value * 100) / this.progressBar.Maximum)).ToString(CultureInfo.InvariantCulture);
            this.labelProgress.Text += "% Done";
        }

        #endregion
    }
}
