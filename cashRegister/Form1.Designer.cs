namespace cashRegister
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
            this.title = new System.Windows.Forms.Label();
            this.receiptText = new System.Windows.Forms.Label();
            this.calcOutputLabel = new System.Windows.Forms.Label();
            this.calculateTotal = new System.Windows.Forms.Button();
            this.amountInput = new System.Windows.Forms.TextBox();
            this.calculateChangeBtn = new System.Windows.Forms.Button();
            this.printReceiptBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();

            this.payInputLabel = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Label();

            this.frenchFryLabel = new System.Windows.Forms.Label();
            this.cheeseBurgerLabel = new System.Windows.Forms.Label();
            this.waterLabel = new System.Windows.Forms.Label();

            this.fryInput = new System.Windows.Forms.TextBox();
            this.cheeseBurgerInput = new System.Windows.Forms.TextBox();
            this.waterInput = new System.Windows.Forms.TextBox();

            this.SuspendLayout();
            // 
            // Title label
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(150, 68);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(35, 13);
            this.title.TabIndex = 0;
            this.title.Text = "The Cash Register";

            this.calcOutputLabel.AutoSize = true;
            this.calcOutputLabel.Location = new System.Drawing.Point(50, 185);
            this.calcOutputLabel.Name = "calcOutputLabel";
            this.calcOutputLabel.Size = new System.Drawing.Size(35, 13);
            this.calcOutputLabel.TabIndex = 0;
            this.calcOutputLabel.Text = "";

            this.changeLabel.AutoSize = true;
            this.changeLabel.Location = new System.Drawing.Point(50, 270);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(35, 13);
            this.changeLabel.TabIndex = 0;
            this.changeLabel.Text = "";

            // Item labels
            this.frenchFryLabel.AutoSize = true;
            this.frenchFryLabel.Location = new System.Drawing.Point(50, 90);
            this.frenchFryLabel.Name = "frenchFryLabel";
            this.frenchFryLabel.Size = new System.Drawing.Size(35, 13);
            this.frenchFryLabel.TabIndex = 0;
            this.frenchFryLabel.Text = $"French Fries {FRENCH_FRY_COST.ToString("C")}";

            this.cheeseBurgerLabel.AutoSize = true;
            this.cheeseBurgerLabel.Location = new System.Drawing.Point(50, 110);
            this.cheeseBurgerLabel.Name = "cheeseBurgerLabel";
            this.cheeseBurgerLabel.Size = new System.Drawing.Size(35, 13);
            this.cheeseBurgerLabel.TabIndex = 0;
            this.cheeseBurgerLabel.Text = $"Cheese Burgers {CHEESE_BURGER_COST.ToString("C")}";

            this.waterLabel.AutoSize = true;
            this.waterLabel.Location = new System.Drawing.Point(50, 128);
            this.waterLabel.Name = "waterLabel";
            this.waterLabel.Size = new System.Drawing.Size(35, 13);
            this.waterLabel.TabIndex = 0;
            this.waterLabel.Text = $"Water {WATER_COST.ToString("C")}";

            this.receiptText.AutoSize = true;
            this.receiptText.Location = new System.Drawing.Point(275, 90);
            this.receiptText.Name = "receiptText";
            this.receiptText.Size = new System.Drawing.Size(35, 13);
            this.receiptText.TabIndex = 0;
            this.receiptText.BackColor = System.Drawing.Color.White;

            // Item input boxes
            this.fryInput.Location = new System.Drawing.Point(170, 90);
            this.fryInput.Name = "fryInput";
            this.fryInput.Size = new System.Drawing.Size(100, 20);
            this.fryInput.TabIndex = 2;

            this.cheeseBurgerInput.Location = new System.Drawing.Point(170, 112);
            this.cheeseBurgerInput.Name = "cheeseBurgerInput";
            this.cheeseBurgerInput.Size = new System.Drawing.Size(100, 20);
            this.cheeseBurgerInput.TabIndex = 2;

            this.waterInput.Location = new System.Drawing.Point(170, 134);
            this.waterInput.Name = "waterInput";
            this.waterInput.Size = new System.Drawing.Size(100, 20);
            this.waterInput.TabIndex = 2;

            // 
            // Calculate total button
            // 
            this.calculateTotal.Location = new System.Drawing.Point(50, 155);
            this.calculateTotal.Name = "calculateTotal";
            this.calculateTotal.Size = new System.Drawing.Size(75, 23);
            this.calculateTotal.TabIndex = 1;
            this.calculateTotal.Text = "Calculate total";
            this.calculateTotal.UseVisualStyleBackColor = true;
            this.calculateTotal.Click += new System.EventHandler(this.calculateTotal_Click);
            //
            // Calculate change button
            //
            this.calculateChangeBtn.Location = new System.Drawing.Point(50, 245);
            this.calculateChangeBtn.Name = "calculateChangeBtn";
            this.calculateChangeBtn.Size = new System.Drawing.Size(75, 23);
            this.calculateChangeBtn.TabIndex = 1;
            this.calculateChangeBtn.Text = "Calculate change";
            this.calculateChangeBtn.UseVisualStyleBackColor = true;
            this.calculateChangeBtn.Click += new System.EventHandler(this.calculateChange_Click);

            //
            // Print receipt button
            //
            this.printReceiptBtn.Location = new System.Drawing.Point(50, 300);
            this.printReceiptBtn.Name = "printReceiptBtn";
            this.printReceiptBtn.Size = new System.Drawing.Size(75, 23);
            this.printReceiptBtn.TabIndex = 1;
            this.printReceiptBtn.Text = "Print Receipt";
            this.printReceiptBtn.UseVisualStyleBackColor = true;
            this.printReceiptBtn.Click += new System.EventHandler(this.printReceipt);


            this.resetBtn.Location = new System.Drawing.Point(50, 340);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 23);
            this.resetBtn.TabIndex = 1;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.Reset);

            // 
            // Input amount
            // 
            this.amountInput.Location = new System.Drawing.Point(50, 220);
            this.amountInput.Name = "amountInput";
            this.amountInput.Size = new System.Drawing.Size(100, 20);
            this.amountInput.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 450);
            this.Controls.Add(this.amountInput);
            this.Controls.Add(this.calculateTotal);
            this.Controls.Add(this.title);
            this.Controls.Add(this.calcOutputLabel);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.receiptText);
            // this.Controls.Add(this.resetButton);
            this.BackColor = System.Drawing.Color.DarkGray;
            //this.Controls.Add(this.calculateChangeBtn);

            // Add item labels
            this.Controls.Add(this.frenchFryLabel);
            this.Controls.Add(this.cheeseBurgerLabel);
            this.Controls.Add(this.waterLabel);

            // Add item inputs
            this.Controls.Add(this.fryInput);
            this.Controls.Add(this.cheeseBurgerInput);
            this.Controls.Add(this.waterInput);

            this.Name = "CashRegister";
            this.Text = "Cash Register";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button calculateTotal;
        private System.Windows.Forms.Button calculateChangeBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button printReceiptBtn;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TextBox amountInput;
        private System.Windows.Forms.TextBox fryInput;
        private System.Windows.Forms.TextBox cheeseBurgerInput;
        private System.Windows.Forms.TextBox waterInput;
        private System.Windows.Forms.Label frenchFryLabel;
        private System.Windows.Forms.Label cheeseBurgerLabel;
        private System.Windows.Forms.Label waterLabel;
        private System.Windows.Forms.Label calcOutputLabel;
        private System.Windows.Forms.Label payInputLabel;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label receiptText;
    }
}

