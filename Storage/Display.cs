using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace QLyQuanAn.Storage
{
    public class Display
    {
        public static void GoFullscreen(Form form, bool fullscreen)
        {
            if (fullscreen)
            {
                form.WindowState = FormWindowState.Normal;
                form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                form.Bounds = Screen.PrimaryScreen.Bounds;
            }
            else
            {
                form.WindowState = FormWindowState.Maximized;
                form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            }
        }
    }
}
