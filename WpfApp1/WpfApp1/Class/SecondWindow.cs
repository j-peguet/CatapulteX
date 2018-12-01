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
using MySql.Data.MySqlClient;
using MySql.Web;

namespace WpfApp1.Class
{
    public class SecondWindow : Window
    {
        static Button b1 = new Button();
        static DockPanel dp1 = new DockPanel();
        static Label lab = new Label();

        public SecondWindow()
        {
            this.Height = 600;
            this.Width = 1000;
            this.Hide();
            this.Closed += Fermer;
            b1.Content = "Click";
            b1.Height = 100;
            b1.Width = 100;
            dp1.Children.Add(b1);
            DockPanel.SetDock(b1, Dock.Left);
            lab.Content = "Coucou c'est moi";
            dp1.Children.Add(lab);
            DockPanel.SetDock(lab, Dock.Left);
            this.Content = dp1;
        }

        private void Fermer(object sender, EventArgs e)
        {
            dp1.Children.Clear();
            this.Close();
            MainWindow.SetWindow2();
        }
    }
}
