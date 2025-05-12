using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CloudflareDDNS_UpdaterGUI.Models;
using CloudflareDDNS_UpdaterGUI.Services;
using MaterialSkin;
using MaterialSkin.Controls;

namespace CloudflareDDNS_UpdaterGUI
{
    public partial class Form1 : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private readonly ConfigurationService _configService;
        private readonly IpService _ipService;

        private CloudflareConfig _config;
        private CloudflareService? _cloudflareService;
        private string _currentIp = string.Empty;
        private List<Domain> _domains = new List<Domain>();

        public Form1()
        {
            InitializeComponent();

            // Initialize MaterialSkin
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.DeepOrange500, Primary.DeepOrange700,
                Primary.DeepOrange100, Accent.DeepOrange200,
                TextShade.WHITE);

            // Initialize services
            _configService = new ConfigurationService();
            _ipService = new IpService();
            
            // Load configuration
            _config = _configService.LoadConfig();
            
            // Populate form with config values
            txtApiKey.Text = _config.ApiKey;
            txtEmail.Text = _config.Email;
            txtDomain.Text = _config.DomainName;

            // Set form properties
            Text = "Cloudflare DDNS Updater";

            // Set up event handlers
            Load += Form1_Load;
            btnSaveConfig.Click += BtnSaveConfig_Click;
            btnRefresh.Click += BtnRefresh_Click;
            btnUpdateSelected.Click += BtnUpdateSelected_Click;
            btnUpdateAll.Click += BtnUpdateAll_Click;
            lstDomains.SelectedIndexChanged += LstDomains_SelectedIndexChanged;
        }

        private async void Form1_Load(object? sender, EventArgs e)
        {
            try
            {
                await UpdateCurrentIp();
                InitializeCloudflareService();
                
                if (_config.IsValid())
                {
                    await LoadDomainsAndRecords();
                }
            }
            catch (Exception ex)
            {
                ShowError($"Error during initialization: {ex.Message}");
            }
        }

        private void InitializeCloudflareService()
        {
            if (_config.IsValid())
            {
                _cloudflareService = new CloudflareService(_config);
            }
        }

        private async Task UpdateCurrentIp()
        {
            try
            {
                _currentIp = await _ipService.GetCurrentIpAsync();
                lblCurrentIp.Text = $"Current IP: {_currentIp}";
            }
            catch (Exception ex)
            {
                ShowError($"Failed to get current IP: {ex.Message}");
            }
        }

        private async Task LoadDomainsAndRecords()
        {
            if (_cloudflareService == null)
            {
                ShowError("Cloudflare service not initialized. Check configuration.");
                return;
            }

            try
            {
                ShowStatus("Loading domains and records...");
                lstDomains.Items.Clear();
                lstRecords.Items.Clear();

                _domains = await _cloudflareService.GetDomainsAsync();
                
                foreach (var domain in _domains)
                {
                    lstDomains.Items.Add(domain);
                }

                if (lstDomains.Items.Count > 0)
                {
                    lstDomains.SelectedIndex = 0;
                }

                ShowStatus($"Loaded {_domains.Count} domains");
            }
            catch (Exception ex)
            {
                ShowError($"Failed to load domains: {ex.Message}");
            }
        }

        private void LstDomains_SelectedIndexChanged(object? sender, EventArgs e)
        {
            lstRecords.Items.Clear();

            if (lstDomains.SelectedItem is Domain selectedDomain)
            {
                foreach (var record in selectedDomain.Records.Where(r => r.Type == "A"))
                {
                    var listViewItem = new ListViewItem(record.ToString()) { Tag = record };
                    lstRecords.Items.Add(listViewItem);

                    if (record.Content != _currentIp)
                    {
                        listViewItem.Selected = true;
                    }
                }

                lblDomainInfo.Text = $"Zone ID: {selectedDomain.Id} | Status: {selectedDomain.Status}";
            }
            else
            {
                lblDomainInfo.Text = string.Empty;
            }
        }



        private async void BtnSaveConfig_Click(object? sender, EventArgs e)
        {
            try
            {
                _config.ApiKey = txtApiKey.Text.Trim();
                _config.Email = txtEmail.Text.Trim();
                _config.DomainName = txtDomain.Text.Trim();

                _configService.SaveConfig(_config);
                InitializeCloudflareService();

                ShowStatus("Configuration saved");

                if (_config.IsValid())
                {
                    await LoadDomainsAndRecords();
                }
            }
            catch (Exception ex)
            {
                ShowError($"Failed to save configuration: {ex.Message}");
            }
        }

        private async void BtnRefresh_Click(object? sender, EventArgs e)
        {
            try
            {
                await UpdateCurrentIp();
                await LoadDomainsAndRecords();
            }
            catch (Exception ex)
            {
                ShowError($"Failed to refresh data: {ex.Message}");
            }
        }

        private async void BtnUpdateSelected_Click(object? sender, EventArgs e)
        {
            if (_cloudflareService == null)
            {
                ShowError("Cloudflare service not initialized. Check configuration.");
                return;
            }

            if (string.IsNullOrEmpty(_currentIp))
            {
                ShowError("Current IP is not available. Try refreshing the data.");
                return;
            }

            try
            {
                int updatedCount = 0;

                foreach (DnsRecord record in lstRecords.SelectedItems)
                {
                    if (record.NeedsUpdate(_currentIp))
                    {
                        ShowStatus($"Updating {record.Name}...");
                        bool success = await _cloudflareService.UpdateDnsRecordAsync(record, _currentIp);
                        if (success)
                        {
                            updatedCount++;
                            record.Content = _currentIp;
                        }
                    }
                }

                await LoadDomainsAndRecords();
                ShowStatus($"Successfully updated {updatedCount} records");
            }
            catch (Exception ex)
            {
                ShowError($"Failed to update records: {ex.Message}");
            }
        }

        private async void BtnUpdateAll_Click(object? sender, EventArgs e)
        {
            if (_cloudflareService == null)
            {
                ShowError("Cloudflare service not initialized. Check configuration.");
                return;
            }

            if (string.IsNullOrEmpty(_currentIp))
            {
                ShowError("Current IP is not available. Try refreshing the data.");
                return;
            }

            try
            {
                int updatedCount = 0;

                foreach (Domain domain in _domains)
                {
                    foreach (var record in domain.Records.Where(r => r.Type == "A" && r.NeedsUpdate(_currentIp)))
                    {
                        ShowStatus($"Updating {record.Name}...");
                        bool success = await _cloudflareService.UpdateDnsRecordAsync(record, _currentIp);
                        if (success)
                        {
                            updatedCount++;
                        }
                    }
                }

                await LoadDomainsAndRecords();
                ShowStatus($"Successfully updated {updatedCount} records");
            }
            catch (Exception ex)
            {
                ShowError($"Failed to update records: {ex.Message}");
            }
        }

        private void ShowStatus(string message)
        {
            lblStatus.ForeColor = Color.DarkGreen;
            lblStatus.Text = message;
        }

        private void ShowError(string message)
        {
            lblStatus.ForeColor = Color.DarkRed;
            lblStatus.Text = message;
        }
    }
}
