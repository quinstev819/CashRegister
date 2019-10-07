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
        int tenderedAmount;
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
                blackBarLabel.BackColor = Color.Black;
                blackBarLabel.ForeColor = Color.Black;
                if (numbersOfIceCream = )
                {
                    numbersOfIceCream = 
                }
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
                blackBarLabel.BackColor = Color.Black;
                blackBarLabel.ForeColor = Color.Black;
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
            string printedNumberOfIceCreams;
            printedNumberOfIceCreams = Convert.ToString(numbersOfIceCream);

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
        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
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
