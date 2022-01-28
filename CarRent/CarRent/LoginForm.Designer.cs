
namespace CarRent
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.Btn_Login = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Lb_Username = new System.Windows.Forms.Label();
            this.Tb_Username = new System.Windows.Forms.TextBox();
            this.Tb_Password = new System.Windows.Forms.TextBox();
            this.Lb_Password = new System.Windows.Forms.Label();
            this.Lb_ErrorUsername = new System.Windows.Forms.Label();
            this.Lb_ErrorPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Login
            // 
            this.Btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_Login.Location = new System.Drawing.Point(808, 292);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(155, 40);
            this.Btn_Login.TabIndex = 0;
            this.Btn_Login.Text = "Login";
            this.Btn_Login.UseVisualStyleBackColor = true;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(-2, 2);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(327, 300);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            // 
            // Lb_Username
            // 
            this.Lb_Username.AutoSize = true;
            this.Lb_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lb_Username.Location = new System.Drawing.Point(359, 79);
            this.Lb_Username.Name = "Lb_Username";
            this.Lb_Username.Size = new System.Drawing.Size(124, 29);
            this.Lb_Username.TabIndex = 2;
            this.Lb_Username.Text = "Username";
            // 
            // Tb_Username
            // 
            this.Tb_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tb_Username.Location = new System.Drawing.Point(501, 79);
            this.Tb_Username.Name = "Tb_Username";
            this.Tb_Username.Size = new System.Drawing.Size(283, 34);
            this.Tb_Username.TabIndex = 3;
            this.Tb_Username.TextChanged += new System.EventHandler(this.Tb_Username_TextChanged);
            // 
            // Tb_Password
            // 
            this.Tb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tb_Password.Location = new System.Drawing.Point(501, 174);
            this.Tb_Password.Name = "Tb_Password";
            this.Tb_Password.PasswordChar = '*';
            this.Tb_Password.Size = new System.Drawing.Size(283, 34);
            this.Tb_Password.TabIndex = 5;
            this.Tb_Password.TextChanged += new System.EventHandler(this.Tb_Password_TextChanged);
            // 
            // Lb_Password
            // 
            this.Lb_Password.AutoSize = true;
            this.Lb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lb_Password.Location = new System.Drawing.Point(359, 177);
            this.Lb_Password.Name = "Lb_Password";
            this.Lb_Password.Size = new System.Drawing.Size(120, 29);
            this.Lb_Password.TabIndex = 4;
            this.Lb_Password.Text = "Password";
            // 
            // Lb_ErrorUsername
            // 
            this.Lb_ErrorUsername.AutoSize = true;
            this.Lb_ErrorUsername.ForeColor = System.Drawing.Color.Red;
            this.Lb_ErrorUsername.Location = new System.Drawing.Point(508, 126);
            this.Lb_ErrorUsername.Name = "Lb_ErrorUsername";
            this.Lb_ErrorUsername.Size = new System.Drawing.Size(0, 17);
            this.Lb_ErrorUsername.TabIndex = 6;
            // 
            // Lb_ErrorPassword
            // 
            this.Lb_ErrorPassword.AutoSize = true;
            this.Lb_ErrorPassword.ForeColor = System.Drawing.Color.Red;
            this.Lb_ErrorPassword.Location = new System.Drawing.Point(498, 227);
            this.Lb_ErrorPassword.Name = "Lb_ErrorPassword";
            this.Lb_ErrorPassword.Size = new System.Drawing.Size(0, 17);
            this.Lb_ErrorPassword.TabIndex = 7;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 758);
            this.Controls.Add(this.Lb_ErrorPassword);
            this.Controls.Add(this.Lb_ErrorUsername);
            this.Controls.Add(this.Tb_Password);
            this.Controls.Add(this.Lb_Password);
            this.Controls.Add(this.Tb_Username);
            this.Controls.Add(this.Lb_Username);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.Btn_Login);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label Lb_Username;
        private System.Windows.Forms.TextBox Tb_Username;
        private System.Windows.Forms.TextBox Tb_Password;
        private System.Windows.Forms.Label Lb_Password;
        private System.Windows.Forms.Label Lb_ErrorUsername;
        private System.Windows.Forms.Label Lb_ErrorPassword;
    }
}

