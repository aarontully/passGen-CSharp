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
                MessageBox.Show("Password length must be between 8 and 128");
            }

            string charSet = "";

            if ((bool)Lowercase.IsChecked)
            {
                charSet += lowerCase;
            }

            if ((bool)Uppercase.IsChecked)
            {
                charSet += upperCase;
            }
            else if ((bool)!Lowercase.IsChecked)
            {

            }

            if ((bool)Numbers.IsChecked)
            {
                charSet += numbers;
            }


            if ((bool)Symbols.IsChecked)
            {
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
            if((bool) Lowercase.IsChecked == true || (bool)Uppercase.IsChecked == true || (bool)Numbers.IsChecked == true || (bool)Symbols.IsChecked == true)
            {
                lblPassword.Text = generatePassword(val);

                Popup popup = new Popup();
                popup.PlacementTarget = lblPassword;
                popup.Placement = PlacementMode.Right;
                popup.HorizontalOffset = -55;
                popup.PopupAnimation = PopupAnimation.Fade;
                popup.AllowsTransparency = true;
                TextBlock popupText = new TextBlock();
                popupText.Text = "Copied!";
                popupText.Background = Brushes.AliceBlue;
                popupText.Foreground = Brushes.Black;
                popupText.FontSize = 16;
                popupText.TextWrapping = TextWrapping.Wrap;
                popup.Child = popupText;
                lblPassword.ToolTip = popup;
                popup.IsOpen = true;
                popup.StaysOpen = false;
            }
            else
            {
                lblPassword.Text = "Please specify a parameter";
            }

            if (!string.IsNullOrEmpty(lblPassword.Text))
            {
                Clipboard.SetText(lblPassword.Text);
            }
        }
    }
}
