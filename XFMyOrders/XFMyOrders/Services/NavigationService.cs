using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XFMyOrders.Models;

namespace XFMyOrders.Services
{
    public class NavigationService
    {
        public static void goToPage(Object item, bool existParams = false)
        {
            var objData = item as INavigationModel;
            if (objData != null)
            {
                Type targetPage = objData.TargetPage;
                NavigationPage page;
                if (existParams)
                {
                    page = new NavigationPage
                    (
                        (Page)Activator.CreateInstance(targetPage, objData)
                    );
                }
                else
                {
                    page = new NavigationPage
                    (
                        (Page)Activator.CreateInstance(targetPage)
                    );
                }
                page.BarBackgroundColor = Color.FromHex("#1565c0");
                App.Master.Detail = page;
                App.Master.IsPresented = false;
            }
        }
    }
}
