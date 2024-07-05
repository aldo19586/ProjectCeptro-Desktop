namespace CapaPresentation
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDni = new System.Windows.Forms.TextBox();
            this.btnShowDni = new System.Windows.Forms.Button();
            this.btnShowReport = new System.Windows.Forms.Button();
            this.lblDni = new System.Windows.Forms.Label();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelUser = new System.Windows.Forms.Panel();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnInfoUsers = new System.Windows.Forms.Button();
            this.panelMatricula = new System.Windows.Forms.Panel();
            this.btnTeachingUnit = new System.Windows.Forms.Button();
            this.btnSpecialties = new System.Windows.Forms.Button();
            this.btnMatricula = new System.Windows.Forms.Button();
            this.btnInfoMatricula = new System.Windows.Forms.Button();
            this.panelStudent = new System.Windows.Forms.Panel();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnInfoStudent = new System.Windows.Forms.Button();
            this.panelCetpro = new System.Windows.Forms.Panel();
            this.btnCetpro = new System.Windows.Forms.Button();
            this.btnInfoCetpro = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.txtRol = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSaveBackup = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnTuition = new System.Windows.Forms.Button();
            this.panelSideMenu.SuspendLayout();
            this.panelUser.SuspendLayout();
            this.panelMatricula.SuspendLayout();
            this.panelStudent.SuspendLayout();
            this.panelCetpro.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.Location = new System.Drawing.Point(1147, 433);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(262, 45);
            this.txtDni.TabIndex = 1;
            // 
            // btnShowDni
            // 
            this.btnShowDni.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnShowDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDni.Location = new System.Drawing.Point(1114, 558);
            this.btnShowDni.Name = "btnShowDni";
            this.btnShowDni.Size = new System.Drawing.Size(244, 85);
            this.btnShowDni.TabIndex = 2;
            this.btnShowDni.Text = "VER DNI (Pdf)";
            this.btnShowDni.UseVisualStyleBackColor = false;
            this.btnShowDni.Click += new System.EventHandler(this.btnShowDni_Click);
            // 
            // btnShowReport
            // 
            this.btnShowReport.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnShowReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowReport.Location = new System.Drawing.Point(848, 558);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Size = new System.Drawing.Size(244, 85);
            this.btnShowReport.TabIndex = 3;
            this.btnShowReport.Text = "VER DATOS PERSONALES(Pdf)";
            this.btnShowReport.UseVisualStyleBackColor = false;
            this.btnShowReport.Click += new System.EventHandler(this.btnShowReport_Click);
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(1001, 373);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(523, 33);
            this.lblDni.TabIndex = 4;
            this.lblDni.Text = "Ingrese el documento de identidad";
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelSideMenu.BackColor = System.Drawing.Color.Silver;
            this.panelSideMenu.Controls.Add(this.panelUser);
            this.panelSideMenu.Controls.Add(this.btnInfoUsers);
            this.panelSideMenu.Controls.Add(this.panelMatricula);
            this.panelSideMenu.Controls.Add(this.btnInfoMatricula);
            this.panelSideMenu.Controls.Add(this.panelStudent);
            this.panelSideMenu.Controls.Add(this.btnInfoStudent);
            this.panelSideMenu.Controls.Add(this.panelCetpro);
            this.panelSideMenu.Controls.Add(this.btnInfoCetpro);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Location = new System.Drawing.Point(12, 12);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(433, 1003);
            this.panelSideMenu.TabIndex = 6;
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUser.Controls.Add(this.btnUser);
            this.panelUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUser.Location = new System.Drawing.Point(0, 920);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(433, 41);
            this.panelUser.TabIndex = 15;
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.White;
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnUser.Location = new System.Drawing.Point(0, 0);
            this.btnUser.Name = "btnUser";
            this.btnUser.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnUser.Size = new System.Drawing.Size(431, 40);
            this.btnUser.TabIndex = 11;
            this.btnUser.Text = "USUARIO";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnInfoUsers
            // 
            this.btnInfoUsers.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnInfoUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInfoUsers.FlatAppearance.BorderSize = 0;
            this.btnInfoUsers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInfoUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfoUsers.Location = new System.Drawing.Point(0, 837);
            this.btnInfoUsers.Name = "btnInfoUsers";
            this.btnInfoUsers.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnInfoUsers.Size = new System.Drawing.Size(433, 83);
            this.btnInfoUsers.TabIndex = 14;
            this.btnInfoUsers.Text = "CONTROL DE\r\nUSUARIOS";
            this.btnInfoUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfoUsers.UseVisualStyleBackColor = true;
            this.btnInfoUsers.Click += new System.EventHandler(this.btnInfoUsers_Click);
            // 
            // panelMatricula
            // 
            this.panelMatricula.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelMatricula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMatricula.Controls.Add(this.btnTeachingUnit);
            this.panelMatricula.Controls.Add(this.btnSpecialties);
            this.panelMatricula.Controls.Add(this.btnMatricula);
            this.panelMatricula.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMatricula.Location = new System.Drawing.Point(0, 714);
            this.panelMatricula.Name = "panelMatricula";
            this.panelMatricula.Size = new System.Drawing.Size(433, 123);
            this.panelMatricula.TabIndex = 13;
            // 
            // btnTeachingUnit
            // 
            this.btnTeachingUnit.BackColor = System.Drawing.Color.White;
            this.btnTeachingUnit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTeachingUnit.FlatAppearance.BorderSize = 0;
            this.btnTeachingUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeachingUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeachingUnit.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnTeachingUnit.Location = new System.Drawing.Point(0, 80);
            this.btnTeachingUnit.Name = "btnTeachingUnit";
            this.btnTeachingUnit.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnTeachingUnit.Size = new System.Drawing.Size(431, 40);
            this.btnTeachingUnit.TabIndex = 4;
            this.btnTeachingUnit.Text = "UNIDADES DIDACTICAS";
            this.btnTeachingUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeachingUnit.UseVisualStyleBackColor = false;
            this.btnTeachingUnit.Click += new System.EventHandler(this.btnTeachingUnit_Click);
            // 
            // btnSpecialties
            // 
            this.btnSpecialties.BackColor = System.Drawing.Color.White;
            this.btnSpecialties.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSpecialties.FlatAppearance.BorderSize = 0;
            this.btnSpecialties.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpecialties.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpecialties.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSpecialties.Location = new System.Drawing.Point(0, 40);
            this.btnSpecialties.Name = "btnSpecialties";
            this.btnSpecialties.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSpecialties.Size = new System.Drawing.Size(431, 40);
            this.btnSpecialties.TabIndex = 3;
            this.btnSpecialties.Text = "ESPECIALIDADES";
            this.btnSpecialties.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSpecialties.UseVisualStyleBackColor = false;
            this.btnSpecialties.Click += new System.EventHandler(this.btnSpecialties_Click);
            // 
            // btnMatricula
            // 
            this.btnMatricula.BackColor = System.Drawing.Color.White;
            this.btnMatricula.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMatricula.FlatAppearance.BorderSize = 0;
            this.btnMatricula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatricula.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnMatricula.Location = new System.Drawing.Point(0, 0);
            this.btnMatricula.Name = "btnMatricula";
            this.btnMatricula.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnMatricula.Size = new System.Drawing.Size(431, 40);
            this.btnMatricula.TabIndex = 2;
            this.btnMatricula.Text = "MATRICULA";
            this.btnMatricula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMatricula.UseVisualStyleBackColor = false;
            this.btnMatricula.Click += new System.EventHandler(this.btnMatricula_Click);
            // 
            // btnInfoMatricula
            // 
            this.btnInfoMatricula.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnInfoMatricula.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInfoMatricula.FlatAppearance.BorderSize = 0;
            this.btnInfoMatricula.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInfoMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfoMatricula.Location = new System.Drawing.Point(0, 631);
            this.btnInfoMatricula.Name = "btnInfoMatricula";
            this.btnInfoMatricula.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnInfoMatricula.Size = new System.Drawing.Size(433, 83);
            this.btnInfoMatricula.TabIndex = 5;
            this.btnInfoMatricula.Text = "MATRICULA";
            this.btnInfoMatricula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfoMatricula.UseVisualStyleBackColor = true;
            this.btnInfoMatricula.Click += new System.EventHandler(this.btnInfoMatricula_Click);
            // 
            // panelStudent
            // 
            this.panelStudent.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStudent.Controls.Add(this.btnStudent);
            this.panelStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStudent.Location = new System.Drawing.Point(0, 590);
            this.panelStudent.Name = "panelStudent";
            this.panelStudent.Size = new System.Drawing.Size(433, 41);
            this.panelStudent.TabIndex = 3;
            // 
            // btnStudent
            // 
            this.btnStudent.BackColor = System.Drawing.Color.White;
            this.btnStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudent.FlatAppearance.BorderSize = 0;
            this.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnStudent.Location = new System.Drawing.Point(0, 0);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnStudent.Size = new System.Drawing.Size(431, 40);
            this.btnStudent.TabIndex = 1;
            this.btnStudent.Text = "ESTUDIANTE";
            this.btnStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudent.UseVisualStyleBackColor = false;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnInfoStudent
            // 
            this.btnInfoStudent.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnInfoStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInfoStudent.FlatAppearance.BorderSize = 0;
            this.btnInfoStudent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInfoStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfoStudent.Location = new System.Drawing.Point(0, 507);
            this.btnInfoStudent.Name = "btnInfoStudent";
            this.btnInfoStudent.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnInfoStudent.Size = new System.Drawing.Size(433, 83);
            this.btnInfoStudent.TabIndex = 2;
            this.btnInfoStudent.Text = "INFORMACION DEL\r ESTUDIANTE";
            this.btnInfoStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfoStudent.UseVisualStyleBackColor = true;
            this.btnInfoStudent.Click += new System.EventHandler(this.btnInfoStudent_Click);
            // 
            // panelCetpro
            // 
            this.panelCetpro.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelCetpro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCetpro.Controls.Add(this.btnCetpro);
            this.panelCetpro.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCetpro.Location = new System.Drawing.Point(0, 466);
            this.panelCetpro.Name = "panelCetpro";
            this.panelCetpro.Size = new System.Drawing.Size(433, 41);
            this.panelCetpro.TabIndex = 1;
            // 
            // btnCetpro
            // 
            this.btnCetpro.BackColor = System.Drawing.Color.White;
            this.btnCetpro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCetpro.FlatAppearance.BorderSize = 0;
            this.btnCetpro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCetpro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCetpro.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnCetpro.Location = new System.Drawing.Point(0, 0);
            this.btnCetpro.Name = "btnCetpro";
            this.btnCetpro.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCetpro.Size = new System.Drawing.Size(431, 40);
            this.btnCetpro.TabIndex = 1;
            this.btnCetpro.Text = "CETPRO";
            this.btnCetpro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCetpro.UseVisualStyleBackColor = false;
            this.btnCetpro.Click += new System.EventHandler(this.btnCetpro_Click);
            // 
            // btnInfoCetpro
            // 
            this.btnInfoCetpro.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnInfoCetpro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInfoCetpro.FlatAppearance.BorderSize = 0;
            this.btnInfoCetpro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInfoCetpro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfoCetpro.Location = new System.Drawing.Point(0, 383);
            this.btnInfoCetpro.Name = "btnInfoCetpro";
            this.btnInfoCetpro.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnInfoCetpro.Size = new System.Drawing.Size(433, 83);
            this.btnInfoCetpro.TabIndex = 0;
            this.btnInfoCetpro.Text = "INFORMACION DEL \r\nCETPRO";
            this.btnInfoCetpro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfoCetpro.UseVisualStyleBackColor = true;
            this.btnInfoCetpro.Click += new System.EventHandler(this.btnInfoCetpro_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.txtRol);
            this.panelLogo.Controls.Add(this.txtName);
            this.panelLogo.Controls.Add(this.label2);
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(433, 383);
            this.panelLogo.TabIndex = 1;
            // 
            // txtRol
            // 
            this.txtRol.AutoSize = true;
            this.txtRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRol.Location = new System.Drawing.Point(306, 309);
            this.txtRol.Name = "txtRol";
            this.txtRol.Size = new System.Drawing.Size(90, 20);
            this.txtRol.TabIndex = 13;
            this.txtRol.Text = "Nombres:";
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(98, 309);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(84, 20);
            this.txtName.TabIndex = 12;
            this.txtName.Text = "Nombres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Rol:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentation.Properties.Resources.cetpropgn;
            this.pictureBox1.Location = new System.Drawing.Point(84, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnSaveBackup
            // 
            this.btnSaveBackup.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSaveBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveBackup.Image = global::CapaPresentation.Properties.Resources._733554f;
            this.btnSaveBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveBackup.Location = new System.Drawing.Point(1555, 52);
            this.btnSaveBackup.Name = "btnSaveBackup";
            this.btnSaveBackup.Padding = new System.Windows.Forms.Padding(20, 0, 5, 0);
            this.btnSaveBackup.Size = new System.Drawing.Size(281, 75);
            this.btnSaveBackup.TabIndex = 9;
            this.btnSaveBackup.Text = "SUBIR AL DRIVE";
            this.btnSaveBackup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveBackup.UseVisualStyleBackColor = false;
            this.btnSaveBackup.Click += new System.EventHandler(this.btnSaveBackup_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = global::CapaPresentation.Properties.Resources.salirdd;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(1555, 884);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.btnExit.Size = new System.Drawing.Size(281, 75);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "SALIR";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnTuition
            // 
            this.btnTuition.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTuition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTuition.Location = new System.Drawing.Point(1402, 558);
            this.btnTuition.Name = "btnTuition";
            this.btnTuition.Size = new System.Drawing.Size(244, 85);
            this.btnTuition.TabIndex = 11;
            this.btnTuition.Text = "VER MATRICULA (Pdf)";
            this.btnTuition.UseVisualStyleBackColor = false;
            this.btnTuition.Click += new System.EventHandler(this.btnTuition_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1900, 1027);
            this.ControlBox = false;
            this.Controls.Add(this.btnTuition);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSaveBackup);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.btnShowReport);
            this.Controls.Add(this.btnShowDni);
            this.MinimumSize = new System.Drawing.Size(1918, 1074);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelUser.ResumeLayout(false);
            this.panelMatricula.ResumeLayout(false);
            this.panelStudent.ResumeLayout(false);
            this.panelCetpro.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Button btnShowDni;
        private System.Windows.Forms.Button btnShowReport;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelStudent;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnInfoStudent;
        private System.Windows.Forms.Panel panelCetpro;
        private System.Windows.Forms.Button btnCetpro;
        private System.Windows.Forms.Button btnInfoCetpro;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSaveBackup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtRol;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnInfoUsers;
        private System.Windows.Forms.Panel panelMatricula;
        private System.Windows.Forms.Button btnMatricula;
        private System.Windows.Forms.Button btnInfoMatricula;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnTeachingUnit;
        private System.Windows.Forms.Button btnSpecialties;
        private System.Windows.Forms.Button btnTuition;
    }
}

