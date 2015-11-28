using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace State
{
    public partial class Default : System.Web.UI.Page
    {
        private int counter = 0;
        protected int GetCounter()
        {
            Application.Lock();
            int result = (int)(Application["counter"] ?? 0);
            Application["counter"] = ++result;
            Application.UnLock();
            return result;
        }
    }
}