namespace CapaPresentation
{
    partial class FrmTuition
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewTuition = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRemoveTuition = new System.Windows.Forms.Button();
            this.btnUpdateTuitionDialog = new System.Windows.Forms.Button();
            this.btnAddTuitionDialog = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTypeSearch = new System.Windows.Forms.ComboBox();
            this.txtSearchTuition = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTuition)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTuition
            // 
            this.dataGridViewTuition.AllowUserToAddRows = false;
            this.dataGridViewTuition.AllowUserToDeleteRows = false;
            this.dataGridViewTuition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewTuition.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewTuition.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTuition.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTuition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTuition.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTuition.EnableHeadersVisualStyles = false;
            this.dataGridViewTuition.Location = new System.Drawing.Point(47, 198);
            this.dataGridViewTuition.Name = "dataGridViewTuition";
            this.dataGridViewTuition.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTuition.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTuition.RowHeadersVisible = false;
            this.dataGridViewTuition.RowHeadersWidth = 51;
            this.dataGridViewTuition.RowTemplate.Height = 24;
            this.dataGridViewTuition.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTuition.Size = new System.Drawing.Size(1787, 603);
            this.dataGridViewTuition.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1618, 866);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(216, 92);
            this.btnExit.TabIndex = 45;
            this.btnExit.Text = "SALIR";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRemoveTuition
            // 
            this.btnRemoveTuition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemoveTuition.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRemoveTuition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveTuition.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveTuition.Location = new System.Drawing.Point(563, 866);
            this.btnRemoveTuition.Name = "btnRemoveTuition";
            this.btnRemoveTuition.Size = new System.Drawing.Size(216, 92);
            this.btnRemoveTuition.TabIndex = 44;
            this.btnRemoveTuition.Text = "ELIMINAR";
            this.btnRemoveTuition.UseVisualStyleBackColor = false;
            this.btnRemoveTuition.Click += new System.EventHandler(this.btnRemoveTuition_Click);
            // 
            // btnUpdateTuitionDialog
            // 
            this.btnUpdateTuitionDialog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateTuitionDialog.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdateTuitionDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTuitionDialog.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateTuitionDialog.Location = new System.Drawing.Point(305, 866);
            this.btnUpdateTuitionDialog.Name = "btnUpdateTuitionDialog";
            this.btnUpdateTuitionDialog.Size = new System.Drawing.Size(216, 92);
            this.btnUpdateTuitionDialog.TabIndex = 43;
            this.btnUpdateTuitionDialog.Text = "ACTUALIZAR";
            this.btnUpdateTuitionDialog.UseVisualStyleBackColor = false;
            this.btnUpdateTuitionDialog.Click += new System.EventHandler(this.btnUpdateTuitionDialog_Click);
            // 
            // btnAddTuitionDialog
            // 
            this.btnAddTuitionDialog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddTuitionDialog.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddTuitionDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTuitionDialog.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnAddTuitionDialog.Location = new System.Drawing.Point(47, 866);
            this.btnAddTuitionDialog.Name = "btnAddTuitionDialog";
            this.btnAddTuitionDialog.Size = new System.Drawing.Size(216, 92);
            this.btnAddTuitionDialog.TabIndex = 42;
            this.btnAddTuitionDialog.Text = "AGREGAR";
            this.btnAddTuitionDialog.UseVisualStyleBackColor = false;
            this.btnAddTuitionDialog.Click += new System.EventHandler(this.btnAddTuitionDialog_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(755, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 75);
            this.label1.TabIndex = 58;
            this.label1.Text = "MATRÍCULAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1209, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 61;
            this.label2.Text = "Buscar:";
            // 
            // comboBoxTypeSearch
            // 
            this.comboBoxTypeSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxTypeSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTypeSearch.FormattingEnabled = true;
            this.comboBoxTypeSearch.Items.AddRange(new object[] {
            "Dni",
            "Apellidos",
            "Nombres"});
            this.comboBoxTypeSearch.Location = new System.Drawing.Point(1294, 155);
            this.comboBoxTypeSearch.Name = "comboBoxTypeSearch";
            this.comboBoxTypeSearch.Size = new System.Drawing.Size(194, 37);
            this.comboBoxTypeSearch.TabIndex = 60;
            this.comboBoxTypeSearch.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypeSearch_SelectedIndexChanged);
            // 
            // txtSearchTuition
            // 
            this.txtSearchTuition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchTuition.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchTuition.Location = new System.Drawing.Point(1496, 150);
            this.txtSearchTuition.Multiline = true;
            this.txtSearchTuition.Name = "txtSearchTuition";
            this.txtSearchTuition.Size = new System.Drawing.Size(338, 42);
            this.txtSearchTuition.TabIndex = 59;
            this.txtSearchTuition.TextChanged += new System.EventHandler(this.txtSearchTuition_TextChanged);
            // 
            // FrmTuition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1900, 1027);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxTypeSearch);
            this.Controls.Add(this.txtSearchTuition);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRemoveTuition);
            this.Controls.Add(this.btnUpdateTuitionDialog);
            this.Controls.Add(this.btnAddTuitionDialog);
            this.Controls.Add(this.dataGridViewTuition);
            this.MinimumSize = new System.Drawing.Size(1918, 1074);
            this.Name = "FrmTuition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matriculas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmTuition_FormClosed);
            this.Load += new System.EventHandler(this.FrmTuition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTuition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewTuition;
        private System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Button btnRemoveTuition;
        public System.Windows.Forms.Button btnUpdateTuitionDialog;
        public System.Windows.Forms.Button btnAddTuitionDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxTypeSearch;
        private System.Windows.Forms.TextBox txtSearchTuition;
    }
}