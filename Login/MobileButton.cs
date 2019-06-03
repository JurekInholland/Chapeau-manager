using Login.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    /// <summary>
    /// A custom Button subclass
    /// that mimics well known mobile ui buttons
    /// </summary>
    class MobileButton: Button
    {

        private Rectangle borderRec;
        private Rectangle IconRec;
        private Rectangle textRec;

        protected override void OnPaint(PaintEventArgs pevent)
        {
            Height = 40;

            SolidBrush borderBrush = new SolidBrush(Color.White);
            SolidBrush textBrush = new SolidBrush(Color.Black);
            borderRec = new Rectangle(0, 0, Width, Height);

            textRec = new Rectangle(15, 0, Width - 15, Height);


            IconRec = new Rectangle(Width-40, 10, 18, 18);
            // Align the button text to the left, vertically centered
            StringFormat format = new StringFormat
            {
                LineAlignment = StringAlignment.Center,
                Alignment = StringAlignment.Near
            };

            

            pevent.Graphics.FillRectangle(borderBrush, borderRec);
            pevent.Graphics.DrawString(Text, new Font("Segore UI", 12), textBrush, textRec, format);

            // Load a resource image file
            Bitmap arrowB = Resources.arrow;
            arrowB.MakeTransparent();

            pevent.Graphics.DrawImage(arrowB, IconRec);


            //base.OnPaint(pevent);

            ControlPaint.DrawBorder(pevent.Graphics, ClientRectangle,
            Color.Black, 0, ButtonBorderStyle.Solid,
            Color.Black, 0, ButtonBorderStyle.Solid,
            Color.Black, 0, ButtonBorderStyle.Solid,
            Color.FromArgb(149, 149, 149), 1, ButtonBorderStyle.Solid);
            //ControlPaint.DrawBorder(pevent.Graphics, borderRec, Color.AliceBlue, ButtonBorderStyle.Solid);
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
        }
    }
}
