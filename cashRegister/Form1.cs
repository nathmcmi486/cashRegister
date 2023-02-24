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
        // 
        private static double AMOUNT = 0.0;
        private static double PAID_AMOUNT = 0.0;
        private static double TAX_AMOUNT = 0.0;
        public const double TAX_RATE = 0.13;
        

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
            this.calcOutputLabel.Text = $"Total amount: {AMOUNT}\nTax amount:  {TAX_AMOUNT}";

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

            this.changeLabel.Text = $" ";
        }
    }
}
