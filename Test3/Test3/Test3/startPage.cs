using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Test3
{
	public class startPage : ContentPage
	{
		public startPage()
		{
            Label header = new Label() { Text = "Привет из Xamarin Forms" };
            this.Content = header;
        }
	}
}