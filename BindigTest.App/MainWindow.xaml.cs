using System.Windows;
using BindigTest.Lib;

namespace BindigTest.App
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