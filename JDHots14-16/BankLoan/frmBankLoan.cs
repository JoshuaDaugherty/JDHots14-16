using System;
using System.Windows.Forms;
using ILoan;
namespace BankLoan
{
    public partial class frmBankLoan : Form
    {
        //constants
        const decimal MINLOAN = 100.00m;
        const decimal MAXLOAN = 999999.99m;

        const decimal SHORTINTERESTRATE      = 0.10m;
        const decimal LONGINTERESTRATE       = 0.05m;
        const decimal SHORTPAY               = 450.00m;
        const decimal LONGPAY                = 200.00m;

        //class variable
        decimal AMOUNT = 0.00m;
        

        public frmBankLoan()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtAmount.Text = "";
            txtName.Text = "";
            rbLongTerm.Checked = false;
            rbShortTerm.Checked = false;
            lblName2.Text = "";
            lblTermAmount.Text = "";
            lblAfterPayment.Text = "";
            lblAfterInterest.Text = "";
            txtName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitForm();
        }

        private void ExitForm()
        {
            DialogResult dialog = MessageBox.Show(
        "Do You Really Want To Exit The Program?",
        "EXIT NOW?",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void ShowErrorMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }

        private void btnCreateLoan_Click(object sender, EventArgs e)
        {
            bool success;

            bool keepGoing = ValidaterbChosen();

            if (keepGoing)
            {
                keepGoing = ValidateCommonFields();
            }
            else
            {
                return;
            }

            if (keepGoing && rbShortTerm.Checked)
            {
                SetUpShortTerm();
            }
            else if (keepGoing && rbLongTerm.Checked)
            {
                SetUpLongTerm();
            }
            else return;
        }



        private bool ValidateCommonFields()
        {
            bool success = true;
            string errorMessage = "";

            errorMessage += Validator.IsPresent(txtName.Text, "Name");
            errorMessage += Validator.IsPresent(txtAmount.Text, "Amount");

            if (errorMessage != "")
            {
                success = false;
                ShowErrorMessage(errorMessage, "ERROR(s) IN INPUT");
            }
            return success;
        }

        private bool ValidaterbChosen()
        {
            bool retVal = true;

            if(!rbLongTerm.Checked && !rbShortTerm.Checked)
            {
                ShowErrorMessage("You Must Chose A Loan Type", "NO LOAN TYPE CHOSEN");

                retVal = false;
            }
            return retVal;
        }

        private void SetUpShortTerm()
        {
            bool success;

            lblTermAmount.Text = "Short-Term loan of: $" + txtAmount.Text ;
            lblName2.Text = txtName.Text;

            success = ValidateAmount();

            if (success)
            {
                CreateShortTerm();
            }

        }

        private void SetUpLongTerm()
        {
            lblTermAmount.Text = "Long-Term loan of: $" + txtAmount.Text;
            lblName2.Text = txtName.Text;
            
        }

        private bool ValidateAmount()
        {
            bool success = true;
            string errorMessage = "";

            errorMessage += Validator.IsDecimal(txtAmount.Text, "Amount");
            errorMessage += Validator.IsWithinRange(txtAmount.Text, "Amount", 
                                                    MINLOAN, MAXLOAN);

            if (errorMessage != "")
            {
                success = false;
                ShowErrorMessage(errorMessage, "ERROR(s) IN INPUT");
            }
            return success;
        }

        private void CreateShortTerm()
        {
            decimal AMOUNT = Convert.ToDecimal(txtAmount.Text.Trim());
        }

        private void btnMakePayment_Click(object sender, EventArgs e)
        {
          

            if ( rbShortTerm.Checked)
            {
                 CalculateShortTerm();
                
            }
            else if (rbLongTerm.Checked)
            {
                CalculateLongTerm();
            }

        }

        private void CalculateShortTerm()
        {
            MakePayment();
            
            ApplyInterest();
        }

        private void ApplyInterest()
        {
            decimal results = 0.00m;
            decimal result = 0.00m;


           
            result = decimal.Parse(txtAmount.Text) - SHORTPAY;
            results = (result * SHORTINTERESTRATE) + result;

            lblAfterInterest.Text = $"After interest your loan is: ${results:n2}";
        }

        private void MakePayment()
        {
           
            decimal result = 0.00m;
            

            result = decimal.Parse(txtAmount.Text) - SHORTPAY;

            

            lblAfterPayment.Text = $"After the last payment your loan is: ${result:n2}";

            

            
        }

        private void CalculateLongTerm()
        {
            Makepayment();
            Applyinterest();

        }

        private void Makepayment()
        {
            decimal result = 0.00m;


            result = decimal.Parse(txtAmount.Text) - LONGPAY;
            



            lblAfterPayment.Text = $"After the last payment your loan is: ${result:n2}";
        }

        private void Applyinterest()
        {
            decimal results = 0.00m;
            decimal result = 0.00m;

            

            result = decimal.Parse(txtAmount.Text) - LONGPAY;
            results = (result * LONGINTERESTRATE) + result;

            

            lblAfterInterest.Text = $"After interest your loan is: ${results:n2}";
        }
    }
}
