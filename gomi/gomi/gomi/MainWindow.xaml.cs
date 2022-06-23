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

namespace gomi {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            //            string Template = @$"<article><section><h2>{this.cVal.Text}</h2><p>{this.cExplanation.Text}</p><figure><img class="""" alt=""{this.cVal.Text}"" src =""./img/{this.cRoot.Text}/{this.cVal.Text}.png"" /></figure></section>";


            string Template = $"\r\n  <article>\r\n" +
                              $"    <section>\r\n" +
                              $"      <h2>{this.cVal.Text}</h2>\r\n" +
                              $"      <p>{this.cExplanation.Text}</p>\r\n" +
                              $"      <figure>\r\n" +
                              @$"        <img class="""" alt=""{this.cVal.Text}"" src=""./img/{this.cRoot.Text}/{this.cVal.Text}.png"" />" + "\r\n" + 
                              $"      </figure>\r\n" +
                              $"    </section>\r\n" +
                              $"  </article>\r\n";


            Clipboard.SetText(Template, TextDataFormat.Text);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) {
            string Template = $@"    ""{this.cVal.Text}"": ""#0000ff""," + "\r\n";
            Clipboard.SetText(Template, TextDataFormat.Text);
        }
    }
}
