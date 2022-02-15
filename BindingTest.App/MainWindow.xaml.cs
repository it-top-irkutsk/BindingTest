using System.Windows;
using BindingTest.Lib;

namespace BindingTest.App
{
    public partial class MainWindow : Window
    {
        public Person Person { get; set; }
        
        public MainWindow()
        {
            InitializeComponent();
            Person = new Person
            {
                Id = 1,
                FirstName = "Andrey",
                LastName = "Starinin"
            };
        }
    }
}