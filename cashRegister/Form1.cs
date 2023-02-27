using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cashRegister
{
    public partial class Form1 : Form
    {
        // Foos costs
        public const double FRENCH_FRY_COST = 1.99;
        public const double CHEESE_BURGER_COST = 3.5;
        public const double WATER_COST = 9.99;

        /* 
         * Index 0 - Frenh fires
         * Index 1 - Cheese burgers
         * Index 2 - Water
        */
        public static uint[] QUANTITY = {0, 0, 0};
        // Amounts paid
        private static double AMOUNT = 0.0;
        private static double PAID_AMOUNT = 0.0;
        private static double TAX_AMOUNT = 0.0;
        public const double TAX_RATE = 0.13;

        private static string RECEIPT_TEXT = "";

        public Form1()
        {
            InitializeComponent();
        }

        /* ``calculateTotal_Click(object, EventArgs)``
         * _ - Unused
         * e - Unused
         * 
         * Calculates the amount (``AMOUNT``) with tax (``TAX_AMOUNT``) from the values in ``QUANTITY``.
        */
        private void calculateTotal_Click(object _, EventArgs e)
        {
            try
            {
                QUANTITY[0] = Convert.ToUInt32(this.fryInput.Text);
                QUANTITY[1] = Convert.ToUInt32(this.cheeseBurgerInput.Text);
                QUANTITY[2] = Convert.ToUInt32(this.waterInput.Text);
            } catch
            {
                System.Console.WriteLine("There was an invalid input");
                this.calcOutputLabel.Text = "Please enter valid numbers in all text boxes";
                return;
            }

            double amount = (QUANTITY[0] * FRENCH_FRY_COST) + (QUANTITY[1] * CHEESE_BURGER_COST) + (QUANTITY[2] * WATER_COST);
            double tax_amount = amount * TAX_RATE;
            amount = amount + tax_amount;
            System.Console.WriteLine($"Amount: {amount}");
            AMOUNT = amount;
            TAX_AMOUNT = tax_amount;
            this.calcOutputLabel.Text = $"Total amount: {AMOUNT.ToString("C")}\nTax amount:  {TAX_AMOUNT.ToString("C")}";

            this.Controls.Add(this.calculateChangeBtn);
        }

        private void calculateChange_Click(object _, EventArgs e)
        {
            try
            {
                PAID_AMOUNT = Convert.ToDouble(this.amountInput.Text);
            }
            catch
            {
                System.Console.WriteLine($"{this.amountInput.Text}");
                throw;
            }

            double change = PAID_AMOUNT - AMOUNT;
            
            if (change < 0)
            {
                this.changeLabel.Text = $"Did not enter enough money, still need {(change * -1).ToString("C")}";
                return;
            }

            this.changeLabel.Text = $"Change is: {change.ToString("C")}";
            // this.Controls.Add(this.receiptText);
            this.Controls.Add(this.printReceiptBtn);
        }

        private async void printReceipt(object _, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(600, 450);

            // Display the texts at different times so it seems "realistic"

            this.receiptText.Text += "----------- The Store -----------\n\nOrder";

            this.Refresh();
            System.Threading.Thread.Sleep(120);

            this.receiptText.Text += "ed:\n";

            this.Refresh();
            System.Threading.Thread.Sleep(750);

            this.receiptText.Text += $"{QUANTITY[0]} French Fries:         {(QUANTITY[0] * FRENCH_FRY_COST).ToString("C")}\n{QUANTITY[1]} ";

            this.Refresh();
            System.Threading.Thread.Sleep(900);


            this.receiptText.Text += $"Cheese Burgers:   {(QUANTITY[1] * CHEESE_BURGER_COST).ToString("C")}\n";

            this.Refresh();
            System.Threading.Thread.Sleep(300);

            this.receiptText.Text += $"{QUANTITY[2]} Waters                  {(QUANTITY[2] * WATER_COST).ToString("C")}\n";

            this.Refresh();
            System.Threading.Thread.Sleep(50);

            this.receiptText.Text += "\n";

            this.Refresh();
            System.Threading.Thread.Sleep(1000);

            this.receiptText.Text += $"Total:                       {(AMOUNT - TAX_AMOUNT).ToString("C")}\n";
            this.receiptText.Text += $"Tax:                         {TAX_AMOUNT.ToString("C")}\n";
            this.receiptText.Text += $"Total w/ Tax:           {AMOUNT.ToString("C")}\n\n";

            this.Refresh();
            System.Threading.Thread.Sleep(1000);

            this.receiptText.Text += $"Paid with:                 {PAID_AMOUNT.ToString("C")}\n";
            this.receiptText.Text += $"Change:                   {(PAID_AMOUNT - AMOUNT).ToString("C")}\n";

            this.Refresh();
            System.Threading.Thread.Sleep(120);

            this.receiptText.Text += "\nHave a";

            this.Refresh();
            System.Threading.Thread.Sleep(120);

            this.receiptText.Text += " good da";

            this.Refresh();
            System.Threading.Thread.Sleep(85);

            this.receiptText.Text += "y!";
        }
    }
}
