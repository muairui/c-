namespace socketExample
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbCOM = new System.Windows.Forms.ComboBox();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.txtReceive = new System.Windows.Forms.TextBox();
            this.btnState = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbCOM
            // 
            this.cmbCOM.FormattingEnabled = true;
            this.cmbCOM.Location = new System.Drawing.Point(26, 177);
            this.cmbCOM.Name = "cmbCOM";
            this.cmbCOM.Size = new System.Drawing.Size(121, 20);
            this.cmbCOM.TabIndex = 0;
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(187, 286);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(100, 21);
            this.txtSend.TabIndex = 1;
            // 
            // txtReceive
            // 
            this.txtReceive.Location = new System.Drawing.Point(187, 341);
            this.txtReceive.Name = "txtReceive";
            this.txtReceive.Size = new System.Drawing.Size(100, 21);
            this.txtReceive.TabIndex = 2;
            // 
            // btnState
            // 
            this.btnState.Location = new System.Drawing.Point(362, 201);
            this.btnState.Name = "btnState";
            this.btnState.Size = new System.Drawing.Size(75, 23);
            this.btnState.TabIndex = 3;
            this.btnState.Text = "button1";
            this.btnState.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnState);
            this.Controls.Add(this.txtReceive);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.cmbCOM);
            this.Name = "FrmMain";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCOM;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.TextBox txtReceive;
        private System.Windows.Forms.Button btnState;
    }
}