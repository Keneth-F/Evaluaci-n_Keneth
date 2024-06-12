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

namespace Evaluación_Keneth.Forms
{
    public partial class Main : MaterialForm
    {
        public static bool LoggedIn = false;
        public static string User = "sa";
        public static string Password = "Dev24.";
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //LoadForm();

        }

        public void LoadForm()
        {
            Form frm = new Login();
            if (!LoggedIn)
            {
                this.Text = "Login";
                //LoadForm(new Login());
            }
            else
            {
                this.Text = "Gestion";
                //LoadForm(new Gestion());
                frm=new Gestion();
            }
            Container.Controls.Clear();
            frm.TopLevel = false;
            frm.AutoScroll = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            Container.Controls.Add(frm);
            frm.Show();
        }
    }
}
