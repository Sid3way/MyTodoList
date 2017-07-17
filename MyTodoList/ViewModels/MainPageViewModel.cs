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
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private string _title = "My base title";
        private string _modifiedTitle;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public ObservableCollection<string> TodoElems { get; set; }

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
                    RaisePropertyChanged("Title");
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

        public ICommand OnAddButtonCommand { get; set; }
        public ICommand OnModifyTitleButtonCommand { get; set; }
        

        public MainPageViewModel()
        {
            _modifiedTitle = "Entrez le nouveau titre ici";
            TodoElems = new ObservableCollection<string>
                {
                    "1",
                    "2",
                    "3",
                    "4",
                    "5",
                    "6",
                };
            OnAddButtonCommand = new BaseCommand(AddElem);
            OnModifyTitleButtonCommand = new BaseCommand(ChangeTitle);
        }

        private void ChangeTitle(object obj)
        {
            Title = ModifiedTitle;
        }

        public void AddElem(object parameter)
        {
            TodoElems.Add("42");
        }

    }
}