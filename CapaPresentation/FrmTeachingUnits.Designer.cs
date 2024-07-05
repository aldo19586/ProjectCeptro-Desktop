namespace CapaPresentation
{
    partial class FrmTeachingUnits
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
            this.dataGridViewUnits = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRemoveUnits = new System.Windows.Forms.Button();
            this.btnUpdateUnitsDialog = new System.Windows.Forms.Button();
            this.btnAddUnitsDialog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnits)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUnits
            // 
            this.dataGridViewUnits.AllowUserToAddRows = false;
            this.dataGridViewUnits.AllowUserToDeleteRows = false;
            this.dataGridViewUnits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewUnits.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewUnits.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUnits.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewUnits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewUnits.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewUnits.EnableHeadersVisualStyles = false;
            this.dataGridViewUnits.Location = new System.Drawing.Point(12, 96);
            this.dataGridViewUnits.Name = "dataGridViewUnits";
            this.dataGridViewUnits.ReadOnly = true;
            this.dataGridViewUnits.RowHeadersVisible = false;
            this.dataGridViewUnits.RowHeadersWidth = 51;
            this.dataGridViewUnits.RowTemplate.Height = 24;
            this.dataGridViewUnits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUnits.Size = new System.Drawing.Size(776, 255);
            this.dataGridViewUnits.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(223, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 36);
            this.label1.TabIndex = 58;
            this.label1.Text = "UNIDADES DIDÁCTICAS";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(648, 391);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(138, 47);
            this.btnExit.TabIndex = 62;
            this.btnExit.Text = "SALIR";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRemoveUnits
            // 
            this.btnRemoveUnits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveUnits.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRemoveUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveUnits.Location = new System.Drawing.Point(336, 391);
            this.btnRemoveUnits.Name = "btnRemoveUnits";
            this.btnRemoveUnits.Size = new System.Drawing.Size(138, 47);
            this.btnRemoveUnits.TabIndex = 61;
            this.btnRemoveUnits.Text = "ELIMINAR";
            this.btnRemoveUnits.UseVisualStyleBackColor = false;
            this.btnRemoveUnits.Click += new System.EventHandler(this.btnRemoveUnits_Click);
            // 
            // btnUpdateUnitsDialog
            // 
            this.btnUpdateUnitsDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateUnitsDialog.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdateUnitsDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUnitsDialog.Location = new System.Drawing.Point(176, 391);
            this.btnUpdateUnitsDialog.Name = "btnUpdateUnitsDialog";
            this.btnUpdateUnitsDialog.Size = new System.Drawing.Size(138, 47);
            this.btnUpdateUnitsDialog.TabIndex = 60;
            this.btnUpdateUnitsDialog.Text = "ACTUALIZAR";
            this.btnUpdateUnitsDialog.UseVisualStyleBackColor = false;
            this.btnUpdateUnitsDialog.Click += new System.EventHandler(this.btnUpdateUnitsDialog_Click);
            // 
            // btnAddUnitsDialog
            // 
            this.btnAddUnitsDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddUnitsDialog.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddUnitsDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUnitsDialog.Location = new System.Drawing.Point(12, 391);
            this.btnAddUnitsDialog.Name = "btnAddUnitsDialog";
            this.btnAddUnitsDialog.Size = new System.Drawing.Size(138, 47);
            this.btnAddUnitsDialog.TabIndex = 59;
            this.btnAddUnitsDialog.Text = "AGREGAR";
            this.btnAddUnitsDialog.UseVisualStyleBackColor = false;
            this.btnAddUnitsDialog.Click += new System.EventHandler(this.btnAddUnitsDialog_Click);
            // 
            // FrmTeachingUnits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRemoveUnits);
            this.Controls.Add(this.btnUpdateUnitsDialog);
            this.Controls.Add(this.btnAddUnitsDialog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewUnits);
            this.MaximumSize = new System.Drawing.Size(818, 522);
            this.MinimumSize = new System.Drawing.Size(818, 522);
            this.Name = "FrmTeachingUnits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unidades Didácticas";
            this.Load += new System.EventHandler(this.FrmTeachingUnits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewUnits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Button btnRemoveUnits;
        public System.Windows.Forms.Button btnUpdateUnitsDialog;
        public System.Windows.Forms.Button btnAddUnitsDialog;
    }
}