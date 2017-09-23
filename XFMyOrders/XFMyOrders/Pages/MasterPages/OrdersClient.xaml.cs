using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFMyOrders.Pages.MasterPages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class OrdersClient : ContentPage
	{
		public OrdersClient ()
		{
			InitializeComponent ();
		}
	}
}