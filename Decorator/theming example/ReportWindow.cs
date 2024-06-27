using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class ReportWindow : Window
    {
        public ReportWindow()
        {
            
        }

        public ReportWindow(string title) : base(title)
        {

        }

        public override void Render()
        {
            Console.WriteLine($"Rendering report window with title: {Title}");
        }
    }
}
