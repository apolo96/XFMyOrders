using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFMyOrders.Models
{
    public class OrderModel: INavigationModel
    {
        public string Title { get; set; }

        public string Image { get; set; }

        public string Detail { get; set; }

        public Type TargetPage { get; set; }
    }
}
