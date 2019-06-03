// Made by Jurek Baumann, 2019
using Login.Properties;
using System.Drawing;
using System.Windows.Forms;

namespace Login
{
    /// <summary>
    /// A custom Button subclass that mimics
    /// well established mobile ui buttons
    /// </summary>
    class MobileButton: Button
    {
        private Rectangle boundingRec;
        private Rectangle IconRec;
        private Rectangle textRec;

        // override paint method to draw a custom button
        protected override void OnPaint(PaintEventArgs pevent)
        {
            Height = 40;  // Set a fixed height

            // Set background and text colors
            SolidBrush backgroundBrush = new SolidBrush(Color.White);
            SolidBrush textBrush = new SolidBrush(Color.Black);

            // Define rectangles
            boundingRec = new Rectangle(0, 0, Width, Height);
            textRec = new Rectangle(15, 0, Width - 15, Height);
            IconRec = new Rectangle(Width  -40, 10, 18, 18);

            // Align the button text to the left, vertically centered
            StringFormat format = new StringFormat
            {
                LineAlignment = StringAlignment.Center,
                Alignment = StringAlignment.Near
            };

            // Draw background and text
            pevent.Graphics.FillRectangle(backgroundBrush, boundingRec);
            pevent.Graphics.DrawString(Text, new Font("Segore UI", 12), textBrush, textRec, format);

            // Load a resource image file as bitmap and make it transparent
            Bitmap arrowB = Resources.arrow;
            arrowB.MakeTransparent();

            // Draw the image
            pevent.Graphics.DrawImage(arrowB, IconRec);

            // Draw a 1px wide border on the bottom of the button
            ControlPaint.DrawBorder(pevent.Graphics, ClientRectangle,
            Color.Black, 0, ButtonBorderStyle.Solid,
            Color.Black, 0, ButtonBorderStyle.Solid,
            Color.Black, 0, ButtonBorderStyle.Solid,
            Color.FromArgb(149, 149, 149), 1, ButtonBorderStyle.Solid);
        }
    }
}
