namespace Ejercicio_1
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
            txbName = new TextBox();
            txbLastName = new TextBox();
            lblName = new Label();
            lblLastName = new Label();
            lblFavoriteSubjet = new Label();
            btnHello = new Button();
            btnExit = new Button();
            cmbFavoriteSubjet = new ComboBox();
            SuspendLayout();
            // 
            // txbName
            // 
            txbName.Location = new Point(23, 49);
            txbName.Name = "txbName";
            txbName.Size = new Size(149, 23);
            txbName.TabIndex = 7;
            // 
            // txbLastName
            // 
            txbLastName.Location = new Point(209, 49);
            txbLastName.Name = "txbLastName";
            txbLastName.Size = new Size(149, 23);
            txbLastName.TabIndex = 8;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(23, 29);
            lblName.Name = "lblName";
            lblName.Size = new Size(58, 17);
            lblName.TabIndex = 10;
            lblName.Text = "Nombre";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblLastName.Location = new Point(209, 29);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(60, 17);
            lblLastName.TabIndex = 11;
            lblLastName.Text = "Apellido";
            // 
            // lblFavoriteSubjet
            // 
            lblFavoriteSubjet.AutoSize = true;
            lblFavoriteSubjet.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblFavoriteSubjet.Location = new Point(23, 91);
            lblFavoriteSubjet.Name = "lblFavoriteSubjet";
            lblFavoriteSubjet.Size = new Size(109, 17);
            lblFavoriteSubjet.TabIndex = 12;
            lblFavoriteSubjet.Text = "Materia Favorita";
            // 
            // btnHello
            // 
            btnHello.BackColor = SystemColors.ScrollBar;
            btnHello.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnHello.Location = new Point(79, 189);
            btnHello.Name = "btnHello";
            btnHello.Size = new Size(93, 44);
            btnHello.TabIndex = 13;
            btnHello.Text = "Saludar";
            btnHello.UseVisualStyleBackColor = false;
            btnHello.Click += btnHello_Click_1;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ScrollBar;
            btnExit.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(209, 189);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(93, 44);
            btnExit.TabIndex = 14;
            btnExit.Text = "Salir";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click_1;
            // 
            // cmbFavoriteSubjet
            // 
            cmbFavoriteSubjet.FormattingEnabled = true;
            cmbFavoriteSubjet.Location = new Point(23, 111);
            cmbFavoriteSubjet.Name = "cmbFavoriteSubjet";
            cmbFavoriteSubjet.Size = new Size(149, 23);
            cmbFavoriteSubjet.TabIndex = 15;
            // 
            // Data
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(386, 245);
            Controls.Add(cmbFavoriteSubjet);
            Controls.Add(btnExit);
            Controls.Add(btnHello);
            Controls.Add(lblFavoriteSubjet);
            Controls.Add(lblLastName);
            Controls.Add(lblName);
            Controls.Add(txbLastName);
            Controls.Add(txbName);
            Name = "Data";
            Text = "Form1";
            Load += Data_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbName;
        private TextBox txbLastName;
        private Label lblName;
        private Label lblLastName;
        private Label lblFavoriteSubjet;
        private Button btnHello;
        private Button btnExit;
        private ComboBox cmbFavoriteSubjet;
    }
}