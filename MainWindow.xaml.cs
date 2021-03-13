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

namespace CandyRoll
{

    public partial class MainWindow : Window
    {

        int sides;
        int dices;
        Random rnd = new Random();
        int RollStandardDie()
        {
            return rnd.Next(1, sides + 1);
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void numDices_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void numSides_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string userText1 = numDices.Text;
            string userText2 = numSides.Text;
            if (Int32.TryParse(userText1, out dices) & Int32.TryParse(userText2, out sides))
            {
                message.Text = ("Кидаем " + userText1 + " кубиков с " + userText2 + " гранями..." + "\n\r");
            }
            else
            {
                MessageBox.Show("Некорректный ввод");
            }

            int[] dice = new int[dices];
            int sum = 0;
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = RollStandardDie();
                message.Text = (message.Text + "■ " + dice[i] + "; ");
                sum += dice[i];
            }
            message.Text = (message.Text + "\nРезультат - " + sum + ".");

        }

    }

}