namespace CapaPresentation
{
    partial class FrmUpdateUser
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
            this.btnExit = new System.Windows.Forms.Button();
            this.cBxState = new System.Windows.Forms.ComboBox();
            this.cBxRol = new System.Windows.Forms.ComboBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSurtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(284, 249);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(140, 47);
            this.btnExit.TabIndex = 89;
            this.btnExit.Text = "SALIR";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cBxState
            // 
            this.cBxState.FormattingEnabled = true;
            this.cBxState.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cBxState.Location = new System.Drawing.Point(329, 200);
            this.cBxState.Name = "cBxState";
            this.cBxState.Size = new System.Drawing.Size(192, 24);
            this.cBxState.TabIndex = 87;
            this.cBxState.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cBxState_KeyPress);
            // 
            // cBxRol
            // 
            this.cBxRol.FormattingEnabled = true;
            this.cBxRol.Items.AddRange(new object[] {
            "Director",
            "Docente",
            "Auxiliar"});
            this.cBxRol.Location = new System.Drawing.Point(51, 200);
            this.cBxRol.Name = "cBxRol";
            this.cBxRol.Size = new System.Drawing.Size(192, 24);
            this.cBxRol.TabIndex = 86;
            this.cBxRol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cBxRol_KeyPress);
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(50, 131);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(192, 27);
            this.txtUser.TabIndex = 85;
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUser_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 25);
            this.label5.TabIndex = 84;
            this.label5.Text = "Rol:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(324, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 25);
            this.label6.TabIndex = 83;
            this.label6.Text = "Estado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 82;
            this.label2.Text = "Usuario:";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(329, 131);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(191, 27);
            this.txtPass.TabIndex = 81;
            this.txtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPass_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(324, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 80;
            this.label3.Text = "Contraseña:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(49, 71);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(192, 27);
            this.txtName.TabIndex = 79;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 78;
            this.label1.Text = "Nombres:";
            // 
            // txtSurtName
            // 
            this.txtSurtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurtName.Location = new System.Drawing.Point(329, 71);
            this.txtSurtName.Name = "txtSurtName";
            this.txtSurtName.Size = new System.Drawing.Size(191, 27);
            this.txtSurtName.TabIndex = 77;
            this.txtSurtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSurtName_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(324, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 76;
            this.label4.Text = "Apellidos:";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(49, 12);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(50, 27);
            this.txtId.TabIndex = 90;
            this.txtId.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(101, 249);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(134, 44);
            this.btnUpdate.TabIndex = 88;
            this.btnUpdate.Text = "GUARDAR";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // FrmUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 334);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cBxState);
            this.Controls.Add(this.cBxRol);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSurtName);
            this.Controls.Add(this.label4);
            this.MaximumSize = new System.Drawing.Size(585, 381);
            this.MinimumSize = new System.Drawing.Size(585, 381);
            this.Name = "FrmUpdateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Usuario";
            this.Load += new System.EventHandler(this.FrmUpdateUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cBxState;
        public System.Windows.Forms.ComboBox cBxRol;
        public System.Windows.Forms.TextBox txtUser;
        public System.Windows.Forms.TextBox txtPass;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txtSurtName;
        public System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnUpdate;
    }
}