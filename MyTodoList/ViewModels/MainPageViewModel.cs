using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyTodoList.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private string _title = "My base title";
        private string _modifiedTitle;

        private  Dictionary<int, MyWeek> _weeks;

        public MyWeek CurrentWeek { get; set; }

        public DateTimeOffset SelectedDate { get; set; }

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _title = value;
                    RaisePropertyChanged(nameof(Title));
                }
            }
        }

        public string ModifiedTitle
        {
            get
            {
                return _modifiedTitle;
            }
            set
            {
                _modifiedTitle = value;
            }
        }
        public ICommand OnModifyTitleButtonCommand { get; set; }



        public MainPageViewModel()
        {
            _modifiedTitle = "Entrez le nouveau titre ici";
            OnModifyTitleButtonCommand = new BaseCommand(ChangeTitle);
            SelectedDate = DateTimeOffset.Now;
            CurrentWeek = new MyWeek();
        }

        private void ChangeTitle(object obj)
        {
            Title = ModifiedTitle;
        }

    }
}