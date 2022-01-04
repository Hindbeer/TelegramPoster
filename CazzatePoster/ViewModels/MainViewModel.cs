using System.Windows.Input;
using CazzatePoster.Models;
using CazzatePoster.Views;

namespace CazzatePoster.ViewModels
{
    class MainViewModel : BaseViewModel
    {
        private BotModel _botModel = new BotModel();
        private Settings _settings = new Settings();
        
        private string _postText = "";
        public string PostText
        {
            get { return _postText; } 
            set 
            { 
                _postText = value;
                OnPropertyChanged();
            }
        }

        public ICommand SendPost
        {
            get 
            {
                return new RelayCommand((obj) => _botModel.SendMessage(text: PostText, chatId: _settings.ChanelId, token: _settings.BotToken));
            }
        }

        //public ICommand SettingsButton
        //{
        //    get
        //    {
        //        return new RelayCommand((obj) => new SettingsWindow().ShowDialog());
        //    }
        //}

    }
}
