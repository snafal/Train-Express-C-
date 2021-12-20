namespace Railway_express
{
    partial class frmAdminStation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txtKmFromMainStation = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.txtStationName = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.lblLineError = new Guna.UI.WinForms.GunaLabel();
            this.lblRateError = new Guna.UI.WinForms.GunaLabel();
            this.lblErrormainStation = new Guna.UI.WinForms.GunaLabel();
            this.lblErrorEndStation = new Guna.UI.WinForms.GunaLabel();
            this.btnSave = new Guna.UI.WinForms.GunaButton();
            this.cmbLineName = new Guna.UI.WinForms.GunaComboBox();
            this.dgvRailwayLine = new Guna.UI.WinForms.GunaDataGridView();
            this.station_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.station_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.main_station = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.far_from_main_station = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRailwayLine)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel1.Location = new System.Drawing.Point(59, 102);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(246, 67);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "RAILWAY";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.gunaLabel2.Location = new System.Drawing.Point(301, 110);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(201, 57);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "STATION";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.gunaLabel3.Location = new System.Drawing.Point(65, 66);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(63, 35);
            this.gunaLabel3.TabIndex = 1;
            this.gunaLabel3.Text = "Add";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gunaLabel4.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel4.Location = new System.Drawing.Point(65, 274);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(102, 25);
            this.gunaLabel4.TabIndex = 1;
            this.gunaLabel4.Text = "Line Name";
            // 
            // txtKmFromMainStation
            // 
            this.txtKmFromMainStation.BaseColor = System.Drawing.Color.White;
            this.txtKmFromMainStation.BorderColor = System.Drawing.Color.Silver;
            this.txtKmFromMainStation.BorderSize = 0;
            this.txtKmFromMainStation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKmFromMainStation.FocusedBaseColor = System.Drawing.Color.White;
            this.txtKmFromMainStation.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtKmFromMainStation.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtKmFromMainStation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtKmFromMainStation.Location = new System.Drawing.Point(69, 473);
            this.txtKmFromMainStation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKmFromMainStation.Name = "txtKmFromMainStation";
            this.txtKmFromMainStation.PasswordChar = '\0';
            this.txtKmFromMainStation.SelectedText = "";
            this.txtKmFromMainStation.Size = new System.Drawing.Size(299, 37);
            this.txtKmFromMainStation.TabIndex = 0;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gunaLabel5.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel5.Location = new System.Drawing.Point(65, 434);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(198, 25);
            this.gunaLabel5.TabIndex = 1;
            this.gunaLabel5.Text = "Km From Main Station";
            // 
            // txtStationName
            // 
            this.txtStationName.BaseColor = System.Drawing.Color.White;
            this.txtStationName.BorderColor = System.Drawing.Color.Silver;
            this.txtStationName.BorderSize = 0;
            this.txtStationName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStationName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtStationName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtStationName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtStationName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtStationName.Location = new System.Drawing.Point(517, 313);
            this.txtStationName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStationName.Name = "txtStationName";
            this.txtStationName.PasswordChar = '\0';
            this.txtStationName.SelectedText = "";
            this.txtStationName.Size = new System.Drawing.Size(299, 37);
            this.txtStationName.TabIndex = 0;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gunaLabel6.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel6.Location = new System.Drawing.Point(512, 274);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(125, 25);
            this.gunaLabel6.TabIndex = 1;
            this.gunaLabel6.Text = "Station Name";
            // 
            // lblLineError
            // 
            this.lblLineError.AutoSize = true;
            this.lblLineError.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLineError.ForeColor = System.Drawing.Color.Red;
            this.lblLineError.Location = new System.Drawing.Point(69, 358);
            this.lblLineError.Name = "lblLineError";
            this.lblLineError.Size = new System.Drawing.Size(0, 20);
            this.lblLineError.TabIndex = 2;
            // 
            // lblRateError
            // 
            this.lblRateError.AutoSize = true;
            this.lblRateError.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRateError.ForeColor = System.Drawing.Color.Red;
            this.lblRateError.Location = new System.Drawing.Point(521, 358);
            this.lblRateError.Name = "lblRateError";
            this.lblRateError.Size = new System.Drawing.Size(0, 20);
            this.lblRateError.TabIndex = 2;
            // 
            // lblErrormainStation
            // 
            this.lblErrormainStation.AutoSize = true;
            this.lblErrormainStation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblErrormainStation.ForeColor = System.Drawing.Color.Red;
            this.lblErrormainStation.Location = new System.Drawing.Point(69, 519);
            this.lblErrormainStation.Name = "lblErrormainStation";
            this.lblErrormainStation.Size = new System.Drawing.Size(0, 20);
            this.lblErrormainStation.TabIndex = 2;
            // 
            // lblErrorEndStation
            // 
            this.lblErrorEndStation.AutoSize = true;
            this.lblErrorEndStation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblErrorEndStation.ForeColor = System.Drawing.Color.Red;
            this.lblErrorEndStation.Location = new System.Drawing.Point(521, 519);
            this.lblErrorEndStation.Name = "lblErrorEndStation";
            this.lblErrorEndStation.Size = new System.Drawing.Size(0, 20);
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
            this.btnSave.Location = new System.Drawing.Point(655, 636);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Radius = 5;
            this.btnSave.Size = new System.Drawing.Size(160, 52);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbLineName
            // 
            this.cmbLineName.BackColor = System.Drawing.Color.Transparent;
            this.cmbLineName.BaseColor = System.Drawing.Color.White;
            this.cmbLineName.BorderColor = System.Drawing.Color.Silver;
            this.cmbLineName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLineName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLineName.FocusedColor = System.Drawing.Color.Empty;
            this.cmbLineName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbLineName.ForeColor = System.Drawing.Color.Black;
            this.cmbLineName.FormattingEnabled = true;
            this.cmbLineName.Location = new System.Drawing.Point(69, 311);
            this.cmbLineName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbLineName.Name = "cmbLineName";
            this.cmbLineName.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbLineName.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbLineName.Size = new System.Drawing.Size(297, 31);
            this.cmbLineName.TabIndex = 5;
            this.cmbLineName.SelectedIndexChanged += new System.EventHandler(this.cmbLineName_SelectedIndexChanged);
            // 
            // dgvRailwayLine
            // 
            this.dgvRailwayLine.AllowUserToAddRows = false;
            this.dgvRailwayLine.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.dgvRailwayLine.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRailwayLine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRailwayLine.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.dgvRailwayLine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRailwayLine.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRailwayLine.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRailwayLine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRailwayLine.ColumnHeadersHeight = 60;
            this.dgvRailwayLine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.station_id,
            this.station_name,
            this.main_station,
            this.far_from_main_station});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRailwayLine.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRailwayLine.EnableHeadersVisualStyles = false;
            this.dgvRailwayLine.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.dgvRailwayLine.Location = new System.Drawing.Point(875, 274);
            this.dgvRailwayLine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRailwayLine.Name = "dgvRailwayLine";
            this.dgvRailwayLine.ReadOnly = true;
            this.dgvRailwayLine.RowHeadersVisible = false;
            this.dgvRailwayLine.RowHeadersWidth = 51;
            this.dgvRailwayLine.RowTemplate.Height = 24;
            this.dgvRailwayLine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRailwayLine.Size = new System.Drawing.Size(777, 395);
            this.dgvRailwayLine.TabIndex = 12;
            this.dgvRailwayLine.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvRailwayLine.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.dgvRailwayLine.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvRailwayLine.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvRailwayLine.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvRailwayLine.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvRailwayLine.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.dgvRailwayLine.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.dgvRailwayLine.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.dgvRailwayLine.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRailwayLine.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.dgvRailwayLine.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvRailwayLine.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvRailwayLine.ThemeStyle.HeaderStyle.Height = 60;
            this.dgvRailwayLine.ThemeStyle.ReadOnly = true;
            this.dgvRailwayLine.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.dgvRailwayLine.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRailwayLine.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvRailwayLine.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.dgvRailwayLine.ThemeStyle.RowsStyle.Height = 24;
            this.dgvRailwayLine.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.dgvRailwayLine.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            // 
            // station_id
            // 
            this.station_id.DataPropertyName = "station_id";
            this.station_id.HeaderText = "Station ID";
            this.station_id.MinimumWidth = 6;
            this.station_id.Name = "station_id";
            this.station_id.ReadOnly = true;
            // 
            // station_name
            // 
            this.station_name.DataPropertyName = "station_name";
            this.station_name.HeaderText = "Station Name";
            this.station_name.MinimumWidth = 6;
            this.station_name.Name = "station_name";
            this.station_name.ReadOnly = true;
            // 
            // main_station
            // 
            this.main_station.DataPropertyName = "main_station";
            this.main_station.HeaderText = "Main Station";
            this.main_station.MinimumWidth = 6;
            this.main_station.Name = "main_station";
            this.main_station.ReadOnly = true;
            // 
            // far_from_main_station
            // 
            this.far_from_main_station.DataPropertyName = "far_from_main_station";
            this.far_from_main_station.HeaderText = "Far from Main Station";
            this.far_from_main_station.MinimumWidth = 6;
            this.far_from_main_station.Name = "far_from_main_station";
            this.far_from_main_station.ReadOnly = true;
            // 
            // frmAdminStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1669, 741);
            this.Controls.Add(this.dgvRailwayLine);
            this.Controls.Add(this.cmbLineName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblRateError);
            this.Controls.Add(this.lblErrorEndStation);
            this.Controls.Add(this.lblErrormainStation);
            this.Controls.Add(this.lblLineError);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.txtStationName);
            this.Controls.Add(this.txtKmFromMainStation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAdminStation";
            this.Text = "frmAdminDash";
            this.Load += new System.EventHandler(this.frmAdminLine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRailwayLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaTextBox txtStationName;
        private Guna.UI.WinForms.GunaTextBox txtKmFromMainStation;
        private Guna.UI.WinForms.GunaLabel lblRateError;
        private Guna.UI.WinForms.GunaLabel lblErrorEndStation;
        private Guna.UI.WinForms.GunaLabel lblErrormainStation;
        private Guna.UI.WinForms.GunaLabel lblLineError;
        private Guna.UI.WinForms.GunaButton btnSave;
        private Guna.UI.WinForms.GunaComboBox cmbLineName;
        private Guna.UI.WinForms.GunaDataGridView dgvRailwayLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn station_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn station_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn main_station;
        private System.Windows.Forms.DataGridViewTextBoxColumn far_from_main_station;
    }
}