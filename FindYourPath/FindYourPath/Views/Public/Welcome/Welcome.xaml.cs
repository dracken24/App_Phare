﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FindYourPath.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Welcome : ContentPage
	{
		public Welcome()
		{
			Title = "Accueil";
			Console.WriteLine("***************************** WELCOME ******************************");
			App.PrintMembers();
			InitializeComponent();
		}
	}
}