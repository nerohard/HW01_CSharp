using System.Runtime.InteropServices;
using System.Windows.Input;
using HW01.Models;
using HW01.Tools;

namespace HW01.ViewModels
{
    class OutputViewModel : ObservableItem
    {
        public OutputModel Model { get; private set; }

        private int _age = 0;
        private string _event = "null";
        private string _zodiacSign = "null";
        private string _chineseSign = "null";

        private ICommand _returnCommand;

        public int Age
        {
            get { return _age; }
            set { ChangeAndNotify(ref _age, value, () => Age); }
        }

        public string Event
        {
            get { return _event; }
            set { ChangeAndNotify(ref _event, value, () => Event); }
        }

        public string ZodiacSign
        {
            get { return _zodiacSign; }
            set { ChangeAndNotify(ref _zodiacSign, value, () => ZodiacSign); }
        }
        public string ChineseSign
        {
            get { return _chineseSign; }
            set { ChangeAndNotify(ref _chineseSign, value, () => ChineseSign); }
        }

        public OutputViewModel(UserModel user)
        {
            Model = new OutputModel(user);
            Load();
        }

        public void Load()
        {
            Age = Model.GetAge();
            ZodiacSign = Model.GetZodiacSign();
            ChineseSign = Model.GetChineseSign();
            if (Model.IsBirthday()) Event = "Happy Birthday!";
        }

        public ICommand ReturnCommand
        {
            get
            {
                if (_returnCommand == null) _returnCommand = new RelayCommand<object>(ExecuteOutput, CanExecuteOutput);
                return _returnCommand;
            }
            set { ChangeAndNotify(ref _returnCommand, value, () => ReturnCommand); }
        }

        private void ExecuteOutput(object obj)
        {
            Model.Return();
        }

        private bool CanExecuteOutput(object obj)
        {
            return true;
        }
    }
}
