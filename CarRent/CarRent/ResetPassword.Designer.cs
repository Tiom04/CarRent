
namespace CarRent
{
    partial class ResetPassword
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
            this.Lb_NewPassword = new System.Windows.Forms.Label();
            this.Tb_NewPassword = new System.Windows.Forms.TextBox();
            this.Btn_resetPassword = new System.Windows.Forms.Button();
            this.Tb_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.Lb_NewPassword2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lb_NewPassword
            // 
            this.Lb_NewPassword.AutoSize = true;
            this.Lb_NewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lb_NewPassword.Location = new System.Drawing.Point(76, 50);
            this.Lb_NewPassword.Name = "Lb_NewPassword";
            this.Lb_NewPassword.Size = new System.Drawing.Size(188, 25);
            this.Lb_NewPassword.TabIndex = 0;
            this.Lb_NewPassword.Text = "Enter new password";
            // 
            // Tb_NewPassword
            // 
            this.Tb_NewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tb_NewPassword.Location = new System.Drawing.Point(316, 50);
            this.Tb_NewPassword.Name = "Tb_NewPassword";
            this.Tb_NewPassword.PasswordChar = '*';
            this.Tb_NewPassword.Size = new System.Drawing.Size(244, 30);
            this.Tb_NewPassword.TabIndex = 1;
            // 
            // Btn_resetPassword
            // 
            this.Btn_resetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_resetPassword.Location = new System.Drawing.Point(611, 178);
            this.Btn_resetPassword.Name = "Btn_resetPassword";
            this.Btn_resetPassword.Size = new System.Drawing.Size(132, 39);
            this.Btn_resetPassword.TabIndex = 2;
            this.Btn_resetPassword.Text = "Reset";
            this.Btn_resetPassword.UseVisualStyleBackColor = true;
            // 
            // Tb_ConfirmPassword
            // 
            this.Tb_ConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tb_ConfirmPassword.Location = new System.Drawing.Point(316, 96);
            this.Tb_ConfirmPassword.Name = "Tb_ConfirmPassword";
            this.Tb_ConfirmPassword.PasswordChar = '*';
            this.Tb_ConfirmPassword.Size = new System.Drawing.Size(244, 30);
            this.Tb_ConfirmPassword.TabIndex = 4;
            // 
            // Lb_NewPassword2
            // 
            this.Lb_NewPassword2.AutoSize = true;
            this.Lb_NewPassword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lb_NewPassword2.Location = new System.Drawing.Point(76, 96);
            this.Lb_NewPassword2.Name = "Lb_NewPassword2";
            this.Lb_NewPassword2.Size = new System.Drawing.Size(169, 25);
            this.Lb_NewPassword2.TabIndex = 3;
            this.Lb_NewPassword2.Text = "Confirm password";
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 316);
            this.Controls.Add(this.Tb_ConfirmPassword);
            this.Controls.Add(this.Lb_NewPassword2);
            this.Controls.Add(this.Btn_resetPassword);
            this.Controls.Add(this.Tb_NewPassword);
            this.Controls.Add(this.Lb_NewPassword);
            this.Name = "ResetPassword";
            this.Text = "ResetPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb_NewPassword;
        private System.Windows.Forms.TextBox Tb_NewPassword;
        private System.Windows.Forms.Button Btn_resetPassword;
        private System.Windows.Forms.TextBox Tb_ConfirmPassword;
        private System.Windows.Forms.Label Lb_NewPassword2;
    }
}