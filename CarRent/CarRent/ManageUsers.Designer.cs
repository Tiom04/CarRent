
namespace CarRent
{
    partial class ManageUsers
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
            this.Btn_Refresh = new System.Windows.Forms.Button();
            this.dataGridUsers = new System.Windows.Forms.DataGridView();
            this.Btn_AddNewUser = new System.Windows.Forms.Button();
            this.Btn_ResetPassword = new System.Windows.Forms.Button();
            this.Btn_ActivateDisactivateUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_Refresh.Location = new System.Drawing.Point(18, 19);
            this.Btn_Refresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(150, 72);
            this.Btn_Refresh.TabIndex = 0;
            this.Btn_Refresh.Text = "refresh";
            this.Btn_Refresh.UseVisualStyleBackColor = true;
            this.Btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // dataGridUsers
            // 
            this.dataGridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsers.Location = new System.Drawing.Point(-16, 208);
            this.dataGridUsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridUsers.Name = "dataGridUsers";
            this.dataGridUsers.RowHeadersWidth = 51;
            this.dataGridUsers.RowTemplate.Height = 24;
            this.dataGridUsers.Size = new System.Drawing.Size(1890, 761);
            this.dataGridUsers.TabIndex = 1;
            // 
            // Btn_AddNewUser
            // 
            this.Btn_AddNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_AddNewUser.Location = new System.Drawing.Point(113, 1032);
            this.Btn_AddNewUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_AddNewUser.Name = "Btn_AddNewUser";
            this.Btn_AddNewUser.Size = new System.Drawing.Size(299, 72);
            this.Btn_AddNewUser.TabIndex = 2;
            this.Btn_AddNewUser.Text = "Add new user";
            this.Btn_AddNewUser.UseVisualStyleBackColor = true;
            // 
            // Btn_ResetPassword
            // 
            this.Btn_ResetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_ResetPassword.Location = new System.Drawing.Point(527, 1032);
            this.Btn_ResetPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_ResetPassword.Name = "Btn_ResetPassword";
            this.Btn_ResetPassword.Size = new System.Drawing.Size(290, 72);
            this.Btn_ResetPassword.TabIndex = 3;
            this.Btn_ResetPassword.Text = "Reset password";
            this.Btn_ResetPassword.UseVisualStyleBackColor = true;
            this.Btn_ResetPassword.Click += new System.EventHandler(this.Btn_ResetPassword_Click);
            // 
            // Btn_ActivateDisactivateUser
            // 
            this.Btn_ActivateDisactivateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_ActivateDisactivateUser.Location = new System.Drawing.Point(1470, 1032);
            this.Btn_ActivateDisactivateUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_ActivateDisactivateUser.Name = "Btn_ActivateDisactivateUser";
            this.Btn_ActivateDisactivateUser.Size = new System.Drawing.Size(338, 72);
            this.Btn_ActivateDisactivateUser.TabIndex = 4;
            this.Btn_ActivateDisactivateUser.Text = "Activate/Deactivate user";
            this.Btn_ActivateDisactivateUser.UseVisualStyleBackColor = true;
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1872, 1342);
            this.Controls.Add(this.Btn_ActivateDisactivateUser);
            this.Controls.Add(this.Btn_ResetPassword);
            this.Controls.Add(this.Btn_AddNewUser);
            this.Controls.Add(this.dataGridUsers);
            this.Controls.Add(this.Btn_Refresh);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ManageUsers";
            this.Text = "ManageUsers";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Refresh;
        private System.Windows.Forms.DataGridView dataGridUsers;
        private System.Windows.Forms.Button Btn_AddNewUser;
        private System.Windows.Forms.Button Btn_ResetPassword;
        private System.Windows.Forms.Button Btn_ActivateDisactivateUser;
    }
}