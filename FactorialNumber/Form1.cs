// Andrew Mackinnon
// Oct 15 2015
// ICS3UR
// Pick a number to take the factorial of 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorialNumber
{
    public partial class frmFactorialNumber : Form
    {
        public frmFactorialNumber()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Varibles

            Double factorialNumber;
            Double factorialAnswer;
            

            this.lstListBox.Items.Clear();
            factorialAnswer = 1;
            factorialNumber = Convert.ToDouble(this.txtFactorialNumber.Text) + 1; // I dont know :D
            

            // Loop

            for (int factorialCounter = 1; factorialNumber != factorialCounter; factorialCounter++)
            {

                // process


                this.lstListBox.Items.Add(factorialCounter);
                factorialAnswer = factorialAnswer * factorialCounter;
            }
            

            // Output

            this.lblAnswer.Text = Convert.ToString(factorialAnswer);
        }
    }
}
