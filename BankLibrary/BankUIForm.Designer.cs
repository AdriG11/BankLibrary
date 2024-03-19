namespace BankLibrary
{
    partial class BankUIForm
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
            accountTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            balanceTextBox = new TextBox();
            Cuenta = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // accountTextBox
            // 
            accountTextBox.Location = new Point(235, 47);
            accountTextBox.Name = "accountTextBox";
            accountTextBox.Size = new Size(100, 23);
            accountTextBox.TabIndex = 0;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(235, 206);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(100, 23);
            lastNameTextBox.TabIndex = 1;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(235, 119);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(100, 23);
            firstNameTextBox.TabIndex = 2;
            // 
            // balanceTextBox
            // 
            balanceTextBox.Location = new Point(235, 288);
            balanceTextBox.Name = "balanceTextBox";
            balanceTextBox.Size = new Size(100, 23);
            balanceTextBox.TabIndex = 3;
            // 
            // Cuenta
            // 
            Cuenta.AutoSize = true;
            Cuenta.Location = new Point(27, 47);
            Cuenta.Name = "Cuenta";
            Cuenta.Size = new Size(45, 15);
            Cuenta.TabIndex = 4;
            Cuenta.Text = "Cuenta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 119);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 5;
            label2.Text = "Primer Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 214);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 6;
            label3.Text = "Apellido Paterno";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 291);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 7;
            label4.Text = "Saldo";
            // 
            // BankUIForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 396);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Cuenta);
            Controls.Add(balanceTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(accountTextBox);
            Name = "BankUIForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox accountTextBox;
        private TextBox lastNameTextBox;
        private TextBox firstNameTextBox;
        private TextBox balanceTextBox;
        private Label Cuenta;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}