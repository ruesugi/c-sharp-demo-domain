
namespace c_sharp_demo.WinForm
{
    partial class UserSaveView
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.IDLabel = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.MailCheckBox = new System.Windows.Forms.CheckBox();
            this.MailAddressLabel = new System.Windows.Forms.Label();
            this.MailAddressTextBox = new System.Windows.Forms.TextBox();
            this.PricePlanGroupBox = new System.Windows.Forms.GroupBox();
            this.BusinessRadioButton = new c_sharp_demo_domain.WinForm.BindHelpers.BindableRadioButton();
            this.FreeRadioButton = new c_sharp_demo_domain.WinForm.BindHelpers.BindableRadioButton();
            this.NoteLabel = new System.Windows.Forms.Label();
            this.EnableComboBox = new System.Windows.Forms.ComboBox();
            this.ActionButtonsPanel = new System.Windows.Forms.Panel();
            this.SaveButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.PricePlanGroupBox.SuspendLayout();
            this.ActionButtonsPanel.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(28, 26);
            this.IDLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(32, 24);
            this.IDLabel.TabIndex = 0;
            this.IDLabel.Text = "ID";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(76, 20);
            this.IDTextBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(212, 31);
            this.IDTextBox.TabIndex = 1;
            // 
            // MailCheckBox
            // 
            this.MailCheckBox.AutoSize = true;
            this.MailCheckBox.Location = new System.Drawing.Point(33, 88);
            this.MailCheckBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MailCheckBox.Name = "MailCheckBox";
            this.MailCheckBox.Size = new System.Drawing.Size(203, 28);
            this.MailCheckBox.TabIndex = 2;
            this.MailCheckBox.Text = "メールを送信する";
            this.MailCheckBox.UseVisualStyleBackColor = true;
            this.MailCheckBox.CheckedChanged += new System.EventHandler(this.MailCheckBox_CheckedChanged);
            // 
            // MailAddressLabel
            // 
            this.MailAddressLabel.AutoSize = true;
            this.MailAddressLabel.Location = new System.Drawing.Point(33, 134);
            this.MailAddressLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.MailAddressLabel.Name = "MailAddressLabel";
            this.MailAddressLabel.Size = new System.Drawing.Size(138, 24);
            this.MailAddressLabel.TabIndex = 3;
            this.MailAddressLabel.Text = "メールアドレス";
            // 
            // MailAddressTextBox
            // 
            this.MailAddressTextBox.Location = new System.Drawing.Point(195, 128);
            this.MailAddressTextBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MailAddressTextBox.Name = "MailAddressTextBox";
            this.MailAddressTextBox.Size = new System.Drawing.Size(212, 31);
            this.MailAddressTextBox.TabIndex = 4;
            // 
            // PricePlanGroupBox
            // 
            this.PricePlanGroupBox.Controls.Add(this.BusinessRadioButton);
            this.PricePlanGroupBox.Controls.Add(this.FreeRadioButton);
            this.PricePlanGroupBox.Location = new System.Drawing.Point(37, 198);
            this.PricePlanGroupBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.PricePlanGroupBox.Name = "PricePlanGroupBox";
            this.PricePlanGroupBox.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.PricePlanGroupBox.Size = new System.Drawing.Size(433, 140);
            this.PricePlanGroupBox.TabIndex = 5;
            this.PricePlanGroupBox.TabStop = false;
            this.PricePlanGroupBox.Text = "プラン";
            // 
            // BusinessRadioButton
            // 
            this.BusinessRadioButton.AutoCheck = false;
            this.BusinessRadioButton.AutoSize = true;
            this.BusinessRadioButton.Location = new System.Drawing.Point(245, 60);
            this.BusinessRadioButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.BusinessRadioButton.Name = "BusinessRadioButton";
            this.BusinessRadioButton.Size = new System.Drawing.Size(116, 28);
            this.BusinessRadioButton.TabIndex = 1;
            this.BusinessRadioButton.TabStop = true;
            this.BusinessRadioButton.Text = "ビジネス";
            this.BusinessRadioButton.UseVisualStyleBackColor = true;
            this.BusinessRadioButton.CheckedChanged += new System.EventHandler(this.BusinessRadioButton_CheckedChanged);
            // 
            // FreeRadioButton
            // 
            this.FreeRadioButton.AutoCheck = false;
            this.FreeRadioButton.AutoSize = true;
            this.FreeRadioButton.Location = new System.Drawing.Point(39, 60);
            this.FreeRadioButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.FreeRadioButton.Name = "FreeRadioButton";
            this.FreeRadioButton.Size = new System.Drawing.Size(89, 28);
            this.FreeRadioButton.TabIndex = 0;
            this.FreeRadioButton.TabStop = true;
            this.FreeRadioButton.Text = "無料";
            this.FreeRadioButton.UseVisualStyleBackColor = true;
            // 
            // NoteLabel
            // 
            this.NoteLabel.AutoSize = true;
            this.NoteLabel.Location = new System.Drawing.Point(33, 344);
            this.NoteLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.NoteLabel.Name = "NoteLabel";
            this.NoteLabel.Size = new System.Drawing.Size(183, 24);
            this.NoteLabel.TabIndex = 6;
            this.NoteLabel.Text = "無制限で使えます";
            // 
            // EnableComboBox
            // 
            this.EnableComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EnableComboBox.FormattingEnabled = true;
            this.EnableComboBox.Location = new System.Drawing.Point(37, 406);
            this.EnableComboBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.EnableComboBox.Name = "EnableComboBox";
            this.EnableComboBox.Size = new System.Drawing.Size(258, 32);
            this.EnableComboBox.TabIndex = 7;
            // 
            // ActionButtonsPanel
            // 
            this.ActionButtonsPanel.Controls.Add(this.SaveButton);
            this.ActionButtonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ActionButtonsPanel.Location = new System.Drawing.Point(0, 466);
            this.ActionButtonsPanel.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ActionButtonsPanel.Name = "ActionButtonsPanel";
            this.ActionButtonsPanel.Size = new System.Drawing.Size(615, 118);
            this.ActionButtonsPanel.TabIndex = 8;
            // 
            // SaveButton
            // 
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.SaveButton.Location = new System.Drawing.Point(0, 0);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(163, 118);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "保存";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusText});
            this.statusStrip1.Location = new System.Drawing.Point(0, 584);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(615, 38);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusText
            // 
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(0, 28);
            // 
            // UserSaveView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 622);
            this.Controls.Add(this.ActionButtonsPanel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.EnableComboBox);
            this.Controls.Add(this.NoteLabel);
            this.Controls.Add(this.PricePlanGroupBox);
            this.Controls.Add(this.MailAddressTextBox);
            this.Controls.Add(this.MailAddressLabel);
            this.Controls.Add(this.MailCheckBox);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.IDLabel);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "UserSaveView";
            this.Text = "ユーザー登録";
            this.PricePlanGroupBox.ResumeLayout(false);
            this.PricePlanGroupBox.PerformLayout();
            this.ActionButtonsPanel.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.CheckBox MailCheckBox;
        private System.Windows.Forms.Label MailAddressLabel;
        private System.Windows.Forms.TextBox MailAddressTextBox;
        private System.Windows.Forms.GroupBox PricePlanGroupBox;
        private c_sharp_demo_domain.WinForm.BindHelpers.BindableRadioButton BusinessRadioButton;
        private c_sharp_demo_domain.WinForm.BindHelpers.BindableRadioButton FreeRadioButton;
        private System.Windows.Forms.Label NoteLabel;
        private System.Windows.Forms.ComboBox EnableComboBox;
        private System.Windows.Forms.Panel ActionButtonsPanel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusText;
    }
}

