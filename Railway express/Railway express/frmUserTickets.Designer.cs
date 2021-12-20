namespace Railway_express
{
    partial class frmUserTickets
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
            this.btnSave = new Guna.UI.WinForms.GunaButton();
            this.cmbClass = new Guna.UI.WinForms.GunaComboBox();
            this.lblClass = new Guna.UI.WinForms.GunaLabel();
            this.cmbType = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.lblType = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.lblDestination = new Guna.UI.WinForms.GunaLabel();
            this.lblCountOfTickets = new Guna.UI.WinForms.GunaLabel();
            this.lblDipatcher = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txtCountOfTickets = new Guna.UI.WinForms.GunaTextBox();
            this.cmbdiptcher = new Guna.UI.WinForms.GunaComboBox();
            this.cmbdestination = new Guna.UI.WinForms.GunaComboBox();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
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
            this.btnSave.Location = new System.Drawing.Point(733, 599);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Radius = 5;
            this.btnSave.Size = new System.Drawing.Size(160, 52);
            this.btnSave.TabIndex = 41;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // cmbClass
            // 
            this.cmbClass.BackColor = System.Drawing.Color.Transparent;
            this.cmbClass.BaseColor = System.Drawing.Color.White;
            this.cmbClass.BorderColor = System.Drawing.Color.Silver;
            this.cmbClass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClass.FocusedColor = System.Drawing.Color.Empty;
            this.cmbClass.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbClass.ForeColor = System.Drawing.Color.Black;
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Items.AddRange(new object[] {
            "hawa"});
            this.cmbClass.Location = new System.Drawing.Point(595, 327);
            this.cmbClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbClass.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbClass.Size = new System.Drawing.Size(297, 31);
            this.cmbClass.TabIndex = 39;
            this.cmbClass.SelectedIndexChanged += new System.EventHandler(this.cmbClass_SelectedIndexChanged);
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblClass.ForeColor = System.Drawing.Color.Red;
            this.lblClass.Location = new System.Drawing.Point(595, 373);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(0, 20);
            this.lblClass.TabIndex = 37;
            // 
            // cmbType
            // 
            this.cmbType.BackColor = System.Drawing.Color.Transparent;
            this.cmbType.BaseColor = System.Drawing.Color.White;
            this.cmbType.BorderColor = System.Drawing.Color.Silver;
            this.cmbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FocusedColor = System.Drawing.Color.Empty;
            this.cmbType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbType.ForeColor = System.Drawing.Color.Black;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Express",
            "Slow",
            "postage",
            "intercity"});
            this.cmbType.Location = new System.Drawing.Point(79, 327);
            this.cmbType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbType.Name = "cmbType";
            this.cmbType.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbType.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbType.Size = new System.Drawing.Size(297, 31);
            this.cmbType.TabIndex = 40;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gunaLabel6.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel6.Location = new System.Drawing.Point(590, 290);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(55, 25);
            this.gunaLabel6.TabIndex = 35;
            this.gunaLabel6.Text = "Class";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblType.ForeColor = System.Drawing.Color.Red;
            this.lblType.Location = new System.Drawing.Point(79, 373);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(0, 20);
            this.lblType.TabIndex = 38;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gunaLabel5.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel5.Location = new System.Drawing.Point(75, 290);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(51, 25);
            this.gunaLabel5.TabIndex = 36;
            this.gunaLabel5.Text = "Type";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDestination.ForeColor = System.Drawing.Color.Red;
            this.lblDestination.Location = new System.Drawing.Point(595, 233);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(0, 20);
            this.lblDestination.TabIndex = 32;
            // 
            // lblCountOfTickets
            // 
            this.lblCountOfTickets.AutoSize = true;
            this.lblCountOfTickets.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCountOfTickets.ForeColor = System.Drawing.Color.Red;
            this.lblCountOfTickets.Location = new System.Drawing.Point(79, 506);
            this.lblCountOfTickets.Name = "lblCountOfTickets";
            this.lblCountOfTickets.Size = new System.Drawing.Size(0, 20);
            this.lblCountOfTickets.TabIndex = 33;
            // 
            // lblDipatcher
            // 
            this.lblDipatcher.AutoSize = true;
            this.lblDipatcher.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDipatcher.ForeColor = System.Drawing.Color.Red;
            this.lblDipatcher.Location = new System.Drawing.Point(79, 233);
            this.lblDipatcher.Name = "lblDipatcher";
            this.lblDipatcher.Size = new System.Drawing.Size(0, 20);
            this.lblDipatcher.TabIndex = 34;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel1.Location = new System.Drawing.Point(590, 149);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(108, 25);
            this.gunaLabel1.TabIndex = 29;
            this.gunaLabel1.Text = "Destination";
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gunaLabel8.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel8.Location = new System.Drawing.Point(75, 423);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(152, 25);
            this.gunaLabel8.TabIndex = 30;
            this.gunaLabel8.Text = "Count of  Tickets";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gunaLabel4.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel4.Location = new System.Drawing.Point(75, 149);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(94, 25);
            this.gunaLabel4.TabIndex = 31;
            this.gunaLabel4.Text = "Dipatcher";
            // 
            // txtCountOfTickets
            // 
            this.txtCountOfTickets.BaseColor = System.Drawing.Color.White;
            this.txtCountOfTickets.BorderColor = System.Drawing.Color.Silver;
            this.txtCountOfTickets.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCountOfTickets.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCountOfTickets.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtCountOfTickets.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCountOfTickets.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCountOfTickets.Location = new System.Drawing.Point(79, 460);
            this.txtCountOfTickets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCountOfTickets.Name = "txtCountOfTickets";
            this.txtCountOfTickets.PasswordChar = '\0';
            this.txtCountOfTickets.SelectedText = "";
            this.txtCountOfTickets.Size = new System.Drawing.Size(299, 37);
            this.txtCountOfTickets.TabIndex = 27;
            // 
            // cmbdiptcher
            // 
            this.cmbdiptcher.BackColor = System.Drawing.Color.Transparent;
            this.cmbdiptcher.BaseColor = System.Drawing.Color.White;
            this.cmbdiptcher.BorderColor = System.Drawing.Color.Silver;
            this.cmbdiptcher.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbdiptcher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbdiptcher.FocusedColor = System.Drawing.Color.Empty;
            this.cmbdiptcher.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbdiptcher.ForeColor = System.Drawing.Color.Black;
            this.cmbdiptcher.FormattingEnabled = true;
            this.cmbdiptcher.Location = new System.Drawing.Point(80, 188);
            this.cmbdiptcher.Name = "cmbdiptcher";
            this.cmbdiptcher.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbdiptcher.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbdiptcher.Size = new System.Drawing.Size(296, 31);
            this.cmbdiptcher.TabIndex = 42;
            this.cmbdiptcher.SelectedIndexChanged += new System.EventHandler(this.cmbdiptcher_SelectedIndexChanged);
            // 
            // cmbdestination
            // 
            this.cmbdestination.BackColor = System.Drawing.Color.Transparent;
            this.cmbdestination.BaseColor = System.Drawing.Color.White;
            this.cmbdestination.BorderColor = System.Drawing.Color.Silver;
            this.cmbdestination.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbdestination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbdestination.FocusedColor = System.Drawing.Color.Empty;
            this.cmbdestination.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbdestination.ForeColor = System.Drawing.Color.Black;
            this.cmbdestination.FormattingEnabled = true;
            this.cmbdestination.Location = new System.Drawing.Point(595, 188);
            this.cmbdestination.Name = "cmbdestination";
            this.cmbdestination.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbdestination.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbdestination.Size = new System.Drawing.Size(298, 31);
            this.cmbdestination.TabIndex = 43;
            this.cmbdestination.SelectedIndexChanged += new System.EventHandler(this.cmbdestination_SelectedIndexChanged);
            // 
            // frmUserTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1219, 722);
            this.Controls.Add(this.cmbdestination);
            this.Controls.Add(this.cmbdiptcher);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.lblCountOfTickets);
            this.Controls.Add(this.lblDipatcher);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaLabel8);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.txtCountOfTickets);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmUserTickets";
            this.Text = "frmAdminDash";
            this.Load += new System.EventHandler(this.frmUserTickets_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaButton btnSave;
        private Guna.UI.WinForms.GunaComboBox cmbClass;
        private Guna.UI.WinForms.GunaLabel lblClass;
        private Guna.UI.WinForms.GunaComboBox cmbType;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel lblType;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel lblDestination;
        private Guna.UI.WinForms.GunaLabel lblCountOfTickets;
        private Guna.UI.WinForms.GunaLabel lblDipatcher;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaTextBox txtCountOfTickets;
        private Guna.UI.WinForms.GunaComboBox cmbdestination;
        private Guna.UI.WinForms.GunaComboBox cmbdiptcher;
    }
}