using System.Windows.Controls;

namespace CommandFromWPF
{
    internal class MainWindowVM : BaseVM
    {
        private Page _FramePage;
        public Page FramePage
        {
            get { return _FramePage; }
            set
            {
                _FramePage = value;
                OnPropertyChanged("FramePage");
            }
        }
        private Command _Load2Page_C;
        public Command Load2Page_C
        {
            get
            {
                return _Load2Page_C ?? (_Load2Page_C = new Command(obj =>
            {
                FramePage = MainModel.GetPage(1);
            }));
            }
        }
        private Command _LoadMainPage_C;
        public Command LoadMainPage_C
        {
            get
            {
                return _LoadMainPage_C ??
                    (_LoadMainPage_C = new Command(obj =>
                    {
                        FramePage = MainModel.GetPage(0);
                    }));
            }
        }
    }
}
