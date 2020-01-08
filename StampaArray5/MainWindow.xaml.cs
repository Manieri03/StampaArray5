using System;
using System.Collections.Generic;
using System.IO;
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

namespace StampaArray5
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
        int c = 0;
        string[] mex = new string[5];

        private void Stampa_Click(object sender, RoutedEventArgs e)
        {
            for(int i=0; i<5; i++)
            {
                lblrisultato.Content+=$"-{i+1}° messaggio:  {mex[i]} \n";
            }
        }

        private void Inserisci_Click(object sender, RoutedEventArgs e)
        {
            c++;
            mex[c - 1] = txtstringa.Text;
            if (c == 5)
            {
                btnins.IsEnabled = false;
                btnsta.IsEnabled = true;
                btnpub.IsEnabled = true;

            }
            txtstringa.Clear();
        }

        private void Pubblica_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter sw = new StreamWriter("stringhe.txt", false, Encoding.UTF8);
            
            for (int i = 0; i < 5; i++)
            {
                sw.WriteLine($"-{i + 1}° messaggio:  {mex[i]} \n");
            }
            sw.Flush();
            sw.Close();
                
        }
    }
}
