namespace Ejercicio_3
{
    partial class Converter
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txbEuro = new TextBox();
            txbDolar = new TextBox();
            txbPeso = new TextBox();
            btnState = new Button();
            btnConvertEuro = new Button();
            btnConvertDolar = new Button();
            btnConvertPeso = new Button();
            txbEuroToEuro = new TextBox();
            txbEuroToDolar = new TextBox();
            txbEuroToPeso = new TextBox();
            txbDolarToPeso = new TextBox();
            txbDolarToDolar = new TextBox();
            txbDolarToEuro = new TextBox();
            txbPesoToPeso = new TextBox();
            txbPesoToDolar = new TextBox();
            txbPesoToEuro = new TextBox();
            txbCurrentPeso = new TextBox();
            txbCurrentDolar = new TextBox();
            txbCurrentEuro = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(70, 19);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 0;
            label1.Text = "Cotización";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 1;
            label2.Text = "Euro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 95);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 2;
            label3.Text = "Dólar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 120);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 3;
            label4.Text = "Peso";
            // 
            // txbEuro
            // 
            txbEuro.Location = new Point(70, 66);
            txbEuro.Name = "txbEuro";
            txbEuro.Size = new Size(91, 23);
            txbEuro.TabIndex = 4;
            // 
            // txbDolar
            // 
            txbDolar.Location = new Point(70, 92);
            txbDolar.Name = "txbDolar";
            txbDolar.Size = new Size(91, 23);
            txbDolar.TabIndex = 5;
            // 
            // txbPeso
            // 
            txbPeso.Location = new Point(70, 117);
            txbPeso.Name = "txbPeso";
            txbPeso.Size = new Size(91, 23);
            txbPeso.TabIndex = 6;
            // 
            // btnState
            // 
            btnState.Location = new Point(176, 7);
            btnState.Name = "btnState";
            btnState.Size = new Size(89, 32);
            btnState.TabIndex = 7;
            btnState.Text = "button1";
            btnState.UseVisualStyleBackColor = true;
            // 
            // btnConvertEuro
            // 
            btnConvertEuro.Location = new Point(176, 66);
            btnConvertEuro.Name = "btnConvertEuro";
            btnConvertEuro.Size = new Size(89, 23);
            btnConvertEuro.TabIndex = 8;
            btnConvertEuro.Text = "->";
            btnConvertEuro.UseVisualStyleBackColor = true;
            btnConvertEuro.Click += btnConvertEuro_Click;
            // 
            // btnConvertDolar
            // 
            btnConvertDolar.Location = new Point(176, 92);
            btnConvertDolar.Name = "btnConvertDolar";
            btnConvertDolar.Size = new Size(89, 23);
            btnConvertDolar.TabIndex = 9;
            btnConvertDolar.Text = "->";
            btnConvertDolar.UseVisualStyleBackColor = true;
            btnConvertDolar.Click += btnConvertDolar_Click;
            // 
            // btnConvertPeso
            // 
            btnConvertPeso.Location = new Point(176, 120);
            btnConvertPeso.Name = "btnConvertPeso";
            btnConvertPeso.Size = new Size(89, 23);
            btnConvertPeso.TabIndex = 10;
            btnConvertPeso.Text = "->";
            btnConvertPeso.UseVisualStyleBackColor = true;
            btnConvertPeso.Click += btnConvertPeso_Click;
            // 
            // txbEuroToEuro
            // 
            txbEuroToEuro.Location = new Point(283, 66);
            txbEuroToEuro.Name = "txbEuroToEuro";
            txbEuroToEuro.Size = new Size(80, 23);
            txbEuroToEuro.TabIndex = 11;
            // 
            // txbEuroToDolar
            // 
            txbEuroToDolar.Location = new Point(369, 66);
            txbEuroToDolar.Name = "txbEuroToDolar";
            txbEuroToDolar.Size = new Size(80, 23);
            txbEuroToDolar.TabIndex = 12;
            // 
            // txbEuroToPeso
            // 
            txbEuroToPeso.Location = new Point(455, 66);
            txbEuroToPeso.Name = "txbEuroToPeso";
            txbEuroToPeso.Size = new Size(80, 23);
            txbEuroToPeso.TabIndex = 13;
            // 
            // txbDolarToPeso
            // 
            txbDolarToPeso.Location = new Point(455, 92);
            txbDolarToPeso.Name = "txbDolarToPeso";
            txbDolarToPeso.Size = new Size(80, 23);
            txbDolarToPeso.TabIndex = 16;
            // 
            // txbDolarToDolar
            // 
            txbDolarToDolar.Location = new Point(369, 92);
            txbDolarToDolar.Name = "txbDolarToDolar";
            txbDolarToDolar.Size = new Size(80, 23);
            txbDolarToDolar.TabIndex = 15;
            // 
            // txbDolarToEuro
            // 
            txbDolarToEuro.Location = new Point(283, 92);
            txbDolarToEuro.Name = "txbDolarToEuro";
            txbDolarToEuro.Size = new Size(80, 23);
            txbDolarToEuro.TabIndex = 14;
            // 
            // txbPesoToPeso
            // 
            txbPesoToPeso.Location = new Point(455, 117);
            txbPesoToPeso.Name = "txbPesoToPeso";
            txbPesoToPeso.Size = new Size(80, 23);
            txbPesoToPeso.TabIndex = 19;
            // 
            // txbPesoToDolar
            // 
            txbPesoToDolar.Location = new Point(369, 117);
            txbPesoToDolar.Name = "txbPesoToDolar";
            txbPesoToDolar.Size = new Size(80, 23);
            txbPesoToDolar.TabIndex = 18;
            // 
            // txbPesoToEuro
            // 
            txbPesoToEuro.Location = new Point(283, 117);
            txbPesoToEuro.Name = "txbPesoToEuro";
            txbPesoToEuro.Size = new Size(80, 23);
            txbPesoToEuro.TabIndex = 17;
            // 
            // txbCurrentPeso
            // 
            txbCurrentPeso.Location = new Point(455, 13);
            txbCurrentPeso.Name = "txbCurrentPeso";
            txbCurrentPeso.Size = new Size(80, 23);
            txbCurrentPeso.TabIndex = 22;
            // 
            // txbCurrentDolar
            // 
            txbCurrentDolar.Location = new Point(369, 13);
            txbCurrentDolar.Name = "txbCurrentDolar";
            txbCurrentDolar.Size = new Size(80, 23);
            txbCurrentDolar.TabIndex = 21;
            // 
            // txbCurrentEuro
            // 
            txbCurrentEuro.Location = new Point(283, 13);
            txbCurrentEuro.Name = "txbCurrentEuro";
            txbCurrentEuro.Size = new Size(80, 23);
            txbCurrentEuro.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(300, 43);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 23;
            label5.Text = "Euro";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(382, 43);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 24;
            label6.Text = "Dólar";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(473, 43);
            label7.Name = "label7";
            label7.Size = new Size(42, 20);
            label7.TabIndex = 25;
            label7.Text = "Peso";
            // 
            // Converter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 162);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txbCurrentPeso);
            Controls.Add(txbCurrentDolar);
            Controls.Add(txbCurrentEuro);
            Controls.Add(txbPesoToPeso);
            Controls.Add(txbPesoToDolar);
            Controls.Add(txbPesoToEuro);
            Controls.Add(txbDolarToPeso);
            Controls.Add(txbDolarToDolar);
            Controls.Add(txbDolarToEuro);
            Controls.Add(txbEuroToPeso);
            Controls.Add(txbEuroToDolar);
            Controls.Add(txbEuroToEuro);
            Controls.Add(btnConvertPeso);
            Controls.Add(btnConvertDolar);
            Controls.Add(btnConvertEuro);
            Controls.Add(btnState);
            Controls.Add(txbPeso);
            Controls.Add(txbDolar);
            Controls.Add(txbEuro);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Converter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Conversor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txbEuro;
        private TextBox txbDolar;
        private TextBox txbPeso;
        private Button btnState;
        private Button btnConvertEuro;
        private Button btnConvertDolar;
        private Button btnConvertPeso;
        private TextBox txbEuroToEuro;
        private TextBox txbEuroToDolar;
        private TextBox txbEuroToPeso;
        private TextBox txbDolarToPeso;
        private TextBox txbDolarToDolar;
        private TextBox txbDolarToEuro;
        private TextBox txbPesoToPeso;
        private TextBox txbPesoToDolar;
        private TextBox txbPesoToEuro;
        private TextBox txbCurrentPeso;
        private TextBox txbCurrentDolar;
        private TextBox txbCurrentEuro;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}