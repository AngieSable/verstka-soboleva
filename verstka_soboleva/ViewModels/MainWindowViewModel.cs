using System.Text.RegularExpressions;
using verstka_soboleva.Models;

namespace verstka_soboleva.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        public class User
        {
            public string Name { get; set; }
            public string Group { get; set; }
            public string Role { get; set; }
            public string Description { get; set; }
        }
        public User? CurrentUser => ContextData.CurrentUser;
    }
}
