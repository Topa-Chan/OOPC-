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

namespace ScratchWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

        /*
         * 1. Add a second button to the UI. Label it New First Name
         * 2. Change the label of the original button to new Last Name
         * 3. Add the code necessary so that when the "First Name" Button is clicked, it 
         *  randomly selects a new first name and replaces the first name in the label without CHANGING the last name
         * 4. Add similar funcitonality to the "Last Name" button 
         */ 

    public partial class MainWindow : Window
    {
        private static Random rand = new Random();

        private string[] firstNames = new string[]
        {
            "Topanga",
            "Amanda",
            "Leia",
            "Hana",
            "Ranma",
            "Akane"
        };

        private string[] lastNames = new string[]
        {
            "Patterson",
            "Ripley",
            "Skywalker",
            "Song",
            "Saotome",
            "Tendo"
        };

        private string lName;
        private string fName;

        public MainWindow()
        {
            InitializeComponent();
        }
        
        //Event Handler for Button Click
        private void RandomButton_Click(object sender, RoutedEventArgs e)
        {
            //Randomly choose a first and last name and display them as one full name in the label
            fName = firstNames[rand.Next(firstNames.Length)];
            lName = lastNames[rand.Next(lastNames.Length)];
            nameLabel.Content = fName + " " + lName + " is gay!";
        }

        private void FirstNameButton_Click(object sender, RoutedEventArgs e)
        {
            fName = firstNames[rand.Next(firstNames.Length)];
            nameLabel.Content = fName + " " + lName + " is gay!";
        }

        private void LastNameButton_Click(object sender, RoutedEventArgs e)
        {
            lName = lastNames[rand.Next(lastNames.Length)];
            nameLabel.Content = fName + " " + lName + " is gay!";
        }
    }
}
