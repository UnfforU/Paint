using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Paint
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {  

            InitializeComponent();
            penButton.IsChecked = true;

        }

        private void pColor_Button_Click(object sender, RoutedEventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if(dlg.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                penColor.Fill = new SolidColorBrush(Color.FromArgb(dlg.Color.A, dlg.Color.R, dlg.Color.G, dlg.Color.B));
                SetCanvasAttributes();
            }
        }

        private void bColor_Button_Click(object sender, RoutedEventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                brushColor.Fill = new SolidColorBrush(Color.FromArgb(dlg.Color.A, dlg.Color.R, dlg.Color.G, dlg.Color.B));
            }
        }

        private void ToggleButtons_Checked(object sender, RoutedEventArgs e)
        {
            foreach(UIElement el in FiguresList.Children)
                if ((el is ToggleButton button) && el != sender)
                        button.IsChecked = false;
            foreach (UIElement el in ToolsList.Children)
                if ((el is ToggleButton button) && el != sender)
                    button.IsChecked = false;
        }

        private void Pen_Button_Checked(object sender, RoutedEventArgs e) {
            
            ToggleButtons_Checked(sender, e);
            SetCanvasAttributes();
            
        }

        private void SetCanvasAttributes()
        {
            MyCanvas.EditingMode = InkCanvasEditingMode.Ink;
            MyCanvas.Cursor = System.Windows.Input.Cursors.Pen;
            MyCanvas.DefaultDrawingAttributes.Color = ((SolidColorBrush)(penColor.Fill)).Color;
            MyCanvas.DefaultDrawingAttributes.Width = (int)penSize.Value + 1;
            MyCanvas.DefaultDrawingAttributes.Height = (int)penSize.Value + 1;
        }

        private void penSize_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            SetCanvasAttributes();
        }

        private void Eraser_Button_Checked(object sender, RoutedEventArgs e)
        {
            MyCanvas.EditingMode = InkCanvasEditingMode.EraseByPoint;
            MyCanvas.Cursor = System.Windows.Input.Cursors.Cross;
        }
    }
}
