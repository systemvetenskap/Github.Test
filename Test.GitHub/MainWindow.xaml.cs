using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Test.GitHub
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            BankAccount account = new SavingsAccount();
            account.Interest = 34;

            Tacos tacos = new Tacos();
            tacos.Ingrediens.Add(new Tomato());
            tacos.Ingrediens.Add(new Tomato());
            tacos.Ingrediens.Add(new Tomato());
            tacos.Ingrediens.Add(new Tomato());

            tacos.Ingrediens.Add(new Cheese());
            tacos.Ingrediens.Add(new Meat());

            foreach (var ingredient in tacos.Ingrediens)
            {
                ingredient.Chop();
            }
        }
    }
}
