using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class ThemeDecorator : WindowDecorator
    {
        public ThemeDecorator(Window window, string title) : base(window, title)
        {
        }

        public override void Render()
        {
            TargetWindow.Render();
        }

        public void SetTheme(string name)
        {
            Console.WriteLine($"Setting theme: {name}");
            Render();
        }


    }
}
