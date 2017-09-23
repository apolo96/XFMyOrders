using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XFMyOrders.Models
{
    public class MenuItemModel: INavigationModel
    {
        public string Title { get; set; }
        public string Icon { get; set; }
        public Type TargetPage { get; set; }
    }
}
