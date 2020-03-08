namespace ProgressHost
{
    partial class Form1
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
            this.userControlProgress = new ProgressControl.UserControlProgress();
            this.buttonStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userControlProgress
            // 
            this.userControlProgress.Location = new System.Drawing.Point(13, 13);
            this.userControlProgress.Maximum = 100;
            this.userControlProgress.Name = "userControlProgress";
            this.userControlProgress.Size = new System.Drawing.Size(259, 50);
            this.userControlProgress.Step = 10;
            this.userControlProgress.TabIndex = 0;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(106, 156);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 191);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.userControlProgress);
            this.Name = "Form1";
            this.Text = "WinFormUserControlProgressBar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ProgressControl.UserControlProgress userControlProgress;
        private System.Windows.Forms.Button buttonStart;
    }
}

