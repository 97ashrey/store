using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Events.Messages;

namespace UI.Helpers
{
    public static class Extensions
    {
        public static MessageBoxIcon AlertToMessageBox(AlertMessage.MessageType type)
        {
            switch (type)
            {
                case AlertMessage.MessageType.Error:
                    return MessageBoxIcon.Error;
                case AlertMessage.MessageType.Success:
                    return MessageBoxIcon.Information;
                default:
                    return MessageBoxIcon.Warning;
            }
        }
    }
}
