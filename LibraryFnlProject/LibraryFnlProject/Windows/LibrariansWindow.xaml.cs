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
    /// Interaction logic for LibrariansWindow.xaml
    /// </summary>
    public partial class LibrariansWindow : Window
    {
        private readonly LibraryContext _context;
        private Librarian _selectedLibrarian;
        public LibrariansWindow()
        {
            InitializeComponent();
            _context = new LibraryContext();
            FillLibrarian();
        }
        private void Reset()
        {
            TxtLibrarianFullname.Clear();
            TxtLibrarianUsername.Clear();
            TxtLibrarianPassword.Clear();
            BtnAddLibrarian.Visibility = Visibility.Visible;
            BtnDeleteLibrarian.Visibility = Visibility.Hidden;
            BtnUpdateLibrarian.Visibility = Visibility.Hidden;
            FillLibrarian();

        }
        public bool FormValidation()
        {
            bool HasError = false;
            if (string.IsNullOrEmpty(TxtLibrarianFullname.Text))
            {
                LblLibrarianFullname.Foreground = new SolidColorBrush(Colors.Red);
                HasError = true;
            }
            else { LblLibrarianFullname.Foreground = new SolidColorBrush(Colors.Black); }
            if (string.IsNullOrEmpty(TxtLibrarianUsername.Text))
            {
                LblLibrarianUsername.Foreground = new SolidColorBrush(Colors.Red);
                HasError = true;
            }
            else { LblLibrarianUsername.Foreground = new SolidColorBrush(Colors.Black); }
            if (string.IsNullOrEmpty(TxtLibrarianPassword.Text))
            {
                LblLibrarianPassword.Foreground = new SolidColorBrush(Colors.Red);
                HasError = true;
            }
            else { LblLibrarianPassword.Foreground = new SolidColorBrush(Colors.Black); }

            return HasError;

        }

        private void BtnAddLibrarian_Click(object sender, RoutedEventArgs e)
        {
            if (FormValidation())
            {
                MessageBox.Show("Fill the blanks");
            }
            Librarian librarian = new Librarian
            {
                FullName = TxtLibrarianFullname.Text,
                UserName=TxtLibrarianUsername.Text,
                Password=TxtLibrarianPassword.Text

            };
            _context.Librarians.Add(librarian);
            _context.SaveChanges();
            Reset();
            MessageBox.Show("Librarian added");

        }
        public void FillLibrarian()
        {
            DgvLibrarian.ItemsSource = _context.Librarians.ToList();
        }

        private void DgvLibrarian_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DgvLibrarian.SelectedItem == null) return;
            _selectedLibrarian = (Librarian)DgvLibrarian.SelectedItem;
            TxtLibrarianFullname.Text = _selectedLibrarian.FullName;
            TxtLibrarianUsername.Text = _selectedLibrarian.UserName;
            TxtLibrarianPassword.Text = _selectedLibrarian.Password;
            BtnAddLibrarian.Visibility = Visibility.Hidden;
            BtnDeleteLibrarian.Visibility = Visibility.Visible;
            BtnUpdateLibrarian.Visibility = Visibility.Visible;
        }

        private void BtnUpdateLibrarian_Click(object sender, RoutedEventArgs e)
        {
            if (FormValidation())
            {
                MessageBox.Show("Fill the blanks");
            }

            _selectedLibrarian.FullName = TxtLibrarianFullname.Text;
            _selectedLibrarian.UserName = TxtLibrarianUsername.Text;
            _selectedLibrarian.Password = TxtLibrarianPassword.Text;

            
           
            _context.SaveChanges();
            Reset();
            MessageBox.Show("Librarian updated");


        }

        private void BtnDeleteLibrarian_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult r = MessageBox.Show("Librarian will be deleted", _selectedLibrarian.FullName.ToString(),MessageBoxButton.OKCancel);
            if (r==MessageBoxResult.OK)
            {
                _context.Librarians.Remove(_selectedLibrarian);
                _context.SaveChanges();
                Reset();
                MessageBox.Show("User deleted");
            }
        }
    }

}
