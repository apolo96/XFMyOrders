using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XFMyOrders.Models;
using XFMyOrders.Pages;
using XFMyOrders.Services;

namespace XFMyOrders.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<OrderModel> Orders { get; set; }

        public MainViewModel()
        {
            Orders = new ObservableCollection<OrderModel>();
            Orders.Add(
                new OrderModel()
                {
                    Title = "LorenPixel",
                    Image = "icon.png",
                    Detail = "Lorem imsup therte are you and ok",
                    TargetPage = typeof(OrderDetailPage),                
                }
            );
            Orders.Add(
                new OrderModel()
                {
                    Title = "LorenPixel",
                    Image = "icon.png",
                    Detail = "Lorem imsup therte are you and ok",
                    TargetPage = typeof(OrderDetailPage)
                }
            );
            Orders.Add(
                new OrderModel()
                {
                    Title = "LorenPixel",
                    Image = "icon.png",
                    Detail = "Lorem imsup therte are you and ok",
                    TargetPage = typeof(OrderDetailPage)
                }
            );
            Orders.Add(
                new OrderModel()
                {
                    Title = "LorenPixel",
                    Image = "icon.png",
                    Detail = "Lorem imsup therte are you and ok",
                    TargetPage = typeof(OrderDetailPage)
                }
            );
            Orders.Add(
                new OrderModel()
                {
                    Title = "LorenPixel",
                    Image = "icon.png",
                    Detail = "Lorem imsup therte are you and ok",
                    TargetPage = typeof(OrderDetailPage)
                }
            );
            Orders.Add(
                new OrderModel()
                {
                    Title = "LorenPixel",
                    Image = "icon.png",
                    Detail = "Lorem imsup therte are you and ok",
                    TargetPage = typeof(OrderDetailPage)
                }
            );
            Orders.Add(
                new OrderModel()
                {
                    Title = "LorenPixel",
                    Image = "icon.png",
                    Detail = "Lorem imsup therte are you and ok",
                    TargetPage = typeof(OrderDetailPage)
                }
            );
            Orders.Add(
                new OrderModel()
                {
                    Title = "LorenPixel",
                    Image = "icon.png",
                    Detail = "Lorem imsup therte are you and ok",
                    TargetPage = typeof(OrderDetailPage)
                }
            );
            Orders.Add(
                new OrderModel()
                {
                    Title = "LorenPixel",
                    Image = "icon.png",
                    Detail = "Lorem imsup therte are you and ok",
                    TargetPage = typeof(OrderDetailPage)
                }
            );
            Orders.Add(
                new OrderModel()
                {
                    Title = "LorenPixel",
                    Image = "icon.png",
                    Detail = "Lorem imsup therte are you and ok",
                    TargetPage = typeof(OrderDetailPage)
                }
            );
        }

        public ICommand ItemClickCommand
        {
            get
            {
                return new Xamarin.Forms.Command((item) =>
                {                   
                    NavigationService.goToPage(item,true);
                });
            }
        }
    }
}
