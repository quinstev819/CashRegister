namespace CashRegister
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nameLabel = new System.Windows.Forms.Label();
            this.iceCreamsLabel = new System.Windows.Forms.Label();
            this.toppingsLabel = new System.Windows.Forms.Label();
            this.drinksLabel = new System.Windows.Forms.Label();
            this.iceCreamsText = new System.Windows.Forms.TextBox();
            this.toppingsText = new System.Windows.Forms.TextBox();
            this.drinksText = new System.Windows.Forms.TextBox();
            this.calculateTotalsButton = new System.Windows.Forms.Button();
            this.totalsLabel = new System.Windows.Forms.Label();
            this.totalNumbersLabel = new System.Windows.Forms.Label();
            this.blackBarLabel = new System.Windows.Forms.Label();
            this.calculateChangeButton = new System.Windows.Forms.Button();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.tenderedText = new System.Windows.Forms.TextBox();
            this.changeLabel = new System.Windows.Forms.Label();
            this.totalChangeLabel = new System.Windows.Forms.Label();
            this.printReceiptButton = new System.Windows.Forms.Button();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.receiptLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.BackColor = System.Drawing.Color.Blue;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(0, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(497, 35);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Quinn\'s Ice Cream Parlour";
            // 
            // iceCreamsLabel
            // 
            this.iceCreamsLabel.AutoSize = true;
            this.iceCreamsLabel.Location = new System.Drawing.Point(30, 65);
            this.iceCreamsLabel.Name = "iceCreamsLabel";
            this.iceCreamsLabel.Size = new System.Drawing.Size(112, 13);
            this.iceCreamsLabel.TabIndex = 1;
            this.iceCreamsLabel.Text = "Number of Ice Creams";
            // 
            // toppingsLabel
            // 
            this.toppingsLabel.AutoSize = true;
            this.toppingsLabel.Location = new System.Drawing.Point(30, 94);
            this.toppingsLabel.Name = "toppingsLabel";
            this.toppingsLabel.Size = new System.Drawing.Size(103, 13);
            this.toppingsLabel.TabIndex = 2;
            this.toppingsLabel.Text = "Number of Toppings";
            // 
            // drinksLabel
            // 
            this.drinksLabel.AutoSize = true;
            this.drinksLabel.Location = new System.Drawing.Point(30, 124);
            this.drinksLabel.Name = "drinksLabel";
            this.drinksLabel.Size = new System.Drawing.Size(89, 13);
            this.drinksLabel.TabIndex = 3;
            this.drinksLabel.Text = "Number of Drinks";
            // 
            // iceCreamsText
            // 
            this.iceCreamsText.Location = new System.Drawing.Point(148, 62);
            this.iceCreamsText.Name = "iceCreamsText";
            this.iceCreamsText.Size = new System.Drawing.Size(30, 20);
            this.iceCreamsText.TabIndex = 4;
            // 
            // toppingsText
            // 
            this.toppingsText.Location = new System.Drawing.Point(148, 91);
            this.toppingsText.Name = "toppingsText";
            this.toppingsText.Size = new System.Drawing.Size(30, 20);
            this.toppingsText.TabIndex = 5;
            // 
            // drinksText
            // 
            this.drinksText.Location = new System.Drawing.Point(148, 121);
            this.drinksText.Name = "drinksText";
            this.drinksText.Size = new System.Drawing.Size(30, 20);
            this.drinksText.TabIndex = 6;
            // 
            // calculateTotalsButton
            // 
            this.calculateTotalsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calculateTotalsButton.Location = new System.Drawing.Point(33, 147);
            this.calculateTotalsButton.Name = "calculateTotalsButton";
            this.calculateTotalsButton.Size = new System.Drawing.Size(145, 23);
            this.calculateTotalsButton.TabIndex = 7;
            this.calculateTotalsButton.Text = "Calculate Totals";
            this.calculateTotalsButton.UseVisualStyleBackColor = true;
            this.calculateTotalsButton.Click += new System.EventHandler(this.calculateTotalsButton_Click);
            // 
            // totalsLabel
            // 
            this.totalsLabel.AutoSize = true;
            this.totalsLabel.Location = new System.Drawing.Point(30, 183);
            this.totalsLabel.Name = "totalsLabel";
            this.totalsLabel.Size = new System.Drawing.Size(53, 65);
            this.totalsLabel.TabIndex = 8;
            this.totalsLabel.Text = "Sub Total\r\n\r\nTax\r\n\r\nTotal";
            // 
            // totalNumbersLabel
            // 
            this.totalNumbersLabel.Location = new System.Drawing.Point(89, 183);
            this.totalNumbersLabel.Name = "totalNumbersLabel";
            this.totalNumbersLabel.Size = new System.Drawing.Size(89, 65);
            this.totalNumbersLabel.TabIndex = 9;
            this.totalNumbersLabel.Text = "-\r\n\r\n-\r\n\r\n-";
            this.totalNumbersLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // blackBarLabel
            // 
            this.blackBarLabel.BackColor = System.Drawing.Color.Black;
            this.blackBarLabel.ForeColor = System.Drawing.Color.Crimson;
            this.blackBarLabel.Location = new System.Drawing.Point(33, 260);
            this.blackBarLabel.Name = "blackBarLabel";
            this.blackBarLabel.Size = new System.Drawing.Size(145, 14);
            this.blackBarLabel.TabIndex = 10;
            // 
            // calculateChangeButton
            // 
            this.calculateChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calculateChangeButton.Location = new System.Drawing.Point(33, 313);
            this.calculateChangeButton.Name = "calculateChangeButton";
            this.calculateChangeButton.Size = new System.Drawing.Size(145, 23);
            this.calculateChangeButton.TabIndex = 11;
            this.calculateChangeButton.Text = "Calculate Change";
            this.calculateChangeButton.UseVisualStyleBackColor = true;
            this.calculateChangeButton.Click += new System.EventHandler(this.calculateChangeButton_Click);
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.Location = new System.Drawing.Point(30, 287);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(53, 13);
            this.tenderedLabel.TabIndex = 12;
            this.tenderedLabel.Text = "Tendered";
            // 
            // tenderedText
            // 
            this.tenderedText.Location = new System.Drawing.Point(101, 284);
            this.tenderedText.Name = "tenderedText";
            this.tenderedText.Size = new System.Drawing.Size(77, 20);
            this.tenderedText.TabIndex = 13;
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Location = new System.Drawing.Point(30, 350);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(44, 13);
            this.changeLabel.TabIndex = 14;
            this.changeLabel.Text = "Change";
            // 
            // totalChangeLabel
            // 
            this.totalChangeLabel.Location = new System.Drawing.Point(101, 350);
            this.totalChangeLabel.Name = "totalChangeLabel";
            this.totalChangeLabel.Size = new System.Drawing.Size(77, 23);
            this.totalChangeLabel.TabIndex = 15;
            this.totalChangeLabel.Text = "-";
            this.totalChangeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // printReceiptButton
            // 
            this.printReceiptButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.printReceiptButton.Location = new System.Drawing.Point(33, 376);
            this.printReceiptButton.Name = "printReceiptButton";
            this.printReceiptButton.Size = new System.Drawing.Size(145, 23);
            this.printReceiptButton.TabIndex = 16;
            this.printReceiptButton.Text = "Print Receipt";
            this.printReceiptButton.UseVisualStyleBackColor = true;
            this.printReceiptButton.Click += new System.EventHandler(this.printReceiptButton_Click);
            // 
            // newOrderButton
            // 
            this.newOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.newOrderButton.Location = new System.Drawing.Point(194, 376);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(291, 23);
            this.newOrderButton.TabIndex = 18;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = true;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // receiptLabel
            // 
            this.receiptLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.receiptLabel.Location = new System.Drawing.Point(194, 62);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(291, 301);
            this.receiptLabel.TabIndex = 19;
            this.receiptLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(497, 414);
            this.Controls.Add(this.receiptLabel);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.printReceiptButton);
            this.Controls.Add(this.totalChangeLabel);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.tenderedText);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.calculateChangeButton);
            this.Controls.Add(this.blackBarLabel);
            this.Controls.Add(this.totalNumbersLabel);
            this.Controls.Add(this.totalsLabel);
            this.Controls.Add(this.calculateTotalsButton);
            this.Controls.Add(this.drinksText);
            this.Controls.Add(this.toppingsText);
            this.Controls.Add(this.iceCreamsText);
            this.Controls.Add(this.drinksLabel);
            this.Controls.Add(this.toppingsLabel);
            this.Controls.Add(this.iceCreamsLabel);
            this.Controls.Add(this.nameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Quinn\'s Ice Cream Parlour";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label iceCreamsLabel;
        private System.Windows.Forms.Label toppingsLabel;
        private System.Windows.Forms.Label drinksLabel;
        private System.Windows.Forms.TextBox iceCreamsText;
        private System.Windows.Forms.TextBox toppingsText;
        private System.Windows.Forms.TextBox drinksText;
        private System.Windows.Forms.Button calculateTotalsButton;
        private System.Windows.Forms.Label totalsLabel;
        private System.Windows.Forms.Label totalNumbersLabel;
        private System.Windows.Forms.Label blackBarLabel;
        private System.Windows.Forms.Button calculateChangeButton;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.TextBox tenderedText;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label totalChangeLabel;
        private System.Windows.Forms.Button printReceiptButton;
        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.Label receiptLabel;
    }
}

