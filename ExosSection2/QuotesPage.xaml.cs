using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ExosSection2
{
	public partial class QuotesPage : ContentPage
	{
		int i = 0;
		string[] quotes = {
				"You can't blame gravity for falling in love.",
				"Life is like riding a bicycle. To keep your balance, you must keep moving.",
				"Look deep into nature, and then you will understabd everything better."
			};

		public QuotesPage()
		{
			InitializeComponent();
			labelQuotes.Text = quotes[i];
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			i = i + 1;
			if (i == quotes.Length)
			{
				i = 0;
			}
			labelQuotes.Text = quotes[i];
		}

		void Handle_ValueChanged(object sender, Xamarin.Forms.ValueChangedEventArgs e)
		{
			labelFont.Text = String.Format("Font Size: {0:F0}", e.NewValue);
		}
	}
}
