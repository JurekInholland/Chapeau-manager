// Made by Jurek Baumann, 2019
using System.Drawing;
using System.Windows.Forms;

namespace Login
{


    /// <summary>
    /// A custom Label subclass that displays
    /// an icon next to the label's text.
    /// The position can be either left or right and defaults to left.
    /// </summary>
    class IconLabel : Label
    {
        private Rectangle IconRec;
        private Rectangle textRec;


        public string IconPosition = "left";
        public Bitmap LabelIcon { get; set; }

        // override paint method to draw a custom button
        protected override void OnPaint(PaintEventArgs pevent)
        {
            SolidBrush textBrush = new SolidBrush(Color.Black);

            if (IconPosition == "right") {
                IconRec = new Rectangle(Width-Height, 0, Height, Height);
                textRec = new Rectangle(0, 0, Width+Height, Height);
            }
            else
            {
                IconRec = new Rectangle(0, 0, Height, Height);
                textRec = new Rectangle(Height, 0, Width - Height, Height);
            }

            // Align the button text to the left, vertically centered
            StringFormat format = new StringFormat
            {
                LineAlignment = StringAlignment.Center,
                Alignment = StringAlignment.Near
            };

            // Draw text
            pevent.Graphics.DrawString(Text, Font, textBrush, textRec, format);

            // Draw the image
            if (LabelIcon != null)
            {
                pevent.Graphics.DrawImage(LabelIcon, IconRec);
            }

        }


    }
}
