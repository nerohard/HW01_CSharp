using System;
using System.Windows.Input;
using HW01.Models;
using HW01.Tools;

namespace HW01.ViewModels
{
    class InputViewModel : ObservableItem
    {
        private DateTime _selectedDate = DateTime.Now;

        private ICommand _submitCommand;

        public InputModel Model { get; private set; }

        public InputViewModel(UserModel user)
        {
            Model = new InputModel(user);
        }

        public DateTime SelectedDate
        {
            get { return _selectedDate; }
            set { ChangeAndNotify(ref _selectedDate, value, () => SelectedDate); }
        }

        public ICommand SubmitCommand
        {
            get
            {
                if (_submitCommand == null) _submitCommand = new RelayCommand<object>(ExecuteInput, CanExecuteInput);
                return _submitCommand;
            }
            set { ChangeAndNotify(ref _submitCommand, value, () => SubmitCommand); }
        }

        private void ExecuteInput(object obj) { Model.Submit(SelectedDate); }
        private bool CanExecuteInput(object obj) { return true; }
    }
}
