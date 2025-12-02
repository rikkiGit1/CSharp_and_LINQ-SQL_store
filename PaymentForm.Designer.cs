namespace SemesterProjectStoreSales
{
    partial class PaymentForm
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
            this.currBalanceLabel = new System.Windows.Forms.Label();
            this.storeLogoLabel = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.payAmountLabel = new System.Windows.Forms.Label();
            this.amountTextbox = new System.Windows.Forms.TextBox();
            this.submitPaymentButton = new System.Windows.Forms.Button();
            this.PaymentFormTitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // currBalanceLabel
            // 
            this.currBalanceLabel.AutoSize = true;
            this.currBalanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currBalanceLabel.Location = new System.Drawing.Point(197, 116);
            this.currBalanceLabel.Name = "currBalanceLabel";
            this.currBalanceLabel.Size = new System.Drawing.Size(0, 18);
            this.currBalanceLabel.TabIndex = 0;
            // 
            // storeLogoLabel
            // 
            this.storeLogoLabel.AutoSize = true;
            this.storeLogoLabel.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeLogoLabel.Location = new System.Drawing.Point(13, 13);
            this.storeLogoLabel.Name = "storeLogoLabel";
            this.storeLogoLabel.Size = new System.Drawing.Size(123, 24);
            this.storeLogoLabel.TabIndex = 1;
            this.storeLogoLabel.Text = "Store Supplier";
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.Location = new System.Drawing.Point(197, 167);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(248, 18);
            this.messageLabel.TabIndex = 2;
            this.messageLabel.Text = "*You may pay any amount you wish*";
            // 
            // payAmountLabel
            // 
            this.payAmountLabel.AutoSize = true;
            this.payAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payAmountLabel.Location = new System.Drawing.Point(196, 209);
            this.payAmountLabel.Name = "payAmountLabel";
            this.payAmountLabel.Size = new System.Drawing.Size(144, 20);
            this.payAmountLabel.TabIndex = 3;
            this.payAmountLabel.Text = "Enter your amount:";
            // 
            // amountTextbox
            // 
            this.amountTextbox.Location = new System.Drawing.Point(348, 207);
            this.amountTextbox.Name = "amountTextbox";
            this.amountTextbox.Size = new System.Drawing.Size(97, 22);
            this.amountTextbox.TabIndex = 4;
            // 
            // submitPaymentButton
            // 
            this.submitPaymentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitPaymentButton.Location = new System.Drawing.Point(242, 259);
            this.submitPaymentButton.Name = "submitPaymentButton";
            this.submitPaymentButton.Size = new System.Drawing.Size(159, 61);
            this.submitPaymentButton.TabIndex = 5;
            this.submitPaymentButton.Text = "Submit Payment";
            this.submitPaymentButton.UseVisualStyleBackColor = true;
            this.submitPaymentButton.Click += new System.EventHandler(this.submitPaymentButton_Click);
            // 
            // PaymentFormTitleLabel
            // 
            this.PaymentFormTitleLabel.AutoSize = true;
            this.PaymentFormTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentFormTitleLabel.Location = new System.Drawing.Point(207, 70);
            this.PaymentFormTitleLabel.Name = "PaymentFormTitleLabel";
            this.PaymentFormTitleLabel.Size = new System.Drawing.Size(219, 29);
            this.PaymentFormTitleLabel.TabIndex = 6;
            this.PaymentFormTitleLabel.Text = "PAYMENT FORM";
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 383);
            this.Controls.Add(this.PaymentFormTitleLabel);
            this.Controls.Add(this.submitPaymentButton);
            this.Controls.Add(this.amountTextbox);
            this.Controls.Add(this.payAmountLabel);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.storeLogoLabel);
            this.Controls.Add(this.currBalanceLabel);
            this.Name = "PaymentForm";
            this.Text = "Payment Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currBalanceLabel;
        private System.Windows.Forms.Label storeLogoLabel;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Label payAmountLabel;
        private System.Windows.Forms.TextBox amountTextbox;
        private System.Windows.Forms.Button submitPaymentButton;
        private System.Windows.Forms.Label PaymentFormTitleLabel;
    }
}