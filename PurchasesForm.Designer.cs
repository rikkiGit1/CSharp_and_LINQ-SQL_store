namespace SemesterProjectStoreSales
{
    partial class PurchasesForm
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
            this.storeLogoLabel = new System.Windows.Forms.Label();
            this.purchasesTitleLabel = new System.Windows.Forms.Label();
            this.purchasesGrid = new System.Windows.Forms.DataGridView();
            this.viewAllPurchButton = new System.Windows.Forms.Button();
            this.filterDateInstrLabel = new System.Windows.Forms.Label();
            this.fromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.untilDatePicker = new System.Windows.Forms.DateTimePicker();
            this.fromLabel = new System.Windows.Forms.Label();
            this.untilLabel = new System.Windows.Forms.Label();
            this.filterByDateButton = new System.Windows.Forms.Button();
            this.filterPriceInstrLabel = new System.Windows.Forms.Label();
            this.minTextbox = new System.Windows.Forms.TextBox();
            this.maxTextbox = new System.Windows.Forms.TextBox();
            this.filterByPriceButton = new System.Windows.Forms.Button();
            this.minLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // storeLogoLabel
            // 
            this.storeLogoLabel.AutoSize = true;
            this.storeLogoLabel.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeLogoLabel.Location = new System.Drawing.Point(13, 13);
            this.storeLogoLabel.Name = "storeLogoLabel";
            this.storeLogoLabel.Size = new System.Drawing.Size(123, 24);
            this.storeLogoLabel.TabIndex = 0;
            this.storeLogoLabel.Text = "Store Supplier";
            // 
            // purchasesTitleLabel
            // 
            this.purchasesTitleLabel.AutoSize = true;
            this.purchasesTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchasesTitleLabel.Location = new System.Drawing.Point(241, 43);
            this.purchasesTitleLabel.Name = "purchasesTitleLabel";
            this.purchasesTitleLabel.Size = new System.Drawing.Size(255, 29);
            this.purchasesTitleLabel.TabIndex = 1;
            this.purchasesTitleLabel.Text = "Your Past Purchases";
            // 
            // purchasesGrid
            // 
            this.purchasesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchasesGrid.Location = new System.Drawing.Point(350, 97);
            this.purchasesGrid.Name = "purchasesGrid";
            this.purchasesGrid.RowHeadersWidth = 51;
            this.purchasesGrid.RowTemplate.Height = 24;
            this.purchasesGrid.Size = new System.Drawing.Size(415, 326);
            this.purchasesGrid.TabIndex = 2;
            // 
            // viewAllPurchButton
            // 
            this.viewAllPurchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAllPurchButton.Location = new System.Drawing.Point(42, 86);
            this.viewAllPurchButton.Name = "viewAllPurchButton";
            this.viewAllPurchButton.Size = new System.Drawing.Size(252, 44);
            this.viewAllPurchButton.TabIndex = 3;
            this.viewAllPurchButton.Text = "View All Purchases";
            this.viewAllPurchButton.UseVisualStyleBackColor = true;
            this.viewAllPurchButton.Click += new System.EventHandler(this.viewAllPurchButton_Click);
            // 
            // filterDateInstrLabel
            // 
            this.filterDateInstrLabel.AutoSize = true;
            this.filterDateInstrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterDateInstrLabel.Location = new System.Drawing.Point(62, 160);
            this.filterDateInstrLabel.Name = "filterDateInstrLabel";
            this.filterDateInstrLabel.Size = new System.Drawing.Size(208, 17);
            this.filterDateInstrLabel.TabIndex = 5;
            this.filterDateInstrLabel.Text = "Filter Purchases by Date Below:";
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.Location = new System.Drawing.Point(65, 189);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.Size = new System.Drawing.Size(252, 22);
            this.fromDatePicker.TabIndex = 6;
            // 
            // untilDatePicker
            // 
            this.untilDatePicker.Location = new System.Drawing.Point(65, 217);
            this.untilDatePicker.Name = "untilDatePicker";
            this.untilDatePicker.Size = new System.Drawing.Size(252, 22);
            this.untilDatePicker.TabIndex = 7;
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(23, 194);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(41, 16);
            this.fromLabel.TabIndex = 8;
            this.fromLabel.Text = "From:";
            // 
            // untilLabel
            // 
            this.untilLabel.AutoSize = true;
            this.untilLabel.Location = new System.Drawing.Point(23, 222);
            this.untilLabel.Name = "untilLabel";
            this.untilLabel.Size = new System.Drawing.Size(36, 16);
            this.untilLabel.TabIndex = 10;
            this.untilLabel.Text = "Until:";
            // 
            // filterByDateButton
            // 
            this.filterByDateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterByDateButton.Location = new System.Drawing.Point(42, 254);
            this.filterByDateButton.Name = "filterByDateButton";
            this.filterByDateButton.Size = new System.Drawing.Size(252, 31);
            this.filterByDateButton.TabIndex = 11;
            this.filterByDateButton.Text = "Filter Purchases By Date";
            this.filterByDateButton.UseVisualStyleBackColor = true;
            this.filterByDateButton.Click += new System.EventHandler(this.filterByDateButton_Click);
            // 
            // filterPriceInstrLabel
            // 
            this.filterPriceInstrLabel.AutoSize = true;
            this.filterPriceInstrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterPriceInstrLabel.Location = new System.Drawing.Point(62, 324);
            this.filterPriceInstrLabel.Name = "filterPriceInstrLabel";
            this.filterPriceInstrLabel.Size = new System.Drawing.Size(210, 17);
            this.filterPriceInstrLabel.TabIndex = 12;
            this.filterPriceInstrLabel.Text = "Filter Purchases by Price Below:";
            // 
            // minTextbox
            // 
            this.minTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minTextbox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.minTextbox.Location = new System.Drawing.Point(93, 352);
            this.minTextbox.Name = "minTextbox";
            this.minTextbox.Size = new System.Drawing.Size(65, 22);
            this.minTextbox.TabIndex = 13;
            this.minTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maxTextbox
            // 
            this.maxTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxTextbox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.maxTextbox.Location = new System.Drawing.Point(207, 352);
            this.maxTextbox.Name = "maxTextbox";
            this.maxTextbox.Size = new System.Drawing.Size(65, 22);
            this.maxTextbox.TabIndex = 13;
            this.maxTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // filterByPriceButton
            // 
            this.filterByPriceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterByPriceButton.Location = new System.Drawing.Point(42, 392);
            this.filterByPriceButton.Name = "filterByPriceButton";
            this.filterByPriceButton.Size = new System.Drawing.Size(252, 31);
            this.filterByPriceButton.TabIndex = 15;
            this.filterByPriceButton.Text = "Filter Purchases By Price";
            this.filterByPriceButton.UseVisualStyleBackColor = true;
            this.filterByPriceButton.Click += new System.EventHandler(this.filterByPriceButton_Click);
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(56, 355);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(31, 16);
            this.minLabel.TabIndex = 16;
            this.minLabel.Text = "Min:";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(166, 355);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(35, 16);
            this.maxLabel.TabIndex = 17;
            this.maxLabel.Text = "Max:";
            // 
            // PurchasesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.filterByPriceButton);
            this.Controls.Add(this.maxTextbox);
            this.Controls.Add(this.minTextbox);
            this.Controls.Add(this.filterPriceInstrLabel);
            this.Controls.Add(this.filterByDateButton);
            this.Controls.Add(this.untilLabel);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.untilDatePicker);
            this.Controls.Add(this.fromDatePicker);
            this.Controls.Add(this.filterDateInstrLabel);
            this.Controls.Add(this.viewAllPurchButton);
            this.Controls.Add(this.purchasesGrid);
            this.Controls.Add(this.purchasesTitleLabel);
            this.Controls.Add(this.storeLogoLabel);
            this.Name = "PurchasesForm";
            this.Text = "Purchases Form";
            ((System.ComponentModel.ISupportInitialize)(this.purchasesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label storeLogoLabel;
        private System.Windows.Forms.Label purchasesTitleLabel;
        private System.Windows.Forms.DataGridView purchasesGrid;
        private System.Windows.Forms.Button viewAllPurchButton;
        private System.Windows.Forms.Label filterDateInstrLabel;
        private System.Windows.Forms.DateTimePicker fromDatePicker;
        private System.Windows.Forms.DateTimePicker untilDatePicker;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label untilLabel;
        private System.Windows.Forms.Button filterByDateButton;
        private System.Windows.Forms.Label filterPriceInstrLabel;
        private System.Windows.Forms.TextBox minTextbox;
        private System.Windows.Forms.TextBox maxTextbox;
        private System.Windows.Forms.Button filterByPriceButton;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label maxLabel;
    }
}