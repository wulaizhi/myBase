using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using myBase.Extend;
using myBase.Helper;
using myBase.Home;
using myBase.UControls;
namespace myBase
{
    public partial class Base : Form
    {

        public Base()                                                                                                                 
        {
            InitializeComponent();
            this.Load += BaseLoad;
        }





        private void MaxIcon_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;

                MaxIcon.Text = "2";
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                MaxIcon.Text = "1";
            }

        }

        private void MinIcon_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Minimized;
            }

        }

        private void CloseIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Base_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MsgBoxHelper.MsgBoxConfirm("退出系统", "您确定要退出系统吗?") == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }
        Point point = new Point();

        bool isMove = false;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;
            isMove = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && isMove)
            {
                Point pointNew = e.Location;//拖动到的新位置
                Point fPointNew = new Point(pointNew.X - point.X, pointNew.Y - point.Y);//相对于原来的起点的距离点
                this.Location += new Size(fPointNew);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Submenu3 submenu3 = new Submenu3();
            AddFormToPanel(submenu3);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Submenu1 submenu1 = new Submenu1();
            AddFormToPanel(submenu1);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Submenu2 submenu2 = new Submenu2();
            AddFormToPanel(submenu2);
        }
        private void AddFormToPanel(Form form)
        {
            PannlExtend.AddPannelForm(this.ContentPanel, form);
            UClosIconBar closIconBar = new UClosIconBar();
            closIconBar.Name = form.Name + "BarItem";
            closIconBar.LableText = form.Name;
            Control control = PannlExtend.FindControlByName(this.panelBarHeader, closIconBar.Name);
            if (control != null)
            {
                return;
            }
            panelBarHeader.Controls.Add(closIconBar);
            closIconBar.clickClosed += ClosIconBar_clickClosed;
            closIconBar.clickSwitch += ClosIconBar_clickSwitch;
        }
        private void ClosIconBar_clickSwitch(string name)
        {
            Control control = PannlExtend.GetOpenForm(name);
            PannlExtend.AddPannelForm(this.ContentPanel, control as Form);
        }

        private void ClosIconBar_clickClosed(string name)
        {
            PannlExtend.GetOpenForm(name).Close();
            Control control = PannlExtend.FindControlByName(panelBarHeader, name + "BarItem");
            if (control != null)
            {
                panelBarHeader.Controls.Remove(control);
            }

        }

    }
}
