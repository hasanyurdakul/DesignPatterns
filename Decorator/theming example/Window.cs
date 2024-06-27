using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class Window
    {
        private string _title;

        protected string Title
        {
            get => _title;
            set => _title = value;
        }

        protected Window()
        {
            _title = " ";
        }

        public Window(string title)
        {
            _title = title;
        }

        public abstract void Render();
    }
}
