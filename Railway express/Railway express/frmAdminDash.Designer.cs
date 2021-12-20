namespace Railway_express
{
    partial class frmAdminDash
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
            this.components = new System.ComponentModel.Container();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.prgrsTrainCount = new Guna.UI.WinForms.GunaCircleProgressBar();
            this.lblTrainCount = new Guna.UI.WinForms.GunaLabel();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.gunaShadowPanel2 = new Guna.UI.WinForms.GunaShadowPanel();
            this.prgrsTrainCount.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // prgrsTrainCount
            // 
            this.prgrsTrainCount.AnimationSpeed = 0.6F;
            this.prgrsTrainCount.BaseColor = System.Drawing.Color.Transparent;
            this.prgrsTrainCount.Controls.Add(this.lblTrainCount);
            this.prgrsTrainCount.IdleColor = System.Drawing.Color.Transparent;
            this.prgrsTrainCount.IdleOffset = 20;
            this.prgrsTrainCount.Image = null;
            this.prgrsTrainCount.ImageSize = new System.Drawing.Size(52, 52);
            this.prgrsTrainCount.Location = new System.Drawing.Point(36, 403);
            this.prgrsTrainCount.Name = "prgrsTrainCount";
            this.prgrsTrainCount.ProgressMaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.prgrsTrainCount.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.prgrsTrainCount.ProgressOffset = 20;
            this.prgrsTrainCount.Size = new System.Drawing.Size(277, 268);
            this.prgrsTrainCount.TabIndex = 0;
            this.prgrsTrainCount.Value = 70;
            // 
            // lblTrainCount
            // 
            this.lblTrainCount.AutoSize = true;
            this.lblTrainCount.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTrainCount.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTrainCount.Location = new System.Drawing.Point(105, 120);
            this.lblTrainCount.Name = "lblTrainCount";
            this.lblTrainCount.Size = new System.Drawing.Size(79, 35);
            this.lblTrainCount.TabIndex = 0;
            this.lblTrainCount.Text = "100%";
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.gunaShadowPanel1.Location = new System.Drawing.Point(70, 89);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.Radius = 5;
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.ShadowShift = 6;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(255, 227);
            this.gunaShadowPanel1.TabIndex = 1;
            // 
            // gunaShadowPanel2
            // 
            this.gunaShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.gunaShadowPanel2.Location = new System.Drawing.Point(351, 89);
            this.gunaShadowPanel2.Name = "gunaShadowPanel2";
            this.gunaShadowPanel2.Radius = 5;
            this.gunaShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel2.ShadowShift = 6;
            this.gunaShadowPanel2.Size = new System.Drawing.Size(255, 227);
            this.gunaShadowPanel2.TabIndex = 1;
            // 
            // frmAdminDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1094, 699);
            this.Controls.Add(this.gunaShadowPanel2);
            this.Controls.Add(this.gunaShadowPanel1);
            this.Controls.Add(this.prgrsTrainCount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminDash";
            this.Text = "frmAdminDash";
            this.Load += new System.EventHandler(this.frmAdminDash_Load);
            this.prgrsTrainCount.ResumeLayout(false);
            this.prgrsTrainCount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaCircleProgressBar prgrsTrainCount;
        private Guna.UI.WinForms.GunaLabel lblTrainCount;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel2;
    }
}