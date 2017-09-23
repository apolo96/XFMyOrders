using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace XFMyOrders.Controls
{
    class BetterListView: ListView
    {
        public BetterListView()
        {
            this.ItemTapped += OnItemTapped;
        }

        public static BindableProperty ItemClickCommandProperty = 
            BindableProperty.Create(
                nameof(ItemClickCommand), 
                typeof(ICommand), 
                typeof(BetterListView), null);

        public ICommand ItemClickCommand
        {
            get
            {
                return (ICommand)this.GetValue(ItemClickCommandProperty);
            }
            set
            {
                this.SetValue(ItemClickCommandProperty, value);
            }
        }
        
        private void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null)
            {
                ItemClickCommand?.Execute(e.Item);
                SelectedItem = null;
            }
        }
    }
}
