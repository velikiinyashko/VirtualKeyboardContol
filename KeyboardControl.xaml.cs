using ReactiveUI;
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

namespace VirtualKeyboardControl
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class KeyboardControl : UserControl, IViewFor<KeyboardViewModel>
    {
        public static readonly DependencyProperty ViewModelProperty =
            DependencyProperty.Register("ViewModel", typeof(KeyboardViewModel), typeof(KeyboardControl), new PropertyMetadata(null));

        public KeyboardControl()
        {
            ViewModel = new KeyboardViewModel();
            InitializeComponent();
           this.WhenActivated(dispose =>
           {
               dispose(this.WhenAnyValue(x => x.ViewModel).BindTo(this, x => x.DataContext));
           });
        }

        public KeyboardViewModel ViewModel
        {
            get => (KeyboardViewModel)GetValue(ViewModelProperty);
            set => SetValue(ViewModelProperty, value);
        }
        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (KeyboardViewModel)value;
        }
    }
}
