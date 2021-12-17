namespace Railway_express
{
    partial class frmAdminTrain
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
            this.btnLine = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnStation = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.pnlChange = new Guna.UI.WinForms.GunaPanel();
            this.btnTrain = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // btnLine
            // 
            this.btnLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLine.AnimationHoverSpeed = 0.07F;
            this.btnLine.AnimationSpeed = 0.03F;
            this.btnLine.BaseColor = System.Drawing.Color.Transparent;
            this.btnLine.BorderColor = System.Drawing.Color.Black;
            this.btnLine.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnLine.CheckedBaseColor = System.Drawing.Color.Transparent;
            this.btnLine.CheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.btnLine.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.btnLine.CheckedImage = null;
            this.btnLine.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.btnLine.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLine.FocusedColor = System.Drawing.Color.Empty;
            this.btnLine.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLine.ForeColor = System.Drawing.Color.White;
            this.btnLine.Image = null;
            this.btnLine.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLine.LineBottom = 2;
            this.btnLine.LineColor = System.Drawing.Color.Transparent;
            this.btnLine.Location = new System.Drawing.Point(169, 128);
            this.btnLine.Name = "btnLine";
            this.btnLine.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnLine.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnLine.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.btnLine.OnHoverImage = null;
            this.btnLine.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnLine.OnPressedColor = System.Drawing.Color.Black;
            this.btnLine.Size = new System.Drawing.Size(180, 58);
            this.btnLine.TabIndex = 6;
            this.btnLine.Text = "Train Line";
            this.btnLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnStation
            // 
            this.btnStation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStation.AnimationHoverSpeed = 0.07F;
            this.btnStation.AnimationSpeed = 0.03F;
            this.btnStation.BaseColor = System.Drawing.Color.Transparent;
            this.btnStation.BorderColor = System.Drawing.Color.Black;
            this.btnStation.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnStation.CheckedBaseColor = System.Drawing.Color.Transparent;
            this.btnStation.CheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.btnStation.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.btnStation.CheckedImage = null;
            this.btnStation.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.btnStation.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnStation.FocusedColor = System.Drawing.Color.Empty;
            this.btnStation.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnStation.ForeColor = System.Drawing.Color.White;
            this.btnStation.Image = null;
            this.btnStation.ImageSize = new System.Drawing.Size(20, 20);
            this.btnStation.LineBottom = 2;
            this.btnStation.LineColor = System.Drawing.Color.Transparent;
            this.btnStation.Location = new System.Drawing.Point(355, 128);
            this.btnStation.Name = "btnStation";
            this.btnStation.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnStation.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnStation.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.btnStation.OnHoverImage = null;
            this.btnStation.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnStation.OnPressedColor = System.Drawing.Color.Black;
            this.btnStation.Size = new System.Drawing.Size(180, 58);
            this.btnStation.TabIndex = 6;
            this.btnStation.Text = "Train Station";
            this.btnStation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnStation.Click += new System.EventHandler(this.btnStation_Click);
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.gunaAdvenceButton1);
            this.gunaPanel1.Controls.Add(this.btnTrain);
            this.gunaPanel1.Controls.Add(this.btnLine);
            this.gunaPanel1.Controls.Add(this.btnStation);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1094, 192);
            this.gunaPanel1.TabIndex = 7;
            // 
            // pnlChange
            // 
            this.pnlChange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChange.Location = new System.Drawing.Point(0, 192);
            this.pnlChange.Name = "pnlChange";
            this.pnlChange.Size = new System.Drawing.Size(1094, 507);
            this.pnlChange.TabIndex = 8;
            // 
            // btnTrain
            // 
            this.btnTrain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTrain.AnimationHoverSpeed = 0.07F;
            this.btnTrain.AnimationSpeed = 0.03F;
            this.btnTrain.BaseColor = System.Drawing.Color.Transparent;
            this.btnTrain.BorderColor = System.Drawing.Color.Black;
            this.btnTrain.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnTrain.Checked = true;
            this.btnTrain.CheckedBaseColor = System.Drawing.Color.Transparent;
            this.btnTrain.CheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.btnTrain.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.btnTrain.CheckedImage = null;
            this.btnTrain.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.btnTrain.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTrain.FocusedColor = System.Drawing.Color.Empty;
            this.btnTrain.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnTrain.ForeColor = System.Drawing.Color.White;
            this.btnTrain.Image = null;
            this.btnTrain.ImageSize = new System.Drawing.Size(20, 20);
            this.btnTrain.LineBottom = 2;
            this.btnTrain.LineColor = System.Drawing.Color.Transparent;
            this.btnTrain.Location = new System.Drawing.Point(12, 128);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnTrain.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnTrain.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.btnTrain.OnHoverImage = null;
            this.btnTrain.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnTrain.OnPressedColor = System.Drawing.Color.Black;
            this.btnTrain.Size = new System.Drawing.Size(180, 58);
            this.btnTrain.TabIndex = 7;
            this.btnTrain.Text = "Train";
            this.btnTrain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.gunaAdvenceButton1.CheckedImage = null;
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.gunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.Image = null;
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton1.LineBottom = 2;
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(541, 128);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(180, 58);
            this.gunaAdvenceButton1.TabIndex = 8;
            this.gunaAdvenceButton1.Text = "Train Tickets";
            this.gunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmAdminTrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1094, 699);
            this.Controls.Add(this.pnlChange);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminTrain";
            this.Text = "frmAdminDash";
            this.Load += new System.EventHandler(this.frmAdminTrain_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaAdvenceButton btnLine;
        private Guna.UI.WinForms.GunaAdvenceButton btnStation;
        private Guna.UI.WinForms.GunaPanel pnlChange;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaAdvenceButton btnTrain;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
    }
}