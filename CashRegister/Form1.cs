using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Media;

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
        int numbersOfIceCream = 0;
        int numbersOfToppings = 0;
        int numbersOfDrinks = 0;
        double subTotal = 0;
        double taxesTotal = 0;
        double totalPrice = 0;
        double tenderedAmount = 0;
        double changeAmounts = 0;

        public Form1()
        { 
            InitializeComponent();
        
        }

        private void calculateTotalsButton_Click(object sender, EventArgs e)
        {

            //prices mathematics
            try
            {
                //sets the bar colour to black
                blackBarLabel.BackColor = Color.Black;
                blackBarLabel.ForeColor = Color.Black;

                //calculating the subtotal
                subTotal = (numbersOfIceCream * ICE_CREAM_PRICE)
                    + (numbersOfToppings * TOPPING_PRICE)
                    + (numbersOfDrinks * DRINKS_PRICE);

                //calculating the tax total
                taxesTotal = subTotal * TAX_RATE;
                
                //calculating the total price
                totalPrice = subTotal + taxesTotal;

                //printing everything to the total numbers label
                totalNumbersLabel.Text = subTotal.ToString("C")
                    + "\n\n"
                    + taxesTotal.ToString("C")
                    + "\n\n"
                    + totalPrice.ToString("C");

                //setting the text fields and buttons to accessible or inaccessible depending on whether you need them or not
                tenderedText.Enabled = true;
                calculateChangeButton.Enabled = true;
                iceCreamsText.Enabled = false;
                toppingsText.Enabled = false;
                drinksText.Enabled = false;
                calculateTotalsButton.Enabled = false;
            }
            catch
            {
                //printing error code
                blackBarLabel.Text = "Please enter a number.";

                //printing the lines displaying nothing inputted into the fields above
                totalNumbersLabel.Text = "-\n\n-\n\n-";

                //setting the background to white and the text color to red
                blackBarLabel.BackColor = Color.White;
                blackBarLabel.ForeColor = Color.Red;
                
            }
        }

        private void calculateChangeButton_Click(object sender, EventArgs e)
        {
            try {
                //sets the bar colour to black
                blackBarLabel.BackColor = Color.Black;
                blackBarLabel.ForeColor = Color.Black;

                //calculates the subtotal
                subTotal = (numbersOfIceCream * ICE_CREAM_PRICE)
                    + (numbersOfToppings * TOPPING_PRICE)
                    + (numbersOfDrinks * DRINKS_PRICE);

                //calculting the tax
                taxesTotal = subTotal * TAX_RATE;

                //calculating the price
                totalPrice = subTotal + taxesTotal;

                //calculating the change amount
                changeAmounts = tenderedAmount - totalPrice;

                //printing the change amount to the appropriate label
                totalChangeLabel.Text = changeAmounts.ToString("C");

                //setting the text fields and buttons to accessible or inaccessible depending on whether you need them or not
                printReceiptButton.Enabled = true;
                tenderedText.Enabled = false;
                calculateChangeButton.Enabled = false;
            }
            catch
            {
                //printing error code
                blackBarLabel.Text = "Please enter a number.";

                //printing the line displaying nothing inputted into the field above
                totalChangeLabel.Text = "-";

                //setting the background to white and the text color to red
                blackBarLabel.BackColor = Color.White;
                blackBarLabel.ForeColor = Color.Red;
            }
        }

        private void printReceiptButton_Click(object sender, EventArgs e)
        {
            //graphics setup
            printReceiptButton.Enabled = false;
            Graphics g = receiptLabel.CreateGraphics();
            Font drawFont = new Font("Courier New", 8);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            //local global variables
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

            //sound player setup
            SoundPlayer printerSound = new SoundPlayer(Properties.Resources.printerSound);

            //printing the receipt and playing the sound
            printerSound.Play();
            g.DrawString("Quinn\'s Ice Cream Parlour", drawFont, drawBrush, (receiptLabel.Width/2)-85, 0);
            Thread.Sleep(2010);
            printerSound.Play();
            g.DrawString("     428 Forman Ave.      ", drawFont, drawBrush, (receiptLabel.Width/2)-85, 10);
            Thread.Sleep(2010);
            printerSound.Play();
            g.DrawString("        Stratford         ", drawFont, drawBrush, (receiptLabel.Width/2)-85, 20);
            Thread.Sleep(2010);
            printerSound.Play();
            g.DrawString("     Ontario, N5A 6R7     ", drawFont, drawBrush, (receiptLabel.Width/2)-85, 30);
            Thread.Sleep(2010);
            printerSound.Play();
            g.DrawString("      (519) 271-9740      ", drawFont, drawBrush, (receiptLabel.Width/2)-85, 40);
            Thread.Sleep(2010);
            printerSound.Play();
            g.DrawString(day, drawFont, drawBrush, (receiptLabel.Width/2)-85, 50);
            Thread.Sleep(2010);
            printerSound.Play();
            g.DrawString(printedNumberOfIceCreams, drawFont, drawBrush, 0, 70);
            if (printedNumberOfIceCreamsOne == 1)
            {
                g.DrawString("Ice Cream @ $5.00", drawFont, drawBrush, (receiptLabel.Width/2)-55, 70);
            }
            else
            {
                g.DrawString("Ice Creams @ $5.00", drawFont, drawBrush, (receiptLabel.Width/2)-55, 70);
            }
            g.DrawString(printedIceCreamTotal.ToString("C"), drawFont, drawBrush, 241, 70);
            Thread.Sleep(2010);
            printerSound.Play();
            g.DrawString(printedNumberOfToppings, drawFont, drawBrush, 0, 80);
            if (printedNumberOfToppingsOne == 1)
            {
                g.DrawString("Topping @ 70¢", drawFont, drawBrush, (receiptLabel.Width/2)-40, 80);
            }
            else
            {
                g.DrawString("Toppings @ 70¢", drawFont, drawBrush, (receiptLabel.Width/2)-40, 80);
            }
            g.DrawString(printedToppingsTotal.ToString("C"), drawFont, drawBrush, 241, 80);
            Thread.Sleep(2010);
            printerSound.Play();
            g.DrawString(printedNumberOfDrinks, drawFont, drawBrush, 0, 90);
            if (printedNumberOfDrinksOne == 1)
            {
                g.DrawString("Drink @ $2.50", drawFont, drawBrush, (receiptLabel.Width/2)-40, 90);
            }
            else
            {
                g.DrawString("Drinks @ $2.50", drawFont, drawBrush, (receiptLabel.Width/2)-40, 90);
            }
            g.DrawString(printedDrinksTotal.ToString("C"), drawFont, drawBrush, 241, 90);
            Thread.Sleep(2010);
            printerSound.Play();
            g.DrawString("Sub Total:", drawFont, drawBrush, 0, 110);
            g.DrawString(subTotal.ToString("C"), drawFont, drawBrush, 241, 110);
            Thread.Sleep(2010);
            printerSound.Play();
            g.DrawString("Tax:", drawFont, drawBrush, 0, 120);
            g.DrawString(taxesTotal.ToString("C"), drawFont, drawBrush, 241, 120);
            Thread.Sleep(2010);
            printerSound.Play();
            g.DrawString("Total:", drawFont, drawBrush, 0, 130);
            g.DrawString(totalPrice.ToString("C"), drawFont, drawBrush, 241, 130);
            Thread.Sleep(2010);
            printerSound.Play();
            g.DrawString("Payment Method:", drawFont, drawBrush, 0, 150);
            g.DrawString("Cash", drawFont, drawBrush, 241, 150);
            Thread.Sleep(2010);
            printerSound.Play();
            g.DrawString("Tendered:", drawFont, drawBrush, 0, 160);
            g.DrawString(tenderedAmount.ToString("C"), drawFont, drawBrush, 241, 160);
            Thread.Sleep(2010);
            printerSound.Play();
            g.DrawString("Change:", drawFont, drawBrush, 0, 170);
            g.DrawString(changeAmounts.ToString("C"), drawFont, drawBrush, 241, 170);
            Thread.Sleep(2010);
            printerSound.Play();
            g.DrawString("Thank you for shopping with us!", drawFont, drawBrush, (receiptLabel.Width/2)-100, 190);
            Thread.Sleep(2010);
            printerSound.Stop();
        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            //clearing everything
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
            iceCreamsText.Enabled = true;
            toppingsText.Enabled = true;
            drinksText.Enabled = true;
            calculateTotalsButton.Enabled = true;
            tenderedText.Enabled = false;
            calculateChangeButton.Enabled = false;
            printReceiptButton.Enabled = false;
        }
    }
}