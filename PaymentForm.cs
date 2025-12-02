using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
//Rikki Weinberger - T00498676
namespace SemesterProjectStoreSales
{
    public partial class PaymentForm : Form
    {
        private User currUser;
        public PaymentForm(User user)
        {
            InitializeComponent();

            using(var db = new DataClasses1DataContext())
            {
                currUser = db.Users.FirstOrDefault(u => u.Id == user.Id);
                currBalanceLabel.Text = $"Your current balance {currUser.Balance:C}";
            }
        }

        private void submitPaymentButton_Click(object sender, EventArgs e)
        {
            string amt = amountTextbox.Text;

            if (string.IsNullOrEmpty(amt))
            {
                MessageBox.Show("Please enter in a payment value.");
                return;
            }

            if (!decimal.TryParse(amt, out decimal paymentAmt))
            {
                MessageBox.Show("Invalid input. Please enter a numeric value.");
                return;
            }

            using (var db = new DataClasses1DataContext())
            {
                var user = db.Users.FirstOrDefault(u => u.Id == currUser.Id);
                user.Balance -= paymentAmt;
                db.SubmitChanges();

                MessageBox.Show($"You successfully paid {paymentAmt:C}.\nYour new balance is: {user.Balance:C}");
                this.Close();
            }
        }
    }
}
