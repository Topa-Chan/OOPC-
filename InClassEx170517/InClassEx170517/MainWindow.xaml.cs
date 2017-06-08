using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace InClassEx170517
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /*
         * You are building a dice roller. The formula for dice is usually expressed as xDy + z,
         * where x is the number of dice being rolled, y is the number of sides per die,
         * and z is any modifier. So, 3d6 + 5 means you roll three six-sided dice, add them
         * together, then add five for the final total.
         * 
         * Your Job:
         * Add the code necessary to meet the following requirements:
         * 1) When "Roll Dice" is clicked, use the Text property in NumOfDiceField and
         *      NumOfSidesField to generate a random number.
         * 2) Add the mod to the random number.
         * 3) Note that if any TextBox is empty or contains invalid data, it counts as a value of 0.
         * 4) Display the final total in the Content property of the TotalLabel.
         * 5) When Reset is clicked, empty out the Label and all three TextBoxes.
         */

        private void RollDiceButton_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            int dice = 0;
            int side = 0;
            int total = 0;
            int adding = 0;
            int mod = 0;
            int.TryParse(NumOfDiceField.Text, out dice);
            int.TryParse(NumOfSidesField.Text, out side);
            //if (int.TryParse(NumOfDiceField.Text, out dice) == false)
            //{
            //    dice = 0;
            //}
            //if (int.TryParse(NumOfSidesField.Text, out side) == false)
            //{
            //    side = 0;
            //}
            int.TryParse(ModField.Text, out mod);
            //if (int.TryParse(ModField.Text, out mod) == false)
            //{
            //    mod = 0;
            //}
            if (dice >= 1 && side > 0)
            {
                for (int i = 0; i < dice; i++)
                {
                    adding = rand.Next(side) + 1;
                    total += adding;
                }
            }
            int final = total + mod;
            TotalLabel.Content = final;
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            NumOfDiceField.Clear(); ;
            NumOfSidesField.Clear();
            ModField.Clear();
            TotalLabel.Content = "";
        }

    }
}
