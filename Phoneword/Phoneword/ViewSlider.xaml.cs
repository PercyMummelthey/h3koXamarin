using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Phoneword
{
    public partial class ViewSlider : ContentPage
    {
        public ViewSlider()
        {
            InitializeComponent();
        }
        private void SliderElement_ValueChanged(object send, ValueChangedEventArgs e)
        {
            //Array Fibu[]{0,1,1,2,3,5,8,13,21,34,55,89};
            textResult.Text = "Value :" + (int)SliderElement.Value;
            fibunatcci.Text = "Fibo :" + 10 ;
        }

    }
}
