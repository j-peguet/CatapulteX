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
using WpfApp1.Class;

namespace WpfApp1
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static DockPanel dp = new DockPanel();
        static TextBox tb = new TextBox();
        static Label lab = new Label();
        static ListBox listb = new ListBox();
        static Button b = new Button();
        static SecondWindow Window2 = new SecondWindow();
        static Image Logo = new Image();

        public static void SetWindow2()
        {
            Window2 = null;
        }

        private void Affiche(object sender, EventArgs e)
        {
            if (Window2 == null)
            {
                Window2 = new SecondWindow();
            }
            Window2.Show();
        }
        private void Fermer(object sender, EventArgs e)
        {
            if (Window2 != null) {
                Window2.Close();
            }
        }

        public MainWindow()
        {
            this.Height = 600;
            this.Width = 1200;
            this.Closed += Fermer;

            Logo.Height = 50;
            Logo.Width = 50;
            Logo.Margin = new Thickness(10, 10, 0, 0);
            Logo.VerticalAlignment = VerticalAlignment.Top;
            Logo.HorizontalAlignment = HorizontalAlignment.Left;
            BitmapImage BiLogo = new BitmapImage();
            BiLogo.BeginInit();
            BiLogo.UriSource = new Uri("/Images/AirAtlantique.PNG", UriKind.Relative);
            BiLogo.EndInit();
            Logo.Stretch = Stretch.Fill;
            Logo.Source = BiLogo;
            dp.Children.Add(Logo);
            DockPanel.SetDock(Logo, Dock.Top);



            List<Button> mesbuttons = new List<Button>();
            mesbuttons.Add(new Button());
            mesbuttons.Add(new Button());
            mesbuttons.Add(new Button());

            for (int i=0; i<mesbuttons.Count(); i++)
            {
                mesbuttons[i].Height = 100;
                mesbuttons[i].Width = 100;
                mesbuttons[i].Content = "Button"+i;
                mesbuttons[i].Click += Affiche;
                dp.Children.Add(mesbuttons[i]);
                DockPanel.SetDock(mesbuttons[i], Dock.Bottom);
            }
            DBConnect dBConnect = new DBConnect();
            
            tb.Text = dBConnect.Select().ToString();
            dp.Children.Add(tb);

            this.Content = dp;
            InitializeComponent();
        }

    }
}
