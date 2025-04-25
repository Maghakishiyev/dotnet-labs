using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Task5_UIContainers
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonDisplay_Click(object sender, RoutedEventArgs e)
        {
            string input = textBoxInput?.Text ?? string.Empty;
            labelOutput.Text = "You entered: " + input;
        }

        private void buttonCount_Click(object sender, RoutedEventArgs e)
        {
            string text = textBoxChar?.Text ?? string.Empty;
            labelCharCount.Text = "Character count: " + text.Length;
        }
    }
}