using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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

namespace Automation_Sephora
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ChromeDriver chromeDriver = new ChromeDriver();
            chromeDriver.Url = "https://www.sephora.com/";
            chromeDriver.Navigate();
            var closeModalIntro = chromeDriver.FindElement(By.CssSelector("[data-at='modal_close']"));
            closeModalIntro.Click();
            var handleOpenModalSignIn = chromeDriver.FindElement(By.CssSelector("[data-at='search_input']"));
            handleOpenModalSignIn.SendKeys("sephonra lipstick");

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
