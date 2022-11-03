namespace CommandFromWPF.VM
{
    internal class SecondPageVM : BaseVM
    {
        private string _Button1Text = MainModel.GetButtonText();
        public string Button1Text
        {
            get
            {
                return _Button1Text;
            }
            set
            {
                _Button1Text = value;
                OnPropertyChanged("Button1Text");
            }
        }

        private string _Button2Text = MainModel.GetButton2Text();
        public string Button2Text
        {
            get
            {
                return _Button2Text;
            }
            set
            {
                _Button2Text = value;
                OnPropertyChanged("Button2Text");
            }
        }

        private Command _Button1_Click;
        public Command Button1_Click
        {
            get
            {
                return _Button1_Click ?? (_Button1_Click = new Command(obj =>
                {
                    MainModel.ButtonClick();
                    Button1Text = MainModel.GetButtonText();
                    Button2Text = MainModel.GetButton2Text();
                }));
            }
        }

        private Command _Button2_Click;
        public Command Button2_Click
        {
            get
            {
                return _Button2_Click ?? (_Button2_Click = new Command(obj =>
                {
                    MainModel.Button2Click();
                    Button2Text = MainModel.GetButton2Text();
                }));
            }
        }
    }
}
