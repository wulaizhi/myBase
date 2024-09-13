using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myBase.UControls
{
    public partial class UIconButton : Button
    {
        public UIconButton()
        {
            InitializeComponent();
            this.Size = new Size(30, 30);
            this.Font = new Font("Webdings",10.8F);
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Text = "0";
            this.ForeColor = Color.Silver;
            this.BackColor = Color.Transparent;
        }


        private Color mouseEnterColor = Color.FromArgb(88, 116, 216);

        [Browsable(true)]
        [Category("自定义")]
        [Description("鼠标进入button上的颜色")]
        public Color MouseEnterColor
        {
            get { return mouseEnterColor; }
            set { mouseEnterColor = value; }
        }

        private Color mouseLeaveColor = Color.FromArgb(45, 50, 116);

        [Browsable(true)]
        [Category("自定义")]
        [Description("鼠标离开button上的颜色")]
        public Color MouseLeaveColor
        {
            get { return mouseLeaveColor; }
            set { mouseLeaveColor = value; }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            this.BackColor = this.mouseEnterColor;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this.BackColor = this.mouseLeaveColor;
        }

        /// <summary>
        /// 设置不显示聚焦框
        /// </summary>
        protected override bool ShowFocusCues
        {
            get { return false; }
        }
    }
}
