using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlaKlouk
{
    public class FormResizer
    {
        private Size originalFormSize;
        private Dictionary<Control, Rectangle> originalControls = new Dictionary<Control, Rectangle>();
        private Dictionary<Control, float> originalFonts = new Dictionary<Control, float>();

        public void Capture(Form form)
        {
            originalFormSize = form.Size;
            SaveOriginalControls(form);
        }

        public void Resize(Form form)
        {
            float xRatio = (float)form.Width / originalFormSize.Width;
            float yRatio = (float)form.Height / originalFormSize.Height;

            ResizeAllControls(form, xRatio, yRatio);
        }

        private void SaveOriginalControls(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                originalControls[c] = new Rectangle(c.Location, c.Size);
                originalFonts[c] = c.Font.Size;

                if (c.HasChildren)
                    SaveOriginalControls(c);
            }
        }

        private void ResizeAllControls(Control parent, float xRatio, float yRatio)
        {
            foreach (Control c in parent.Controls)
            {
                Rectangle r = originalControls[c];

                c.Location = new Point((int)(r.X * xRatio), (int)(r.Y * yRatio));
                c.Size = new Size((int)(r.Width * xRatio), (int)(r.Height * yRatio));

                float newFont = originalFonts[c] * ((xRatio + yRatio) / 2);
                c.Font = new Font(c.Font.FontFamily, newFont);

                if (c.HasChildren)
                    ResizeAllControls(c, xRatio, yRatio);
            }
        }
    }

}
