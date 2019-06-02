using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class CircularRadioButton : RadioButton
{
    protected override void OnPaint(PaintEventArgs pevent)
    {
        GraphicsPath g = new GraphicsPath();
        g.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
        this.Region = new System.Drawing.Region(g);
        base.OnPaint(pevent);
    }
}
