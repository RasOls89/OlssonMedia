namespace WinFormsGUI
{
    partial class LogIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bttn_Login = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxUserName = new TextBox();
            textBoxPassword = new TextBox();
            buttn_Login = new Button();
            SuspendLayout();
            // 
            // bttn_Login
            // 
            bttn_Login.AutoSize = true;
            bttn_Login.Location = new Point(34, 25);
            bttn_Login.Name = "bttn_Login";
            bttn_Login.Size = new Size(141, 15);
            bttn_Login.TabIndex = 0;
            bttn_Login.Text = "Olsson media applikation";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 70);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 1;
            label2.Text = "Användarnamn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 103);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 2;
            label3.Text = "Lösenord";
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(176, 69);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(100, 23);
            textBoxUserName.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(173, 106);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(100, 23);
            textBoxPassword.TabIndex = 4;
            // 
            // buttn_Login
            // 
            buttn_Login.Location = new Point(312, 270);
            buttn_Login.Name = "buttn_Login";
            buttn_Login.Size = new Size(75, 23);
            buttn_Login.TabIndex = 5;
            buttn_Login.Text = "Logga in";
            buttn_Login.UseVisualStyleBackColor = true;
            buttn_Login.Click += buttn_Login_Click;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 450);
            Controls.Add(buttn_Login);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUserName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(bttn_Login);
            Name = "LogIn";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label bttn_Login;
        private Label label2;
        private Label label3;
        private TextBox textBoxUserName;
        private TextBox textBoxPassword;
        private Button buttn_Login;
    }
}