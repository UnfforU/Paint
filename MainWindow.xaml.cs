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


namespace Paint
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {  

            InitializeComponent();
            

            //Рисуем ломаную
            var polyline = new Polyline();
            polyline.Points = new PointCollection();
            polyline.Points.Add(new Point(10, 40));
            polyline.Points.Add(new Point(20, 10));
            polyline.Points.Add(new Point(100, 150));
            polyline.Points.Add(new Point(100, 150));
            polyline.Points.Add(new Point(132, 76));
            polyline.Points.Add(new Point(10, 40));
            polyline.Stroke = Brushes.Black;
            myGrid.Children.Add(polyline);

            //Рисуем отрезок
            var segment = new Line();
            segment.X1 = 10;
            segment.X2 = 150;
            segment.Y1 = 400;
            segment.Y2 = 400;
            segment.Stroke = Brushes.Red;
            myGrid.Children.Add(segment);
            var leftLine = new Line();
            leftLine.X1 = 10;
            leftLine.X2 = 10;
            leftLine.Y1 = 390;
            leftLine.Y2 = 410;
            leftLine.Stroke = Brushes.Red;
            myGrid.Children.Add(leftLine);
            var RightLine = new Line();
            RightLine.X1 = 150;
            RightLine.X2 = 150;
            RightLine.Y1 = 390;
            RightLine.Y2 = 410;
            RightLine.Stroke = Brushes.Red;
            myGrid.Children.Add(RightLine);


            //Рисуем многоугольник(звезду)
            var poligon = new Polygon();
            poligon.Points.Add(new Point(400, 280));
            poligon.Points.Add(new Point(425, 235));
            poligon.Points.Add(new Point(475, 225));
            poligon.Points.Add(new Point(440, 190));
            poligon.Points.Add(new Point(450, 140));
            poligon.Points.Add(new Point(400, 160));
            poligon.Points.Add(new Point(350, 140));
            poligon.Points.Add(new Point(360, 190));
            poligon.Points.Add(new Point(325, 225));
            poligon.Points.Add(new Point(375, 235));
            poligon.Fill = Brushes.Purple;
            poligon.Stroke = Brushes.Purple;
            myGrid.Children.Add(poligon);


        }
    }
}
