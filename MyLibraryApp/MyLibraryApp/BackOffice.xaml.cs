﻿using LibraryLib.Data;
using LibraryLib.Domain.Models;
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
using System.Windows.Shapes;

namespace MyLibraryApp
{
    /// <summary>
    /// Interaction logic for BackOffice.xaml
    /// </summary>
    public partial class BackOffice : Window
    {
        LibraryContext context = null;
        public BackOffice(LibraryContext ctx)
        {
            InitializeComponent();
            context = ctx;

            DataContext = context;
        }

        private void btnDeleteBook_Click(object sender, RoutedEventArgs e)
        {
            if (lstAllBooks.SelectedItem != null)
            {
            context.DeleteBook((Book)lstAllBooks.SelectedItem);

            }
        }

        private void btnAddBook_Click(object sender, RoutedEventArgs e)
        {
            if (txtBookName != null || cmbAuthors.SelectedItem != null || cmbPublishers.SelectedItem != null || cmbCategories.SelectedItem != null)
            {
                bool res = context.CreateBook
                    (
                    txtBookName.Text,
                    (Publisher)cmbPublishers.SelectedItem,
                    new List<Author> { (Author)cmbAuthors.SelectedItem },
                    new List<Category> { (Category)cmbCategories.SelectedItem }
                    );
            }
            else
            {
                MessageBox.Show("Error ! Need more informations !");
            }
        }

    }
}
