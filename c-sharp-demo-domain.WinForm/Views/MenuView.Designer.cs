
namespace c_sharp_demo_domain.WinForm.Views
{
    partial class MenuView
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
            this.UserSaveViewButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserSaveViewButton
            // 
            this.UserSaveViewButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserSaveViewButton.Location = new System.Drawing.Point(0, 0);
            this.UserSaveViewButton.Name = "UserSaveViewButton";
            this.UserSaveViewButton.Size = new System.Drawing.Size(284, 40);
            this.UserSaveViewButton.TabIndex = 0;
            this.UserSaveViewButton.Text = "ユーザー登録";
            this.UserSaveViewButton.UseVisualStyleBackColor = true;
            this.UserSaveViewButton.Click += new System.EventHandler(this.UserSaveViewButton_Click);
            // 
            // MenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.UserSaveViewButton);
            this.Name = "MenuView";
            this.Text = "メニュー";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UserSaveViewButton;
    }
}