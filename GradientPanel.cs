using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CarsDB
{
    class GradientPanel : Panel
    {
        private Color _firstFillColor;
        private Color _secondFillColor;
        private LinearGradientMode _gradientDirection;

        [Description("Первый цвет градиента."), DefaultValue(typeof(Color), "")]
        public Color ColorFillFirst
        {
            get => _firstFillColor;
            set => _firstFillColor = value;
        }
        [Description("Второй цвет градиента."), DefaultValue(typeof(Color), "")]
        public Color ColorFillSecond
        {
            get => _secondFillColor;
            set => _secondFillColor = value;
        }
        [Description("Направление градиента."), DefaultValue(LinearGradientMode.ForwardDiagonal)]
        public LinearGradientMode GradientDirection
        {
            get => _gradientDirection;
            set => _gradientDirection = value;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (ClientRectangle.Width != 0)
            {
                var brush = new LinearGradientBrush(ClientRectangle, _firstFillColor, _secondFillColor, _gradientDirection);
                var g = e.Graphics;
                g.FillRectangle(brush, ClientRectangle);
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                SetStyle(ControlStyles.ResizeRedraw, true);
                base.OnPaint(e);
            }
        }
    }
}
