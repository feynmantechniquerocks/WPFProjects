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

namespace WPF_Combobox___Sample_Application
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Create a new rulers list.
            List<Ruler> rulers = new List<Ruler>();

            //Populate list with new rulers' info.
            rulers.Add(new Ruler()
            {
                Name = "Alexandrina Victoria",
                reignName = "Victoria",
                House = "Hanover",
                Birth = new DateTime(1819, 5, 24),
                Death = new DateTime(1901, 1, 22),
                Image_URL = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e3/Queen_Victoria_by_Bassano.jpg/330px-Queen_Victoria_by_Bassano.jpg",
                Predecessor = "William IV",
                Successor = "Edward VII",
            });

            rulers.Add(new Ruler()
            {
                Name = "Albert Edward",
                reignName = "Edward VII",
                House = "Saxe-Coburg and Gotha",
                Birth = new DateTime(1841, 11, 9),
                Death = new DateTime(1910, 5, 6),
                Image_URL = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/7b/King-Edward-VII_%28cropped%29.jpg/330px-King-Edward-VII_%28cropped%29.jpg",
                Predecessor = "Victoria",
                Successor = "George V",
            });
            rulers.Add(new Ruler()
            {
                Name = "George Frederick Ernest Albert",
                reignName = "George V",
                House = "Saxe-Coburg and Gotha & Windsor",
                Birth = new DateTime(1865, 6, 3),
                Death = new DateTime(1936, 1, 20),
                Image_URL = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c9/King_George_1923_LCCN2014715558_%28cropped%29.jpg/330px-King_George_1923_LCCN2014715558_%28cropped%29.jpg",
                Predecessor = "Edward VII",
                Successor = "Edward VIII",
            });
            rulers.Add(new Ruler()
            {
                Name = "Edward Albert Christian George",
                reignName = "Edward VIII",
                House = "Windsor",
                Birth = new DateTime(1896, 6, 23),
                Death = new DateTime(1972, 5, 28),
                Image_URL = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a3/HRH_The_Prince_of_Wales_No_4_%28HS85-10-36416%29.jpg/330px-HRH_The_Prince_of_Wales_No_4_%28HS85-10-36416%29.jpg",
                Predecessor = "George V",
                Successor = "George VI",
            });
            rulers.Add(new Ruler()
            {
                Name = "Albert Frederick Arthur George",
                reignName = "George VI",
                House = "Windsor",
                Birth = new DateTime(1895, 12, 14),
                Death = new DateTime(1952, 2, 6),
                Image_URL = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/25/King_George_VI_LOC_matpc.14736_%28cleaned%29.jpg/330px-King_George_VI_LOC_matpc.14736_%28cleaned%29.jpg",
                Predecessor = "Edward VIII",
                Successor = "Elizabeth II",
            });
            rulers.Add(new Ruler()
            {
                Name = "Elizabeth Alexandra Mary",
                reignName = "Elizabeth II",
                House = "Windsor",
                Birth = new DateTime(1926, 4, 21),
                Death = null,
                Image_URL = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b6/Queen_Elizabeth_II_in_March_2015.jpg/330px-Queen_Elizabeth_II_in_March_2015.jpg",
                Predecessor = "George VI",
                Successor = "",
            });

            // populate the listbox with the rulers list.
            britishRulers.ItemsSource = rulers;
        }

        private void britishRulers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (britishRulers.SelectedItem != null)
            {
                //Allow Description stackpanel to be seen when SelectionChanged event is fired.
                Description.Visibility = Visibility.Visible;

                //Cast selected item as Ruler and Fill the Details stackpanel with selected rulers' info.
                Ruler selectedRuler = britishRulers.SelectedItem as Ruler;
                Image.Source = new BitmapImage(new Uri(selectedRuler.Image_URL));
                Name.Text = selectedRuler.Name;
                reignName.Text = selectedRuler.reignName;
                House.Text = selectedRuler.House;
                Birth.Text = selectedRuler.Birth.ToString("MMM dd yyyy");
                Death.Text = selectedRuler.Death?.ToString("MMM dd yyyy") ?? "-"; // C# 6.0 feature.
                Predecessor.Text = selectedRuler.Predecessor;
                Successor.Text = selectedRuler.Successor != "" ? selectedRuler.Successor : "-"; // Ternary operator.

            }
        }
    }
}