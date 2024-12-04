namespace FTPZLab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                decimal creditAmount = decimal.Parse(txtCreditAmount.Text);
                int creditTerm = int.Parse(txtCreditTerm.Text);

                decimal baseRate = 15.0m; 
                decimal rate = baseRate;

                if (creditAmount <= 0 || creditTerm <= 0)
                {
                    MessageBox.Show("Помилка вводу: сума та строк кредиту мають бути додатніми числами", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    return;
                }

                if (creditAmount < 1000) 
                {
                    MessageBox.Show("Кредит сумою менше 1000 гривень не видається", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    return;
                }

                if (creditAmount >= 10000 && creditAmount < 20000)
                    rate -= 1;
                else if (creditAmount >= 20000 && creditAmount < 40000)
                    rate -= 2;
                else if (creditAmount >= 40000)
                {
                    MessageBox.Show("Для суми кредиту понад 40 000 грн. ставка обговорюється індивідуально.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    return;
                }

                if (creditTerm > 3 && creditTerm <= 5)
                    rate += 1;
                else if (creditTerm > 5 && creditTerm <= 10)
                    rate += 2;
                else if (creditTerm > 10)
                {
                    MessageBox.Show("Для строку кредиту понад 10 років ставка обговорюється індивідуально.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    return;
                }

                lblResult.Text = $"Ставка по кредиту: {rate}%";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка вводу: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}