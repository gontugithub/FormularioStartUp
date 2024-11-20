namespace Formulario
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblMaritalStatus = new System.Windows.Forms.Label();
            this.txtParentsNames = new System.Windows.Forms.TextBox();
            this.txtLastName2 = new System.Windows.Forms.TextBox();
            this.txtLastName1 = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtPassport = new System.Windows.Forms.TextBox();
            this.txtNIE = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.ComboBox();
            this.cmbMaritalStatus = new System.Windows.Forms.ComboBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblParentsNames = new System.Windows.Forms.Label();
            this.lblLastName2 = new System.Windows.Forms.Label();
            this.lblLastName1 = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblPassport = new System.Windows.Forms.Label();
            this.lblNIE = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCompanions = new System.Windows.Forms.ComboBox();
            this.txtDestination = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblCompanions = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbGender);
            this.groupBox1.Controls.Add(this.lblGender);
            this.groupBox1.Controls.Add(this.lblMaritalStatus);
            this.groupBox1.Controls.Add(this.txtParentsNames);
            this.groupBox1.Controls.Add(this.txtLastName2);
            this.groupBox1.Controls.Add(this.txtLastName1);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.txtPassport);
            this.groupBox1.Controls.Add(this.txtNIE);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.cmbMaritalStatus);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.lblParentsNames);
            this.groupBox1.Controls.Add(this.lblLastName2);
            this.groupBox1.Controls.Add(this.lblLastName1);
            this.groupBox1.Controls.Add(this.lblFirstName);
            this.groupBox1.Controls.Add(this.lblPassport);
            this.groupBox1.Controls.Add(this.lblNIE);
            this.groupBox1.Location = new System.Drawing.Point(35, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(722, 151);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Masculino",
            "",
            "Femenino",
            "",
            "Otro"});
            this.cmbGender.Location = new System.Drawing.Point(565, 37);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(121, 21);
            this.cmbGender.TabIndex = 17;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(601, 20);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(31, 13);
            this.lblGender.TabIndex = 16;
            this.lblGender.Text = "Sexo";
            // 
            // lblMaritalStatus
            // 
            this.lblMaritalStatus.AutoSize = true;
            this.lblMaritalStatus.Location = new System.Drawing.Point(416, 20);
            this.lblMaritalStatus.Name = "lblMaritalStatus";
            this.lblMaritalStatus.Size = new System.Drawing.Size(59, 13);
            this.lblMaritalStatus.TabIndex = 15;
            this.lblMaritalStatus.Text = "EstadoCivil";
            // 
            // txtParentsNames
            // 
            this.txtParentsNames.Location = new System.Drawing.Point(221, 128);
            this.txtParentsNames.Name = "txtParentsNames";
            this.txtParentsNames.Size = new System.Drawing.Size(100, 20);
            this.txtParentsNames.TabIndex = 14;
            // 
            // txtLastName2
            // 
            this.txtLastName2.Location = new System.Drawing.Point(248, 88);
            this.txtLastName2.Name = "txtLastName2";
            this.txtLastName2.Size = new System.Drawing.Size(100, 20);
            this.txtLastName2.TabIndex = 13;
            // 
            // txtLastName1
            // 
            this.txtLastName1.Location = new System.Drawing.Point(235, 37);
            this.txtLastName1.Name = "txtLastName1";
            this.txtLastName1.Size = new System.Drawing.Size(100, 20);
            this.txtLastName1.TabIndex = 12;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(36, 128);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 11;
            // 
            // txtPassport
            // 
            this.txtPassport.Location = new System.Drawing.Point(45, 84);
            this.txtPassport.Name = "txtPassport";
            this.txtPassport.Size = new System.Drawing.Size(100, 20);
            this.txtPassport.TabIndex = 10;
            // 
            // txtNIE
            // 
            this.txtNIE.Location = new System.Drawing.Point(45, 37);
            this.txtNIE.Name = "txtNIE";
            this.txtNIE.Size = new System.Drawing.Size(100, 20);
            this.txtNIE.TabIndex = 9;
            // 
            // txtAddress
            // 
            this.txtAddress.FormattingEnabled = true;
            this.txtAddress.Items.AddRange(new object[] {
            "Madrid",
            "",
            "Barcelona",
            "",
            "Valencia",
            "",
            "Sevilla",
            "",
            "Otra"});
            this.txtAddress.Location = new System.Drawing.Point(394, 100);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(121, 21);
            this.txtAddress.TabIndex = 8;
            // 
            // cmbMaritalStatus
            // 
            this.cmbMaritalStatus.FormattingEnabled = true;
            this.cmbMaritalStatus.Items.AddRange(new object[] {
            "Soltero",
            "",
            "Casado",
            "",
            "Divorciado",
            "",
            "Viudo"});
            this.cmbMaritalStatus.Location = new System.Drawing.Point(394, 37);
            this.cmbMaritalStatus.Name = "cmbMaritalStatus";
            this.cmbMaritalStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbMaritalStatus.TabIndex = 7;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(416, 84);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(49, 13);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Domicilio";
            // 
            // lblParentsNames
            // 
            this.lblParentsNames.AutoSize = true;
            this.lblParentsNames.Location = new System.Drawing.Point(209, 111);
            this.lblParentsNames.Name = "lblParentsNames";
            this.lblParentsNames.Size = new System.Drawing.Size(116, 13);
            this.lblParentsNames.TabIndex = 5;
            this.lblParentsNames.Text = "Nombres de los Padres";
            // 
            // lblLastName2
            // 
            this.lblLastName2.AutoSize = true;
            this.lblLastName2.Location = new System.Drawing.Point(218, 72);
            this.lblLastName2.Name = "lblLastName2";
            this.lblLastName2.Size = new System.Drawing.Size(90, 13);
            this.lblLastName2.TabIndex = 4;
            this.lblLastName2.Text = "Segundo Apellido";
            // 
            // lblLastName1
            // 
            this.lblLastName1.AutoSize = true;
            this.lblLastName1.Location = new System.Drawing.Point(232, 20);
            this.lblLastName1.Name = "lblLastName1";
            this.lblLastName1.Size = new System.Drawing.Size(76, 13);
            this.lblLastName1.TabIndex = 3;
            this.lblLastName1.Text = "Primer Apellido";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(23, 111);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(44, 13);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "Nombre";
            // 
            // lblPassport
            // 
            this.lblPassport.AutoSize = true;
            this.lblPassport.Location = new System.Drawing.Point(23, 67);
            this.lblPassport.Name = "lblPassport";
            this.lblPassport.Size = new System.Drawing.Size(113, 13);
            this.lblPassport.TabIndex = 1;
            this.lblPassport.Text = "Número de Pasaporte:";
            // 
            // lblNIE
            // 
            this.lblNIE.AutoSize = true;
            this.lblNIE.Location = new System.Drawing.Point(42, 20);
            this.lblNIE.Name = "lblNIE";
            this.lblNIE.Size = new System.Drawing.Size(25, 13);
            this.lblNIE.TabIndex = 0;
            this.lblNIE.Text = "NIE";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCompanions);
            this.groupBox2.Controls.Add(this.txtDestination);
            this.groupBox2.Controls.Add(this.btnSubmit);
            this.groupBox2.Controls.Add(this.lblCompanions);
            this.groupBox2.Controls.Add(this.lblDestination);
            this.groupBox2.Location = new System.Drawing.Point(35, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(537, 161);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // txtCompanions
            // 
            this.txtCompanions.FormattingEnabled = true;
            this.txtCompanions.Items.AddRange(new object[] {
            "Solo",
            "",
            "Familia",
            "",
            "Amigos",
            "",
            "Pareja",
            "",
            "Otro"});
            this.txtCompanions.Location = new System.Drawing.Point(260, 42);
            this.txtCompanions.Name = "txtCompanions";
            this.txtCompanions.Size = new System.Drawing.Size(121, 21);
            this.txtCompanions.TabIndex = 4;
            // 
            // txtDestination
            // 
            this.txtDestination.FormattingEnabled = true;
            this.txtDestination.Items.AddRange(new object[] {
            "España",
            "",
            "Francia",
            "",
            "Alemania",
            "I",
            "talia",
            "",
            "Otro"});
            this.txtDestination.Location = new System.Drawing.Point(6, 42);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(121, 21);
            this.txtDestination.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(158, 40);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Botón ";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblCompanions
            // 
            this.lblCompanions.AutoSize = true;
            this.lblCompanions.Location = new System.Drawing.Point(271, 26);
            this.lblCompanions.Name = "lblCompanions";
            this.lblCompanions.Size = new System.Drawing.Size(51, 13);
            this.lblCompanions.TabIndex = 1;
            this.lblCompanions.Text = "Viaja con";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(25, 26);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(43, 13);
            this.lblDestination.TabIndex = 0;
            this.lblDestination.Text = "Destino";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "MINISTERIO DE ESPAÑA";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(287, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "º";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbMaritalStatus;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblParentsNames;
        private System.Windows.Forms.Label lblLastName2;
        private System.Windows.Forms.Label lblLastName1;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblPassport;
        private System.Windows.Forms.Label lblNIE;
        private System.Windows.Forms.ComboBox txtAddress;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblCompanions;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.TextBox txtParentsNames;
        private System.Windows.Forms.TextBox txtLastName2;
        private System.Windows.Forms.TextBox txtLastName1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtPassport;
        private System.Windows.Forms.TextBox txtNIE;
        private System.Windows.Forms.Label lblMaritalStatus;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox txtDestination;
        private System.Windows.Forms.ComboBox txtCompanions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

