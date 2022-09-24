using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Readed_Book_Lister.Helpers
{
    public class DisableAcceptOrCancelButtonFrames
    {
        public static void DisableUnvantedFrames(params Button[] buttons)
        {
            foreach (var button in buttons)
            {
                button.NotifyDefault(false);
            }

        }
    }
}
