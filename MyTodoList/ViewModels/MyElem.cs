using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyTodoList.ViewModels
{
    public class MyElem : AElem
    {
        private MyWeek _parent;

        public ObservableCollection<MySubElem> SubTasks { get; set; }

        public string MyText { get; set; }
        public ICommand OnElemButtonClickedCommand { get; set; }

        public MyElem(string content, MyWeek parent)
        {
            _parent = parent;
            SubTasks = new ObservableCollection<MySubElem>();
            MyText = content;
            OnElemButtonClickedCommand = new BaseCommand(ElemClicked);
        }

        private void ElemClicked(object elemClicked)
        {
            _parent.ElemClicked(this);
        }

    }
}
