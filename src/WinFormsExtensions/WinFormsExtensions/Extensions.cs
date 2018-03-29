using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System.Windows.Forms
{
    public static class Extensions
    {
        public static void Invoke(this Control self, Action action)
        {
            self.Invoke(action);
        }
    }
}
