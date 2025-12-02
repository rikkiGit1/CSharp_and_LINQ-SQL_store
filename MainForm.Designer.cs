namespace SemesterProjectStoreSales
{
    partial class MainForm
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.itemsGrid = new System.Windows.Forms.DataGridView();
            this.itemGridInstrLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.quantityNumUpDn = new System.Windows.Forms.NumericUpDown();
            this.purchaseItemButton = new System.Windows.Forms.Button();
            this.purchaseStatusLabel = new System.Windows.Forms.Label();
            this.storeLogoLabelSm = new System.Windows.Forms.Label();
            this.viewBalanceButton = new System.Windows.Forms.Button();
            this.makePaymentButton = new System.Windows.Forms.Button();
            this.viewPastPurButton = new System.Windows.Forms.Button();
            this.thankYouLabel = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumUpDn)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(371, 15);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(0, 18);
            this.welcomeLabel.TabIndex = 0;
            // 
            // itemsGrid
            // 
            this.itemsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsGrid.Location = new System.Drawing.Point(36, 86);
            this.itemsGrid.Name = "itemsGrid";
            this.itemsGrid.RowHeadersWidth = 51;
            this.itemsGrid.RowTemplate.Height = 24;
            this.itemsGrid.Size = new System.Drawing.Size(489, 295);
            this.itemsGrid.TabIndex = 2;
            // 
            // itemGridInstrLabel
            // 
            this.itemGridInstrLabel.AutoSize = true;
            this.itemGridInstrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemGridInstrLabel.Location = new System.Drawing.Point(150, 55);
            this.itemGridInstrLabel.Name = "itemGridInstrLabel";
            this.itemGridInstrLabel.Size = new System.Drawing.Size(230, 18);
            this.itemGridInstrLabel.TabIndex = 3;
            this.itemGridInstrLabel.Text = "Select an item below to purchase:";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.Location = new System.Drawing.Point(118, 419);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(66, 18);
            this.quantityLabel.TabIndex = 4;
            this.quantityLabel.Text = "Quantity:";
            // 
            // quantityNumUpDn
            // 
            this.quantityNumUpDn.Location = new System.Drawing.Point(190, 418);
            this.quantityNumUpDn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantityNumUpDn.Name = "quantityNumUpDn";
            this.quantityNumUpDn.Size = new System.Drawing.Size(60, 22);
            this.quantityNumUpDn.TabIndex = 5;
            this.quantityNumUpDn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // purchaseItemButton
            // 
            this.purchaseItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseItemButton.Location = new System.Drawing.Point(294, 399);
            this.purchaseItemButton.Name = "purchaseItemButton";
            this.purchaseItemButton.Size = new System.Drawing.Size(153, 59);
            this.purchaseItemButton.TabIndex = 6;
            this.purchaseItemButton.Text = "Purchase Item";
            this.purchaseItemButton.UseVisualStyleBackColor = true;
            this.purchaseItemButton.Click += new System.EventHandler(this.purchaseItemButton_Click);
            // 
            // purchaseStatusLabel
            // 
            this.purchaseStatusLabel.AutoSize = true;
            this.purchaseStatusLabel.Location = new System.Drawing.Point(150, 465);
            this.purchaseStatusLabel.Name = "purchaseStatusLabel";
            this.purchaseStatusLabel.Size = new System.Drawing.Size(0, 16);
            this.purchaseStatusLabel.TabIndex = 7;
            // 
            // storeLogoLabelSm
            // 
            this.storeLogoLabelSm.AutoSize = true;
            this.storeLogoLabelSm.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeLogoLabelSm.Location = new System.Drawing.Point(12, 9);
            this.storeLogoLabelSm.Name = "storeLogoLabelSm";
            this.storeLogoLabelSm.Size = new System.Drawing.Size(123, 24);
            this.storeLogoLabelSm.TabIndex = 8;
            this.storeLogoLabelSm.Text = "Store Supplier";
            // 
            // viewBalanceButton
            // 
            this.viewBalanceButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.viewBalanceButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.viewBalanceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBalanceButton.Location = new System.Drawing.Point(587, 112);
            this.viewBalanceButton.Name = "viewBalanceButton";
            this.viewBalanceButton.Size = new System.Drawing.Size(252, 52);
            this.viewBalanceButton.TabIndex = 9;
            this.viewBalanceButton.Text = "View Balance ";
            this.viewBalanceButton.UseVisualStyleBackColor = true;
            this.viewBalanceButton.Click += new System.EventHandler(this.viewBalanceButton_Click);
            // 
            // makePaymentButton
            // 
            this.makePaymentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makePaymentButton.Location = new System.Drawing.Point(587, 194);
            this.makePaymentButton.Name = "makePaymentButton";
            this.makePaymentButton.Size = new System.Drawing.Size(252, 52);
            this.makePaymentButton.TabIndex = 9;
            this.makePaymentButton.Text = "Make a Payment";
            this.makePaymentButton.UseVisualStyleBackColor = true;
            this.makePaymentButton.Click += new System.EventHandler(this.makePaymentButton_Click);
            // 
            // viewPastPurButton
            // 
            this.viewPastPurButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewPastPurButton.Location = new System.Drawing.Point(587, 275);
            this.viewPastPurButton.Name = "viewPastPurButton";
            this.viewPastPurButton.Size = new System.Drawing.Size(252, 52);
            this.viewPastPurButton.TabIndex = 9;
            this.viewPastPurButton.Text = "View Past Purchases";
            this.viewPastPurButton.UseVisualStyleBackColor = true;
            this.viewPastPurButton.Click += new System.EventHandler(this.viewPastPurButton_Click);
            // 
            // thankYouLabel
            // 
            this.thankYouLabel.AutoSize = true;
            this.thankYouLabel.Font = new System.Drawing.Font("Monotype Corsiva", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thankYouLabel.Location = new System.Drawing.Point(570, 399);
            this.thankYouLabel.Name = "thankYouLabel";
            this.thankYouLabel.Size = new System.Drawing.Size(281, 28);
            this.thankYouLabel.TabIndex = 10;
            this.thankYouLabel.Text = "Thank You for Choosing Us.";
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(632, 447);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(160, 34);
            this.logoutButton.TabIndex = 11;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 514);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.thankYouLabel);
            this.Controls.Add(this.viewPastPurButton);
            this.Controls.Add(this.makePaymentButton);
            this.Controls.Add(this.viewBalanceButton);
            this.Controls.Add(this.storeLogoLabelSm);
            this.Controls.Add(this.purchaseStatusLabel);
            this.Controls.Add(this.purchaseItemButton);
            this.Controls.Add(this.quantityNumUpDn);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.itemGridInstrLabel);
            this.Controls.Add(this.itemsGrid);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "MainForm";
            this.Text = "Store Supplier";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumUpDn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.DataGridView itemsGrid;
        private System.Windows.Forms.Label itemGridInstrLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.NumericUpDown quantityNumUpDn;
        private System.Windows.Forms.Button purchaseItemButton;
        private System.Windows.Forms.Label purchaseStatusLabel;
        private System.Windows.Forms.Label storeLogoLabelSm;
        private System.Windows.Forms.Button viewBalanceButton;
        private System.Windows.Forms.Button makePaymentButton;
        private System.Windows.Forms.Button viewPastPurButton;
        private System.Windows.Forms.Label thankYouLabel;
        private System.Windows.Forms.Button logoutButton;
    }
}