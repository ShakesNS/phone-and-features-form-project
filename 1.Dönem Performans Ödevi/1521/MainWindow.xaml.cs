using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace _1521
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Telefon> Özellikler = new ObservableCollection<Telefon>();
        public MainWindow()
        {
            InitializeComponent();
            LbListe.ItemsSource = Özellikler;
            BtnKaydet.Click += BtnKaydet_Click;
            BtnSil.Click += BtnSil_Click;
            BtnYenile.Click += BtnYenile_Click;
            LbListe.SelectionChanged += LbListe_SelectionChanged;
            Ctsil.Click += Ctsil_Click;
            Ctgöster.Click += Ctgöster_Click;
            Özellikler.Add(new Telefon("Apple", "Iphone", 4,10,10,128,"IOS",4,0,0));
        }

        private void Ctgöster_Click(object sender, RoutedEventArgs e)
        {
            Telefon seçiliTelefon = (Telefon)LbListe.SelectedItem;
            MessageBox.Show($"{"Marka: "}{seçiliTelefon.Marka}\n{"Model: "}{seçiliTelefon.Model}\n{"Ram: "}{seçiliTelefon.Ram}\n{"Arka Kamera: "}{seçiliTelefon.ArkaKamera}\n{"Ön Kamera: "}{seçiliTelefon.ÖnKamera}\n{"Depolama: "}{seçiliTelefon.Depolama}\n{"Yazılım: "}{seçiliTelefon.Yazılım}\n{"Çekirdek: "}{seçiliTelefon.Çekirdek}\n{"Sim Kart: "}{seçiliTelefon.SimKart}\n{"Sd Kart: "}{seçiliTelefon.SdKart}","Özellikler", MessageBoxButton.OK , MessageBoxImage.Information);
        }

        

        private void Ctsil_Click(object sender, RoutedEventArgs e)
        {
            if (LbListe.SelectedItem != null)
                Özellikler.RemoveAt(LbListe.SelectedIndex);
            TbSilindi.Visibility = Visibility.Visible;
            TbKaydedildi.Visibility = Visibility.Collapsed;

        }

        private void BtnYenile_Click(object sender, RoutedEventArgs e)
        {
            LbListe.Items.Refresh();
            TbKaydedildi.Visibility = Visibility.Collapsed;
            TbSilindi.Visibility = Visibility.Collapsed;

        }

        

        void Temizle()
        {
            TbMarka.Clear();
            TbModel.Clear();
            TbRam.Clear();
            TbArkaKamera.Clear();
            TbÖnKamera.Clear();
            TbDepolama.Clear();
            TbYazılım.Clear();
            TbÇekirdek.Clear();
            TbSimKart.Clear();
            TbSdKart.Clear();

        }

        private void BtnSil_Click(object sender, RoutedEventArgs e)
        {
            if (LbListe.SelectedItem != null)
                Özellikler.RemoveAt(LbListe.SelectedIndex);
            TbSilindi.Visibility = Visibility.Visible;
            TbKaydedildi.Visibility = Visibility.Collapsed;

        }

        private void LbListe_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Telefon seçilitelefon = (Telefon)LbListe.SelectedItem;
            if (seçilitelefon != null)
            {
                TbMarka.Text = seçilitelefon.Marka;
                TbModel.Text = seçilitelefon.Model;
                TbRam.Text = seçilitelefon.Ram.ToString();
                TbArkaKamera.Text = seçilitelefon.ArkaKamera.ToString();
                TbÖnKamera.Text = seçilitelefon.ÖnKamera.ToString();
                TbDepolama.Text = seçilitelefon.Depolama.ToString();
                TbYazılım.Text = seçilitelefon.Yazılım;
                TbÇekirdek.Text = seçilitelefon.Çekirdek.ToString();
                TbSimKart.Text = seçilitelefon.SimKart.ToString();
                TbSdKart.Text = seçilitelefon.SdKart.ToString();






            }
            else
            {
                Temizle();
            }
        }

        private void BtnKaydet_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbMarka.Text) == true)
            {
                MessageBox.Show("Marka boş olmamalı");
                return;
            }
            else if (string.IsNullOrWhiteSpace(TbModel.Text) == true)
            {
                MessageBox.Show("Model boş olmamalı");
                return;
            }
            else if (int.TryParse(TbRam.Text, out int numara)==false)
            {
                MessageBox.Show("Ram kapasitesi  sayı olmalı");
                return;
            }
            else if (int.TryParse(TbArkaKamera.Text, out int numara1) == false)
            {
                MessageBox.Show("Arka kamera pikseli  sayı olmalı");
                return;
            }
            else if (int.TryParse(TbÖnKamera.Text, out int numara2) == false)
            {
                MessageBox.Show("Ön kamera pikseli  sayı olmalı");
                return;
            }
            else if (int.TryParse(TbDepolama.Text, out int numara3) == false)
            {
                MessageBox.Show("Telefon depolaması sayı olmalı");
                return;
            }
            else if (string.IsNullOrWhiteSpace(TbYazılım.Text) == true)
            {
                MessageBox.Show("Yazılım boş olmamalı");
                return;
            }
            else if (int.TryParse(TbÇekirdek.Text, out int numara4) == false)
            {
                MessageBox.Show("Çekirdek sayısı sayı olmalı");
                return;
            }
            else if (int.TryParse(TbSimKart.Text, out int numara5) == false)
            {
                MessageBox.Show("Sim kart sayısı sayı olmalı");
                return;
            }
            else if (int.TryParse(TbSdKart.Text, out int numara6) == false)
            {
                MessageBox.Show("Sd kart kapasitesi sayı olmalı");
                return;
            }

            Telefon seçilitelefon = (Telefon)LbListe.SelectedItem;
            if (seçilitelefon == null)
            {
                Özellikler.Add(new Telefon(TbModel.Text, TbMarka.Text, int.Parse(TbRam.Text), int.Parse(TbArkaKamera.Text), int.Parse(TbÖnKamera.Text), int.Parse(TbDepolama.Text), TbYazılım.Text, int.Parse(TbÇekirdek.Text), int.Parse(TbSimKart.Text), int.Parse(TbSdKart.Text)));

            }
            else
            {
                seçilitelefon.Marka = TbMarka.Text;
                seçilitelefon.Model = TbModel.Text;
                seçilitelefon.Ram = int.Parse(TbRam.Text);
                seçilitelefon.ArkaKamera = int.Parse(TbArkaKamera.Text);
                seçilitelefon.ÖnKamera = int.Parse(TbÖnKamera.Text);
                seçilitelefon.Depolama = int.Parse(TbDepolama.Text);
                seçilitelefon.Yazılım = TbYazılım.Text;
                seçilitelefon.Çekirdek = int.Parse(TbÇekirdek.Text);
                seçilitelefon.SimKart = int.Parse(TbSimKart.Text);
                seçilitelefon.SdKart = int.Parse(TbSdKart.Text);

            }

            Temizle();
            LbListe.SelectedItem = null;
            LbListe.Items.Refresh();
            TbKaydedildi.Visibility = Visibility.Visible;
            TbSilindi.Visibility = Visibility.Collapsed;

        }
    }
}
