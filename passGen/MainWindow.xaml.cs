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

namespace passGen {

    public partial class MainWindow : Window {

        public string generatePassword(int passwordLength) {

            const string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string lowerCase = "abcdefghijklmnopqrstuvwxyz";
            const string numbers = "1234567890";
            const string symbols = "!@#$%^&*()";
            const int passwordLengthMin = 8;
            const int passwordLengthMax = 128;

            if (passwordLength < passwordLengthMin || passwordLength > passwordLengthMax) {
                return "Password length must be between 8 and 128";
            }

            string charSet = "";

            if ((bool) Lowercase.IsChecked) {
                charSet += lowerCase;
            }

            if ((bool)Uppercase.IsChecked) {
                charSet += upperCase;
            }

            if ((bool) Numbers.IsChecked) {
                charSet += numbers;
            }

            if ((bool) Symbols.IsChecked) {
                charSet += symbols;
            }

            char[] password = new char[passwordLength];
            int charSetLength = charSet.Length;

            System.Random random = new System.Random();
            for (int charPos = 0; charPos < passwordLength; charPos++) {
                password[charPos] = charSet[random.Next(charSetLength - 1)];
            }

            return string.Join(null, password);
        }

        public MainWindow() {
            InitializeComponent();
        }

        void btnGenerate_Click(object sender, RoutedEventArgs e) {
            double pass = passSlider.Value;
            int val = Convert.ToInt32(pass);
            lblPassword.Text = generatePassword(val);
        }
    }
}
