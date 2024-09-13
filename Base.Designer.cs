using System;
using System.Drawing;
using System.Windows.Forms;

namespace myBase
{
    partial class Base
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        bool sidbarExpend = true;
        bool honmebarExpend = false;
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;


        private void BaseLoad(object sender, EventArgs e)
        {
            const int MaxW = 250;
            const int MinW = 85;
            Size minSize = sidBar.MinimumSize;
            Size maxSize = sidBar.MaximumSize;
            sidBar.MinimumSize = new Size(MinW, minSize.Height);
            sidBar.MaximumSize = new Size(MaxW, maxSize.Height);

            //homeBar
            int homeBarFpanlMaxH = 220;
            int homeBarFpanlMinH = 50;
            Size homeBarFpanlminSize = homeBarFpanl.MinimumSize;
            Size homeBarFpanlmaxSize = homeBarFpanl.MaximumSize;
            homeBarFpanl.MinimumSize = new Size(homeBarFpanlminSize.Width, homeBarFpanlMinH);
            homeBarFpanl.MaximumSize = new Size(homeBarFpanlmaxSize.Width, homeBarFpanlMaxH);
        }

        private void sidabarTimer_Tick(object sender, EventArgs e)
        {
            if (sidbarExpend)
            {
                sidBar.Width -= 30;
                if (sidBar.Width == sidBar.MinimumSize.Width)
                {
                    sidbarExpend = false;
                    sidBarTimer.Stop();
                }
            }
            else
            {
                sidBar.Width += 30;
                if (sidBar.Width == sidBar.MaximumSize.Width)
                {
                    sidbarExpend = true;
                    sidBarTimer.Stop();
                }
            }
        }
        private void homeBarTimer_Tick(object sender, EventArgs e)
        {
            if (honmebarExpend)
            {
                homeBarFpanl.Height -= 10;
                if (homeBarFpanl.Height == homeBarFpanl.MinimumSize.Height)
                {
                    honmebarExpend = false;
                    homeBarTimer.Stop();
                }
            }
            else
            {
                homeBarFpanl.Height += 10;
                if (homeBarFpanl.Height == homeBarFpanl.MaximumSize.Height)
                {
                    honmebarExpend = true;
                    homeBarTimer.Stop();
                }
            }
            Invalidate();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidBarTimer.Start();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            homeBarTimer.Start();
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            // 只当鼠标右键被按下时开始拖动  
            if ((e.Button == MouseButtons.Right) || (e.Button == MouseButtons.Left))
            {
                dragging = true;
                dragCursorPoint = Cursor.Position;
                dragFormPoint = this.Location;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            // 只在拖动时移动窗体  
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            // 无论哪个鼠标按钮释放，都停止拖动  
            dragging = false;
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Base));
            this.sidBar = new System.Windows.Forms.FlowLayoutPanel();
            this.he = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.homeBarFpanl = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.sidBarTimer = new System.Windows.Forms.Timer(this.components);
            this.homeBarTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.MaxIcon = new myBase.UControls.UIconButton();
            this.MinIcon = new myBase.UControls.UIconButton();
            this.CloseIcon = new myBase.UControls.UIconButton();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.panelBarHeader = new System.Windows.Forms.FlowLayoutPanel();
            this.sidBar.SuspendLayout();
            this.he.SuspendLayout();
            this.homeBarFpanl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidBar
            // 
            this.sidBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.sidBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sidBar.Controls.Add(this.he);
            this.sidBar.Controls.Add(this.homeBarFpanl);
            this.sidBar.Controls.Add(this.button3);
            this.sidBar.Controls.Add(this.button4);
            this.sidBar.Controls.Add(this.button2);
            this.sidBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidBar.Location = new System.Drawing.Point(0, 0);
            this.sidBar.Margin = new System.Windows.Forms.Padding(0);
            this.sidBar.Name = "sidBar";
            this.sidBar.Size = new System.Drawing.Size(250, 800);
            this.sidBar.TabIndex = 0;
            // 
            // he
            // 
            this.he.Controls.Add(this.button5);
            this.he.Location = new System.Drawing.Point(3, 3);
            this.he.Name = "he";
            this.he.Size = new System.Drawing.Size(250, 120);
            this.he.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(3, 40);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(250, 50);
            this.button5.TabIndex = 2;
            this.button5.Text = "     Menu";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // homeBarFpanl
            // 
            this.homeBarFpanl.Controls.Add(this.button1);
            this.homeBarFpanl.Controls.Add(this.button8);
            this.homeBarFpanl.Controls.Add(this.button6);
            this.homeBarFpanl.Controls.Add(this.button7);
            this.homeBarFpanl.Location = new System.Drawing.Point(3, 129);
            this.homeBarFpanl.MaximumSize = new System.Drawing.Size(250, 220);
            this.homeBarFpanl.MinimumSize = new System.Drawing.Size(250, 50);
            this.homeBarFpanl.Name = "homeBarFpanl";
            this.homeBarFpanl.Size = new System.Drawing.Size(250, 50);
            this.homeBarFpanl.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(250, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "     Home";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button8
            // 
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Dock = System.Windows.Forms.DockStyle.Top;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(3, 59);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button8.Size = new System.Drawing.Size(250, 50);
            this.button8.TabIndex = 7;
            this.button8.Text = "      SubMenu";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(3, 115);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(250, 50);
            this.button6.TabIndex = 5;
            this.button6.Text = "      SubMenu";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(3, 171);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button7.Size = new System.Drawing.Size(250, 50);
            this.button7.TabIndex = 6;
            this.button7.Text = "      SubMenu";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(3, 185);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(250, 50);
            this.button3.TabIndex = 3;
            this.button3.Text = "     Help";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(3, 241);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(250, 50);
            this.button4.TabIndex = 4;
            this.button4.Text = "     About";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(3, 297);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(250, 50);
            this.button2.TabIndex = 2;
            this.button2.Text = "     Setting";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // sidBarTimer
            // 
            this.sidBarTimer.Interval = 20;
            this.sidBarTimer.Tick += new System.EventHandler(this.sidabarTimer_Tick);
            // 
            // homeBarTimer
            // 
            this.homeBarTimer.Interval = 10;
            this.homeBarTimer.Tick += new System.EventHandler(this.homeBarTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.MaxIcon);
            this.panel1.Controls.Add(this.MinIcon);
            this.panel1.Controls.Add(this.CloseIcon);
            this.panel1.Location = new System.Drawing.Point(250, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1150, 72);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // MaxIcon
            // 
            this.MaxIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxIcon.BackColor = System.Drawing.Color.Transparent;
            this.MaxIcon.FlatAppearance.BorderSize = 0;
            this.MaxIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaxIcon.Font = new System.Drawing.Font("Webdings", 10.8F);
            this.MaxIcon.ForeColor = System.Drawing.Color.Silver;
            this.MaxIcon.Location = new System.Drawing.Point(1049, 3);
            this.MaxIcon.MouseEnterColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.MaxIcon.MouseLeaveColor = System.Drawing.Color.Transparent;
            this.MaxIcon.Name = "MaxIcon";
            this.MaxIcon.Size = new System.Drawing.Size(45, 45);
            this.MaxIcon.TabIndex = 2;
            this.MaxIcon.Text = "1";
            this.MaxIcon.UseVisualStyleBackColor = false;
            this.MaxIcon.Click += new System.EventHandler(this.MaxIcon_Click);
            // 
            // MinIcon
            // 
            this.MinIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinIcon.BackColor = System.Drawing.Color.Transparent;
            this.MinIcon.FlatAppearance.BorderSize = 0;
            this.MinIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinIcon.Font = new System.Drawing.Font("Webdings", 10.8F);
            this.MinIcon.ForeColor = System.Drawing.Color.Silver;
            this.MinIcon.Location = new System.Drawing.Point(998, 3);
            this.MinIcon.MouseEnterColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.MinIcon.MouseLeaveColor = System.Drawing.Color.Transparent;
            this.MinIcon.Name = "MinIcon";
            this.MinIcon.Size = new System.Drawing.Size(45, 45);
            this.MinIcon.TabIndex = 1;
            this.MinIcon.Text = "0";
            this.MinIcon.UseVisualStyleBackColor = false;
            this.MinIcon.Click += new System.EventHandler(this.MinIcon_Click);
            // 
            // CloseIcon
            // 
            this.CloseIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseIcon.BackColor = System.Drawing.Color.Transparent;
            this.CloseIcon.FlatAppearance.BorderSize = 0;
            this.CloseIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseIcon.Font = new System.Drawing.Font("Webdings", 10.8F);
            this.CloseIcon.ForeColor = System.Drawing.Color.Silver;
            this.CloseIcon.Location = new System.Drawing.Point(1100, 3);
            this.CloseIcon.MouseEnterColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.CloseIcon.MouseLeaveColor = System.Drawing.Color.Transparent;
            this.CloseIcon.Name = "CloseIcon";
            this.CloseIcon.Size = new System.Drawing.Size(45, 45);
            this.CloseIcon.TabIndex = 0;
            this.CloseIcon.Text = "r";
            this.CloseIcon.UseVisualStyleBackColor = false;
            this.CloseIcon.Click += new System.EventHandler(this.CloseIcon_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Location = new System.Drawing.Point(250, 130);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(1150, 616);
            this.ContentPanel.TabIndex = 4;
            // 
            // panelBarHeader
            // 
            this.panelBarHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBarHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panelBarHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBarHeader.Location = new System.Drawing.Point(250, 72);
            this.panelBarHeader.Name = "panelBarHeader";
            this.panelBarHeader.Size = new System.Drawing.Size(1150, 54);
            this.panelBarHeader.TabIndex = 3;
            // 
            // Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.panelBarHeader);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sidBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Base";
            this.ShowIcon = false;
            this.Text = "Base";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Base_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.sidBar.ResumeLayout(false);
            this.he.ResumeLayout(false);
            this.homeBarFpanl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidBar;
        private System.Windows.Forms.Panel he;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer sidBarTimer;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Timer homeBarTimer;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel homeBarFpanl;
        private UControls.UIconButton MaxIcon;
        private UControls.UIconButton MinIcon;
        private UControls.UIconButton CloseIcon;
        private Panel panel1;
        private Panel ContentPanel;
        private FlowLayoutPanel panelBarHeader;
    }
}

