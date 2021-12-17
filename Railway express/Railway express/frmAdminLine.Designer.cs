namespace Railway_express
{
    partial class frmAdminLine
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
            this.TxtLaineName = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.TxtStation = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.TxtRate = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.TxtEndStation = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.lblLineError = new Guna.UI.WinForms.GunaLabel();
            this.lblRateError = new Guna.UI.WinForms.GunaLabel();
            this.lblErrormainStation = new Guna.UI.WinForms.GunaLabel();
            this.lblErrorEndStation = new Guna.UI.WinForms.GunaLabel();
            this.btnSave = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // TxtLaineName
            // 
            this.TxtLaineName.BaseColor = System.Drawing.Color.White;
            this.TxtLaineName.BorderColor = System.Drawing.Color.Silver;
            this.TxtLaineName.BorderSize = 0;
            this.TxtLaineName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtLaineName.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtLaineName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TxtLaineName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtLaineName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtLaineName.Location = new System.Drawing.Point(52, 254);
            this.TxtLaineName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtLaineName.Name = "TxtLaineName";
            this.TxtLaineName.PasswordChar = '\0';
            this.TxtLaineName.SelectedText = "";
            this.TxtLaineName.Size = new System.Drawing.Size(224, 26);
            this.TxtLaineName.TabIndex = 0;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel1.Location = new System.Drawing.Point(44, 83);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(197, 54);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "RAILWAY";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.gunaLabel2.Location = new System.Drawing.Point(226, 89);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(93, 46);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "LINE";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.gunaLabel3.Location = new System.Drawing.Point(49, 54);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(50, 28);
            this.gunaLabel3.TabIndex = 1;
            this.gunaLabel3.Text = "Add";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gunaLabel4.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel4.Location = new System.Drawing.Point(49, 223);
            this.gunaLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(80, 20);
            this.gunaLabel4.TabIndex = 1;
            this.gunaLabel4.Text = "Line Name";
            // 
            // TxtStation
            // 
            this.TxtStation.BaseColor = System.Drawing.Color.White;
            this.TxtStation.BorderColor = System.Drawing.Color.Silver;
            this.TxtStation.BorderSize = 0;
            this.TxtStation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtStation.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtStation.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TxtStation.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtStation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtStation.Location = new System.Drawing.Point(52, 384);
            this.TxtStation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtStation.Name = "TxtStation";
            this.TxtStation.PasswordChar = '\0';
            this.TxtStation.SelectedText = "";
            this.TxtStation.Size = new System.Drawing.Size(224, 26);
            this.TxtStation.TabIndex = 0;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gunaLabel5.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel5.Location = new System.Drawing.Point(49, 353);
            this.gunaLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(93, 20);
            this.gunaLabel5.TabIndex = 1;
            this.gunaLabel5.Text = "Main Station";
            // 
            // TxtRate
            // 
            this.TxtRate.BaseColor = System.Drawing.Color.White;
            this.TxtRate.BorderColor = System.Drawing.Color.Silver;
            this.TxtRate.BorderSize = 0;
            this.TxtRate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtRate.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtRate.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TxtRate.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtRate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtRate.Location = new System.Drawing.Point(388, 254);
            this.TxtRate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtRate.Name = "TxtRate";
            this.TxtRate.PasswordChar = '\0';
            this.TxtRate.SelectedText = "";
            this.TxtRate.Size = new System.Drawing.Size(224, 26);
            this.TxtRate.TabIndex = 0;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gunaLabel6.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel6.Location = new System.Drawing.Point(384, 223);
            this.gunaLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(91, 20);
            this.gunaLabel6.TabIndex = 1;
            this.gunaLabel6.Text = "Rate per KM";
            // 
            // TxtEndStation
            // 
            this.TxtEndStation.BaseColor = System.Drawing.Color.White;
            this.TxtEndStation.BorderColor = System.Drawing.Color.Silver;
            this.TxtEndStation.BorderSize = 0;
            this.TxtEndStation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtEndStation.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtEndStation.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TxtEndStation.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtEndStation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtEndStation.Location = new System.Drawing.Point(388, 384);
            this.TxtEndStation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtEndStation.Name = "TxtEndStation";
            this.TxtEndStation.PasswordChar = '\0';
            this.TxtEndStation.SelectedText = "";
            this.TxtEndStation.Size = new System.Drawing.Size(224, 26);
            this.TxtEndStation.TabIndex = 0;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gunaLabel7.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel7.Location = new System.Drawing.Point(384, 353);
            this.gunaLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(85, 20);
            this.gunaLabel7.TabIndex = 1;
            this.gunaLabel7.Text = "End Station";
            // 
            // lblLineError
            // 
            this.lblLineError.AutoSize = true;
            this.lblLineError.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLineError.ForeColor = System.Drawing.Color.Red;
            this.lblLineError.Location = new System.Drawing.Point(52, 291);
            this.lblLineError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLineError.Name = "lblLineError";
            this.lblLineError.Size = new System.Drawing.Size(0, 15);
            this.lblLineError.TabIndex = 2;
            // 
            // lblRateError
            // 
            this.lblRateError.AutoSize = true;
            this.lblRateError.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRateError.ForeColor = System.Drawing.Color.Red;
            this.lblRateError.Location = new System.Drawing.Point(391, 291);
            this.lblRateError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRateError.Name = "lblRateError";
            this.lblRateError.Size = new System.Drawing.Size(0, 15);
            this.lblRateError.TabIndex = 2;
            // 
            // lblErrormainStation
            // 
            this.lblErrormainStation.AutoSize = true;
            this.lblErrormainStation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblErrormainStation.ForeColor = System.Drawing.Color.Red;
            this.lblErrormainStation.Location = new System.Drawing.Point(52, 422);
            this.lblErrormainStation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrormainStation.Name = "lblErrormainStation";
            this.lblErrormainStation.Size = new System.Drawing.Size(0, 15);
            this.lblErrormainStation.TabIndex = 2;
            // 
            // lblErrorEndStation
            // 
            this.lblErrorEndStation.AutoSize = true;
            this.lblErrorEndStation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblErrorEndStation.ForeColor = System.Drawing.Color.Red;
            this.lblErrorEndStation.Location = new System.Drawing.Point(391, 422);
            this.lblErrorEndStation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrorEndStation.Name = "lblErrorEndStation";
            this.lblErrorEndStation.Size = new System.Drawing.Size(0, 15);
            this.lblErrorEndStation.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.AnimationHoverSpeed = 0.07F;
            this.btnSave.AnimationSpeed = 0.03F;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.btnSave.BorderColor = System.Drawing.Color.Black;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.FocusedColor = System.Drawing.Color.Empty;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = null;
            this.btnSave.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSave.Location = new System.Drawing.Point(491, 517);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Radius = 5;
            this.btnSave.Size = new System.Drawing.Size(120, 42);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAdminLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(835, 602);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblRateError);
            this.Controls.Add(this.lblErrorEndStation);
            this.Controls.Add(this.lblErrormainStation);
            this.Controls.Add(this.lblLineError);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.TxtRate);
            this.Controls.Add(this.TxtEndStation);
            this.Controls.Add(this.TxtStation);
            this.Controls.Add(this.TxtLaineName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAdminLine";
            this.Text = "frmAdminDash";
            this.Load += new System.EventHandler(this.frmAdminLine_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox TxtLaineName;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaTextBox TxtRate;
        private Guna.UI.WinForms.GunaTextBox TxtEndStation;
        private Guna.UI.WinForms.GunaTextBox TxtStation;
        private Guna.UI.WinForms.GunaLabel lblRateError;
        private Guna.UI.WinForms.GunaLabel lblErrorEndStation;
        private Guna.UI.WinForms.GunaLabel lblErrormainStation;
        private Guna.UI.WinForms.GunaLabel lblLineError;
        private Guna.UI.WinForms.GunaButton btnSave;
    }
}