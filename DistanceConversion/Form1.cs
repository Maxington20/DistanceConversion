using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistanceConversion
{
	public partial class Form1 : Form
	{
		List<string> _source = new List<string>();
		List<string> _target = new List<string>();
		public Form1()
		{
			InitializeComponent();

			//assign the values for the _source list string
			_source.Add("Yards");
			_source.Add("Feet");
			_source.Add("Inches");

			//assign the values for the _target list string
			_target.Add("Yards");
			_target.Add("Feet");
			_target.Add("Inches");

			//set the options for each listbox
			SourceListBox.DataSource = _source;
			TargetListbox.DataSource = _target;
		}

		//code that allows the convert button to display the target distance
		private void Convert_Click(object sender, EventArgs e)
		{
			//we want the user input to be a double
			var inputAsNumber = Convert.ToDouble(InputTextbox.Text);

			//the user picks yards as a source unit of measure
			if (SourceListBox.SelectedItem.ToString() == "Yards")
			{
				//the user picks yards as the target unit of measure
				if (TargetListbox.SelectedItem.ToString() == "Yards")
				{
					AnswerTextbox.Text = InputTextbox.Text;
					
				}
				//the user picks feet as the target unit of measure
				else if (TargetListbox.SelectedItem.ToString() == "Feet")
				{
					//make the calculation and convert the double back to a string
					var conversion = inputAsNumber * 3;
					
					AnswerTextbox.Text = Convert.ToString(conversion);
				}
				//the user picks inches as the target unit of measure
				else 
				{
					//make the calculation and convert the double back to a string
					var conversion = inputAsNumber * 36;
					
					AnswerTextbox.Text = Convert.ToString(conversion);
				}
			}
			//the user picks feet as the source unit of measure
			else if (SourceListBox.SelectedItem.ToString() == "Feet")
			{
				//the user picks feet as the target unit of measure
				if (TargetListbox.SelectedItem.ToString() == "Feet")
				{
					AnswerTextbox.Text = InputTextbox.Text;
					
				}
				//the user picks yards as the target unit of measure
				else if (TargetListbox.SelectedItem.ToString() == "Yards")
				{
					//make the calculation and convert the double back to a string
					var conversion = inputAsNumber / 3;
					
					AnswerTextbox.Text = Convert.ToString(conversion);
				}
				//the user picks inches as the target unit of measure
				else
				{
					//make the calculation and convert the double back to a string
					var conversion = inputAsNumber * 12;
					
					AnswerTextbox.Text = Convert.ToString(conversion);
				}
			}
			//the user picks inches as the source unit of measure
			else 
			{
				//the user picks inches as the target unit of measure
				if (TargetListbox.SelectedItem.ToString() == "Inches")
				{
					AnswerTextbox.Text = InputTextbox.Text;
					
				}
				//the user picks feet as the target unit of measure
				else if (TargetListbox.SelectedItem.ToString() == "Feet")
				{
					var conversion = inputAsNumber / 12;
					
					AnswerTextbox.Text = Convert.ToString(conversion);
				}
				//the user picks yards as the target unit of measure
				else
				{
					var conversion = inputAsNumber / 36;
					
					AnswerTextbox.Text = Convert.ToString(conversion);

					//the below will change the background of the convert button when
						//the above condidtions are true
					//this.ConvertButton.BackColor = System.Drawing.Color.DarkBlue;
				}
			}
		}

		//only allow numbers to be entered into the input textbox
		private void InputTextbox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
				(e.KeyChar != '.'))
			{
				e.Handled = true;
				//display a message when user tries to enter a non numeric value
				MessageBox.Show("Only numbers are permitted");
			}

			//only allow one decimal to be used within the input textbox
			if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
			{
				e.Handled = true;
				//display a message when the user tries to enter more than one decimal
				MessageBox.Show("Only one decimal is permitted");
			}
		
			//enable the clear button and convert button
			ConvertButton.Enabled = true;
		}

		

		//The code that allows the user to exit by clicking the Exit button
		private void exitBox_Click(object sender, EventArgs e)
		{
			//Environment.Exit(0);
			Close();
		}

		private void SourceListBox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
