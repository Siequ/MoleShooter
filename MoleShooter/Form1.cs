#define My_Debug


namespace MoleShooter
{
    public partial class moleShooter : Form
    {
        int _cursX = 0;
        int _cursY = 0;

        public moleShooter()
        {
            InitializeComponent();
        }
        private void timerGameLoop_Tick(object sender, EventArgs e)
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics dc = e.Graphics;

            TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.EndEllipsis;
            Font _font = new System.Drawing.Font("Stencil ", 12, FontStyle.Regular);
            TextRenderer.DrawText(dc, "X=" + _cursX.ToString() + ":" + "Y=" + _cursY.ToString(), _font,
                new Rectangle(30, 28, 120, 20), SystemColors.ControlText, flags);

            base.OnPaint(e);
        }

        private void moleShooter_MouseMove(object sender, MouseEventArgs e)
        {
            _cursX = e.X;
            _cursY = e.Y;

            this.Refresh();
        }
    }
}
