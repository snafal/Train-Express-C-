namespace Railway_express
{
    partial class frmUserCanteen
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
            this.lblItemError = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.btnSave = new Guna.UI.WinForms.GunaButton();
            this.cmbItem = new Guna.UI.WinForms.GunaComboBox();
            this.txtItemCount = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.lblIteamCount = new Guna.UI.WinForms.GunaLabel();
            this.dgvResourt = new Guna.UI.WinForms.GunaDataGridView();
            this.iteam_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iteam_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avalable_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iteam_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResourt)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // lblItemError
            // 
            this.lblItemError.AutoSize = true;
            this.lblItemError.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblItemError.ForeColor = System.Drawing.Color.Red;
            this.lblItemError.Location = new System.Drawing.Point(71, 354);
            this.lblItemError.Name = "lblItemError";
            this.lblItemError.Size = new System.Drawing.Size(0, 20);
            this.lblItemError.TabIndex = 5;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gunaLabel4.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel4.Location = new System.Drawing.Point(67, 270);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(49, 25);
            this.gunaLabel4.TabIndex = 4;
            this.gunaLabel4.Text = "Item";
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
            this.btnSave.Location = new System.Drawing.Point(208, 545);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Radius = 5;
            this.btnSave.Size = new System.Drawing.Size(160, 52);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbItem
            // 
            this.cmbItem.BackColor = System.Drawing.Color.Transparent;
            this.cmbItem.BaseColor = System.Drawing.Color.White;
            this.cmbItem.BorderColor = System.Drawing.Color.Silver;
            this.cmbItem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItem.FocusedColor = System.Drawing.Color.Empty;
            this.cmbItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbItem.ForeColor = System.Drawing.Color.Black;
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(71, 307);
            this.cmbItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbItem.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbItem.Size = new System.Drawing.Size(297, 31);
            this.cmbItem.TabIndex = 8;
            // 
            // txtItemCount
            // 
            this.txtItemCount.BaseColor = System.Drawing.Color.White;
            this.txtItemCount.BorderColor = System.Drawing.Color.Silver;
            this.txtItemCount.BorderSize = 0;
            this.txtItemCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItemCount.FocusedBaseColor = System.Drawing.Color.White;
            this.txtItemCount.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtItemCount.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtItemCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtItemCount.Location = new System.Drawing.Point(71, 441);
            this.txtItemCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtItemCount.Name = "txtItemCount";
            this.txtItemCount.PasswordChar = '\0';
            this.txtItemCount.SelectedText = "";
            this.txtItemCount.Size = new System.Drawing.Size(299, 37);
            this.txtItemCount.TabIndex = 3;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel1.Location = new System.Drawing.Point(67, 403);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(105, 25);
            this.gunaLabel1.TabIndex = 4;
            this.gunaLabel1.Text = "Item Count";
            // 
            // lblIteamCount
            // 
            this.lblIteamCount.AutoSize = true;
            this.lblIteamCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblIteamCount.ForeColor = System.Drawing.Color.Red;
            this.lblIteamCount.Location = new System.Drawing.Point(71, 487);
            this.lblIteamCount.Name = "lblIteamCount";
            this.lblIteamCount.Size = new System.Drawing.Size(0, 20);
            this.lblIteamCount.TabIndex = 5;
            // 
            // dgvResourt
            // 
            this.dgvResourt.AllowUserToAddRows = false;
            this.dgvResourt.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.dgvResourt.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResourt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResourt.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.dgvResourt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvResourt.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvResourt.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResourt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResourt.ColumnHeadersHeight = 60;
            this.dgvResourt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iteam_Id,
            this.iteam_name,
            this.avalable_count,
            this.iteam_price});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResourt.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvResourt.EnableHeadersVisualStyles = false;
            this.dgvResourt.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.dgvResourt.Location = new System.Drawing.Point(456, 270);
            this.dgvResourt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvResourt.Name = "dgvResourt";
            this.dgvResourt.ReadOnly = true;
            this.dgvResourt.RowHeadersVisible = false;
            this.dgvResourt.RowHeadersWidth = 51;
            this.dgvResourt.RowTemplate.Height = 24;
            this.dgvResourt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResourt.Size = new System.Drawing.Size(777, 395);
            this.dgvResourt.TabIndex = 25;
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
            // iteam_Id
            // 
            this.iteam_Id.DataPropertyName = "iteam_Id";
            this.iteam_Id.HeaderText = "Item ID";
            this.iteam_Id.MinimumWidth = 6;
            this.iteam_Id.Name = "iteam_Id";
            this.iteam_Id.ReadOnly = true;
            // 
            // iteam_name
            // 
            this.iteam_name.DataPropertyName = "iteam_name";
            this.iteam_name.HeaderText = "Item";
            this.iteam_name.MinimumWidth = 6;
            this.iteam_name.Name = "iteam_name";
            this.iteam_name.ReadOnly = true;
            // 
            // avalable_count
            // 
            this.avalable_count.DataPropertyName = "avalable_count";
            this.avalable_count.HeaderText = "Quantity";
            this.avalable_count.MinimumWidth = 6;
            this.avalable_count.Name = "avalable_count";
            this.avalable_count.ReadOnly = true;
            // 
            // iteam_price
            // 
            this.iteam_price.DataPropertyName = "iteam_price";
            this.iteam_price.HeaderText = "Price";
            this.iteam_price.MinimumWidth = 6;
            this.iteam_price.Name = "iteam_price";
            this.iteam_price.ReadOnly = true;
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
            this.gunaTextBox1.Location = new System.Drawing.Point(456, 192);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.SelectedText = "";
            this.gunaTextBox1.Size = new System.Drawing.Size(357, 39);
            this.gunaTextBox1.TabIndex = 24;
            // 
            // frmUserCanteen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1272, 788);
            this.Controls.Add(this.dgvResourt);
            this.Controls.Add(this.gunaTextBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbItem);
            this.Controls.Add(this.lblIteamCount);
            this.Controls.Add(this.lblItemError);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.txtItemCount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmUserCanteen";
            this.Text = "frmAdminDash";
            this.Load += new System.EventHandler(this.frmUserTickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResourt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaLabel lblItemError;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaButton btnSave;
        private Guna.UI.WinForms.GunaComboBox cmbItem;
        private Guna.UI.WinForms.GunaLabel lblIteamCount;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox txtItemCount;
        private Guna.UI.WinForms.GunaDataGridView dgvResourt;
        private System.Windows.Forms.DataGridViewTextBoxColumn iteam_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn iteam_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn avalable_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn iteam_price;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox1;
    }
}