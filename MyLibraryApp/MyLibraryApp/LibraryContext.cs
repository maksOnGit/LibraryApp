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
    public class LibraryContext : INotifyPropertyChanged
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

        private ObservableCollection<Publisher> allPublishers = new ObservableCollection<Publisher>();

        public ObservableCollection<Publisher> AllPublishers
        {
            get
            {
                return this.allPublishers;
            }
            set
            {
                if (value != this.allPublishers)
                {
                    this.allPublishers = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private ObservableCollection<Author> allAuthors = new ObservableCollection<Author>();

        public ObservableCollection<Author> AllAuthors
        {
            get
            {
                return this.allAuthors;
            }
            set
            {
                if (value != this.allAuthors)
                {
                    this.allAuthors = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private ObservableCollection<Category> allCategories = new ObservableCollection<Category>();

        public ObservableCollection<Category> AllCategories
        {
            get
            {
                return this.allCategories;
            }
            set
            {
                if (value != this.allCategories)
                {
                    this.allCategories = value;
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
            GetPublishers();
            GetAuthors();
            GetCategories();
        }

        #region Methods

        public bool CreatePublisher(string name)
        {
            bool res = _publisherService.CreatePublisher(name);
            GetPublishers();
            return res;
        }

        public bool CreateBook(string bookName, Publisher publisher, List<Author> authors, List<Category> categories)
        {
            authors.RemoveAll(a => a == null);
            bool res = _booksService.CreateBook(bookName, publisher, authors, categories);
            GetBooks();
            return res;
        }
        public bool DeleteBook(Book book)
        {
     
            //_booksService.DeleteBook(book);
            bool res =_booksService.DeleteBook(book);
            GetBooks();
            return res;
        }
        public void GetCategories()
        {
            AllCategories = new ObservableCollection<Category>(_categoriesService.GetAllCategorie());
        }
        public void GetAuthors()
        {
            AllAuthors = new ObservableCollection<Author>(_authorsService.GetAllAuthors());
        }
        public void GetPublishers()
        {
            AllPublishers = new ObservableCollection<Publisher>(_publisherService.GetAllPublishers());
        }
        public void GetBooks()
        {
            Allbooks = new ObservableCollection<Book>(_booksService.GetAllBooks());
            AvailableBooks = new ObservableCollection<Book>(_booksService.GetAllAvaiableBooks());
        }

        public void GetCustomers()
        {
            Customers = new ObservableCollection<Customer>(_customersService.GetAllCustomers());
        }

        public void IssueBook(Book book)
        {
            _booksService.IssueBook(book);
            GetBooks();         
        }

        public void IssueBookById(int id)
        {
            _booksService.IssueBookById(id);
            GetBooks();
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
