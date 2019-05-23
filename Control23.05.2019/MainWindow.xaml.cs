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
using Newtonsoft.Json;
using System.Net;
using System.IO;

namespace Control23._05._2019
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string _url = "https://nationalbank.kz/rss/rates_all.xml?switch=russian";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void UpdateButtonClick(object sender, RoutedEventArgs e)
        {
            WebClient client = new WebClient();

            string xml = "";

            using (Stream stream = client.OpenRead(new Uri(_url)))
            {
                using (var reader = new StreamReader(stream))
                {
                    string line = "";
                    while ((line = reader.ReadLine()) != null)
                    {
                        xml += line;
                    }
                }
            }
            var value = Deserialize<Valute>(xml);

            List<Service> valuteServices = new List<Service>();

            foreach (var item in value.chanel.Item)
            {
                var valute = new Service { Currency = item.Currency, Change = item.Change, Denomination = item.Denomination };
                valuteServices.Add(valute);
            }

            dataGrid.ItemsSource = valuteServices;
        }

        private T Deserialize<T>(string input) where T : class
        {
            System.Xml.Serialization.XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(typeof(T));

            using (StringReader sr = new StringReader(input))
            {
                return (T)ser.Deserialize(sr);
            }
        }
    }
}
