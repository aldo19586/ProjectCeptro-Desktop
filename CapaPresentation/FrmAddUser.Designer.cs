namespace CapaPresentation
{
    partial class FrmAddUser
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
            this.txtSurtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.cBxRol = new System.Windows.Forms.ComboBox();
            this.cBxState = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSurtName
            // 
            this.txtSurtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurtName.Location = new System.Drawing.Point(321, 64);
            this.txtSurtName.Name = "txtSurtName";
            this.txtSurtName.Size = new System.Drawing.Size(191, 27);
            this.txtSurtName.TabIndex = 44;
            this.txtSurtName.TextChanged += new System.EventHandler(this.txtSurtName_TextChanged);
            this.txtSurtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSurtName_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(317, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 43;
            this.label4.Text = "Apellidos:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(43, 64);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(192, 27);
            this.txtName.TabIndex = 46;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 45;
            this.label1.Text = "Nombres:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 49;
            this.label2.Text = "Usuario:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(321, 124);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(191, 27);
            this.txtPass.TabIndex = 48;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            this.txtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPass_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(317, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 47;
            this.label3.Text = "Contraseña:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 25);
            this.label5.TabIndex = 53;
            this.label5.Text = "Rol:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(317, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 25);
            this.label6.TabIndex = 51;
            this.label6.Text = "Estado:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(44, 124);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(192, 27);
            this.txtUser.TabIndex = 55;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUser_KeyPress);
            // 
            // cBxRol
            // 
            this.cBxRol.FormattingEnabled = true;
            this.cBxRol.Items.AddRange(new object[] {
            "Director",
            "Docente",
            "Auxiliar"});
            this.cBxRol.Location = new System.Drawing.Point(44, 193);
            this.cBxRol.Name = "cBxRol";
            this.cBxRol.Size = new System.Drawing.Size(192, 24);
            this.cBxRol.TabIndex = 56;
            this.cBxRol.SelectedIndexChanged += new System.EventHandler(this.cBxRol_SelectedIndexChanged);
            this.cBxRol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cBxRol_KeyPress);
            // 
            // cBxState
            // 
            this.cBxState.FormattingEnabled = true;
            this.cBxState.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cBxState.Location = new System.Drawing.Point(321, 193);
            this.cBxState.Name = "cBxState";
            this.cBxState.Size = new System.Drawing.Size(192, 24);
            this.cBxState.TabIndex = 57;
            this.cBxState.SelectedIndexChanged += new System.EventHandler(this.cBxState_SelectedIndexChanged);
            this.cBxState.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cBxState_KeyPress);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(277, 254);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(134, 44);
            this.btnExit.TabIndex = 75;
            this.btnExit.Text = "SALIR";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(105, 254);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 44);
            this.btnSave.TabIndex = 74;
            this.btnSave.Text = "GUARDAR";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 334);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
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
            this.Name = "FrmAddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Usuario";
            this.Load += new System.EventHandler(this.FrmAddUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSurtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.ComboBox cBxRol;
        private System.Windows.Forms.ComboBox cBxState;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
    }
}