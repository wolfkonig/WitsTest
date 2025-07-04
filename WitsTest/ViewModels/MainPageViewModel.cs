using System.Windows.Input;

namespace WitsTest.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        private string? _name;

        public ICommand NextCommand => new Command(async () => 
        { 
            if(string.IsNullOrWhiteSpace(Name))
            {
                await Shell.Current.DisplayAlert("Error", "Please enter your name first", "OK");
                return;
            }

            await Shell.Current.GoToAsync($"welcome?name={Name}");        
        });

        public string? Name
        {
            get => _name;
            set
            {
                if (_name == value) 
                    return;

                _name = value;
                OnPropertyChanged();
            }
        }
    }
}
