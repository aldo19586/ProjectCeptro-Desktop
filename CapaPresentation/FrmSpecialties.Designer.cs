namespace CapaPresentation
{
    partial class FrmSpecialties
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
            this.dataGridViewSpecialties = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRemoveSpecialty = new System.Windows.Forms.Button();
            this.btnUpdateSpecialtyDialog = new System.Windows.Forms.Button();
            this.btnAddSpecialtyDialog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpecialties)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSpecialties
            // 
            this.dataGridViewSpecialties.AllowUserToAddRows = false;
            this.dataGridViewSpecialties.AllowUserToDeleteRows = false;
            this.dataGridViewSpecialties.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSpecialties.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewSpecialties.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSpecialties.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSpecialties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSpecialties.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSpecialties.EnableHeadersVisualStyles = false;
            this.dataGridViewSpecialties.Location = new System.Drawing.Point(33, 74);
            this.dataGridViewSpecialties.Name = "dataGridViewSpecialties";
            this.dataGridViewSpecialties.ReadOnly = true;
            this.dataGridViewSpecialties.RowHeadersVisible = false;
            this.dataGridViewSpecialties.RowHeadersWidth = 51;
            this.dataGridViewSpecialties.RowTemplate.Height = 24;
            this.dataGridViewSpecialties.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSpecialties.Size = new System.Drawing.Size(708, 269);
            this.dataGridViewSpecialties.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(279, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 29);
            this.label1.TabIndex = 58;
            this.label1.Text = "ESPECIALIDADES";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(607, 370);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(134, 44);
            this.btnExit.TabIndex = 62;
            this.btnExit.Text = "SALIR";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRemoveSpecialty
            // 
            this.btnRemoveSpecialty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemoveSpecialty.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRemoveSpecialty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveSpecialty.Location = new System.Drawing.Point(338, 370);
            this.btnRemoveSpecialty.Name = "btnRemoveSpecialty";
            this.btnRemoveSpecialty.Size = new System.Drawing.Size(134, 44);
            this.btnRemoveSpecialty.TabIndex = 61;
            this.btnRemoveSpecialty.Text = "ELIMINAR";
            this.btnRemoveSpecialty.UseVisualStyleBackColor = false;
            this.btnRemoveSpecialty.Click += new System.EventHandler(this.btnRemoveSpecialty_Click);
            // 
            // btnUpdateSpecialtyDialog
            // 
            this.btnUpdateSpecialtyDialog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateSpecialtyDialog.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdateSpecialtyDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSpecialtyDialog.Location = new System.Drawing.Point(183, 370);
            this.btnUpdateSpecialtyDialog.Name = "btnUpdateSpecialtyDialog";
            this.btnUpdateSpecialtyDialog.Size = new System.Drawing.Size(134, 44);
            this.btnUpdateSpecialtyDialog.TabIndex = 60;
            this.btnUpdateSpecialtyDialog.Text = "ACTUALIZAR";
            this.btnUpdateSpecialtyDialog.UseVisualStyleBackColor = false;
            this.btnUpdateSpecialtyDialog.Click += new System.EventHandler(this.btnUpdateSpecialtyDialog_Click);
            // 
            // btnAddSpecialtyDialog
            // 
            this.btnAddSpecialtyDialog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddSpecialtyDialog.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddSpecialtyDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSpecialtyDialog.Location = new System.Drawing.Point(33, 370);
            this.btnAddSpecialtyDialog.Name = "btnAddSpecialtyDialog";
            this.btnAddSpecialtyDialog.Size = new System.Drawing.Size(134, 44);
            this.btnAddSpecialtyDialog.TabIndex = 59;
            this.btnAddSpecialtyDialog.Text = "AGREGAR";
            this.btnAddSpecialtyDialog.UseVisualStyleBackColor = false;
            this.btnAddSpecialtyDialog.Click += new System.EventHandler(this.btnAddSpecialtyDialog_Click);
            // 
            // FrmSpecialties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRemoveSpecialty);
            this.Controls.Add(this.btnUpdateSpecialtyDialog);
            this.Controls.Add(this.btnAddSpecialtyDialog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewSpecialties);
            this.MaximumSize = new System.Drawing.Size(791, 497);
            this.MinimumSize = new System.Drawing.Size(791, 497);
            this.Name = "FrmSpecialties";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Especialidades";
            this.Load += new System.EventHandler(this.FrmSpecialties_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpecialties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewSpecialties;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Button btnRemoveSpecialty;
        public System.Windows.Forms.Button btnUpdateSpecialtyDialog;
        public System.Windows.Forms.Button btnAddSpecialtyDialog;
    }
}