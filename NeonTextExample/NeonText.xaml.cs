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

namespace NeonTextExample
{
    /// <summary>
    /// Interaction logic for NeonText.xaml
    /// </summary>
    public partial class NeonText : UserControl
    {
        public NeonText()
        {
            InitializeComponent();
        }



        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(NeonText), new PropertyMetadata(""));


        public Color GlowedColor
        {
            get { return (Color)GetValue(GlowedColorProperty); }
            set { SetValue(GlowedColorProperty, value); }
        }

        public static readonly DependencyProperty GlowedColorProperty =
            DependencyProperty.Register("GlowedColor", typeof(Color), typeof(NeonText), new PropertyMetadata(Colors.Red));
    }
}
