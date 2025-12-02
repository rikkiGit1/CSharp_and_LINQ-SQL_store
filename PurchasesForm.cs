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
    public partial class PurchasesForm : Form
    {
        private User currUser;
        public PurchasesForm(User user)
        {
            InitializeComponent();
            currUser = user;
            LoadAllPurchases();
        }

        private void LoadAllPurchases()
        {
            using (var db = new DataClasses1DataContext())
            {
                var purchases = db.Purchases
                    .Where(p => p.UserId == currUser.Id)
                    .Select(p => new
                    {
                        Item = p.Item.Name,
                        p.Quantity,
                        TotalPrice = p.Quantity * p.Item.Price,
                        p.PurchaseDate
                    });

                setUpGrid();

                //I kept the foreach loop in each method to preserve deferred execution
                //and avoid calling .ToList() to pass it to a shared method
                foreach (var p in purchases)
                {
                    purchasesGrid.Rows.Add(p.Item, p.Quantity, p.TotalPrice, p.PurchaseDate);
                }
            }
        }

        private void viewAllPurchButton_Click(object sender, EventArgs e)
        {
            LoadAllPurchases();
        }

        private void filterByDateButton_Click(object sender, EventArgs e)
        {
            DateTime startDate = fromDatePicker.Value.Date;
            DateTime endDate = untilDatePicker.Value.Date.AddDays(1); //to include full end day

            using (var db = new DataClasses1DataContext())
            {
                var purchases = db.Purchases
                    .Where(p => p.UserId == currUser.Id && p.PurchaseDate >= startDate && p.PurchaseDate < endDate)
                    .Select(p => new
                    {
                        Item = p.Item.Name,
                        p.Quantity,
                        TotalPrice = p.Item.Price * p.Quantity,
                        p.PurchaseDate
                    });

                if (!purchases.Any())
                {
                    MessageBox.Show("No results for this filter.");
                    return;
                }

                setUpGrid();

                foreach (var p in purchases)
                {
                    purchasesGrid.Rows.Add(p.Item, p.Quantity, p.TotalPrice, p.PurchaseDate);
                }
            }
        }

        private void filterByPriceButton_Click(object sender, EventArgs e)
        {
            string minText = minTextbox.Text;
            string maxText = maxTextbox.Text;

            if(string.IsNullOrEmpty(minText) || string.IsNullOrEmpty(maxText))
            {
                MessageBox.Show("Please fill in both minimum and maximum price fields.");
                return;
            }

            if (!decimal.TryParse(minText, out decimal min) ||
               !decimal.TryParse(maxText, out decimal max))
            {
                MessageBox.Show("Invalid input. Please enter a numeric value.");
                return;
            }

            using (var db = new DataClasses1DataContext())
            {
                var purchases = db.Purchases
                    .Where(p => p.UserId == currUser.Id
                    && (p.Quantity * p.Item.Price) >= min && (p.Quantity * p.Item.Price) <= max)
                    .Select(p => new
                    {
                        Item = p.Item.Name,
                        p.Quantity,
                        TotalPrice = p.Item.Price * p.Quantity,
                        p.PurchaseDate
                    });

                if (!purchases.Any())
                {
                    MessageBox.Show("No results for this filter.");
                    return;
                }

                setUpGrid();

                foreach (var p in purchases)
                {
                    purchasesGrid.Rows.Add(p.Item, p.Quantity, p.TotalPrice, p.PurchaseDate);
                }
            }
        }

        private void setUpGrid()
        {
            purchasesGrid.Columns.Clear();
            purchasesGrid.Rows.Clear();
            purchasesGrid.Columns.Add("Item", "Item");
            purchasesGrid.Columns.Add("Quantity", "Quantity");
            purchasesGrid.Columns.Add("TotalPrice", "Total Price");
            purchasesGrid.Columns.Add("PurchaseDate", "Purchase Date");
        }
    }
}
