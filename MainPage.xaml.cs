using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace u1_02_nameOutput
{
	public partial class MainPage : ContentPage
	{
        bool ranonce = false;
		public MainPage()
		{
			InitializeComponent();
            
		}

        public void sliderChanged(Object sender, EventArgs e)
        {

            sliderOutput.Text = sliderNumber.Value.ToString();
        }

        private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            stepperOutput.Text = stepperNumber.Value.ToString();
        }

        private void switchTF_Toggled(object sender, ToggledEventArgs e)
        {
            switchOutput.Text = switchTF.IsToggled.ToString();
        }

        private void entryInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            entryOutput.Text = entryInput.Text;
        }

        private void editorInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            editorOutput.Text = editorInput.Text;
        }

        private void searchInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            searchOutput.Text = searchInput.Text;
        }

        private void datePickerInput_DateSelected(object sender, DateChangedEventArgs e)
        {
            datePickerOutput.Text = datePickerInput.Date.ToString();
        }

        private void timePickerInput_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Time")
            {
                timePickerOutput.Text = timePickerInput.Time.ToString();
            }
        }

        private void btnChangeImage_Clicked(object sender, EventArgs e)
        {
            imageOutput.Source = new UriImageSource
            {
                Uri = new Uri(@"https://mrmctavish.files.wordpress.com/2017/06/mctlogo.png?w=125")
            };
        }
    }
}
