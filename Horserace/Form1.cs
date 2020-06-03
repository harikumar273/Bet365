using Horserace.Core;
using Horserace.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Horserace
{
    public partial class Form1 : Form
    {
        List<Horse> horses = new List<Horse>();
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtHorseName_TextChanged(object sender, EventArgs e)
        {
            ValidateHorseName();
        }

        private void BtnAddHorseToRace_Click(object sender, EventArgs e)
        {
            if (ValidHorse())
            {
                double odd = (Convert.ToDouble(TxtOdd1.Text) / Convert.ToDouble(TxtOdd2.Text));
                Horse horse = new Horse { HorseName = TxtHorseName.Text, Odd = odd, Odds = TxtOdd1.Text + "/" + TxtOdd2.Text };
                horseBindingSource.Add(horse);
                horses.Add(horse);
            }           
        }


        private void BrnRunRace_Click(object sender, EventArgs e)
        {
            HorseRace horseRace = new HorseRace(horses, 110, 140);

            if (horseRace.IsValidRace())
            {
                TxtRaceWinner.Text = "The Winner Is :" + horseRace.Winner().HorseName;
            }
            else
            {
                MessageBox.Show("Margin Not Between 110% and 140%");
            }
        }
        private void ValidateHorseName()
        {
            if (TxtHorseName.Text.Length > 18)
            {
                MessageBox.Show("Horse Name can be maximum 18 characters");

                TxtHorseName.Text.Remove(TxtHorseName.Text.Length - 1);
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(TxtHorseName.Text, "^[a-zA-Z ]*$"))
            {
                MessageBox.Show("Horse Name can be A-Z only including spaces");
                TxtHorseName.Text.Remove(TxtHorseName.Text.Length - 1);
            }
        }
        private bool ValidHorse()
        {
            bool isValidHorse = true;
            if (TxtHorseName.Text.Length <= 0 || TxtOdd1.Text.Length <= 0 || TxtOdd2.Text.Length <= 0)
            {
                MessageBox.Show("Horse Cannot be added, Please check all details are entered");
                isValidHorse = false;
            }
            if (horses.Count >= 16) {
                MessageBox.Show("Max No of horses for a race reached");
                isValidHorse = false;
            }
            return isValidHorse;
        }

        private void TxtOdd1_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(TxtOdd1.Text, "^[1-9]*$"))
            {
                MessageBox.Show("Should be integer greater than 1");
                TxtOdd1.Text = "";
            }
        }

        private void TxtOdd2_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(TxtOdd2.Text, "^[1-9]*$"))
            {
                MessageBox.Show("Should be integer greater than 1");
                TxtOdd2.Text = "";
            }
        }
    }
}
