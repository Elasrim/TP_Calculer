using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Documents.DocumentStructures;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace TpCalculeRb
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

        private void Quitter_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        double nbr1;
        double nbr2;
        double Calcule;


        private void Calculer_Click(object sender, RoutedEventArgs e)
        {
            
            

            try
            {
                nbr1 = double.Parse(TbNbr1.Text);
                Lnb1.Content = "";
                TbNbr1.BorderBrush = Brushes.Transparent;
            }


            catch
            {

                TbNbr1.BorderBrush = Brushes.Red;
                Lnb1.Content = "<<";
            }

            try
            {
                nbr2 = double.Parse(TbNbr2.Text);
                Lnb2.Content = "";
                TbNbr2.BorderBrush = Brushes.Transparent;
            }
            catch
            {
                TbNbr2.BorderBrush = Brushes.Red;
                Lnb2.Content = "<<";
            }


            if (Radd.IsChecked ==true) Calcule = nbr1 + nbr2;

            else if (Rsous.IsChecked == true) Calcule = nbr1 - nbr2;

            else if (Rdiv.IsChecked == true) Calcule = nbr1 / nbr2;

            else if (Rmult.IsChecked == true) Calcule = nbr1 * nbr2;

            else 
            {
                MessageBox.Show("Aucun operation ajouter");
            }

            TbResultat.Text = Calcule.ToString(); 
            
            if (Lnb2.Content == "<<" || Lnb1.Content == "<<")
            {
                TbResultat.Text = "error";
            }
            else
                TbResultat.Text = Calcule.ToString();

        }

        private void Effacer_Click(object sender, RoutedEventArgs e)
        {
            TbNbr1.Text = "";
            TbNbr2.Text = "";
            TbResultat.Text = "";
            TbNbr1.BorderBrush = TbNbr2.BorderBrush = Brushes.Transparent;
            Lnb1.Content = Lnb2.Content = "";
        }

        private void Rdadd(object sender, RoutedEventArgs e)
        {

        }
    }
}



/*try
            {
                
                //Lnb1.Content = "";
                //TbNbr1.BorderBrush = Brushes.Transparent;
            }
                

            catch
            {
                TbNbr1.BorderBrush = Brushes.Red;
                //Lnb1.Content = "<<";
            }

            try
            {
                
                //Lnb2.Content = "";
                //TbNbr2.BorderBrush = Brushes.Transparent;
            }
            catch
            {
                TbNbr2.BorderBrush = Brushes.Red;
                //Lnb2.Content = "<<";
            */