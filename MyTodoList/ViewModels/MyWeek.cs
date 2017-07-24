using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyTodoList.ViewModels
{
    public class MyWeek : ViewModelBase
    {
        public DateTime WeekStart { get; set; }
        public ObservableCollection<MyElem> Tasks {get; set;}
        public ICommand OnAddButtonCommand { get; set; }


        public MyWeek()
        {
            Tasks = new ObservableCollection<MyElem>
                {
                    new MyElem("1", this),
                    new MyElem("2", this),
                    new MyElem("3", this),
                    new MyElem("4", this),
                    new MyElem("5", this),
                    new MyElem("6", this),
                };
            OnAddButtonCommand = new BaseCommand(AddElem);
        }

        public void AddElem(object parameter)
        {
            Tasks.Add(new MyElem("42", this));
        }
        internal void ElemClicked(MyElem elemClicked)
        {

        }

    }
}
