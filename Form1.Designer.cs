namespace CloudflareDDNS_UpdaterGUI
{
    partial class Form1
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
            materialTabControl = new MaterialSkin.Controls.MaterialTabControl();
            tabConfig = new TabPage();
            btnSaveConfig = new MaterialSkin.Controls.MaterialButton();
            txtDomain = new MaterialSkin.Controls.MaterialTextBox();
            txtEmail = new MaterialSkin.Controls.MaterialTextBox();
            txtApiKey = new MaterialSkin.Controls.MaterialTextBox();
            lblConfig = new MaterialSkin.Controls.MaterialLabel();
            tabDomains = new TabPage();
            lblStatus = new MaterialSkin.Controls.MaterialLabel();
            lblDomainInfo = new MaterialSkin.Controls.MaterialLabel();
            btnUpdateAll = new MaterialSkin.Controls.MaterialButton();
            btnUpdateSelected = new MaterialSkin.Controls.MaterialButton();
            btnRefresh = new MaterialSkin.Controls.MaterialButton();
            lblRecords = new MaterialSkin.Controls.MaterialLabel();
            lstRecords = new ListView();
            lblDomains = new MaterialSkin.Controls.MaterialLabel();
            lstDomains = new ListBox();
            lblCurrentIp = new MaterialSkin.Controls.MaterialLabel();
            materialTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            materialTabControl.SuspendLayout();
            tabConfig.SuspendLayout();
            tabDomains.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl
            // 
            materialTabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            materialTabControl.Controls.Add(tabConfig);
            materialTabControl.Controls.Add(tabDomains);
            materialTabControl.Depth = 0;
            materialTabControl.Location = new Point(6, 106);
            materialTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl.Multiline = true;
            materialTabControl.Name = "materialTabControl";
            materialTabControl.SelectedIndex = 0;
            materialTabControl.Size = new Size(788, 457);
            materialTabControl.TabIndex = 0;
            // 
            // tabConfig
            // 
            tabConfig.BackColor = Color.White;
            tabConfig.Controls.Add(btnSaveConfig);
            tabConfig.Controls.Add(txtDomain);
            tabConfig.Controls.Add(txtEmail);
            tabConfig.Controls.Add(txtApiKey);
            tabConfig.Controls.Add(lblConfig);
            tabConfig.Location = new Point(4, 24);
            tabConfig.Name = "tabConfig";
            tabConfig.Padding = new Padding(3);
            tabConfig.Size = new Size(780, 429);
            tabConfig.TabIndex = 0;
            tabConfig.Text = "Configuration";
            // 
            // btnSaveConfig
            // 
            btnSaveConfig.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSaveConfig.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSaveConfig.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSaveConfig.Depth = 0;
            btnSaveConfig.HighEmphasis = true;
            btnSaveConfig.Icon = null;
            btnSaveConfig.Location = new Point(649, 242);
            btnSaveConfig.Margin = new Padding(4, 6, 4, 6);
            btnSaveConfig.MouseState = MaterialSkin.MouseState.HOVER;
            btnSaveConfig.Name = "btnSaveConfig";
            btnSaveConfig.NoAccentTextColor = Color.Empty;
            btnSaveConfig.Size = new Size(64, 36);
            btnSaveConfig.TabIndex = 4;
            btnSaveConfig.Text = "Save";
            btnSaveConfig.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSaveConfig.UseAccentColor = false;
            btnSaveConfig.UseVisualStyleBackColor = true;
            // 
            // txtDomain
            // 
            txtDomain.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDomain.AnimateReadOnly = false;
            txtDomain.BorderStyle = BorderStyle.None;
            txtDomain.Depth = 0;
            txtDomain.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDomain.Hint = "Domain Name";
            txtDomain.LeadingIcon = null;
            txtDomain.Location = new Point(22, 182);
            txtDomain.MaxLength = 50;
            txtDomain.MouseState = MaterialSkin.MouseState.OUT;
            txtDomain.Multiline = false;
            txtDomain.Name = "txtDomain";
            txtDomain.Size = new Size(691, 50);
            txtDomain.TabIndex = 3;
            txtDomain.Text = "";
            txtDomain.TrailingIcon = null;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.AnimateReadOnly = false;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Depth = 0;
            txtEmail.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmail.Hint = "Email";
            txtEmail.LeadingIcon = null;
            txtEmail.Location = new Point(22, 126);
            txtEmail.MaxLength = 50;
            txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(691, 50);
            txtEmail.TabIndex = 2;
            txtEmail.Text = "";
            txtEmail.TrailingIcon = null;
            // 
            // txtApiKey
            // 
            txtApiKey.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtApiKey.AnimateReadOnly = false;
            txtApiKey.BorderStyle = BorderStyle.None;
            txtApiKey.Depth = 0;
            txtApiKey.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtApiKey.Hint = "API Key";
            txtApiKey.LeadingIcon = null;
            txtApiKey.Location = new Point(22, 70);
            txtApiKey.MaxLength = 100;
            txtApiKey.MouseState = MaterialSkin.MouseState.OUT;
            txtApiKey.Multiline = false;
            txtApiKey.Name = "txtApiKey";
            txtApiKey.Password = true;
            txtApiKey.Size = new Size(691, 50);
            txtApiKey.TabIndex = 1;
            txtApiKey.Text = "";
            txtApiKey.TrailingIcon = null;
            // 
            // lblConfig
            // 
            lblConfig.AutoSize = true;
            lblConfig.Depth = 0;
            lblConfig.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblConfig.Location = new Point(22, 26);
            lblConfig.MouseState = MaterialSkin.MouseState.HOVER;
            lblConfig.Name = "lblConfig";
            lblConfig.Size = new Size(203, 19);
            lblConfig.TabIndex = 0;
            lblConfig.Text = "Cloudflare API Configuration";
            // 
            // tabDomains
            // 
            tabDomains.BackColor = Color.White;
            tabDomains.Controls.Add(lblStatus);
            tabDomains.Controls.Add(lblDomainInfo);
            tabDomains.Controls.Add(btnUpdateAll);
            tabDomains.Controls.Add(btnUpdateSelected);
            tabDomains.Controls.Add(btnRefresh);
            tabDomains.Controls.Add(lblRecords);
            tabDomains.Controls.Add(lstRecords);
            tabDomains.Controls.Add(lblDomains);
            tabDomains.Controls.Add(lstDomains);
            tabDomains.Location = new Point(4, 24);
            tabDomains.Name = "tabDomains";
            tabDomains.Padding = new Padding(3);
            tabDomains.Size = new Size(780, 429);
            tabDomains.TabIndex = 1;
            tabDomains.Text = "Domains";
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblStatus.Depth = 0;
            lblStatus.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblStatus.Location = new Point(16, 397);
            lblStatus.MouseState = MaterialSkin.MouseState.HOVER;
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(746, 20);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "Status: Ready";
            // 
            // lblDomainInfo
            // 
            lblDomainInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDomainInfo.Depth = 0;
            lblDomainInfo.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblDomainInfo.Location = new Point(16, 135);
            lblDomainInfo.MouseState = MaterialSkin.MouseState.HOVER;
            lblDomainInfo.Name = "lblDomainInfo";
            lblDomainInfo.Size = new Size(746, 19);
            lblDomainInfo.TabIndex = 7;
            lblDomainInfo.Text = "Domain Information";
            // 
            // btnUpdateAll
            // 
            btnUpdateAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUpdateAll.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdateAll.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpdateAll.Depth = 0;
            btnUpdateAll.HighEmphasis = true;
            btnUpdateAll.Icon = null;
            btnUpdateAll.Location = new Point(656, 349);
            btnUpdateAll.Margin = new Padding(4, 6, 4, 6);
            btnUpdateAll.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdateAll.Name = "btnUpdateAll";
            btnUpdateAll.NoAccentTextColor = Color.Empty;
            btnUpdateAll.Size = new Size(106, 36);
            btnUpdateAll.TabIndex = 6;
            btnUpdateAll.Text = "Update All";
            btnUpdateAll.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUpdateAll.UseAccentColor = false;
            btnUpdateAll.UseVisualStyleBackColor = true;
            // 
            // btnUpdateSelected
            // 
            btnUpdateSelected.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUpdateSelected.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdateSelected.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpdateSelected.Depth = 0;
            btnUpdateSelected.HighEmphasis = true;
            btnUpdateSelected.Icon = null;
            btnUpdateSelected.Location = new Point(488, 349);
            btnUpdateSelected.Margin = new Padding(4, 6, 4, 6);
            btnUpdateSelected.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdateSelected.Name = "btnUpdateSelected";
            btnUpdateSelected.NoAccentTextColor = Color.Empty;
            btnUpdateSelected.Size = new Size(151, 36);
            btnUpdateSelected.TabIndex = 5;
            btnUpdateSelected.Text = "Update Selected";
            btnUpdateSelected.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUpdateSelected.UseAccentColor = false;
            btnUpdateSelected.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRefresh.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRefresh.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnRefresh.Depth = 0;
            btnRefresh.HighEmphasis = true;
            btnRefresh.Icon = null;
            btnRefresh.Location = new Point(16, 349);
            btnRefresh.Margin = new Padding(4, 6, 4, 6);
            btnRefresh.MouseState = MaterialSkin.MouseState.HOVER;
            btnRefresh.Name = "btnRefresh";
            btnRefresh.NoAccentTextColor = Color.Empty;
            btnRefresh.Size = new Size(84, 36);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnRefresh.UseAccentColor = false;
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // lblRecords
            // 
            lblRecords.AutoSize = true;
            lblRecords.Depth = 0;
            lblRecords.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblRecords.Location = new Point(16, 164);
            lblRecords.MouseState = MaterialSkin.MouseState.HOVER;
            lblRecords.Name = "lblRecords";
            lblRecords.Size = new Size(94, 19);
            lblRecords.TabIndex = 3;
            lblRecords.Text = "DNS Records";
            // 
            // lstRecords
            // 
            lstRecords.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstRecords.Location = new Point(16, 186);
            lstRecords.Name = "lstRecords";
            lstRecords.Size = new Size(746, 154);
            lstRecords.TabIndex = 2;
            lstRecords.UseCompatibleStateImageBehavior = false;
            lstRecords.View = View.List;
            // 
            // lblDomains
            // 
            lblDomains.AutoSize = true;
            lblDomains.Depth = 0;
            lblDomains.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblDomains.Location = new Point(16, 16);
            lblDomains.MouseState = MaterialSkin.MouseState.HOVER;
            lblDomains.Name = "lblDomains";
            lblDomains.Size = new Size(65, 19);
            lblDomains.TabIndex = 1;
            lblDomains.Text = "Domains";
            // 
            // lstDomains
            // 
            lstDomains.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lstDomains.FormattingEnabled = true;
            lstDomains.ItemHeight = 15;
            lstDomains.Location = new Point(16, 38);
            lstDomains.Name = "lstDomains";
            lstDomains.Size = new Size(746, 94);
            lstDomains.TabIndex = 0;
            // 
            // lblCurrentIp
            // 
            lblCurrentIp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblCurrentIp.Depth = 0;
            lblCurrentIp.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblCurrentIp.Location = new Point(402, 81);
            lblCurrentIp.MouseState = MaterialSkin.MouseState.HOVER;
            lblCurrentIp.Name = "lblCurrentIp";
            lblCurrentIp.Size = new Size(392, 19);
            lblCurrentIp.TabIndex = 2;
            lblCurrentIp.Text = "Current IP: -";
            lblCurrentIp.TextAlign = ContentAlignment.MiddleRight;
            // 
            // materialTabSelector
            // 
            materialTabSelector.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            materialTabSelector.BaseTabControl = materialTabControl;
            materialTabSelector.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            materialTabSelector.Depth = 0;
            materialTabSelector.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTabSelector.Location = new Point(6, 67);
            materialTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabSelector.Name = "materialTabSelector";
            materialTabSelector.Size = new Size(362, 33);
            materialTabSelector.TabIndex = 1;
            materialTabSelector.Text = "materialTabSelector1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 569);
            Controls.Add(lblCurrentIp);
            Controls.Add(materialTabSelector);
            Controls.Add(materialTabControl);
            Name = "Form1";
            Text = "Cloudflare DDNS Updater";
            materialTabControl.ResumeLayout(false);
            tabConfig.ResumeLayout(false);
            tabConfig.PerformLayout();
            tabDomains.ResumeLayout(false);
            tabDomains.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl;
        private TabPage tabConfig;
        private TabPage tabDomains;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector;
        private MaterialSkin.Controls.MaterialLabel lblConfig;
        private MaterialSkin.Controls.MaterialTextBox txtApiKey;
        private MaterialSkin.Controls.MaterialTextBox txtEmail;
        private MaterialSkin.Controls.MaterialTextBox txtDomain;
        private MaterialSkin.Controls.MaterialButton btnSaveConfig;
        private ListBox lstDomains;
        private MaterialSkin.Controls.MaterialLabel lblDomains;
        private ListView lstRecords;
        private MaterialSkin.Controls.MaterialLabel lblRecords;
        private MaterialSkin.Controls.MaterialButton btnRefresh;
        private MaterialSkin.Controls.MaterialButton btnUpdateSelected;
        private MaterialSkin.Controls.MaterialButton btnUpdateAll;
        private MaterialSkin.Controls.MaterialLabel lblDomainInfo;
        private MaterialSkin.Controls.MaterialLabel lblStatus;
        private MaterialSkin.Controls.MaterialLabel lblCurrentIp;
    }
}
