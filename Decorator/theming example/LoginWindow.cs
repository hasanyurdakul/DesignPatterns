using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class LoginWindow : Window
    {
        public LoginWindow()
        {
            
        }

        public LoginWindow(string title) : base(title)
        {

        }

        public override void Render()
        {
            Console.WriteLine($"Rendering login window with title: {Title}");
        }
    }
}
