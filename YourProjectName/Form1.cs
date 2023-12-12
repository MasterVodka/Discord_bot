using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace YourProjectName
{
    public partial class Form1 : Form
    {
        private const int LabelLocationX = 50;
        private const int LabelLocationY = 50;

        // Constructor for the Form1 class
        public Form1()
        {
            InitializeComponent();

            // Call a method to get a phrase from the user and display it
            // Ask the user which method to pick
            string userChoice = Interaction.InputBox("Choose a method (1 or 2):\n1. GGST TO TEKKEN \n2. TEKKEN TO GGST", "User Input", "");
            
            // Check the user's choice and call the corresponding method
            if (!string.IsNullOrEmpty(userChoice))
            {
                if (userChoice == "1")
                {
                    GGSTTOTK();
                }
                else if (userChoice == "2")
                {
                    TKTOGGST();
                }
            }
            else
            {
                // If no choice is entered, default to GGSTTOTK
                MessageBox.Show("No choice entered. Defaulting to GGSTTOTK.");
                GGSTTOTK();
            }
        }

        // Method to handle GGST to TEKKEN conversion
        private void GGSTTOTK()
        {
            try
            {
                // Show an input box to get a phrase from the user
                string userEnteredPhrase = Interaction.InputBox("Enter a phrase:", "User Input", "");

                // Check if the user entered a phrase
                if (!string.IsNullOrEmpty(userEnteredPhrase))
                {
                    // Replace various inputs with corresponding TEKKEN inputs
                    userEnteredPhrase = userEnteredPhrase.Replace("214", "QCB");
                    userEnteredPhrase = userEnteredPhrase.Replace("236", "QCF");
                    userEnteredPhrase = userEnteredPhrase.Replace("2", "D");
                    userEnteredPhrase = userEnteredPhrase.Replace("6", "F");
                    userEnteredPhrase = userEnteredPhrase.Replace("4", "B");
                    userEnteredPhrase = userEnteredPhrase.Replace("42", "DB");
                    userEnteredPhrase = userEnteredPhrase.Replace("26", "DF");
                    userEnteredPhrase = userEnteredPhrase.Replace("41236", "HCF");

                    // Create a Label control
                    Label label1 = new Label();
                    
                    // Set properties for the label
                    label1.Text = "You entered: " + userEnteredPhrase;
                    label1.AutoSize = true;
                    label1.Location = new System.Drawing.Point(LabelLocationX, LabelLocationY);

                    // Add the label to the form's Controls collection
                    this.Controls.Add(label1);
                }
                else
                {
                    // Handle the case where the user did not enter a phrase
                    MessageBox.Show("You did not enter a phrase.");
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions, e.g., if the user clicks Cancel in the InputBox
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        // Method to handle TEKKEN to GGST conversion
        private void TKTOGGST()
        {
            // Implement the logic for TEKKEN TO GGST here
            MessageBox.Show("You chose TEKKEN TO GGST.");
        }
    }
}
