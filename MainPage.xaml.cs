

namespace RestaurangApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        List<User> users = new List<User>();

        public MainPage()
        {
            InitializeComponent();

            users.Add(new User("test", "test"));
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        public void LoginClicked(object sender, EventArgs e)
        {
            string username = LoginUsername.Text;
            string password = LoginPassword.Text;

            var user = users.FirstOrDefault(u => u.TryLogin(username, password));

            if(user != null)
            {
                DisplayAlert("It worked", "woho", "ok");
            }
            else
            {
                DisplayAlert("Invalid input", "Username or password was incorrect", "OK");
            }
        }
    }

}
