using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace FA.Koyo.TRD_KEM.UI
{
    public partial class LED : UserControl
    {
        public  LED()
        {
            InitializeComponent();

            //支持重绘和背景透明化
            SetStyle(ControlStyles.UserPaint | ControlStyles.SupportsTransparentBackColor, true);
            //调整大小
            SetStyle(ControlStyles.ResizeRedraw, true);
            //双缓存
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            //不在接收系统的Message
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }


        private Color centerColor = Color.White;
        private Color gridentColor = Color.LightGreen;
        private Color bordeColor = Color.LightGray;
        private int borderwidth = 2;
        private int distance = 4;


        /// <summary>
        /// 中心颜色
        /// </summary>
        public Color CenterColor
        {
            get { return centerColor; }
            set { centerColor = value; Invalidate(); }
        }

        /// <summary>
        /// 渐变颜色
        /// </summary>
        public Color GridentColor
        {
            get { return gridentColor; }
            set { gridentColor = value; Invalidate(); }
        }
        /// <summary>
        /// 边框颜色
        /// </summary>
        public Color BordeColor
        {
            get { return bordeColor; }
            set { bordeColor = value; Invalidate(); }
        }


        /// <summary>
        /// 内外圆宽度
        /// </summary>
        public int BorderWidth
        {
            get { return borderwidth; }
            set { borderwidth = value; Invalidate(); }
        }


        /// <summary>
        /// 内外圆间距
        /// </summary>
        public int Distance
        {
            get { return distance; }
            set { distance = value; Invalidate(); }
        }


        /// <summary>   
        /// 重绘控件
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            //1.画布
            //2.矩形
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            Rectangle rectOut = new Rectangle(borderwidth, borderwidth, this.Width - 2 * borderwidth, this.Height - 2 * borderwidth);
            Pen pen = new Pen(bordeColor, borderwidth);
            e.Graphics.DrawEllipse(pen, rectOut);
            Rectangle rectIn = new Rectangle(borderwidth + distance, borderwidth + distance,
                               this.Width - 2 * borderwidth - 2 * distance, this.Height - 2 * borderwidth - 2 * distance);

            e.Graphics.DrawEllipse(pen, rectIn);

            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(rectIn);
            PathGradientBrush pathBursh = new PathGradientBrush(path);
            pathBursh.CenterColor = centerColor;
            pathBursh.SurroundColors = new Color[] { gridentColor };
            e.Graphics.FillPath(pathBursh, path);

            base.OnPaint(e);
        }
    }
}
