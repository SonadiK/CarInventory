// Author:  Sonadi Kannangara
// Date:    March 14, 2021
// Type: Lab 4
// Description: Using an existing Car class, this windows form allows the user to add new cars to the list as well as edit existing cars
//  selected from a ListView.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarInventory
{
    public partial class formCarInventory : Form
    {
        private List<Car> carList = new List<Car>();
        private bool isAutomated = false;
        private int selectedIndex = -1;
        public formCarInventory()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Me close form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExitClick(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Reset the form to its default state.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonResetClick(object sender, EventArgs e)
        {
            SetDefaults();
        }

        /// <summary>
        /// Validate the input fields, and if they are valid create the car object, add the entered car to the list, and add them to the ListView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEnterClick(object sender, EventArgs e)
        {
            // Empty the error label.
            labelError.Text = String.Empty;

            // check the car is valid.
            if (IsCarValid(comboBoxMake.Text, textBoxModel.Text, Convert.ToInt16(numericUpDownYear.Text), textBoxPrice.SelectionLength))
            {
                // Car details are valid; create a car object.
                Car newCarToAdd = new Car(comboBoxMake.Text, textBoxModel.Text, Convert.ToInt16(numericUpDownYear.Text), Convert.ToDecimal(textBoxPrice.Text), checkBoxNew.Checked);

                // If a car is currently selected...
                if (selectedIndex >= 0)
                {
                    // Replace the old version of that car with the new one!
                    carList[selectedIndex] = newCarToAdd;
                }
                else
                {
                    // Otherwise, add a car with the entered details to the end of the list.
                    carList.Add(newCarToAdd);
                }

                // Refresh the entire listView.
                PopulateListView(carList);


                // Reset the form to allow new entries.
                SetDefaults();
            }
        }

        /// <summary>
        /// When a car in the ListView is selected, write that car's properties into the input controls.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CarSelected(object sender, EventArgs e)
        {
            // If the list is populated and something is selected.
            if (listViewEntries.Items.Count > 0 && listViewEntries.FocusedItem != null)
            {
                // ...fill in the entry fields with values based on the selected car.
                comboBoxMake.Text = listViewEntries.FocusedItem.SubItems[2].Text;
                textBoxModel.Text = listViewEntries.FocusedItem.SubItems[3].Text;
                numericUpDownYear.Text = listViewEntries.FocusedItem.SubItems[4].Text;
                textBoxPrice.Text = listViewEntries.FocusedItem.SubItems[5].Text;
                checkBoxNew.Checked = listViewEntries.FocusedItem.Checked;

                // Set the selectedIndex to match the listView.
                selectedIndex = listViewEntries.FocusedItem.Index;
            }
            else
            {
                // If nothing is selected, set the selectedIndex to -1.
                selectedIndex = -1;
            }
        }


        /// <summary>
        /// When a checkbox in the ListView is checked, say no and don't let the user change it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PreventCheck(object sender, ItemCheckEventArgs e)
        {
            // Only prevent checking if it's being done by the user.
            if (!isAutomated)
            {
                // Change the new value of the checkbox equal to the old state of the checkbox.
                e.NewValue = e.CurrentValue;
            }
        }

        /// <summary>
        /// Converts the car passed in to a ListViewItem and adds it to listViewEntries
        /// </summary>
        /// <param name="carList"></param>
        private void PopulateListView(List<Car> carList)
        {
            // Clear the listView to start re-populating it.
            listViewEntries.Items.Clear();

            foreach (Car newCar in carList)
            {
                // Declare and instantiate a new ListViewItem.
                ListViewItem carItem = new ListViewItem();

                // Allow the program to modify the ListView's checkboxes.
                isAutomated = true;

                carItem.Checked = newCar.Status;
                carItem.SubItems.Add(newCar.Id.ToString());
                carItem.SubItems.Add(newCar.Make);
                carItem.SubItems.Add(newCar.Model);
                carItem.SubItems.Add(newCar.Year.ToString());
                carItem.SubItems.Add(newCar.Price.ToString("#,0.00"));

                // Add the carItem to the ListView.
                listViewEntries.Items.Add(carItem);

                // Disallow the user from modifying the ListView's checkboxes.
                isAutomated = false;

            }
        }

        /// <summary>
        /// Reset the form's input fields to their default states.
        /// </summary>
        private void SetDefaults()
        {
            // Resets fields to default state.
            comboBoxMake.SelectedIndex = -1;
            textBoxModel.Clear();
            numericUpDownYear.Text = String.Empty;
            textBoxPrice.Clear();
            checkBoxNew.Checked = false;
            listViewEntries.SelectedItems.Clear();
            labelError.Text = String.Empty;
            selectedIndex = -1;

            // Set a default focus.
            comboBoxMake.Focus();

        }

        /// <summary>
        /// Checks the input related to a car is valid.
        /// </summary>
        /// <param name="make">The cars's make as a string</param>
        /// <param name="model">The car's model as a string</param>
        /// <param name="year">The year of the car as an int</param>
        /// <param name="price">The price of the car as a decimal</param>
        /// <returns></returns>
        private bool IsCarValid(string make, string model, int year, decimal price)
        {
            // Assume the car is valid.
            bool isValid = true;

            // Check the make input.
            if (make == String.Empty)
            {
                // If it's not valid, set isValid = false.
                isValid &= false;
                // Display an error message.
                labelError.Text += "You must select a make.\n";
            }

            // Check the model input.
            if (model == String.Empty)
            {
                // If it's not valid, set isValid = false.
                isValid &= false;
                // Display an error message.
                labelError.Text += "You must enter a model.\n";
            }

            // Check the price input.
            if (decimal. TryParse(textBoxPrice.Text , out price))
            {
                // if price is less than 0..
                if(price <=0)
                {
                    // If it's not valid, set isValid = false.
                    isValid &= false;
                    // Display an error message.
                    labelError.Text += "You must enter the price greater than 0.\n";
                }
                
            }
            else
            {
                // If it's not valid, set isValid = false.
                isValid &= false;
                // Display an error message.
                labelError.Text += "You must enter the price as a numbers.\n";
            }

            return isValid;
            
        }

    }
}
