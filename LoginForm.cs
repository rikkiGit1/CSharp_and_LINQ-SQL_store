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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextbox.Text;
            string password = passwordTextbox.Text;

            using(var db = new DataClasses1DataContext())
            {
                var user = db.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
                
                if(user != null)
                {
                    MainForm mainForm = new MainForm(user);
                    this.Hide();
                    mainForm.Show();
                }
                else
                {
                    loginFailLabel.Text = "Invalid username or password. Please try again.";
                }
            }
        }
    }
}
