using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Login
{
    /// <summary>
    /// Double Buffered layout panel - An attempt at decreasing flickering and jankyness of animations
    /// </summary>
    public partial class BufferedPanel : Panel
    {
        public BufferedPanel()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint |
              ControlStyles.OptimizedDoubleBuffer |
              ControlStyles.UserPaint, true);
        }

        private void InitializeComponent()
        {
            return;
        }

        public BufferedPanel(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint |
              ControlStyles.OptimizedDoubleBuffer |
              ControlStyles.UserPaint, true);
        }
    }
}