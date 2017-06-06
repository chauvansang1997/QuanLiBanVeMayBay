using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Help_Fuction
{
    /// <summary>
    /// Lớp này dùng để cập nhật giao diện khi đang trong tiến trình khác 
    /// </summary>
    public static class CrossThreadExtensions
    {
        public static void PerformSafely(this Control target, Action action)
        {
            if (target.InvokeRequired)
            {
                target.Invoke(action);
            }
            else
            {
                action();
            }
        }
    }
}
