namespace SemesterProjectStoreSales
{
    partial class LoginForm
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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.loginFailLabel = new System.Windows.Forms.Label();
            this.storeTitleLabel = new System.Windows.Forms.Label();
            this.storeDescLabel = new System.Windows.Forms.Label();
            this.loginInstrLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(239, 217);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(73, 16);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username:";
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Location = new System.Drawing.Point(335, 211);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(100, 22);
            this.usernameTextbox.TabIndex = 1;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(239, 260);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(70, 16);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password:";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(281, 303);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(92, 50);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(335, 254);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(100, 22);
            this.passwordTextbox.TabIndex = 4;
            // 
            // loginFailLabel
            // 
            this.loginFailLabel.AutoSize = true;
            this.loginFailLabel.Location = new System.Drawing.Point(191, 365);
            this.loginFailLabel.Name = "loginFailLabel";
            this.loginFailLabel.Size = new System.Drawing.Size(0, 16);
            this.loginFailLabel.TabIndex = 5;
            // 
            // storeTitleLabel
            // 
            this.storeTitleLabel.AutoSize = true;
            this.storeTitleLabel.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeTitleLabel.Location = new System.Drawing.Point(235, 52);
            this.storeTitleLabel.Name = "storeTitleLabel";
            this.storeTitleLabel.Size = new System.Drawing.Size(180, 37);
            this.storeTitleLabel.TabIndex = 6;
            this.storeTitleLabel.Text = "Store Supplier";
            // 
            // storeDescLabel
            // 
            this.storeDescLabel.AutoSize = true;
            this.storeDescLabel.Font = new System.Drawing.Font("Microsoft Uighur", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeDescLabel.Location = new System.Drawing.Point(218, 89);
            this.storeDescLabel.Name = "storeDescLabel";
            this.storeDescLabel.Size = new System.Drawing.Size(226, 30);
            this.storeDescLabel.TabIndex = 7;
            this.storeDescLabel.Text = "your everyday supplies in one place";
            // 
            // loginInstrLabel
            // 
            this.loginInstrLabel.AutoSize = true;
            this.loginInstrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginInstrLabel.Location = new System.Drawing.Point(191, 166);
            this.loginInstrLabel.Name = "loginInstrLabel";
            this.loginInstrLabel.Size = new System.Drawing.Size(282, 15);
            this.loginInstrLabel.TabIndex = 8;
            this.loginInstrLabel.Text = "Please login below to access your account:";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 450);
            this.Controls.Add(this.loginInstrLabel);
            this.Controls.Add(this.storeDescLabel);
            this.Controls.Add(this.storeTitleLabel);
            this.Controls.Add(this.loginFailLabel);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameTextbox);
            this.Controls.Add(this.usernameLabel);
            this.Name = "LoginForm";
            this.Text = "Login Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Label loginFailLabel;
        private System.Windows.Forms.Label storeTitleLabel;
        private System.Windows.Forms.Label storeDescLabel;
        private System.Windows.Forms.Label loginInstrLabel;
    }
}

