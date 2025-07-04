using WitsTest.Interfaces;

namespace WitsTest.Platforms
{
    public class WelcomeService : IWelcomeService
    {
        public string GetWelcomeText(string name)
        {
            return $"Hello {name} from Android!";
        }
    }
}
