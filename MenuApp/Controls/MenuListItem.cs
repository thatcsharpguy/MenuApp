using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuApp.Controls
{
    public class MenuListItem
    {
        public string Title { get; set; }
        public string Icon { get; set; }
        public Type Page { get; set; }
    }
}
