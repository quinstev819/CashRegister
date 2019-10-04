using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Quinlan Stevenson
/// Tony Theodoropoulos
/// ICS 3U
/// October 3rd, 2019
/// </summary>

namespace CashRegister
{
    public partial class Form1 : Form
    {
        //global variables
        const double ICE_CREAM_PRICE = 5;
        const double TOPPING_PRICE = 0.7;
        const double DRINKS_PRICE = 2.5;
        const double TAX_RATE = 0.13;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateTotalsButton_Click(object sender, EventArgs e)
        {
            //local variables
            int numbersOfIceCream;
            int numbersOfToppings;
            int numbersOfDrinks;
            double subTotal;
            double taxesTotal;
            double totalPrice;

            //prices mathematics
            try
            {
                numbersOfIceCream = Convert.ToInt16(iceCreamsText.Text);
                numbersOfToppings = Convert.ToInt16(toppingsText.Text);
                numbersOfDrinks = Convert.ToInt16(drinksText.Text);
                subTotal = (numbersOfIceCream * ICE_CREAM_PRICE)
                    + (numbersOfToppings * TOPPING_PRICE)
                    + (numbersOfDrinks * DRINKS_PRICE);
                taxesTotal = subTotal * TAX_RATE;
                totalPrice = subTotal + taxesTotal;

                totalNumbersLabel.Text = subTotal.ToString("C")
                    + "\n\n"
                    + taxesTotal.ToString("C")
                    + "\n\n"
                    + totalPrice.ToString("C");
            }
            catch
            {
                totalNumbersLabel.Text = "-\n\n-\n\n-";
            }
        }

        private void calculateChangeButton_Click(object sender, EventArgs e)
        {
            //local variables
            int numbersOfIceCream;
            int numbersOfToppings;
            int numbersOfDrinks;
            double subTotal;
            double taxesTotal;
            double totalPrice;
            int tenderedAmount;
            double changeAmounts;

            //prices code from above
            try
            {
                numbersOfIceCream = Convert.ToInt16(iceCreamsText.Text);
                numbersOfToppings = Convert.ToInt16(toppingsText.Text);
                numbersOfDrinks = Convert.ToInt16(drinksText.Text);
                subTotal = (numbersOfIceCream * ICE_CREAM_PRICE)
                    + (numbersOfToppings * TOPPING_PRICE)
                    + (numbersOfDrinks * DRINKS_PRICE);
                taxesTotal = subTotal * TAX_RATE;
                totalPrice = subTotal + taxesTotal;
                tenderedAmount = Convert.ToInt16(tenderedText.Text);
                changeAmounts = tenderedAmount - totalPrice;
                totalChangeLabel.Text = changeAmounts.ToString("C");
            }
            catch
            {
                totalChangeLabel.Text = "-";
            }
        }
    }
}
