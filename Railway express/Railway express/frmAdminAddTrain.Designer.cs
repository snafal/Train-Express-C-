namespace Railway_express
{
    partial class frmAdminAddTrain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.txtTrainName = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txtEngineNumber = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.txtTrainCarriage = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.lblTrainName = new Guna.UI.WinForms.GunaLabel();
            this.lblTrainType = new Guna.UI.WinForms.GunaLabel();
            this.lblEngineNumber = new Guna.UI.WinForms.GunaLabel();
            this.lblCompartCount = new Guna.UI.WinForms.GunaLabel();
            this.btnSave = new Guna.UI.WinForms.GunaButton();
            this.cmbTrainType = new Guna.UI.WinForms.GunaComboBox();
            this.dgvRailwayLine = new Guna.UI.WinForms.GunaDataGridView();
            this.train_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.train_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.train_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.train_Engine_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Train_carriages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRailwayLine)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // txtTrainName
            // 
            this.txtTrainName.BaseColor = System.Drawing.Color.White;
            this.txtTrainName.BorderColor = System.Drawing.Color.White;
            this.txtTrainName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTrainName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTrainName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTrainName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTrainName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTrainName.Location = new System.Drawing.Point(70, 312);
            this.txtTrainName.Name = "txtTrainName";
            this.txtTrainName.PasswordChar = '\0';
            this.txtTrainName.SelectedText = "";
            this.txtTrainName.Size = new System.Drawing.Size(298, 30);
            this.txtTrainName.TabIndex = 0;
            this.txtTrainName.TextChanged += new System.EventHandler(this.txtTrainName_TextChanged);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel1.Location = new System.Drawing.Point(59, 102);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(182, 67);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "TRAIN";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.gunaLabel3.Location = new System.Drawing.Point(65, 67);
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
            this.gunaLabel4.Size = new System.Drawing.Size(108, 25);
            this.gunaLabel4.TabIndex = 1;
            this.gunaLabel4.Text = "Train Name";
            // 
            // txtEngineNumber
            // 
            this.txtEngineNumber.BaseColor = System.Drawing.Color.White;
            this.txtEngineNumber.BorderColor = System.Drawing.Color.White;
            this.txtEngineNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEngineNumber.FocusedBaseColor = System.Drawing.Color.White;
            this.txtEngineNumber.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtEngineNumber.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEngineNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEngineNumber.Location = new System.Drawing.Point(70, 473);
            this.txtEngineNumber.Name = "txtEngineNumber";
            this.txtEngineNumber.PasswordChar = '\0';
            this.txtEngineNumber.SelectedText = "";
            this.txtEngineNumber.Size = new System.Drawing.Size(298, 30);
            this.txtEngineNumber.TabIndex = 0;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gunaLabel5.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel5.Location = new System.Drawing.Point(65, 435);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(144, 25);
            this.gunaLabel5.TabIndex = 1;
            this.gunaLabel5.Text = "Engine Number";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gunaLabel6.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel6.Location = new System.Drawing.Point(512, 274);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(97, 25);
            this.gunaLabel6.TabIndex = 1;
            this.gunaLabel6.Text = "Train Type";
            // 
            // txtTrainCarriage
            // 
            this.txtTrainCarriage.BaseColor = System.Drawing.Color.White;
            this.txtTrainCarriage.BorderColor = System.Drawing.Color.White;
            this.txtTrainCarriage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTrainCarriage.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTrainCarriage.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTrainCarriage.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTrainCarriage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTrainCarriage.Location = new System.Drawing.Point(517, 473);
            this.txtTrainCarriage.Name = "txtTrainCarriage";
            this.txtTrainCarriage.PasswordChar = '\0';
            this.txtTrainCarriage.SelectedText = "";
            this.txtTrainCarriage.Size = new System.Drawing.Size(298, 30);
            this.txtTrainCarriage.TabIndex = 0;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gunaLabel7.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel7.Location = new System.Drawing.Point(512, 435);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(135, 25);
            this.gunaLabel7.TabIndex = 1;
            this.gunaLabel7.Text = "Train carriages";
            this.gunaLabel7.Click += new System.EventHandler(this.gunaLabel7_Click);
            // 
            // lblTrainName
            // 
            this.lblTrainName.AutoSize = true;
            this.lblTrainName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTrainName.ForeColor = System.Drawing.Color.Red;
            this.lblTrainName.Location = new System.Drawing.Point(70, 358);
            this.lblTrainName.Name = "lblTrainName";
            this.lblTrainName.Size = new System.Drawing.Size(0, 20);
            this.lblTrainName.TabIndex = 2;
            // 
            // lblTrainType
            // 
            this.lblTrainType.AutoSize = true;
            this.lblTrainType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTrainType.ForeColor = System.Drawing.Color.Red;
            this.lblTrainType.Location = new System.Drawing.Point(521, 358);
            this.lblTrainType.Name = "lblTrainType";
            this.lblTrainType.Size = new System.Drawing.Size(0, 20);
            this.lblTrainType.TabIndex = 2;
            // 
            // lblEngineNumber
            // 
            this.lblEngineNumber.AutoSize = true;
            this.lblEngineNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEngineNumber.ForeColor = System.Drawing.Color.Red;
            this.lblEngineNumber.Location = new System.Drawing.Point(70, 519);
            this.lblEngineNumber.Name = "lblEngineNumber";
            this.lblEngineNumber.Size = new System.Drawing.Size(0, 20);
            this.lblEngineNumber.TabIndex = 2;
            // 
            // lblCompartCount
            // 
            this.lblCompartCount.AutoSize = true;
            this.lblCompartCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCompartCount.ForeColor = System.Drawing.Color.Red;
            this.lblCompartCount.Location = new System.Drawing.Point(521, 519);
            this.lblCompartCount.Name = "lblCompartCount";
            this.lblCompartCount.Size = new System.Drawing.Size(0, 20);
            this.lblCompartCount.TabIndex = 2;
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
            // cmbTrainType
            // 
            this.cmbTrainType.BackColor = System.Drawing.Color.Transparent;
            this.cmbTrainType.BaseColor = System.Drawing.Color.White;
            this.cmbTrainType.BorderColor = System.Drawing.Color.Silver;
            this.cmbTrainType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTrainType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrainType.FocusedColor = System.Drawing.Color.Empty;
            this.cmbTrainType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTrainType.ForeColor = System.Drawing.Color.Black;
            this.cmbTrainType.FormattingEnabled = true;
            this.cmbTrainType.Items.AddRange(new object[] {
            "Express",
            "Slow",
            "Intercity",
            "Postage"});
            this.cmbTrainType.Location = new System.Drawing.Point(517, 311);
            this.cmbTrainType.Name = "cmbTrainType";
            this.cmbTrainType.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbTrainType.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbTrainType.Size = new System.Drawing.Size(298, 31);
            this.cmbTrainType.TabIndex = 5;
            // 
            // dgvRailwayLine
            // 
            this.dgvRailwayLine.AllowUserToAddRows = false;
            this.dgvRailwayLine.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.dgvRailwayLine.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRailwayLine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRailwayLine.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.dgvRailwayLine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRailwayLine.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRailwayLine.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRailwayLine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRailwayLine.ColumnHeadersHeight = 60;
            this.dgvRailwayLine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.train_id,
            this.train_name,
            this.train_type,
            this.train_Engine_number,
            this.Train_carriages});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRailwayLine.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRailwayLine.EnableHeadersVisualStyles = false;
            this.dgvRailwayLine.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.dgvRailwayLine.Location = new System.Drawing.Point(868, 274);
            this.dgvRailwayLine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRailwayLine.Name = "dgvRailwayLine";
            this.dgvRailwayLine.ReadOnly = true;
            this.dgvRailwayLine.RowHeadersVisible = false;
            this.dgvRailwayLine.RowHeadersWidth = 51;
            this.dgvRailwayLine.RowTemplate.Height = 24;
            this.dgvRailwayLine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRailwayLine.Size = new System.Drawing.Size(704, 414);
            this.dgvRailwayLine.TabIndex = 13;
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
            // train_id
            // 
            this.train_id.DataPropertyName = "train_id";
            this.train_id.HeaderText = "Train ID";
            this.train_id.MinimumWidth = 6;
            this.train_id.Name = "train_id";
            this.train_id.ReadOnly = true;
            // 
            // train_name
            // 
            this.train_name.DataPropertyName = "train_name";
            this.train_name.HeaderText = "Train Name";
            this.train_name.MinimumWidth = 6;
            this.train_name.Name = "train_name";
            this.train_name.ReadOnly = true;
            // 
            // train_type
            // 
            this.train_type.DataPropertyName = "train_type";
            this.train_type.HeaderText = "Train Type";
            this.train_type.MinimumWidth = 6;
            this.train_type.Name = "train_type";
            this.train_type.ReadOnly = true;
            // 
            // train_Engine_number
            // 
            this.train_Engine_number.DataPropertyName = "train_Engine_number";
            this.train_Engine_number.HeaderText = "Engine Number";
            this.train_Engine_number.MinimumWidth = 6;
            this.train_Engine_number.Name = "train_Engine_number";
            this.train_Engine_number.ReadOnly = true;
            // 
            // Train_carriages
            // 
            this.Train_carriages.DataPropertyName = "Train_carriages";
            this.Train_carriages.HeaderText = "Train Carriages";
            this.Train_carriages.MinimumWidth = 6;
            this.Train_carriages.Name = "Train_carriages";
            this.Train_carriages.ReadOnly = true;
            // 
            // frmAdminAddTrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1679, 741);
            this.Controls.Add(this.dgvRailwayLine);
            this.Controls.Add(this.cmbTrainType);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTrainType);
            this.Controls.Add(this.lblCompartCount);
            this.Controls.Add(this.lblEngineNumber);
            this.Controls.Add(this.lblTrainName);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.txtTrainCarriage);
            this.Controls.Add(this.txtEngineNumber);
            this.Controls.Add(this.txtTrainName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminAddTrain";
            this.Load += new System.EventHandler(this.frmAdminLine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRailwayLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox txtTrainName;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaTextBox txtTrainCarriage;
        private Guna.UI.WinForms.GunaTextBox txtEngineNumber;
        private Guna.UI.WinForms.GunaLabel lblTrainType;
        private Guna.UI.WinForms.GunaLabel lblCompartCount;
        private Guna.UI.WinForms.GunaLabel lblEngineNumber;
        private Guna.UI.WinForms.GunaLabel lblTrainName;
        private Guna.UI.WinForms.GunaButton btnSave;
        private Guna.UI.WinForms.GunaComboBox cmbTrainType;
        private Guna.UI.WinForms.GunaDataGridView dgvRailwayLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn train_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn train_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn train_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn train_Engine_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Train_carriages;
    }
}