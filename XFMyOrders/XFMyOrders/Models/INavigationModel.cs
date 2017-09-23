using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XFMyOrders.Models
{
    public interface INavigationModel
    {
        Type TargetPage { get; set; }
    }
}
