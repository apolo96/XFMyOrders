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
using XFMyOrders.Pages.MasterPages;

namespace XFMyOrders.ViewModels
{
    public class MasterViewModel
    {

        public MasterViewModel()
        {
            loadMenuItems();
        }

        public ObservableCollection<MenuItemModel> MenuItems { get; set; }

        private void loadMenuItems()
        {
            MenuItems = new ObservableCollection<MenuItemModel>();

            MenuItems.Add
            (
                new MenuItemModel()
                {
                    Title = "Menu",
                    Icon = "ic_unarchive.png",
                    TargetPage = typeof(MainPage)                    
                }
            );

            MenuItems.Add
            (
                new MenuItemModel()
                {
                    Title = "Nueva Orden",
                    Icon = "ic_unarchive.png",
                    TargetPage = typeof(NewOrder)
                }
            );

            MenuItems.Add
            (
                new MenuItemModel()
                {
                    Title = "Clientes",
                    Icon = "ic_unarchive.png",
                    TargetPage = typeof(OrdersClient)
                }
            );
        }

        public ICommand ItemClickCommand
        {
            get
            {
                return new Xamarin.Forms.Command((item) =>
                {     
                    Services.NavigationService.goToPage(item);
                });
            }
        }

    }
}
