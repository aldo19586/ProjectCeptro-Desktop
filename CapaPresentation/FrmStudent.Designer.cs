namespace CapaPresentation
{
    partial class FrmStudent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.btnRemoveStudentDialog = new System.Windows.Forms.Button();
            this.btnUpdateStudentDialog = new System.Windows.Forms.Button();
            this.btnAddStudentDialog = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTypeSearch = new System.Windows.Forms.ComboBox();
            this.txtSearchStudent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExportExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.AllowUserToAddRows = false;
            this.dataGridViewStudents.AllowUserToDeleteRows = false;
            this.dataGridViewStudents.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewStudents.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewStudents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewStudents.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewStudents.EnableHeadersVisualStyles = false;
            this.dataGridViewStudents.Location = new System.Drawing.Point(64, 202);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.ReadOnly = true;
            this.dataGridViewStudents.RowHeadersVisible = false;
            this.dataGridViewStudents.RowHeadersWidth = 51;
            this.dataGridViewStudents.RowTemplate.Height = 24;
            this.dataGridViewStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStudents.Size = new System.Drawing.Size(1787, 603);
            this.dataGridViewStudents.TabIndex = 1;
            // 
            // btnRemoveStudentDialog
            // 
            this.btnRemoveStudentDialog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemoveStudentDialog.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRemoveStudentDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveStudentDialog.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveStudentDialog.Location = new System.Drawing.Point(605, 868);
            this.btnRemoveStudentDialog.Name = "btnRemoveStudentDialog";
            this.btnRemoveStudentDialog.Size = new System.Drawing.Size(216, 92);
            this.btnRemoveStudentDialog.TabIndex = 22;
            this.btnRemoveStudentDialog.Text = "ELIMINAR";
            this.btnRemoveStudentDialog.UseVisualStyleBackColor = false;
            this.btnRemoveStudentDialog.Click += new System.EventHandler(this.btnRemoveStudentDialog_Click);
            // 
            // btnUpdateStudentDialog
            // 
            this.btnUpdateStudentDialog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateStudentDialog.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdateStudentDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStudentDialog.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateStudentDialog.Location = new System.Drawing.Point(336, 868);
            this.btnUpdateStudentDialog.Name = "btnUpdateStudentDialog";
            this.btnUpdateStudentDialog.Size = new System.Drawing.Size(216, 92);
            this.btnUpdateStudentDialog.TabIndex = 21;
            this.btnUpdateStudentDialog.Text = "ACTUALIZAR";
            this.btnUpdateStudentDialog.UseVisualStyleBackColor = false;
            this.btnUpdateStudentDialog.Click += new System.EventHandler(this.btnUpdateStudentDialog_Click);
            // 
            // btnAddStudentDialog
            // 
            this.btnAddStudentDialog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddStudentDialog.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddStudentDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudentDialog.ForeColor = System.Drawing.Color.Black;
            this.btnAddStudentDialog.Location = new System.Drawing.Point(64, 868);
            this.btnAddStudentDialog.Name = "btnAddStudentDialog";
            this.btnAddStudentDialog.Size = new System.Drawing.Size(216, 92);
            this.btnAddStudentDialog.TabIndex = 20;
            this.btnAddStudentDialog.Text = "AGREGAR";
            this.btnAddStudentDialog.UseVisualStyleBackColor = false;
            this.btnAddStudentDialog.Click += new System.EventHandler(this.btnAddStudentDialog_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1635, 868);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(216, 92);
            this.btnExit.TabIndex = 37;
            this.btnExit.Text = "SALIR";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1228, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 40;
            this.label1.Text = "Buscar:";
            // 
            // comboBoxTypeSearch
            // 
            this.comboBoxTypeSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxTypeSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTypeSearch.FormattingEnabled = true;
            this.comboBoxTypeSearch.Items.AddRange(new object[] {
            "Codigo",
            "Dni",
            "Nombres",
            "Apellidos"});
            this.comboBoxTypeSearch.Location = new System.Drawing.Point(1313, 157);
            this.comboBoxTypeSearch.Name = "comboBoxTypeSearch";
            this.comboBoxTypeSearch.Size = new System.Drawing.Size(194, 37);
            this.comboBoxTypeSearch.TabIndex = 39;
            // 
            // txtSearchStudent
            // 
            this.txtSearchStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchStudent.Location = new System.Drawing.Point(1513, 152);
            this.txtSearchStudent.Multiline = true;
            this.txtSearchStudent.Name = "txtSearchStudent";
            this.txtSearchStudent.Size = new System.Drawing.Size(338, 42);
            this.txtSearchStudent.TabIndex = 38;
            this.txtSearchStudent.TextChanged += new System.EventHandler(this.txtSearchStudent_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Heavy", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(769, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(408, 75);
            this.label2.TabIndex = 56;
            this.label2.Text = "ESTUDIANTES";
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExportExcel.BackColor = System.Drawing.Color.MintCream;
            this.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExportExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.ForeColor = System.Drawing.Color.Black;
            this.btnExportExcel.Location = new System.Drawing.Point(868, 868);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(216, 92);
            this.btnExportExcel.TabIndex = 57;
            this.btnExportExcel.Text = "EXCEL";
            this.btnExportExcel.UseVisualStyleBackColor = false;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // FrmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1900, 1027);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTypeSearch);
            this.Controls.Add(this.txtSearchStudent);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRemoveStudentDialog);
            this.Controls.Add(this.btnUpdateStudentDialog);
            this.Controls.Add(this.btnAddStudentDialog);
            this.Controls.Add(this.dataGridViewStudents);
            this.MinimumSize = new System.Drawing.Size(1918, 1074);
            this.Name = "FrmStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estudiantes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmStudent_FormClosed);
            this.Load += new System.EventHandler(this.FrmStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTypeSearch;
        private System.Windows.Forms.TextBox txtSearchStudent;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnRemoveStudentDialog;
        public System.Windows.Forms.Button btnUpdateStudentDialog;
        public System.Windows.Forms.Button btnAddStudentDialog;
        public System.Windows.Forms.Button btnExportExcel;
    }
}