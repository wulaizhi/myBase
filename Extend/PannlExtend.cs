using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * @Author: wulaizhi
 * @Description:
 * @Date: 2024/9/12 19:56:13
 * @Modify:
 */
namespace myBase.Extend
{
    public static class PannlExtend
    {
        /// <summary>
        /// 遍历当前的所有的打开窗口，如果通过form的名字判断，一个页面
        /// 只能存在一个实例
        /// </summary>
        /// <param name="formName"></param>
        /// <returns></returns>

        public static bool CheckOpenForm(string formName)
        {
            bool result = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == formName)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }
        /// <summary>
        /// 获取指定form name 的form
        /// </summary>
        /// <param name="formName"></param>
        /// <returns></returns>
        public static Form GetOpenForm(string formName)
        {
            Form result = null;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == formName)
                {
                    result = f;
                    break;
                }
            }
            return result;
        }
        /// <summary>
        /// 将指定的form显示到Pannel中
        /// </summary>
        /// <param name="panel"></param>
        /// <param name="form"></param>
        public static void AddPannelForm(this Panel panel, Form form)
        {
            bool bExist = false;
            //检查页面是否已经打开
            if (CheckOpenForm(form.Name))
            {
                Form f = GetOpenForm(form.Name);
                //判断,当前显示的form是否已经显示在pannel里面
                bool bl = false;

                foreach (Control c in panel.Controls)
                {
                    if (c is Form)
                    {
                        Form fo = (Form)c;
                        if (fo.Name == form.Name)
                        {
                            form = fo;
                            bl = true;
                            bExist = true;
                            break;
                        }
                    }
                }
                if (!bl)
                {
                    form = f;
                }
            }
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.WindowState = FormWindowState.Maximized;
            form.Dock = DockStyle.Fill;
            if (!bExist)
            {
                //panel.Controls.Clear();
                panel.AutoScroll = true;
                panel.Controls.Add(form);
                form.Show();
            }
            if (bExist)
            {
                form.BringToFront(); ;
            }
        }

        public static Control FindControlByName(Control parentControl, string name)
        {
            // 首先检查当前控件是否是我们要找的控件  
            if (parentControl.Name == name)
            {
                return parentControl;
            }

            // 然后遍历当前控件的所有子控件  
            foreach (Control ctrl in parentControl.Controls)
            {
                // 递归查找子控件  
                Control foundCtrl = FindControlByName(ctrl, name);
                if (foundCtrl != null)
                {
                    return foundCtrl; // 如果在子控件中找到，则返回  
                }
            }

            // 如果没有找到，则返回null  
            return null;
        }
    }
}
