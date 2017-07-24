using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTodoList.ViewModels
{
    interface IElem
    {
        bool IsChecked { get; set; }

        string Text { get; set; }
    }
}
