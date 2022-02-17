using System.Windows;
using BindingTest.Lib;

namespace BindingTest.App
{
    public partial class MainWindow : Window
    {
        public Person Person { get; set; }
        public MainWindow()
        {
            Person = new Person();
            
            InitializeComponent();

            Person.Id = 2;
            Person.FirstName = "Andrey";

            //DataContext = this;
        }

        private void Button_Reverse_OnClick(object sender, RoutedEventArgs e)
        {
            Output.DataContext = new Person
            {
                LastName = "Anonimus",
                Id = 34
            };
        }
    }
}