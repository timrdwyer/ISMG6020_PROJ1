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

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double NumberGrade;
            NumberGrade= double.Parse(txtNumberGrade.Text);
            char LetterGrade = 'A';


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

            txtLetterGrade.Text = LetterGrade.ToString();

            txtNumberGrade.Focus();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
