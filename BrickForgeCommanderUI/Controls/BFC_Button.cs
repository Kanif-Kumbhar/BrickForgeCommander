using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;

namespace BrickForgeCommanderUI.Controls
{
    public class BFC_Button : Button
    {
        private int borderSize = 0;
        private int borderRadius = 20;
        private Color borderColor = Color.PaleVioletRed;
        private Color borderFocusColor = Color.Green;
        private readonly Color originalBorderColor;

        private static Dictionary<BFC_Button, Keys> clickKeys = new Dictionary<BFC_Button, Keys>();

        public BFC_Button()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
            this.Resize += new EventHandler(Button_Resize);

            this.GotFocus += BFC_Button_GotFocus;
            this.LostFocus += BFC_Button_LostFocus;
            this.KeyDown += BFC_Button_KeyDown;

            if (!clickKeys.ContainsKey(this))
            {
                clickKeys.Add(this, Keys.None);
            }

            originalBorderColor = borderColor;

            this.Disposed += new EventHandler(BFC_Button_Disposed);
        }

        #region Properties

        [Category("BFC Custom")]
        [DisplayName("Attached Key")]
        [Description("Attach the key to perform click action.")]
        public Keys ClickKey
        {
            get
            {
                if (clickKeys.ContainsKey(this))
                {
                    return clickKeys[this];
                }
                else
                {
                    return Keys.None;
                }
            }
            set
            {
                if (clickKeys.ContainsKey(this))
                {
                    clickKeys[this] = value;
                }
                else
                {
                    clickKeys.Add(this, value);
                }
            }
        }

        [Category("BFC Custom")]
        public Color BorderFocusColor { get => borderFocusColor; set => borderFocusColor = value; }

        [Category("BFC Custom")]
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        [Category("BFC Custom")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                if (value <= this.Height)
                    borderRadius = value;
                else borderRadius = this.Height;
                this.Invalidate();
            }
        }

        [Category("BFC Custom")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        [Category("BFC Custom")]
        public Color BackgroundColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        [Category("BFC Custom")]
        public Color TextColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }

        #endregion

        private void Button_Resize(object sender, EventArgs e)
        {
            if (borderRadius > this.Height)
                borderRadius = this.Height;
        }

        private GraphicsPath GetFigurePath(Rectangle rect, float radius)
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

        #region Override

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
            int smoothSize = 2;
            if (borderSize > 0)
                smoothSize = borderSize;

            if (borderRadius > 2)
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    this.Region = new Region(pathSurface);
                    pevent.Graphics.DrawPath(penSurface, pathSurface);

                    if (borderSize >= 1)
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.None;
                this.Region = new Region(rectSurface);

                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);

            if (this.Parent != null)
            {
                this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
            }
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        #endregion

        private void BFC_Button_GotFocus(object sender, EventArgs e)
        {
            borderColor = borderFocusColor;
            this.Invalidate();
        }

        private void BFC_Button_LostFocus(object sender, EventArgs e)
        {
            borderColor = originalBorderColor;
            this.Invalidate();
        }

        private void BFC_Button_KeyDown(object sender, KeyEventArgs e)
        {
            if (clickKeys.ContainsKey(this))
            {
                Keys assignedKey = clickKeys[this];

                // Check if the assigned key matches and no modifiers are pressed
                if (e.KeyCode == assignedKey && e.Modifiers == Keys.None)
                {
                    this.Focus();
                    this.PerformClick();
                }
                // Check if a combination of Ctrl+Shift+AssignedKey is pressed
                else if (e.KeyCode == assignedKey && (e.Modifiers & (Keys.Control | Keys.Shift)) == (Keys.Control | Keys.Shift))
                {
                    this.Focus();
                    this.PerformClick();
                }
            }
        }



        private void BFC_Button_Disposed(object sender, EventArgs e)
        {
            clickKeys.Remove(this);

            if (this.Parent != null)
            {
                this.Parent.BackColorChanged -= Container_BackColorChanged;
            }
        }
    }
}
