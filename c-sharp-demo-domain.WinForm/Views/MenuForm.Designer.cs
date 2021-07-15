
namespace c_sharp_demo_domain.WinForm.Views
{
    partial class MenuForm
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
            this.UserSaveFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserSaveFormButton
            // 
            this.UserSaveFormButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserSaveFormButton.Location = new System.Drawing.Point(0, 0);
            this.UserSaveFormButton.Name = "UserSaveFormButton";
            this.UserSaveFormButton.Size = new System.Drawing.Size(284, 40);
            this.UserSaveFormButton.TabIndex = 0;
            this.UserSaveFormButton.Text = "ユーザー登録";
            this.UserSaveFormButton.UseVisualStyleBackColor = true;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.UserSaveFormButton);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UserSaveFormButton;
    }
}