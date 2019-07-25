namespace ButtonEx
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.controlButton1 = new ButtonEx.ControlButton();
            this.SuspendLayout();
            // 
            // controlButton1
            // 
            this.controlButton1.ClickedForeColor = System.Drawing.Color.Yellow;
            this.controlButton1.DownImage = ((System.Drawing.Image)(resources.GetObject("controlButton1.DownImage")));
            this.controlButton1.EnableClicked = true;
            this.controlButton1.EnterImage = null;
            this.controlButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.controlButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.controlButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.controlButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.controlButton1.ImageSize = new System.Drawing.Size(0, 0);
            this.controlButton1.IsClicked = false;
            this.controlButton1.Location = new System.Drawing.Point(135, 97);
            this.controlButton1.Name = "controlButton1";
            this.controlButton1.Size = new System.Drawing.Size(267, 120);
            this.controlButton1.TabIndex = 0;
            this.controlButton1.Text = "controlButton1";
            this.controlButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.controlButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ControlButton controlButton1;
    }
}

