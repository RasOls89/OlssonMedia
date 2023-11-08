namespace WinFormsGUI
{
    public partial class Login : Form
    {


        public Login()
        {
            InitializeComponent();
            textBoxPassword.PasswordChar = '*';
        }



        private void bttn_Login_Click(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '*';

        }

    }
    
}