using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

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
        //global constants
        const double ICE_CREAM_PRICE = 5;
        const double TOPPING_PRICE = 0.7;
        const double DRINKS_PRICE = 2.5;
        const double TAX_RATE = 0.13;

        //global variables
        int numbersOfIceCream;
        int numbersOfToppings;
        int numbersOfDrinks;
        double subTotal;
        double taxesTotal;
        double totalPrice;
        double tenderedAmount;
        double changeAmounts;

        public Form1()
        { 
            InitializeComponent();
        
        }

        private void calculateTotalsButton_Click(object sender, EventArgs e)
        {

            //prices mathematics
            try
            {
                if (iceCreamsText.Text == "")
                {
                    numbersOfIceCream = 0;
                }
                else
                {
                    numbersOfIceCream = Convert.ToInt16(iceCreamsText.Text);
                }
                if (toppingsText.Text == "")
                {
                    numbersOfToppings = 0;
                }
                else
                {
                    numbersOfToppings = Convert.ToInt16(toppingsText.Text);
                }
                if (drinksText.Text == "")
                {
                    numbersOfDrinks = 0;
                }
                else
                {
                    numbersOfDrinks = Convert.ToInt16(drinksText.Text);
                }
                blackBarLabel.BackColor = Color.Black;
                blackBarLabel.ForeColor = Color.Black;
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

                tenderedText.Enabled = true;
                calculateChangeButton.Enabled = true;
                iceCreamsText.Enabled = false;
                toppingsText.Enabled = false;
                drinksText.Enabled = false;
                calculateTotalsButton.Enabled = false;
            }
            catch
            {
                blackBarLabel.Text = "Please enter a number.";
                totalNumbersLabel.Text = "-\n\n-\n\n-";
                blackBarLabel.BackColor = Color.White;
                blackBarLabel.ForeColor = Color.Red;
                
            }
        }

        private void calculateChangeButton_Click(object sender, EventArgs e)
        {
            //prices code from above
            try
            {
                if (iceCreamsText.Text == "")
                {
                    numbersOfIceCream = 0;
                }
                else
                {
                    numbersOfIceCream = Convert.ToInt16(iceCreamsText.Text);
                }
                if (toppingsText.Text == "")
                {
                    numbersOfToppings = 0;
                }
                else
                {
                    numbersOfToppings = Convert.ToInt16(toppingsText.Text);
                }
                if (drinksText.Text == "")
                {
                    numbersOfDrinks = 0;
                }
                else
                {
                    numbersOfDrinks = Convert.ToInt16(drinksText.Text);
                }
                blackBarLabel.BackColor = Color.Black;
                blackBarLabel.ForeColor = Color.Black;
                subTotal = (numbersOfIceCream * ICE_CREAM_PRICE)
                    + (numbersOfToppings * TOPPING_PRICE)
                    + (numbersOfDrinks * DRINKS_PRICE);
                taxesTotal = subTotal * TAX_RATE;
                totalPrice = subTotal + taxesTotal;
                tenderedAmount = Convert.ToDouble(tenderedText.Text);
                changeAmounts = tenderedAmount - totalPrice;
                totalChangeLabel.Text = changeAmounts.ToString("C");
                printReceiptButton.Enabled = true;
                calculateChangeButton.Enabled = false;
            }
            catch
            {
                blackBarLabel.Text = "Please enter a number.";
                totalChangeLabel.Text = "-";
                blackBarLabel.BackColor = Color.White;
                blackBarLabel.ForeColor = Color.Red;
            }
        }

        private void printReceiptButton_Click(object sender, EventArgs e)
        {
            Graphics g = receiptLabel.CreateGraphics();
            Pen drawPen = new Pen(Color.Black);
            Font drawFont = new Font("Courier New", 8);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            string day = DateTime.Now.ToString("    yyy-MM-dd hh:mm tt   ");
            string printedNumberOfIceCreams = Convert.ToString(numbersOfIceCream);
            string printedNumberOfToppings = Convert.ToString(numbersOfToppings);
            string printedNumberOfDrinks = Convert.ToString(numbersOfDrinks);
            double printedNumberOfIceCreamsOne = Convert.ToDouble(numbersOfIceCream);
            double printedNumberOfToppingsOne = Convert.ToDouble(numbersOfToppings);
            double printedNumberOfDrinksOne = Convert.ToDouble(numbersOfDrinks);
            double printedIceCreamTotal = numbersOfIceCream * ICE_CREAM_PRICE;
            double printedDrinksTotal = numbersOfDrinks * DRINKS_PRICE;
            double printedToppingsTotal = numbersOfToppings * TOPPING_PRICE;

            g.DrawString("Quinn\'s Ice Cream Parlour", drawFont, drawBrush, (receiptLabel.Width/2)-85, 0);
            Thread.Sleep(500);
            g.DrawString("     428 Forman Ave.      ", drawFont, drawBrush, (receiptLabel.Width/2)-85, 10);
            Thread.Sleep(500);
            g.DrawString("        Stratford         ", drawFont, drawBrush, (receiptLabel.Width/2)-85, 20);
            Thread.Sleep(500);
            g.DrawString("     Ontario, N5A 6R7     ", drawFont, drawBrush, (receiptLabel.Width/2)-85, 30);
            Thread.Sleep(500);
            g.DrawString("      (519) 271-9740      ", drawFont, drawBrush, (receiptLabel.Width/2)-85, 40);
            Thread.Sleep(500);
            g.DrawString(day, drawFont, drawBrush, (receiptLabel.Width/2)-85, 50);
            Thread.Sleep(500);
            g.DrawString(printedNumberOfIceCreams, drawFont, drawBrush, 0, 70);
            if (printedNumberOfIceCreamsOne == 1)
            {
                g.DrawString("Ice Cream @ $5.00", drawFont, drawBrush, (receiptLabel.Width/2)-55, 70);
            }
            else
            {
                g.DrawString("Ice Creams @ $5.00", drawFont, drawBrush, (receiptLabel.Width/2)-55, 70);
            }
            g.DrawString(printedIceCreamTotal.ToString("C"), drawFont, drawBrush, 251, 70);
            Thread.Sleep(500);
            g.DrawString(printedNumberOfToppings, drawFont, drawBrush, 0, 80);
            if (printedNumberOfToppingsOne == 1)
            {
                g.DrawString("Topping @ 70¢", drawFont, drawBrush, (receiptLabel.Width/2)-55, 80);
            }
            else
            {
                g.DrawString("Toppings @ 70¢", drawFont, drawBrush, (receiptLabel.Width/2)-55, 80);
            }
            g.DrawString(printedToppingsTotal.ToString("C"), drawFont, drawBrush, 251, 80);
            Thread.Sleep(500);
            g.DrawString(printedNumberOfDrinks, drawFont, drawBrush, 0, 90);
            if (printedNumberOfDrinksOne == 1)
            {
                g.DrawString("Drink @ $2.50", drawFont, drawBrush, (receiptLabel.Width/2)-55, 90);
            }
            else
            {
                g.DrawString("Drinks @ $2.50", drawFont, drawBrush, (receiptLabel.Width/2)-55, 90);
            }
            g.DrawString(printedDrinksTotal.ToString("C"), drawFont, drawBrush, 251, 90);
            Thread.Sleep(500);
            g.DrawString("Sub Total", drawFont, drawBrush, 0, 110);
            g.DrawString(subTotal.ToString("C"), drawFont, drawBrush, 251, 110);
            g.DrawString("Thank you for shopping with us!", drawFont, drawBrush, (receiptLabel.Width/2)-85, 120);
        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            Graphics g = receiptLabel.CreateGraphics();
            g.Clear(Color.White);
            numbersOfIceCream = 0;
            numbersOfToppings = 0;
            numbersOfDrinks = 0;
            subTotal = 0;
            taxesTotal = 0;
            totalPrice = 0;
            tenderedAmount = 0;
            changeAmounts = 0;
            totalNumbersLabel.Text = "-\n\n-\n\n-";
            iceCreamsText.Text = "";
            toppingsText.Text = "";
            drinksText.Text = "";
            tenderedText.Text = "";
            totalChangeLabel.Text = "-";
        }
    }
}
