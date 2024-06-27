using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class JPEGHandler : BaseHandler
    {
        public override void HandleRequest(Image image)
        {
            if(image.Extension == "JPEG")
            {
                Console.WriteLine("JPEG Handler is handling the request.");
            }
            else
            {
                _nextHandler.HandleRequest(image);
            }
        }
    }
}
