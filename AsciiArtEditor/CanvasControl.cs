using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsciiArtEditor
{
    public partial class CanvasControl : UserControl
    {
        public int charWidth = 10;
        public int charHeight = 20;
        public float scaleHeight = 1.3333f;
        public CanvasControl()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsState state = e.Graphics.Save();
            if (DesignMode)
            {
                return;
            }
            e.Graphics.ScaleTransform(1, scaleHeight);
            StringFormat format = StringFormat.GenericDefault;
            format.Alignment = StringAlignment.Center;
            format.FormatFlags = StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.MeasureTrailingSpaces;
            format.LineAlignment = StringAlignment.Center;
            for (int y = 0; y < AsciiArt.height; y++)
            {
                for (int x = 0; x < AsciiArt.width; x++)
                {
                    Rectangle thisCharRect = new Rectangle(x * charWidth, (int)Math.Floor(y * (charHeight/scaleHeight)), charWidth, (int)Math.Floor(charHeight / scaleHeight));
                    if (!e.ClipRectangle.IntersectsWith(thisCharRect)) continue;

                    Brush bgb = new SolidBrush(Util.ToColor(AsciiArt.characters[x, y].BG));
                    Brush fgb = new SolidBrush(Util.ToColor(AsciiArt.characters[x, y].FG));
                    if (x >= AsciiArt.selectionMinX && x <= AsciiArt.selectionMaxX && y >= AsciiArt.selectionMinY && y <= AsciiArt.selectionMaxY)
                    {
                        bgb = new HatchBrush(HatchStyle.SolidDiamond, Util.ToColor(AsciiArt.characters[x, y].BG));
                    }
                    if (x == AsciiArt.cursorX && y == AsciiArt.cursorY)
                    {
                        bgb = new HatchBrush(HatchStyle.Percent50, Color.AliceBlue);
                    }
                    e.Graphics.FillRectangle(bgb, thisCharRect);
                    RectangleF textRect = thisCharRect;
                    textRect.Inflate(4, 4);
                    e.Graphics.DrawString(AsciiArt.characters[x, y].character, DefaultFont, fgb, textRect, format);
                }
            }
            e.Graphics.Restore(state);
        }
    }
}
