using LibraryLib.Domain.Interfaces;
using LibraryLib.Domain.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryApp
{
    class LibraryContext : INotifyPropertyChanged
    {

        #region Services

        private IAuthors _authorsService = null;
        private IBooks _booksService = null;
        private ICategories _categoriesService = null;
        private ICustomers _customersService = null;
        private IPublishers _publisherService = null;

        #endregion

        #region Properties

        private ObservableCollection<Book> allBooks = new ObservableCollection<Book>();

        public ObservableCollection<Book> Allbooks
        {
            get
            {
                return this.allBooks;
            }

            set
            {
                if (value != this.allBooks)
                {
                    this.allBooks = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private ObservableCollection<Book> availableBooks = new ObservableCollection<Book>();

        public ObservableCollection<Book> AvailableBooks
        {
            get
            {
                return this.availableBooks;
            }

            set
            {
                if (value != this.availableBooks)
                {
                    this.availableBooks = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private ObservableCollection<Customer> customers = new ObservableCollection<Customer>();

        public ObservableCollection<Customer> Customers
        {
            get
            {
                return this.customers;
            }

            set
            {
                if (value != this.customers)
                {
                    this.customers = value;
                    NotifyPropertyChanged();
                }
            }
        }


        #endregion
        public LibraryContext(IAuthors authorsService, IBooks booksService, ICategories categoriesService, ICustomers customersService, IPublishers publishersService)
        {
            _authorsService = authorsService;
            _booksService = booksService;
            _categoriesService = categoriesService;
            _customersService = customersService;
            _publisherService = publishersService;

            GetBooks();
            GetCustomers();
        }

        #region Methods

        public void GetBooks()
        {
            Allbooks = new ObservableCollection<Book>(_booksService.GetAllBooks());
            AvailableBooks = new ObservableCollection<Book>(_booksService.GetAllAvaiableBooks());
        }

        public void GetCustomers()
        {
            Customers = new ObservableCollection<Customer>(_customersService.GetAllCustomers());
        }
        #endregion

        // Interface implementation
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
