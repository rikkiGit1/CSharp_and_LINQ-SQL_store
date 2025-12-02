using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Rikki Weinberger - T00498676
namespace SemesterProjectStoreSales
{
    public partial class MainForm : Form
    {
        private User currUser;
        public MainForm(User user)
        {
            InitializeComponent();
            currUser = user;

            welcomeLabel.Text = $"Welcome, {currUser.Username}!";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            using (var db = new DataClasses1DataContext())
            {
                var items = db.Items
                    .Select(i => new
                    {
                        i.Name,
                        i.Description,
                        i.Price
                    });

                itemsGrid.DataSource = items;
            }
        }

        private void purchaseItemButton_Click(object sender, EventArgs e)
        {
            if (itemsGrid.CurrentRow == null)
            {
                purchaseStatusLabel.Text = "Please select an item to purchase.";
            }

            else
            {
                var selectedItem = itemsGrid.CurrentRow.Cells["Name"].Value.ToString();

                using (var db = new DataClasses1DataContext())
                {
                    var item = db.Items.FirstOrDefault(i => i.Name == selectedItem);
                    var quantity = quantityNumUpDn.Value;
                    decimal total = item.Price * quantity;

                    var user = db.Users.FirstOrDefault(u => u.Id == currUser.Id);

                    if (user.Balance + total > 100)
                    {
                        purchaseStatusLabel.Text = "Unable to make purchase, your balance will exceed the $100 maximum.";
                        purchaseStatusLabel.ForeColor = Color.Red;
                    }
                    else
                    {
                        var purchase = new Purchase()
                        {
                            UserId = user.Id,
                            ItemId = item.Id,
                            Quantity = (int)quantity,
                            PurchaseDate = DateTime.Now
                        };

                        db.Purchases.InsertOnSubmit(purchase);
                        user.Balance += total;
                        db.SubmitChanges();

                        purchaseStatusLabel.Text = $"Purchased {quantity}X {item.Name} for {total:C}";
                        purchaseStatusLabel.ForeColor = Color.Green;
                    }
                }
            }
        }

        private void viewBalanceButton_Click(object sender, EventArgs e)
        {
            using (var db = new DataClasses1DataContext())
            {
                var user = db.Users.FirstOrDefault(u => u.Id == currUser.Id);

                if (user != null)
                {
                    MessageBox.Show($"Your current balance is: {user.Balance:C}");
                }
            }
        }

        private void makePaymentButton_Click(object sender, EventArgs e)
        {
            PaymentForm paymentForm = new PaymentForm(currUser);
            paymentForm.Show();
        }

        private void viewPastPurButton_Click(object sender, EventArgs e)
        {
            PurchasesForm purchasesForm = new PurchasesForm(currUser);
            purchasesForm.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            var logout = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo);
            if (logout == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
        }
    }
}
