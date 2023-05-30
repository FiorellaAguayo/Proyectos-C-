namespace Ejercicio_2
{
    partial class Data
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grp_Cursos = new GroupBox();
            chkJavaScript = new CheckBox();
            chkCPP = new CheckBox();
            chkCSharp = new CheckBox();
            btnEnter = new Button();
            lbl_Pais = new Label();
            lstCountry = new ListBox();
            grp_Genero = new GroupBox();
            rbNoBinary = new RadioButton();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            grp_DetallesUsuario = new GroupBox();
            lbl_Edad = new Label();
            nudAge = new NumericUpDown();
            lbl_Direccion = new Label();
            txbAddress = new TextBox();
            lbl_Nombre = new Label();
            txbName = new TextBox();
            grp_Cursos.SuspendLayout();
            grp_Genero.SuspendLayout();
            grp_DetallesUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAge).BeginInit();
            SuspendLayout();
            // 
            // grp_Cursos
            // 
            grp_Cursos.Controls.Add(chkJavaScript);
            grp_Cursos.Controls.Add(chkCPP);
            grp_Cursos.Controls.Add(chkCSharp);
            grp_Cursos.Location = new Point(275, 160);
            grp_Cursos.Name = "grp_Cursos";
            grp_Cursos.Size = new Size(116, 113);
            grp_Cursos.TabIndex = 12;
            grp_Cursos.TabStop = false;
            grp_Cursos.Text = "Cursos";
            // 
            // chkJavaScript
            // 
            chkJavaScript.AutoSize = true;
            chkJavaScript.Location = new Point(19, 74);
            chkJavaScript.Name = "chkJavaScript";
            chkJavaScript.Size = new Size(78, 19);
            chkJavaScript.TabIndex = 2;
            chkJavaScript.Text = "JavaScript";
            chkJavaScript.UseVisualStyleBackColor = true;
            // 
            // chkCPP
            // 
            chkCPP.AutoSize = true;
            chkCPP.Location = new Point(19, 49);
            chkCPP.Name = "chkCPP";
            chkCPP.Size = new Size(50, 19);
            chkCPP.TabIndex = 1;
            chkCPP.Text = "C++";
            chkCPP.UseVisualStyleBackColor = true;
            // 
            // chkCSharp
            // 
            chkCSharp.AutoSize = true;
            chkCSharp.Location = new Point(19, 24);
            chkCSharp.Name = "chkCSharp";
            chkCSharp.Size = new Size(41, 19);
            chkCSharp.TabIndex = 0;
            chkCSharp.Text = "C#";
            chkCSharp.UseVisualStyleBackColor = true;
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(294, 293);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(97, 33);
            btnEnter.TabIndex = 11;
            btnEnter.Text = "Ingresar";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btn_Ingreso_Click_1;
            // 
            // lbl_Pais
            // 
            lbl_Pais.AutoSize = true;
            lbl_Pais.Location = new Point(24, 206);
            lbl_Pais.Name = "lbl_Pais";
            lbl_Pais.Size = new Size(28, 15);
            lbl_Pais.TabIndex = 10;
            lbl_Pais.Text = "Pais";
            // 
            // lstCountry
            // 
            lstCountry.FormattingEnabled = true;
            lstCountry.ItemHeight = 15;
            lstCountry.Items.AddRange(new object[] { "Argentina", "Chile", "Uruguay" });
            lstCountry.Location = new Point(24, 224);
            lstCountry.Name = "lstCountry";
            lstCountry.Size = new Size(197, 49);
            lstCountry.TabIndex = 9;
            // 
            // grp_Genero
            // 
            grp_Genero.Controls.Add(rbNoBinary);
            grp_Genero.Controls.Add(rbFemale);
            grp_Genero.Controls.Add(rbMale);
            grp_Genero.Location = new Point(275, 25);
            grp_Genero.Name = "grp_Genero";
            grp_Genero.Size = new Size(116, 111);
            grp_Genero.TabIndex = 8;
            grp_Genero.TabStop = false;
            grp_Genero.Text = "Genero";
            // 
            // rbNoBinary
            // 
            rbNoBinary.AutoSize = true;
            rbNoBinary.Location = new Point(19, 76);
            rbNoBinary.Name = "rbNoBinary";
            rbNoBinary.Size = new Size(81, 19);
            rbNoBinary.TabIndex = 2;
            rbNoBinary.TabStop = true;
            rbNoBinary.Text = "No binario";
            rbNoBinary.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(19, 51);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(78, 19);
            rbFemale.TabIndex = 1;
            rbFemale.TabStop = true;
            rbFemale.Text = "Femenino";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(19, 26);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(80, 19);
            rbMale.TabIndex = 0;
            rbMale.TabStop = true;
            rbMale.Text = "Masculino";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // grp_DetallesUsuario
            // 
            grp_DetallesUsuario.Controls.Add(lbl_Edad);
            grp_DetallesUsuario.Controls.Add(nudAge);
            grp_DetallesUsuario.Controls.Add(lbl_Direccion);
            grp_DetallesUsuario.Controls.Add(txbAddress);
            grp_DetallesUsuario.Controls.Add(lbl_Nombre);
            grp_DetallesUsuario.Controls.Add(txbName);
            grp_DetallesUsuario.ForeColor = SystemColors.ControlText;
            grp_DetallesUsuario.Location = new Point(24, 25);
            grp_DetallesUsuario.Name = "grp_DetallesUsuario";
            grp_DetallesUsuario.Size = new Size(224, 166);
            grp_DetallesUsuario.TabIndex = 7;
            grp_DetallesUsuario.TabStop = false;
            grp_DetallesUsuario.Text = "Detalles del usuario";
            // 
            // lbl_Edad
            // 
            lbl_Edad.AutoSize = true;
            lbl_Edad.Location = new Point(18, 108);
            lbl_Edad.Name = "lbl_Edad";
            lbl_Edad.Size = new Size(33, 15);
            lbl_Edad.TabIndex = 3;
            lbl_Edad.Text = "Edad";
            // 
            // nudAge
            // 
            nudAge.Location = new Point(88, 108);
            nudAge.Minimum = new decimal(new int[] { 18, 0, 0, 0 });
            nudAge.Name = "nudAge";
            nudAge.Size = new Size(120, 23);
            nudAge.TabIndex = 3;
            nudAge.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // lbl_Direccion
            // 
            lbl_Direccion.AutoSize = true;
            lbl_Direccion.Location = new Point(18, 65);
            lbl_Direccion.Name = "lbl_Direccion";
            lbl_Direccion.Size = new Size(57, 15);
            lbl_Direccion.TabIndex = 2;
            lbl_Direccion.Text = "Dirección";
            // 
            // txbAddress
            // 
            txbAddress.Location = new Point(88, 62);
            txbAddress.Name = "txbAddress";
            txbAddress.Size = new Size(120, 23);
            txbAddress.TabIndex = 2;
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.Location = new Point(18, 38);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(51, 15);
            lbl_Nombre.TabIndex = 1;
            lbl_Nombre.Text = "Nombre";
            // 
            // txbName
            // 
            txbName.Location = new Point(88, 30);
            txbName.Name = "txbName";
            txbName.Size = new Size(120, 23);
            txbName.TabIndex = 1;
            // 
            // Data
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(413, 346);
            Controls.Add(grp_Cursos);
            Controls.Add(btnEnter);
            Controls.Add(lbl_Pais);
            Controls.Add(lstCountry);
            Controls.Add(grp_Genero);
            Controls.Add(grp_DetallesUsuario);
            Name = "Data";
            Text = "Form1";
            grp_Cursos.ResumeLayout(false);
            grp_Cursos.PerformLayout();
            grp_Genero.ResumeLayout(false);
            grp_Genero.PerformLayout();
            grp_DetallesUsuario.ResumeLayout(false);
            grp_DetallesUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grp_Cursos;
        private CheckBox chkJavaScript;
        private CheckBox chkCPP;
        private CheckBox chkCSharp;
        private Button btnEnter;
        private Label lbl_Pais;
        private ListBox lstCountry;
        private GroupBox grp_Genero;
        private RadioButton rbNoBinary;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private GroupBox grp_DetallesUsuario;
        private Label lbl_Edad;
        private NumericUpDown nudAge;
        private Label lbl_Direccion;
        private TextBox txbAddress;
        private Label lbl_Nombre;
        private TextBox txbName;
    }
}