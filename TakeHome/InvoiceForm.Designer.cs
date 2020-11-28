namespace TakeHome
{
    partial class InvoiceForm
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
            System.Windows.Forms.Label invoiceNumberLabel;
            System.Windows.Forms.Label invoiceDescriptionLabel;
            System.Windows.Forms.Label invoiceAmountLabel;
            System.Windows.Forms.Label invoiceDateLabel;
            System.Windows.Forms.Label deliveryDateLabel;
            System.Windows.Forms.Label settleDateLabel;
            System.Windows.Forms.Label invoiceVatLabel;
            System.Windows.Forms.Label currencyLabel;
            System.Windows.Forms.Label exchangeRateLabel;
            System.Windows.Forms.Label clientLabel;
            System.Windows.Forms.Label orderNumberLabel;
            System.Windows.Forms.Label salesAgentLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.invoiceNumberLabel1 = new System.Windows.Forms.Label();
            this.invoiceDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.invoiceAmountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.invoiceDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.deliveryDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.settleDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.invoiceVatComboBox = new System.Windows.Forms.ComboBox();
            this.currencyComboBox = new System.Windows.Forms.ComboBox();
            this.exchangeRateComboBox = new System.Windows.Forms.ComboBox();
            this.clientComboBox = new System.Windows.Forms.ComboBox();
            this.orderNumberTextBox = new System.Windows.Forms.TextBox();
            this.salesAgentTextBox = new System.Windows.Forms.TextBox();
            invoiceNumberLabel = new System.Windows.Forms.Label();
            invoiceDescriptionLabel = new System.Windows.Forms.Label();
            invoiceAmountLabel = new System.Windows.Forms.Label();
            invoiceDateLabel = new System.Windows.Forms.Label();
            deliveryDateLabel = new System.Windows.Forms.Label();
            settleDateLabel = new System.Windows.Forms.Label();
            invoiceVatLabel = new System.Windows.Forms.Label();
            currencyLabel = new System.Windows.Forms.Label();
            exchangeRateLabel = new System.Windows.Forms.Label();
            clientLabel = new System.Windows.Forms.Label();
            orderNumberLabel = new System.Windows.Forms.Label();
            salesAgentLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceAmountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // invoiceNumberLabel
            // 
            invoiceNumberLabel.AutoSize = true;
            invoiceNumberLabel.Location = new System.Drawing.Point(18, 18);
            invoiceNumberLabel.Name = "invoiceNumberLabel";
            invoiceNumberLabel.Size = new System.Drawing.Size(110, 17);
            invoiceNumberLabel.TabIndex = 25;
            invoiceNumberLabel.Text = "Invoice Number:";
            // 
            // invoiceDescriptionLabel
            // 
            invoiceDescriptionLabel.AutoSize = true;
            invoiceDescriptionLabel.Location = new System.Drawing.Point(18, 47);
            invoiceDescriptionLabel.Name = "invoiceDescriptionLabel";
            invoiceDescriptionLabel.Size = new System.Drawing.Size(131, 17);
            invoiceDescriptionLabel.TabIndex = 27;
            invoiceDescriptionLabel.Text = "Invoice Description:";
            // 
            // invoiceAmountLabel
            // 
            invoiceAmountLabel.AutoSize = true;
            invoiceAmountLabel.Location = new System.Drawing.Point(21, 110);
            invoiceAmountLabel.Name = "invoiceAmountLabel";
            invoiceAmountLabel.Size = new System.Drawing.Size(108, 17);
            invoiceAmountLabel.TabIndex = 29;
            invoiceAmountLabel.Text = "Invoice Amount:";
            // 
            // invoiceDateLabel
            // 
            invoiceDateLabel.AutoSize = true;
            invoiceDateLabel.Location = new System.Drawing.Point(21, 142);
            invoiceDateLabel.Name = "invoiceDateLabel";
            invoiceDateLabel.Size = new System.Drawing.Size(90, 17);
            invoiceDateLabel.TabIndex = 31;
            invoiceDateLabel.Text = "Invoice Date:";
            // 
            // deliveryDateLabel
            // 
            deliveryDateLabel.AutoSize = true;
            deliveryDateLabel.Location = new System.Drawing.Point(21, 170);
            deliveryDateLabel.Name = "deliveryDateLabel";
            deliveryDateLabel.Size = new System.Drawing.Size(97, 17);
            deliveryDateLabel.TabIndex = 33;
            deliveryDateLabel.Text = "Delivery Date:";
            // 
            // settleDateLabel
            // 
            settleDateLabel.AutoSize = true;
            settleDateLabel.Location = new System.Drawing.Point(21, 198);
            settleDateLabel.Name = "settleDateLabel";
            settleDateLabel.Size = new System.Drawing.Size(82, 17);
            settleDateLabel.TabIndex = 35;
            settleDateLabel.Text = "Settle Date:";
            // 
            // invoiceVatLabel
            // 
            invoiceVatLabel.AutoSize = true;
            invoiceVatLabel.Location = new System.Drawing.Point(21, 225);
            invoiceVatLabel.Name = "invoiceVatLabel";
            invoiceVatLabel.Size = new System.Drawing.Size(81, 17);
            invoiceVatLabel.TabIndex = 37;
            invoiceVatLabel.Text = "Invoice Vat:";
            // 
            // currencyLabel
            // 
            currencyLabel.AutoSize = true;
            currencyLabel.Location = new System.Drawing.Point(21, 256);
            currencyLabel.Name = "currencyLabel";
            currencyLabel.Size = new System.Drawing.Size(69, 17);
            currencyLabel.TabIndex = 39;
            currencyLabel.Text = "Currency:";
            // 
            // exchangeRateLabel
            // 
            exchangeRateLabel.AutoSize = true;
            exchangeRateLabel.Location = new System.Drawing.Point(21, 287);
            exchangeRateLabel.Name = "exchangeRateLabel";
            exchangeRateLabel.Size = new System.Drawing.Size(108, 17);
            exchangeRateLabel.TabIndex = 41;
            exchangeRateLabel.Text = "Exchange Rate:";
            // 
            // clientLabel
            // 
            clientLabel.AutoSize = true;
            clientLabel.Location = new System.Drawing.Point(21, 318);
            clientLabel.Name = "clientLabel";
            clientLabel.Size = new System.Drawing.Size(47, 17);
            clientLabel.TabIndex = 43;
            clientLabel.Text = "Client:";
            // 
            // orderNumberLabel
            // 
            orderNumberLabel.AutoSize = true;
            orderNumberLabel.Location = new System.Drawing.Point(21, 349);
            orderNumberLabel.Name = "orderNumberLabel";
            orderNumberLabel.Size = new System.Drawing.Size(103, 17);
            orderNumberLabel.TabIndex = 45;
            orderNumberLabel.Text = "Order Number:";
            // 
            // salesAgentLabel
            // 
            salesAgentLabel.AutoSize = true;
            salesAgentLabel.Location = new System.Drawing.Point(21, 377);
            salesAgentLabel.Name = "salesAgentLabel";
            salesAgentLabel.Size = new System.Drawing.Size(88, 17);
            salesAgentLabel.TabIndex = 47;
            salesAgentLabel.Text = "Sales Agent:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ButtonSave);
            this.groupBox1.Controls.Add(invoiceNumberLabel);
            this.groupBox1.Controls.Add(this.invoiceNumberLabel1);
            this.groupBox1.Controls.Add(invoiceDescriptionLabel);
            this.groupBox1.Controls.Add(this.invoiceDescriptionTextBox);
            this.groupBox1.Controls.Add(invoiceAmountLabel);
            this.groupBox1.Controls.Add(this.invoiceAmountNumericUpDown);
            this.groupBox1.Controls.Add(invoiceDateLabel);
            this.groupBox1.Controls.Add(this.invoiceDateDateTimePicker);
            this.groupBox1.Controls.Add(deliveryDateLabel);
            this.groupBox1.Controls.Add(this.deliveryDateDateTimePicker);
            this.groupBox1.Controls.Add(settleDateLabel);
            this.groupBox1.Controls.Add(this.settleDateDateTimePicker);
            this.groupBox1.Controls.Add(invoiceVatLabel);
            this.groupBox1.Controls.Add(this.invoiceVatComboBox);
            this.groupBox1.Controls.Add(currencyLabel);
            this.groupBox1.Controls.Add(this.currencyComboBox);
            this.groupBox1.Controls.Add(exchangeRateLabel);
            this.groupBox1.Controls.Add(this.exchangeRateComboBox);
            this.groupBox1.Controls.Add(clientLabel);
            this.groupBox1.Controls.Add(this.clientComboBox);
            this.groupBox1.Controls.Add(orderNumberLabel);
            this.groupBox1.Controls.Add(this.orderNumberTextBox);
            this.groupBox1.Controls.Add(salesAgentLabel);
            this.groupBox1.Controls.Add(this.salesAgentTextBox);
            this.groupBox1.Location = new System.Drawing.Point(7, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 437);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(258, 402);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(100, 34);
            this.ButtonSave.TabIndex = 49;
            this.ButtonSave.Text = "Save Invoice";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // invoiceNumberLabel1
            // 
            this.invoiceNumberLabel1.Location = new System.Drawing.Point(155, 18);
            this.invoiceNumberLabel1.Name = "invoiceNumberLabel1";
            this.invoiceNumberLabel1.Size = new System.Drawing.Size(200, 23);
            this.invoiceNumberLabel1.TabIndex = 26;
            // 
            // invoiceDescriptionTextBox
            // 
            this.invoiceDescriptionTextBox.Location = new System.Drawing.Point(155, 44);
            this.invoiceDescriptionTextBox.Multiline = true;
            this.invoiceDescriptionTextBox.Name = "invoiceDescriptionTextBox";
            this.invoiceDescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.invoiceDescriptionTextBox.Size = new System.Drawing.Size(200, 60);
            this.invoiceDescriptionTextBox.TabIndex = 28;
            // 
            // invoiceAmountNumericUpDown
            // 
            this.invoiceAmountNumericUpDown.Location = new System.Drawing.Point(158, 110);
            this.invoiceAmountNumericUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.invoiceAmountNumericUpDown.Name = "invoiceAmountNumericUpDown";
            this.invoiceAmountNumericUpDown.Size = new System.Drawing.Size(197, 22);
            this.invoiceAmountNumericUpDown.TabIndex = 30;
            this.invoiceAmountNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.invoiceAmountNumericUpDown.ThousandsSeparator = true;
            // 
            // invoiceDateDateTimePicker
            // 
            this.invoiceDateDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.invoiceDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.invoiceDateDateTimePicker.Location = new System.Drawing.Point(158, 138);
            this.invoiceDateDateTimePicker.Name = "invoiceDateDateTimePicker";
            this.invoiceDateDateTimePicker.Size = new System.Drawing.Size(129, 22);
            this.invoiceDateDateTimePicker.TabIndex = 32;
            // 
            // deliveryDateDateTimePicker
            // 
            this.deliveryDateDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.deliveryDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.deliveryDateDateTimePicker.Location = new System.Drawing.Point(158, 166);
            this.deliveryDateDateTimePicker.Name = "deliveryDateDateTimePicker";
            this.deliveryDateDateTimePicker.Size = new System.Drawing.Size(129, 22);
            this.deliveryDateDateTimePicker.TabIndex = 34;
            // 
            // settleDateDateTimePicker
            // 
            this.settleDateDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.settleDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.settleDateDateTimePicker.Location = new System.Drawing.Point(158, 194);
            this.settleDateDateTimePicker.Name = "settleDateDateTimePicker";
            this.settleDateDateTimePicker.Size = new System.Drawing.Size(129, 22);
            this.settleDateDateTimePicker.TabIndex = 36;
            // 
            // invoiceVatComboBox
            // 
            this.invoiceVatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.invoiceVatComboBox.FormattingEnabled = true;
            this.invoiceVatComboBox.Items.AddRange(new object[] {
            "2.5",
            "5.0",
            "7.5"});
            this.invoiceVatComboBox.Location = new System.Drawing.Point(158, 222);
            this.invoiceVatComboBox.Name = "invoiceVatComboBox";
            this.invoiceVatComboBox.Size = new System.Drawing.Size(200, 24);
            this.invoiceVatComboBox.TabIndex = 38;
            // 
            // currencyComboBox
            // 
            this.currencyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currencyComboBox.FormattingEnabled = true;
            this.currencyComboBox.Items.AddRange(new object[] {
            "Pound(£)",
            "USD($)",
            "Naira(#)"});
            this.currencyComboBox.Location = new System.Drawing.Point(158, 253);
            this.currencyComboBox.Name = "currencyComboBox";
            this.currencyComboBox.Size = new System.Drawing.Size(200, 24);
            this.currencyComboBox.TabIndex = 40;
            // 
            // exchangeRateComboBox
            // 
            this.exchangeRateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.exchangeRateComboBox.FormattingEnabled = true;
            this.exchangeRateComboBox.Items.AddRange(new object[] {
            "385.50",
            "401.20",
            "500.10"});
            this.exchangeRateComboBox.Location = new System.Drawing.Point(158, 284);
            this.exchangeRateComboBox.Name = "exchangeRateComboBox";
            this.exchangeRateComboBox.Size = new System.Drawing.Size(200, 24);
            this.exchangeRateComboBox.TabIndex = 42;
            // 
            // clientComboBox
            // 
            this.clientComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientComboBox.FormattingEnabled = true;
            this.clientComboBox.Items.AddRange(new object[] {
            "Michael Harts",
            "Douglas Coker",
            "Tunji Bamishigbin",
            "Wole Soyinka"});
            this.clientComboBox.Location = new System.Drawing.Point(158, 315);
            this.clientComboBox.Name = "clientComboBox";
            this.clientComboBox.Size = new System.Drawing.Size(200, 24);
            this.clientComboBox.TabIndex = 44;
            // 
            // orderNumberTextBox
            // 
            this.orderNumberTextBox.Location = new System.Drawing.Point(158, 346);
            this.orderNumberTextBox.Name = "orderNumberTextBox";
            this.orderNumberTextBox.Size = new System.Drawing.Size(200, 22);
            this.orderNumberTextBox.TabIndex = 46;
            // 
            // salesAgentTextBox
            // 
            this.salesAgentTextBox.Location = new System.Drawing.Point(158, 374);
            this.salesAgentTextBox.Name = "salesAgentTextBox";
            this.salesAgentTextBox.Size = new System.Drawing.Size(200, 22);
            this.salesAgentTextBox.TabIndex = 48;
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 456);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InvoiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Sales Invoice";
            this.Load += new System.EventHandler(this.InvoiceForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceAmountNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label invoiceNumberLabel1;
        private System.Windows.Forms.TextBox invoiceDescriptionTextBox;
        private System.Windows.Forms.NumericUpDown invoiceAmountNumericUpDown;
        private System.Windows.Forms.DateTimePicker invoiceDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker deliveryDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker settleDateDateTimePicker;
        private System.Windows.Forms.ComboBox invoiceVatComboBox;
        private System.Windows.Forms.ComboBox currencyComboBox;
        private System.Windows.Forms.ComboBox exchangeRateComboBox;
        private System.Windows.Forms.ComboBox clientComboBox;
        private System.Windows.Forms.TextBox orderNumberTextBox;
        private System.Windows.Forms.TextBox salesAgentTextBox;
        private System.Windows.Forms.Button ButtonSave;
    }
}

