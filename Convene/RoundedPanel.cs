using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convene
{
    internal class RoundedPanel:Panel
    {

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int BorderRadius { get; set; } = 10;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color BorderColor { get; set; } = Color.FromArgb(224, 224, 224);

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int BorderSize { get; set; } = 2;

        public RoundedPanel()
        {
            this.DoubleBuffered = true;
            this.BackColor = Color.FromArgb(248, 248, 255); // Ghost White
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            // Shrink the border rectangle slightly so thick borders fit perfectly inside the panel
            RectangleF rectBorder = new RectangleF(BorderSize / 2f, BorderSize / 2f, this.Width - BorderSize, this.Height - BorderSize);

            using (GraphicsPath pathSurface = GetFigurePath(rectSurface, BorderRadius))
            using (GraphicsPath pathBorder = GetFigurePath(rectBorder, Math.Max(1f, BorderRadius - (BorderSize / 2f))))
            using (Pen penBorder = new Pen(BorderColor, BorderSize))
            using (SolidBrush brushSurface = new SolidBrush(this.BackColor))
            {
                // 1. Paint the parent's background color in the corners to eliminate jagged black edges
                if (this.Parent != null)
                {
                    e.Graphics.Clear(this.Parent.BackColor);
                }

                // 2. Fill the panel background smoothly
                e.Graphics.FillPath(brushSurface, pathSurface);

                // 3. Draw the thick border smoothly
                if (BorderSize > 0)
                {
                    e.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
        }

        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();

            return path;
        }


    }
}
