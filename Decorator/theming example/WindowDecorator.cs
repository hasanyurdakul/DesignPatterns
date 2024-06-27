using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class WindowDecorator : Window
    {
        private Window _targetWindow;

        public Window TargetWindow { get => _targetWindow; set => _targetWindow = value; }

        public WindowDecorator(Window window, string title)
        {
            _targetWindow = window;
            Title = title;
        }

    }
}
