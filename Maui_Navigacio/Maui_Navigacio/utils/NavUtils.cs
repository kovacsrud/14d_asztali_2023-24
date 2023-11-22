using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maui_Navigacio.utils
{
    public static class NavUtils
    {
        public static void Vizsgal(INavigation navigation)
        {
            StringBuilder builder = new StringBuilder();
            foreach (var page in navigation.NavigationStack)
            {
                builder.AppendLine(page.GetType().Name);
            }
            builder.AppendLine("---------------------");
            Debug.WriteLine(builder.ToString());
        }
    }
}
