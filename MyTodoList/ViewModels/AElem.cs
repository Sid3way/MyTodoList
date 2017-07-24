using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTodoList.ViewModels
{
    public abstract class AElem : ViewModelBase, IElem
    {
        protected bool _isChecked;
        protected string _text;

        public bool IsChecked
        {
            get
            {
                return _isChecked;
            }

            set
            {
                if (_isChecked != value)
                    _isChecked = value;
            }
        }

        public string Text
        {
            get
            {
                return _text;
            }

            set
            {
                _text = value;
            }
        }
    }
}
