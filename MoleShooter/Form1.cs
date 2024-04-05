#define My_Debug


namespace MoleShooter
{
    public partial class moleShooter : Form
    {
        int _cursX = 0;
        int _cursY = 0;

        CMole _mole;
        public moleShooter()
        {
            InitializeComponent();

            _mole = new CMole() { Left = -100, Top = 40 };
        }
        private void timerGameLoop_Tick(object sender, EventArgs e)
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics dc = e.Graphics;
#if My_Debug
            TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.EndEllipsis;
            Font _font = new System.Drawing.Font("Arial ", 12, FontStyle.Regular);
            TextRenderer.DrawText(dc, "X=" + _cursX.ToString() + ":" + "Y=" + _cursY.ToString(), _font,
                new Rectangle(30, 28, 150, 20), SystemColors.ControlText, flags);
#endif

            _mole.DrawImage(dc);
            base.OnPaint(e);
        }

        private void moleShooter_MouseMove(object sender, MouseEventArgs e)
        {
            _cursX = e.X;
            _cursY = e.Y;

            this.Refresh();
        }

        private void moleShooter_Load(object sender, EventArgs e)
        {

        }
    }
}
