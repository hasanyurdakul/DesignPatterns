using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class MessageBoxAdapt
    {
        //Windows Form üyesi olan MessageBox özelliğini Console uygulamasında kullanabilmek için adaptör sınıfı oluşturuldu.
        [DllImport("user32.dll", EntryPoint = "MessageBox", CallingConvention = CallingConvention.Winapi)]
        public static extern int MessageBox(IntPtr hWnd, string text, string caption, uint button);
        public void alert(string title, string message, Buttons combinations)
        {
            MessageBox(new IntPtr(), message, title, (uint)combinations);
        }
    }
}
