using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class CustomHandler : BaseHandler
    {
        public override void HandleRequest(Image image)
        {
            if (image.Extension == "Other")
            {
                Console.WriteLine("Custom Handler is handling the request");
            }
            else if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(image);
            }
        }
    }
}
