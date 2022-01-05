using CazzatePoster.Models;

namespace CazzatePoster.ViewModels
{
    class SettingsViewModel : BaseViewModel
    {
        private Settings _settings = new Settings();

        private string _userToken;
        public string UserToken
        {
            get { return _userToken; }
            set
            {
                _userToken = value;
                OnPropertyChanged();
            }
        } 

        private string _userChanelId;
        public string UserChanelId
        {
            get { return _userChanelId; }
            set
            {
                _userChanelId = value;
                OnPropertyChanged();
            }
        }

    }
}
