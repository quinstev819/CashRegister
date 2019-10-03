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
            
        }
    }
}
