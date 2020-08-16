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
    /// Interaction logic for CustomersWindow.xaml
    /// </summary>
    public partial class CustomersWindow : Window
    {
        private readonly LibraryContext _context;
        private Customer _selectedCustomer;
        public CustomersWindow()
        {
            InitializeComponent();
            _context = new LibraryContext();
            FillCustomers();
        }

        private void BtnAddCustomer_Click(object sender, RoutedEventArgs e)
        {
            if (FormValidation())
            {
                MessageBox.Show("Fill the Blanks");
                return;
            }

            Customer customer = new Customer
            {
                FullName=TxtFullname.Text,
                Fin=TxtFinCode.Text,
                Phone=TxtPhone.Text,
            };
            _context.Customers.Add(customer);
            _context.SaveChanges();
            Reset();
            MessageBox.Show("Customer added");
            

        }
        private void FillCustomers()
        {
            DgvCustomer.ItemsSource = _context.Customers.ToList();
        }
        public void Reset()
        {
            TxtFullname.Clear();
            TxtFinCode.Clear();
            TxtPhone.Clear();
            BtnAddCustomer.Visibility = Visibility.Visible;
            BtnUpdate.Visibility = Visibility.Hidden;
            BtnDelete.Visibility = Visibility.Hidden;
            FillCustomers();

        }
        public bool FormValidation()
        {
            bool HasError = false;
            if (string.IsNullOrEmpty(TxtFullname.Text))
            {
                LblFullname.Foreground = new SolidColorBrush(Colors.Red);
                HasError = true;
            }
            else { LblFinCode.Foreground = new SolidColorBrush(Colors.Black); }
            if (string.IsNullOrEmpty(TxtFinCode.Text))
            {
                LblFinCode.Foreground = new SolidColorBrush(Colors.Red);
                HasError = true;
            }
            else { LblPhone.Foreground = new SolidColorBrush(Colors.Black); }
            if (string.IsNullOrEmpty(TxtPhone.Text))
            {
                LblPhone.Foreground = new SolidColorBrush(Colors.Red);
                HasError = true;
            }
            else { LblPhone.Foreground = new SolidColorBrush(Colors.Black); }
        
            return HasError;

        }

        private void DgvCustomer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DgvCustomer.SelectedItem == null) return;
            _selectedCustomer = (Customer)DgvCustomer.SelectedItem;
            TxtFullname.Text = _selectedCustomer.FullName;
            TxtFinCode.Text = _selectedCustomer.Fin;
            TxtPhone.Text = _selectedCustomer.Phone;
            BtnAddCustomer.Visibility = Visibility.Hidden;
            BtnUpdate.Visibility = Visibility.Visible;
            BtnDelete.Visibility = Visibility.Visible;
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (FormValidation())
            {
                MessageBox.Show("Fill the Blanks");
                return;
            }

            _selectedCustomer.FullName = TxtFullname.Text;
            _selectedCustomer.Fin = TxtFinCode.Text;
            _selectedCustomer.Phone = TxtPhone.Text;
           
           
            _context.SaveChanges();
            Reset();
            MessageBox.Show("Customer added");

        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult r = MessageBox.Show("Customer will be deleted",_selectedCustomer.FullName.ToString(),MessageBoxButton.OKCancel);
            if (r == MessageBoxResult.OK)
            {
                _context.Customers.Remove(_selectedCustomer);
                _context.SaveChanges();
                Reset();
                MessageBox.Show("Customer deleted");
            }
        }
    }
}
