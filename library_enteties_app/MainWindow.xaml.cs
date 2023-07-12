using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace library_enteties_app
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            using (var context = new Entity_LibraryEntities())
            {
                var books = context.Book.ToList();
                books_grid.ItemsSource = books;

                var authors = context.Author.ToList();
                authors_grid.ItemsSource = authors;

                var publishers = context.Publisher.ToList();
                publishers_grid.ItemsSource = publishers;
            }
        }
    }
}
