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
        public HashSet<Control> IgnoreControls = new HashSet<Control>();
        private Size originalFormSize;
        private Dictionary<Control, Rectangle> originalControls = new Dictionary<Control, Rectangle>();
        private Dictionary<Control, float> originalFonts = new Dictionary<Control, float>();
        private bool isCaptured;

        public void Capture(Form form)
        {
            if (form == null) throw new ArgumentNullException(nameof(form));

            originalControls.Clear();
            originalFonts.Clear();

            originalFormSize = form.Size;
            SaveOriginalControls(form);

            isCaptured = originalFormSize.Width > 0 && originalFormSize.Height > 0 && originalControls.Count > 0;
        }

        public void Resize(Form form)
        {
            if (form == null)
                return;

            // Do nothing until initial layout captured
            if (!isCaptured)
                return;

            if (originalFormSize.Width == 0 || originalFormSize.Height == 0)
                return;

            float xRatio = (float)form.Width / originalFormSize.Width;
            float yRatio = (float)form.Height / originalFormSize.Height;

            if (float.IsInfinity(xRatio) || float.IsInfinity(yRatio) || float.IsNaN(xRatio) || float.IsNaN(yRatio))
                return;

            if (Math.Abs(xRatio - 1f) < 1e-6f && Math.Abs(yRatio - 1f) < 1e-6f)
                return;

            ResizeAllControls(form, xRatio, yRatio);
        }

        private void SaveOriginalControls(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (!originalControls.ContainsKey(c))
                {
                    originalControls[c] = new Rectangle(c.Location, c.Size);
                    originalFonts[c] = c.Font?.Size ?? SystemFonts.DefaultFont.Size;
                }

                if (c.HasChildren)
                    SaveOriginalControls(c);
            }
        }

        private void ResizeAllControls(Control parent, float xRatio, float yRatio)
        {
            foreach (Control c in parent.Controls)
            {
                if (IgnoreControls.Contains(c))
                    continue;

                Rectangle r;
                float origFont;

                if (!originalControls.TryGetValue(c, out r) || !originalFonts.TryGetValue(c, out origFont))
                {
                    if (c.HasChildren)
                        ResizeAllControls(c, xRatio, yRatio);
                    continue;
                }

                var newX = (int)(r.X * xRatio);
                var newY = (int)(r.Y * yRatio);
                var newW = Math.Max(1, (int)(r.Width * xRatio));
                var newH = Math.Max(1, (int)(r.Height * yRatio));

                c.Location = new Point(newX, newY);
                c.Size = new Size(newW, newH);

                float newFont = origFont * ((xRatio + yRatio) / 2f);
                newFont = Math.Max(1f, newFont);

                if (c.Font == null || Math.Abs(c.Font.Size - newFont) > 0.2f)
                {
                    try
                    {
                        c.Font = new Font(c.Font?.FontFamily ?? SystemFonts.DefaultFont.FontFamily, newFont, c.Font?.Style ?? FontStyle.Regular);
                    }
                    catch
                    {
                        c.Font = new Font(SystemFonts.DefaultFont.FontFamily, newFont);
                    }
                }

                if (c.HasChildren)
                    ResizeAllControls(c, xRatio, yRatio);
            }
        }
    }

}
