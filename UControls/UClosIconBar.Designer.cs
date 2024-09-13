namespace myBase.UControls
{
    partial class UClosIconBar
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.uLabel = new System.Windows.Forms.Label();
            this.uIcon = new myBase.UControls.UIconButton();
            this.SuspendLayout();
            // 
            // uLabel
            // 
            this.uLabel.AutoSize = true;
            this.uLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uLabel.ForeColor = System.Drawing.Color.White;
            this.uLabel.Location = new System.Drawing.Point(13, 17);
            this.uLabel.Name = "uLabel";
            this.uLabel.Size = new System.Drawing.Size(80, 18);
            this.uLabel.TabIndex = 0;
            this.uLabel.Text = "用户管理";
            this.uLabel.Click += new System.EventHandler(this.uLabel_Click);
            // 
            // uIcon
            // 
            this.uIcon.BackColor = System.Drawing.Color.Transparent;
            this.uIcon.FlatAppearance.BorderSize = 0;
            this.uIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uIcon.Font = new System.Drawing.Font("Webdings", 10.8F);
            this.uIcon.ForeColor = System.Drawing.Color.Silver;
            this.uIcon.Location = new System.Drawing.Point(109, 6);
            this.uIcon.MouseEnterColor = System.Drawing.Color.Transparent;
            this.uIcon.MouseLeaveColor = System.Drawing.Color.Transparent;
            this.uIcon.Name = "uIcon";
            this.uIcon.Size = new System.Drawing.Size(30, 30);
            this.uIcon.TabIndex = 1;
            this.uIcon.Text = "r";
            this.uIcon.UseVisualStyleBackColor = false;
            this.uIcon.Click += new System.EventHandler(this.uIcon_Click);
            // 
            // UClosIconBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.uIcon);
            this.Controls.Add(this.uLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.Name = "UClosIconBar";
            this.Size = new System.Drawing.Size(149, 43);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uLabel;
        private UIconButton uIcon;
    }
}
