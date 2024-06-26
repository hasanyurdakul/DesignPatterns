using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class MessageBoxAdapter
    {
        private MessageBoxAdapt _messageBoxAdapt;

        public MessageBoxAdapter()
        {
            _messageBoxAdapt = new MessageBoxAdapt();
        }

        public void MessageDialog(string title, string text,Buttons buttons)
        {
            _messageBoxAdapt.alert(title, text, buttons);
        }

        internal void MessageDialog(string v)
        {
            throw new NotImplementedException();
        }
    }
}
