using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddNewPage_Click(object sender, RoutedEventArgs e)
        {

        }

        private void IncrementButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DecrementButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            myLabel.Content = "Something is definately here";
        }

        private void AddFloor_Click(object sender, RoutedEventArgs e)
        {
            var tabControl = new TabItem();

            StackPanel stackpanel = new StackPanel();
            TextBlock textBlock = new TextBlock();


            textBlock.Text = $"{HouseTabControl.Items.Count + 1} Floor";

            stackpanel.Children.Add(textBlock);
            tabControl.Header = stackpanel;//new StackPanel() {Children = new TextBlock() { } };



            HouseTabControl.Items.Add(tabControl);
            UpdateRemoveButton();
        }

        private void RemoveFloor_Click(object sender, RoutedEventArgs e)
        {
            
            HouseTabControl.Items.RemoveAt(HouseTabControl.Items.Count - 1);
            UpdateRemoveButton();
           
        }

        private void UpdateRemoveButton()
        {
            if (HouseTabControl.Items.Count == 0)
            {
                RemoveFloor.IsEnabled = false;
            }
            else
            {
                RemoveFloor.IsEnabled = true;
            }
        }
    }
}
