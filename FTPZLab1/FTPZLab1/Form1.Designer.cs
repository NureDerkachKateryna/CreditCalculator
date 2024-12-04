namespace FTPZLab1
{
    partial class Form1
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
            txtCreditAmount = new TextBox();
            txtCreditTerm = new TextBox();
            btnCalculate = new Button();
            lblResult = new Label();
            lblCreditAmount = new Label();
            lblCreditTerm = new Label();
            SuspendLayout();
            // 
            // txtCreditAmount
            // 
            txtCreditAmount.Location = new Point(150, 30);
            txtCreditAmount.Name = "txtCreditAmount";
            txtCreditAmount.Size = new Size(120, 27);
            txtCreditAmount.TabIndex = 0;
            // 
            // txtCreditTerm
            // 
            txtCreditTerm.Location = new Point(150, 70);
            txtCreditTerm.Name = "txtCreditTerm";
            txtCreditTerm.Size = new Size(120, 27);
            txtCreditTerm.TabIndex = 1;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(150, 110);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(120, 30);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "Розрахувати";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(30, 158);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 20);
            lblResult.TabIndex = 3;
            // 
            // lblCreditAmount
            // 
            lblCreditAmount.AutoSize = true;
            lblCreditAmount.Location = new Point(30, 30);
            lblCreditAmount.Name = "lblCreditAmount";
            lblCreditAmount.Size = new Size(105, 20);
            lblCreditAmount.TabIndex = 4;
            lblCreditAmount.Text = "Сума кредиту:";
            // 
            // lblCreditTerm
            // 
            lblCreditTerm.AutoSize = true;
            lblCreditTerm.Location = new Point(30, 70);
            lblCreditTerm.Name = "lblCreditTerm";
            lblCreditTerm.Size = new Size(100, 20);
            lblCreditTerm.TabIndex = 5;
            lblCreditTerm.Text = "Строк (роки):";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 200);
            Controls.Add(lblCreditTerm);
            Controls.Add(lblCreditAmount);
            Controls.Add(lblResult);
            Controls.Add(btnCalculate);
            Controls.Add(txtCreditTerm);
            Controls.Add(txtCreditAmount);
            Name = "Form1";
            Text = "CreditCalculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCreditAmount;
        private TextBox txtCreditTerm;
        private Button btnCalculate;
        private Label lblResult;
        private Label lblCreditAmount;
        private Label lblCreditTerm;
    }
}