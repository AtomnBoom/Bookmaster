using Bookmaster.View.Pages;
using Bookmaster.View.Window;
using System.Windows;

namespace Bookmaster
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LogoutMi.Visibility = Visibility.Collapsed;
            LibraryMi.Visibility = Visibility.Collapsed;
        }

        private void LoginMi_Click(object sender, RoutedEventArgs e)
        {
            // Для реализации оконной навигации нужно:
            // 1) Создать экземпляр окна, которое требуется открыть
            LoginWindow loginWindow = new LoginWindow();

            //2) У экземпляра окна вызвать метод или ShowDialog();
            loginWindow.ShowDialog();
        }

        private void LogoutMi_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CloseMi_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BrowseCatalogMi_Click(object sender, RoutedEventArgs e)
        {
            // Для реализации страничной навигации нужно:
            // 1) Обратиться к элементу Frame по имени и вызываем метод Navigate()
            // 2) В качестве аргумента передйём в метод экземпляр страницы, которую нужно открыть.
            MainFrame.Navigate(new BrowseCatalogPage());
        }

        private void ManagerCustomersMi_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ManageCustomersPage());

        }

        private void CirculationMi_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new CirculationPage());
        }

        private void Reportsmi_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ReportsPage());
        }
    }
}
