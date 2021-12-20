namespace Railway_express
{
    partial class frmAdminResourt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminResourt));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.cmbAvailable = new Guna.UI.WinForms.GunaComboBox();
            this.lblAvailErr = new Guna.UI.WinForms.GunaLabel();
            this.cmbRoomType = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.lblRoomTypeErr = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btnSave = new Guna.UI.WinForms.GunaButton();
            this.lblRoomPriceErr = new Guna.UI.WinForms.GunaLabel();
            this.lblResourtName = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txtPrice = new Guna.UI.WinForms.GunaTextBox();
            this.TxtResiurtName = new Guna.UI.WinForms.GunaTextBox();
            this.dgvResourt = new Guna.UI.WinForms.GunaDataGridView();
            this.resourt_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resourt_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room_availability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResourt)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox1.BorderSize = 0;
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox1.Location = new System.Drawing.Point(747, 150);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.SelectedText = "";
            this.gunaTextBox1.Size = new System.Drawing.Size(357, 39);
            this.gunaTextBox1.TabIndex = 1;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1128, 150);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(49, 39);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 2;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // cmbAvailable
            // 
            this.cmbAvailable.BackColor = System.Drawing.Color.Transparent;
            this.cmbAvailable.BaseColor = System.Drawing.Color.White;
            this.cmbAvailable.BorderColor = System.Drawing.Color.Silver;
            this.cmbAvailable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAvailable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAvailable.FocusedColor = System.Drawing.Color.Empty;
            this.cmbAvailable.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbAvailable.ForeColor = System.Drawing.Color.Black;
            this.cmbAvailable.FormattingEnabled = true;
            this.cmbAvailable.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cmbAvailable.Location = new System.Drawing.Point(381, 380);
            this.cmbAvailable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbAvailable.Name = "cmbAvailable";
            this.cmbAvailable.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbAvailable.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbAvailable.Size = new System.Drawing.Size(297, 31);
            this.cmbAvailable.TabIndex = 21;
            // 
            // lblAvailErr
            // 
            this.lblAvailErr.AutoSize = true;
            this.lblAvailErr.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAvailErr.ForeColor = System.Drawing.Color.Red;
            this.lblAvailErr.Location = new System.Drawing.Point(381, 427);
            this.lblAvailErr.Name = "lblAvailErr";
            this.lblAvailErr.Size = new System.Drawing.Size(0, 20);
            this.lblAvailErr.TabIndex = 19;
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.BackColor = System.Drawing.Color.Transparent;
            this.cmbRoomType.BaseColor = System.Drawing.Color.White;
            this.cmbRoomType.BorderColor = System.Drawing.Color.Silver;
            this.cmbRoomType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomType.FocusedColor = System.Drawing.Color.Empty;
            this.cmbRoomType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbRoomType.ForeColor = System.Drawing.Color.Black;
            this.cmbRoomType.FormattingEnabled = true;
            this.cmbRoomType.Items.AddRange(new object[] {
            "AC ",
            "NON AC"});
            this.cmbRoomType.Location = new System.Drawing.Point(380, 245);
            this.cmbRoomType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbRoomType.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbRoomType.Size = new System.Drawing.Size(297, 31);
            this.cmbRoomType.TabIndex = 22;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gunaLabel3.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel3.Location = new System.Drawing.Point(377, 343);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(104, 25);
            this.gunaLabel3.TabIndex = 17;
            this.gunaLabel3.Text = "Availability";
            // 
            // lblRoomTypeErr
            // 
            this.lblRoomTypeErr.AutoSize = true;
            this.lblRoomTypeErr.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRoomTypeErr.ForeColor = System.Drawing.Color.Red;
            this.lblRoomTypeErr.Location = new System.Drawing.Point(380, 292);
            this.lblRoomTypeErr.Name = "lblRoomTypeErr";
            this.lblRoomTypeErr.Size = new System.Drawing.Size(0, 20);
            this.lblRoomTypeErr.TabIndex = 20;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel1.Location = new System.Drawing.Point(376, 208);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(104, 25);
            this.gunaLabel1.TabIndex = 18;
            this.gunaLabel1.Text = "Room Type";
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
            this.btnSave.Location = new System.Drawing.Point(517, 526);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Radius = 5;
            this.btnSave.Size = new System.Drawing.Size(160, 52);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblRoomPriceErr
            // 
            this.lblRoomPriceErr.AutoSize = true;
            this.lblRoomPriceErr.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRoomPriceErr.ForeColor = System.Drawing.Color.Red;
            this.lblRoomPriceErr.Location = new System.Drawing.Point(38, 426);
            this.lblRoomPriceErr.Name = "lblRoomPriceErr";
            this.lblRoomPriceErr.Size = new System.Drawing.Size(0, 20);
            this.lblRoomPriceErr.TabIndex = 14;
            // 
            // lblResourtName
            // 
            this.lblResourtName.AutoSize = true;
            this.lblResourtName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblResourtName.ForeColor = System.Drawing.Color.Red;
            this.lblResourtName.Location = new System.Drawing.Point(38, 291);
            this.lblResourtName.Name = "lblResourtName";
            this.lblResourtName.Size = new System.Drawing.Size(0, 20);
            this.lblResourtName.TabIndex = 15;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gunaLabel2.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel2.Location = new System.Drawing.Point(29, 342);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(107, 25);
            this.gunaLabel2.TabIndex = 12;
            this.gunaLabel2.Text = "Room Price";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gunaLabel4.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel4.Location = new System.Drawing.Point(29, 207);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(130, 25);
            this.gunaLabel4.TabIndex = 13;
            this.gunaLabel4.Text = "Resourt Name";
            // 
            // txtPrice
            // 
            this.txtPrice.BaseColor = System.Drawing.Color.White;
            this.txtPrice.BorderColor = System.Drawing.Color.Silver;
            this.txtPrice.BorderSize = 0;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPrice.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPrice.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrice.Location = new System.Drawing.Point(34, 380);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.SelectedText = "";
            this.txtPrice.Size = new System.Drawing.Size(299, 37);
            this.txtPrice.TabIndex = 10;
            // 
            // TxtResiurtName
            // 
            this.TxtResiurtName.BaseColor = System.Drawing.Color.White;
            this.TxtResiurtName.BorderColor = System.Drawing.Color.Silver;
            this.TxtResiurtName.BorderSize = 0;
            this.TxtResiurtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtResiurtName.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtResiurtName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TxtResiurtName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtResiurtName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtResiurtName.Location = new System.Drawing.Point(34, 245);
            this.TxtResiurtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtResiurtName.Name = "TxtResiurtName";
            this.TxtResiurtName.PasswordChar = '\0';
            this.TxtResiurtName.SelectedText = "";
            this.TxtResiurtName.Size = new System.Drawing.Size(299, 37);
            this.TxtResiurtName.TabIndex = 11;
            // 
            // dgvResourt
            // 
            this.dgvResourt.AllowUserToAddRows = false;
            this.dgvResourt.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.dgvResourt.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvResourt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResourt.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.dgvResourt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvResourt.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvResourt.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResourt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvResourt.ColumnHeadersHeight = 60;
            this.dgvResourt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.resourt_Id,
            this.resourt_name,
            this.room_type,
            this.room_availability,
            this.room_price});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResourt.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvResourt.EnableHeadersVisualStyles = false;
            this.dgvResourt.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.dgvResourt.Location = new System.Drawing.Point(747, 228);
            this.dgvResourt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvResourt.Name = "dgvResourt";
            this.dgvResourt.ReadOnly = true;
            this.dgvResourt.RowHeadersVisible = false;
            this.dgvResourt.RowHeadersWidth = 51;
            this.dgvResourt.RowTemplate.Height = 24;
            this.dgvResourt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResourt.Size = new System.Drawing.Size(777, 395);
            this.dgvResourt.TabIndex = 23;
            this.dgvResourt.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvResourt.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.dgvResourt.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvResourt.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvResourt.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvResourt.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvResourt.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.dgvResourt.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.dgvResourt.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.dgvResourt.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvResourt.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.dgvResourt.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvResourt.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvResourt.ThemeStyle.HeaderStyle.Height = 60;
            this.dgvResourt.ThemeStyle.ReadOnly = true;
            this.dgvResourt.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.dgvResourt.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvResourt.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvResourt.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.dgvResourt.ThemeStyle.RowsStyle.Height = 24;
            this.dgvResourt.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.dgvResourt.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            // 
            // resourt_Id
            // 
            this.resourt_Id.DataPropertyName = "resourt_Id";
            this.resourt_Id.HeaderText = "Resourt ID";
            this.resourt_Id.MinimumWidth = 6;
            this.resourt_Id.Name = "resourt_Id";
            this.resourt_Id.ReadOnly = true;
            // 
            // resourt_name
            // 
            this.resourt_name.DataPropertyName = "resourt_name";
            this.resourt_name.HeaderText = "Resourt Name";
            this.resourt_name.MinimumWidth = 6;
            this.resourt_name.Name = "resourt_name";
            this.resourt_name.ReadOnly = true;
            // 
            // room_type
            // 
            this.room_type.DataPropertyName = "room_type";
            this.room_type.HeaderText = "Room Type";
            this.room_type.MinimumWidth = 6;
            this.room_type.Name = "room_type";
            this.room_type.ReadOnly = true;
            // 
            // room_availability
            // 
            this.room_availability.DataPropertyName = "room_availability";
            this.room_availability.HeaderText = "Availability";
            this.room_availability.MinimumWidth = 6;
            this.room_availability.Name = "room_availability";
            this.room_availability.ReadOnly = true;
            // 
            // room_price
            // 
            this.room_price.DataPropertyName = "room_price";
            this.room_price.HeaderText = "Price";
            this.room_price.MinimumWidth = 6;
            this.room_price.Name = "room_price";
            this.room_price.ReadOnly = true;
            // 
            // frmAdminResourt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1564, 699);
            this.Controls.Add(this.dgvResourt);
            this.Controls.Add(this.cmbAvailable);
            this.Controls.Add(this.lblAvailErr);
            this.Controls.Add(this.cmbRoomType);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.lblRoomTypeErr);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblRoomPriceErr);
            this.Controls.Add(this.lblResourtName);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.TxtResiurtName);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.gunaTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminResourt";
            this.Text = "frmAdminDash";
            this.Load += new System.EventHandler(this.frmAdminResourt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResourt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Guna.UI.WinForms.GunaComboBox cmbAvailable;
        private Guna.UI.WinForms.GunaLabel lblAvailErr;
        private Guna.UI.WinForms.GunaComboBox cmbRoomType;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel lblRoomTypeErr;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton btnSave;
        private Guna.UI.WinForms.GunaLabel lblRoomPriceErr;
        private Guna.UI.WinForms.GunaLabel lblResourtName;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaTextBox txtPrice;
        private Guna.UI.WinForms.GunaTextBox TxtResiurtName;
        private Guna.UI.WinForms.GunaDataGridView dgvResourt;
        private System.Windows.Forms.DataGridViewTextBoxColumn resourt_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn resourt_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn room_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn room_availability;
        private System.Windows.Forms.DataGridViewTextBoxColumn room_price;
    }
}