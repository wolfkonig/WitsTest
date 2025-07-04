using WitsTest.Interfaces;

namespace WitsTest.ViewModels
{
    public class WelcomeViewModel : BaseViewModel, IQueryAttributable 
    {
        private readonly IWelcomeService _welcomeService;
        private string? _welcomeText;

        public string? WelcomeText
        {
            get => _welcomeText; 
            set
            {
                if(_welcomeText == value) 
                    return;

                _welcomeText = value;
                OnPropertyChanged();
            }
        }

        public WelcomeViewModel(IWelcomeService welcomeService) 
        {
            _welcomeService = welcomeService ?? throw new ArgumentNullException(nameof(welcomeService));            
        }

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            if (query.ContainsKey("name") && query["name"] is string name)
            {
                WelcomeText = _welcomeService.GetWelcomeText(name);
            }
        }
    }
}
