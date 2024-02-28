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

namespace ImgTest
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TESTOEntities BD = new TESTOEntities();
        public MainWindow()
        {
            InitializeComponent();

            var IMG = new Таблица3();
            IMG.ID_Img = 7;
            IMG.ID_Image = File.ReadAllBytes("C:\\Users\\d0ggy\\OneDrive\\Рабочий стол\\Снимок экрана 2023-08-30 184648.png");
            
            BD.Таблица3.Add(IMG);

            BD.SaveChanges(); 

            ListV.ItemsSource = BD.Таблица3.ToList();
        }
    }
}
