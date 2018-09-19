using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateLetterGrade
{
    public partial class frmCalculateGrade : Form
    {
        public frmCalculateGrade()
        {
            InitializeComponent();
        }

        private void frmCalculateGrade_Load(object sender, EventArgs e)
        {

        }

        //Event handler for when Calculate button is clicked
        private void btnCalculate_Click(object sender, EventArgs e)
        {
           
        //Declare variable as type double.  Assign variable of what is entered into text box
            double NumberGrade;
            NumberGrade= double.Parse(txtNumberGrade.Text);
        //Declare variable for letter grade
            char LetterGrade = 'A';

        //Logic for calculating letter grade
            if (NumberGrade >= 90)
            {
                LetterGrade = 'A';
            }
            else if (NumberGrade >= 80)
            {
                LetterGrade = 'B';
            }
            else if (NumberGrade >= 70)
            {
                LetterGrade = 'C';
            }
            else LetterGrade = 'F';

            //Send letter grade to text box
            txtLetterGrade.Text = LetterGrade.ToString();

            //Move focus to number grade text box
            txtNumberGrade.Focus();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
