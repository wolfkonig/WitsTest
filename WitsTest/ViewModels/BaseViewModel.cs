using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WitsTest.ViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (string.IsNullOrEmpty(propertyName)) return;
            var method = PropertyChanged;
            if (method != null)
            {
                foreach (PropertyChangedEventHandler handler in method.GetInvocationList())
                {
                    handler(this, new PropertyChangedEventArgs(propertyName));
                }
            }
        }
    }
}
