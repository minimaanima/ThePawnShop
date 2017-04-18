using System.Windows.Controls;

namespace Startup.SwitchingService
{
    public static class Switcher
    {
        public static MainWindow currentPage;

        public static void Switch(Page newPage)
        {
            currentPage.Navigate(newPage);
        }

        public static void Switch(Page newPage, object state)
        {
            currentPage.Navigate(newPage, state);
        }
    }
}
