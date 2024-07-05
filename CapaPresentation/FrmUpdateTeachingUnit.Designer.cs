namespace CapaPresentation
{
    partial class FrmUpdateTeachingUnit
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtConditions = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCredit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cBxSpecialties = new System.Windows.Forms.ComboBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnUpdate.Location = new System.Drawing.Point(75, 365);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(134, 44);
            this.btnUpdate.TabIndex = 97;
            this.btnUpdate.Text = "GUARDAR";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(233, 365);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(134, 44);
            this.btnExit.TabIndex = 96;
            this.btnExit.Text = "SALIR";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtConditions
            // 
            this.txtConditions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConditions.Location = new System.Drawing.Point(171, 302);
            this.txtConditions.Name = "txtConditions";
            this.txtConditions.Size = new System.Drawing.Size(85, 27);
            this.txtConditions.TabIndex = 95;
            this.txtConditions.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConditions_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 94;
            this.label5.Text = "Condición:";
            // 
            // txtHours
            // 
            this.txtHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHours.Location = new System.Drawing.Point(171, 258);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(87, 27);
            this.txtHours.TabIndex = 93;
            this.txtHours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHours_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 92;
            this.label4.Text = "Horas:";
            // 
            // txtCredit
            // 
            this.txtCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCredit.Location = new System.Drawing.Point(171, 213);
            this.txtCredit.Name = "txtCredit";
            this.txtCredit.Size = new System.Drawing.Size(85, 27);
            this.txtCredit.TabIndex = 91;
            this.txtCredit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCredit_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 90;
            this.label3.Text = "Crédito:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(171, 173);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(253, 27);
            this.txtName.TabIndex = 89;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 88;
            this.label2.Text = "Descripción:";
            // 
            // cBxSpecialties
            // 
            this.cBxSpecialties.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBxSpecialties.FormattingEnabled = true;
            this.cBxSpecialties.Location = new System.Drawing.Point(69, 60);
            this.cBxSpecialties.Name = "cBxSpecialties";
            this.cBxSpecialties.Size = new System.Drawing.Size(355, 28);
            this.cBxSpecialties.TabIndex = 87;
            this.cBxSpecialties.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cBxSpecialties_KeyPress);
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Location = new System.Drawing.Point(171, 129);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(67, 27);
            this.txtNumber.TabIndex = 86;
            this.txtNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 85;
            this.label1.Text = "Número:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(143, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(224, 25);
            this.label14.TabIndex = 84;
            this.label14.Text = "Programa / Especialidad";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(26, 27);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(67, 27);
            this.txtId.TabIndex = 98;
            this.txtId.Visible = false;
            // 
            // FrmUpdateTeachingUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 432);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtConditions);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCredit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBxSpecialties);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label14);
            this.MaximumSize = new System.Drawing.Size(502, 479);
            this.MinimumSize = new System.Drawing.Size(502, 479);
            this.Name = "FrmUpdateTeachingUnit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Unidades Didáctica";
            this.Load += new System.EventHandler(this.FrmUpdateTeachingUnit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox txtId;
        public System.Windows.Forms.TextBox txtConditions;
        public System.Windows.Forms.TextBox txtHours;
        public System.Windows.Forms.TextBox txtCredit;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.ComboBox cBxSpecialties;
        public System.Windows.Forms.TextBox txtNumber;
    }
}