using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passGen {
    public partial class Form1 : Form {

        public static string generatePassword(
            bool incLowercase,
            bool incUppercase,
            bool incNumbers,
            bool incSymbols,
            int passwordLength) {

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

            if (incLowercase) {
                charSet += lowerCase;
            }

            if (incUppercase) {
                charSet += upperCase;
            }

            if (incNumbers) {
                charSet += numbers;
            }

            if (incSymbols) {
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

        public Form1() {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e) {
            lblPassword.Text = generatePassword(true, true, true, true, 16);
        }

        private void lblPassword_Click(object sender, EventArgs e) {
            lblPassword.Size = new Size(100, 50);
        }
    }
}
