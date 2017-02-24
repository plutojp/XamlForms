using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamlForms
{
	public partial class MainPage : ContentPage
	{

        public MainPage()
		{
			InitializeComponent();
            calcButton.Clicked += (sender, e) =>
            {
                double d = 0d;
                if (double.TryParse(priceText.Text, out d))
                {
                    totalPriceText.Text = $"{XamlForms.Calc.GetTax(d)}円";
                }
            };
        }
	}
}
