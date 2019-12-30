using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opdracht3.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Opdracht3.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NewPlacePage : ContentPage
	{
		public NewPlacePage ()
		{
			InitializeComponent ();
            BindingContext = new NewPlaceViewModel();
		}
	}
}