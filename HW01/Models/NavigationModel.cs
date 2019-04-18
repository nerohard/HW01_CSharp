using System;
using HW01.Views;
using HW01.Windows;

namespace HW01.Models
{

    public enum DataHandlers
    {
        Input,
        Output
    }

    class NavigationModel
    {
        private MainWindow _mainWindow;
        private InputView _inputView;
        private OutputView _outputView;


        public NavigationModel(MainWindow mainWindow, UserModel user)
        {
            _mainWindow = mainWindow;
            _inputView = new InputView(user);
            _outputView = new OutputView(user);
        }

        public void Navigate(DataHandlers handler)
        {
            switch (handler)
            {
                case DataHandlers.Input:
                    _mainWindow.ContentControl.Content = _inputView;
                    break;
                case DataHandlers.Output:
                    _mainWindow.ContentControl.Content = _outputView;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(handler), handler, null);
            }
        }

        public void LoadData(UserModel user)
        {
            _outputView = new OutputView(user);
        }
    }
}
