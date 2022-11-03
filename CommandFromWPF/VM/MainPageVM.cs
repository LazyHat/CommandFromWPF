using System.CodeDom;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CommandFromWPF
{
    internal class MainPageVM : BaseVM
    {
        private string _ButtonText = MainModel.GetButtonText();
        public string ButtonText
        {
            get { return _ButtonText; }
            set
            {
                _ButtonText = value;
                OnPropertyChanged("ButtonText");
            }
        }

        private Command _ButtonClick_C;
        public Command ButtonClick_C
        {
            get
            {
                return _ButtonClick_C ??
                    (_ButtonClick_C = new Command(obj =>
                    {
                        MainModel.ButtonClick();
                        ButtonText = MainModel.GetButtonText();
                    }));
            }
        }
    }
}
