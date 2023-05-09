using System;
using System.Collections.Generic;
using System.Text;

namespace QLyQuanAn.Storage
{
    public static class Events
    {
        private static event EventHandler _UpdateTable;
        public static event EventHandler UpdateTable
        {
            add { _UpdateTable += value; }
            remove { _UpdateTable -= value; }
        }
        public static void InvokeUpdateTable()
        {
            _UpdateTable?.Invoke(null, new EventArgs());
        }
    }
}