using LibraryLib.Domain.Models;
using LibraryLib.Domain.Services.Mock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyLibraryApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LibraryContext context = new LibraryContext
            (
            new MokAuthorsService(),
            new MokBooksService(),
            new MokCategoriesService(),
            new MokCustomerService(),
            new MokPublishersService()
            );

        public MainWindow()
        {
            InitializeComponent();
            DataContext = context;
        }

        private void btnIssueBook_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
