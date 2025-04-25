using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Task4_VisualApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

       private void buttonGreet_Click(object sender, RoutedEventArgs e)
        {
            string name = textBoxName?.Text ?? "";
            labelGreeting.Text = "Hello, " + name + "!";
        }
    }
}