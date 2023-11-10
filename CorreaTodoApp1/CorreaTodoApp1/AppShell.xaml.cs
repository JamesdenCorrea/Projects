using CorreaTodoApp1.Views;

namespace CorreaTodoApp1;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new NavigationPage(new TodoListPage())
        {
            BarTextColor = Color.FromRgb(255, 255, 255)
        };
    }
}