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
            SetStyle(ControlStyles.AllPaintingInWmPaint |
              ControlStyles.OptimizedDoubleBuffer |
              ControlStyles.UserPaint, true);
        }

        public BufferedPanel(IContainer container)
        {
            container.Add(this);
            SetStyle(ControlStyles.AllPaintingInWmPaint |
              ControlStyles.OptimizedDoubleBuffer |
              ControlStyles.UserPaint, true);
        }
    }
}