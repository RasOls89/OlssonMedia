using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using BusinessLayer;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Identity.Client;

namespace WinFormsGUI
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private UserLogic _userLogic = new UserLogic();

        public AdminMainMenu AdminMainMenu = new AdminMainMenu();

        private void buttn_Login_Click(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '*';

            _userLogic.Login(textBoxUserName.Text, textBoxPassword.Text);

            string _acessRights = _userLogic.LoggedIn.AcessRights;

            switch (_acessRights)
            {
                case "Admin":
                    
                    AdminMainMenu.Show();
                    this.Hide();
                    break;
            }

            }
    }
}
