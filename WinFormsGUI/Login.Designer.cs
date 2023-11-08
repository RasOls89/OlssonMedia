namespace WinFormsGUI
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            bttn_Login = new Button();
            textBoxUserName = new TextBox();
            textBoxPassword = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(160, 44);
            label1.Name = "label1";
            label1.Size = new Size(181, 15);
            label1.TabIndex = 0;
            label1.Text = "Välkommen till Olsson mediaapp";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 119);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 1;
            label2.Text = "Användarnamn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 151);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 2;
            label3.Text = "Lösenord";
            // 
            // bttn_Login
            // 
            bttn_Login.Location = new Point(383, 244);
            bttn_Login.Name = "bttn_Login";
            bttn_Login.Size = new Size(75, 23);
            bttn_Login.TabIndex = 3;
            bttn_Login.Text = "Logga in";
            bttn_Login.UseVisualStyleBackColor = true;
            bttn_Login.Click += bttn_Login_Click;
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(153, 116);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(218, 23);
            textBoxUserName.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(153, 151);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(218, 23);
            textBoxPassword.TabIndex = 5;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 450);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUserName);
            Controls.Add(bttn_Login);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Olsson MediaApp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button bttn_Login;
        private TextBox textBoxUserName;
        private TextBox textBoxPassword;
    }
}