using Evaluación_Keneth.Forms;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluación_Keneth
{
    public partial class Login : MaterialForm
    {
        public static bool LoggedIn = false;
        public static string User = "sa";
        public static string Password = "Dev24.";
        private int tries = 3;
        public Login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click_1(object sender, EventArgs e)
        {
            var user = TxtUser.Text;
            var password = TxtPassword.Text;
            var superUser = User;
            var superPassword = Password;
            Main.LoggedIn = false;

            if (user == superUser && password == superPassword)
            {
                Main.LoggedIn = true;
                this.Hide();
                var frm = new Gestion();
                frm.ShowDialog();
                this.Close();
                return;
            }

            tries--;
            if (tries == 0)
            {
                MessageBox.Show("Te has quedado sin intento");
                Environment.Exit(0);
            }
            ToggleLabel($"Error: Contraseña o Usuario Invalido\nTe quedan {tries} intentos");
            SetTextBox(TxtUser, "");
            SetTextBox(TxtPassword, "");
        }

        private void SetTextBox(TextBoxBase textBox, string value)
        {
            textBox.Text = value;
        }

        private void ToggleLabel(string text)
        {
            LblError.Visible = !LblError.Visible;
            LblError.Text = text;
        }

        private void BtnLogin_Leave(object sender, EventArgs e)
        {
            ToggleLabel("");
        }
    }
}
