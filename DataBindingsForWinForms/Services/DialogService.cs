using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingsForWinForms.Services
{
    public class DialogService : IDialogService
    {
        public void ShowDialog(string message)
        {
            MessageBox.Show(message);
        }
    }
}
