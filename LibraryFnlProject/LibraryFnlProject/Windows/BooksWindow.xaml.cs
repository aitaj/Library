using LibraryFnlProject.Data;
using LibraryFnlProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LibraryFnlProject.Windows
{
    /// <summary>
    /// Interaction logic for BooksWindow.xaml
    /// </summary>
    public partial class BooksWindow : Window
    {
        private Book _selectedBook;
        private readonly LibraryContext _context;
        public BooksWindow()
        {
            InitializeComponent();
            _context = new LibraryContext();
            FillCathegory();
            FillBooks();
        }
        private void FillCathegory()
        {
            CmbBookCathegory.ItemsSource = _context.BookCathegories.ToList();
        }

        public void Reset()
        {
            TxtArticle.Clear();
            CmbBookCathegory.SelectedItem = null;
            TxtBookName.Clear();
            TxtBookShelf.Clear();
            TxtPrice.Clear();
            BtnAddBook.Visibility = Visibility.Visible;
            BtnBookUpdate.Visibility = Visibility.Hidden;
            BtnBookDelete.Visibility = Visibility.Hidden;
            FillBooks();
        }

        private void FillBooks()
        {
            DgvBook.ItemsSource = _context.Books.ToList();
        }
        private void BtnAddBook_Click(object sender, RoutedEventArgs e)
        {
           
            if (FormValidation())
            {
                MessageBox.Show("Fill the blanks");
                return;
            }


            Book book = new Book
            {

                Name = TxtBookName.Text,
                Article = TxtArticle.Text,
                Price = TxtPrice.Text,
                BookCathegoryId =(int) CmbBookCathegory.SelectedValue,
                BookShelf = TxtBookShelf.Text
            };
            _context.Books.Add(book);
            _context.SaveChanges();
            Reset();
            MessageBox.Show("Book Added");
        }

        private void DgvBook_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DgvBook.SelectedItem == null) return;
            _selectedBook = (Book)DgvBook.SelectedItem;
            TxtBookName.Text = _selectedBook.Name;
            TxtArticle.Text = _selectedBook.Article;
            TxtPrice.Text = _selectedBook.Price;
            CmbBookCathegory.SelectedValue = _selectedBook.BookCathegoryId;
            TxtBookShelf.Text = _selectedBook.BookShelf;
            BtnAddBook.Visibility = Visibility.Hidden;
            BtnBookUpdate.Visibility = Visibility.Visible;
            BtnBookDelete.Visibility = Visibility.Visible;

        }
        public bool FormValidation()
        {
            bool HasError = false;
            if (string.IsNullOrEmpty(TxtBookName.Text))
            {
                LblBookName.Foreground = new SolidColorBrush(Colors.Red);
                HasError = true;
            }
            else { LblBookName.Foreground = new SolidColorBrush(Colors.Black); }
            if (string.IsNullOrEmpty(TxtArticle.Text))
            {
                LblArticle.Foreground = new SolidColorBrush(Colors.Red);
                HasError = true;
            }
            else { LblArticle.Foreground = new SolidColorBrush(Colors.Black); }
            if (string.IsNullOrEmpty(TxtPrice.Text))
            {
                LblPrice.Foreground = new SolidColorBrush(Colors.Red);
                HasError = true;
            }
            else { LblPrice.Foreground = new SolidColorBrush(Colors.Black); }
            if (CmbBookCathegory.SelectedItem == null)
            {
                LblBookCathegory.Foreground = new SolidColorBrush(Colors.Red);
                HasError = true;
            }
            else { LblBookCathegory.Foreground = new SolidColorBrush(Colors.Black); }
            if (string.IsNullOrEmpty(TxtBookShelf.Text))
            {
                LblBookShelf.Foreground = new SolidColorBrush(Colors.Red);
                HasError = true;
            }
            else { LblBookShelf.Foreground = new SolidColorBrush(Colors.Black); }
            return HasError;

        }

        private void BtnBookUpdate_Click(object sender, RoutedEventArgs e)
        {
           if (FormValidation()){
                MessageBox.Show("Fill the blanks");
                return;
            }


            _selectedBook.Name = TxtBookName.Text;
            _selectedBook.Article = TxtArticle.Text;
            _selectedBook.Price = TxtPrice.Text;
            _selectedBook.BookCathegoryId = (int)CmbBookCathegory.SelectedValue;
            _selectedBook.BookShelf = TxtBookShelf.Text;
            
          
            _context.SaveChanges();
            Reset();
            MessageBox.Show("Book updated");

        }

        private void BtnBookDelete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult r = MessageBox.Show("Selected item will be deleted", _selectedBook.Name,MessageBoxButton.OKCancel);
            if (r == MessageBoxResult.OK)
            {
                _context.Remove(_selectedBook);
                _context.SaveChanges();
                Reset();
                MessageBox.Show("Selected item deleted");
            }
        }
    }
}
