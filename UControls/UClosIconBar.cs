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
    public partial class UClosIconBar : UserControl
    {
        public UClosIconBar()
        {
            InitializeComponent();
        }

        private Color mouseEnterColor = Color.Transparent;

        [Browsable(true)]
        [Category("自定义")]
        [Description("鼠标进入button上的颜色")]
        public Color MouseEnterColor
        {
            get { return uIcon.MouseEnterColor; }
            set { uIcon.MouseEnterColor = value; }
        }

        private Color mouseLeaveColor = Color.Transparent;

        [Browsable(true)]
        [Category("自定义")]
        [Description("鼠标离开button上的颜色")]
        public Color MouseLeaveColor
        {
            get { return uIcon.MouseLeaveColor; }
            set { uIcon.MouseLeaveColor = value; }
        }

        private string lableText;

        [Browsable(true)]
        [Category("自定义")]
        [Description("lable的文本")]
        public string LableText
        {
            get { return uLabel.Text; }
            set { uLabel.Text = value; }
        }

        private Color lableForeColor = Color.White;

        [Browsable(true)]
        [Category("自定义")]
        [Description("lable的文本颜色")]
        public Color LableForeColor
        {
            get { return uLabel.ForeColor; }
            set { uLabel.ForeColor = value; }
        }


        [Browsable(true)]
        [Category("自定义")]
        [Description("关闭按钮被点击执行的方法")]
        public event Action<string> clickClosed=null;

        private void uIcon_Click(object sender, EventArgs e)
        {
            clickClosed?.Invoke(this.uLabel.Text);
        }

        [Browsable(true)]
        [Category("自定义")]
        [Description("lable被点击执行的方法")]
        public event Action<string> clickSwitch = null;

        private void uLabel_Click(object sender, EventArgs e)
        {
            clickSwitch?.Invoke(this.uLabel.Text);
        }
    }
}
