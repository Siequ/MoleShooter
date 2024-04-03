namespace MoleShooter
{
    partial class moleShooter
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timerGameLoop = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // timerGameLoop
            // 
            timerGameLoop.Tick += timerGameLoop_Tick;
            // 
            // moleShooter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(782, 403);
            DoubleBuffered = true;
            Name = "moleShooter";
            Text = "MoleShooter";
            MouseMove += moleShooter_MouseMove;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timerGameLoop;
    }
}
