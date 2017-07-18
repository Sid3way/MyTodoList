using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyTodoList.ViewModels
{
    public class MyElem
    {
        private MainPageViewModel _parent;

        public string MyText { get; set; }
        public ICommand OnElemButtonClickedCommand { get; set; }

        public MyElem(string content, MainPageViewModel parent)
        {
            _parent = parent;
            MyText = content;
            OnElemButtonClickedCommand = new BaseCommand(ElemClicked);
        }

        private void ElemClicked(object elemClicked)
        {
            _parent.ElemClicked(this);
        }

    }
}
