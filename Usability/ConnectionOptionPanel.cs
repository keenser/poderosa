﻿// Copyright 2005-2017 The Poderosa Project.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

using Poderosa.Protocols;
using Poderosa.Usability;
using Poderosa.Preferences;
using Poderosa.UI;
using Poderosa.Util;

namespace Poderosa.Forms {

    internal class ConnectionOptionPanel : UserControl {
        private System.Windows.Forms.GroupBox _socksGroup;
        private CheckBox _useSocks;
        private System.Windows.Forms.Label _socksServerLabel;
        private TextBox _socksServerBox;
        private System.Windows.Forms.Label _socksPortLabel;
        private TextBox _socksPortBox;
        private System.Windows.Forms.Label _socksAccountLabel;
        private TextBox _socksAccountBox;
        private System.Windows.Forms.Label _socksPasswordLabel;
        private TextBox _socksPasswordBox;
        private System.Windows.Forms.Label _socksNANetworksLabel;
        private TextBox _socksNANetworksBox;

        private GroupBox _IPv6Group;
        private Label _IPv6PriorityLabel;
        private ComboBox _IPv6PriorityBox;

        public ConnectionOptionPanel() {
            InitializeComponent();
            FillText();
        }
        private void InitializeComponent() {
            this._socksGroup = new System.Windows.Forms.GroupBox();
            this._socksServerLabel = new System.Windows.Forms.Label();
            this._socksServerBox = new System.Windows.Forms.TextBox();
            this._socksPortLabel = new System.Windows.Forms.Label();
            this._socksPortBox = new System.Windows.Forms.TextBox();
            this._socksAccountLabel = new System.Windows.Forms.Label();
            this._socksAccountBox = new System.Windows.Forms.TextBox();
            this._socksPasswordLabel = new System.Windows.Forms.Label();
            this._socksPasswordBox = new System.Windows.Forms.TextBox();
            this._socksNANetworksLabel = new System.Windows.Forms.Label();
            this._socksNANetworksBox = new System.Windows.Forms.TextBox();
            this._useSocks = new System.Windows.Forms.CheckBox();
            this._IPv6Group = new System.Windows.Forms.GroupBox();
            this._IPv6PriorityLabel = new System.Windows.Forms.Label();
            this._IPv6PriorityBox = new System.Windows.Forms.ComboBox();
            this._socksGroup.SuspendLayout();
            this._IPv6Group.SuspendLayout();
            this.SuspendLayout();
            // 
            // _socksGroup
            // 
            this._socksGroup.Controls.Add(this._socksServerLabel);
            this._socksGroup.Controls.Add(this._socksServerBox);
            this._socksGroup.Controls.Add(this._socksPortLabel);
            this._socksGroup.Controls.Add(this._socksPortBox);
            this._socksGroup.Controls.Add(this._socksAccountLabel);
            this._socksGroup.Controls.Add(this._socksAccountBox);
            this._socksGroup.Controls.Add(this._socksPasswordLabel);
            this._socksGroup.Controls.Add(this._socksPasswordBox);
            this._socksGroup.Controls.Add(this._socksNANetworksLabel);
            this._socksGroup.Controls.Add(this._socksNANetworksBox);
            this._socksGroup.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._socksGroup.Location = new System.Drawing.Point(8, 8);
            this._socksGroup.Name = "_socksGroup";
            this._socksGroup.Size = new System.Drawing.Size(416, 128);
            this._socksGroup.TabIndex = 2;
            this._socksGroup.TabStop = false;
            // 
            // _socksServerLabel
            // 
            this._socksServerLabel.Location = new System.Drawing.Point(8, 18);
            this._socksServerLabel.Name = "_socksServerLabel";
            this._socksServerLabel.Size = new System.Drawing.Size(80, 23);
            this._socksServerLabel.TabIndex = 0;
            this._socksServerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _socksServerBox
            // 
            this._socksServerBox.Enabled = false;
            this._socksServerBox.Location = new System.Drawing.Point(96, 18);
            this._socksServerBox.Name = "_socksServerBox";
            this._socksServerBox.Size = new System.Drawing.Size(104, 22);
            this._socksServerBox.TabIndex = 1;
            // 
            // _socksPortLabel
            // 
            this._socksPortLabel.Location = new System.Drawing.Point(216, 18);
            this._socksPortLabel.Name = "_socksPortLabel";
            this._socksPortLabel.Size = new System.Drawing.Size(80, 23);
            this._socksPortLabel.TabIndex = 2;
            this._socksPortLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _socksPortBox
            // 
            this._socksPortBox.Enabled = false;
            this._socksPortBox.Location = new System.Drawing.Point(304, 18);
            this._socksPortBox.MaxLength = 5;
            this._socksPortBox.Name = "_socksPortBox";
            this._socksPortBox.Size = new System.Drawing.Size(104, 22);
            this._socksPortBox.TabIndex = 3;
            // 
            // _socksAccountLabel
            // 
            this._socksAccountLabel.Location = new System.Drawing.Point(8, 40);
            this._socksAccountLabel.Name = "_socksAccountLabel";
            this._socksAccountLabel.Size = new System.Drawing.Size(80, 23);
            this._socksAccountLabel.TabIndex = 4;
            this._socksAccountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _socksAccountBox
            // 
            this._socksAccountBox.Enabled = false;
            this._socksAccountBox.Location = new System.Drawing.Point(96, 40);
            this._socksAccountBox.Name = "_socksAccountBox";
            this._socksAccountBox.Size = new System.Drawing.Size(104, 22);
            this._socksAccountBox.TabIndex = 5;
            // 
            // _socksPasswordLabel
            // 
            this._socksPasswordLabel.Location = new System.Drawing.Point(216, 40);
            this._socksPasswordLabel.Name = "_socksPasswordLabel";
            this._socksPasswordLabel.Size = new System.Drawing.Size(80, 23);
            this._socksPasswordLabel.TabIndex = 6;
            this._socksPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _socksPasswordBox
            // 
            this._socksPasswordBox.Enabled = false;
            this._socksPasswordBox.Location = new System.Drawing.Point(304, 40);
            this._socksPasswordBox.Name = "_socksPasswordBox";
            this._socksPasswordBox.PasswordChar = '*';
            this._socksPasswordBox.Size = new System.Drawing.Size(104, 22);
            this._socksPasswordBox.TabIndex = 7;
            // 
            // _socksNANetworksLabel
            // 
            this._socksNANetworksLabel.Location = new System.Drawing.Point(8, 68);
            this._socksNANetworksLabel.Name = "_socksNANetworksLabel";
            this._socksNANetworksLabel.Size = new System.Drawing.Size(400, 28);
            this._socksNANetworksLabel.TabIndex = 8;
            this._socksNANetworksLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _socksNANetworksBox
            // 
            this._socksNANetworksBox.Enabled = false;
            this._socksNANetworksBox.Location = new System.Drawing.Point(8, 98);
            this._socksNANetworksBox.Name = "_socksNANetworksBox";
            this._socksNANetworksBox.Size = new System.Drawing.Size(400, 22);
            this._socksNANetworksBox.TabIndex = 9;
            // 
            // _useSocks
            // 
            this._useSocks.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._useSocks.Location = new System.Drawing.Point(16, 3);
            this._useSocks.Name = "_useSocks";
            this._useSocks.Size = new System.Drawing.Size(160, 23);
            this._useSocks.TabIndex = 1;
            this._useSocks.CheckedChanged += new System.EventHandler(this.OnUseSocksOptionChanged);
            // 
            // _IPv6Group
            // 
            this._IPv6Group.Controls.Add(this._IPv6PriorityLabel);
            this._IPv6Group.Controls.Add(this._IPv6PriorityBox);
            this._IPv6Group.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._IPv6Group.Location = new System.Drawing.Point(8, 144);
            this._IPv6Group.Name = "_IPv6Group";
            this._IPv6Group.Size = new System.Drawing.Size(416, 64);
            this._IPv6Group.TabIndex = 2;
            this._IPv6Group.TabStop = false;
            // 
            // _IPv6PriorityLabel
            // 
            this._IPv6PriorityLabel.Location = new System.Drawing.Point(8, 18);
            this._IPv6PriorityLabel.Name = "_IPv6PriorityLabel";
            this._IPv6PriorityLabel.Size = new System.Drawing.Size(208, 23);
            this._IPv6PriorityLabel.TabIndex = 0;
            this._IPv6PriorityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _IPv6PriorityBox
            // 
            this._IPv6PriorityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._IPv6PriorityBox.Location = new System.Drawing.Point(216, 18);
            this._IPv6PriorityBox.Name = "_IPv6PriorityBox";
            this._IPv6PriorityBox.Size = new System.Drawing.Size(184, 24);
            this._IPv6PriorityBox.TabIndex = 1;
            // 
            // ConnectionOptionPanel
            // 
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this._useSocks);
            this.Controls.Add(this._socksGroup);
            this.Controls.Add(this._IPv6Group);
            this.Name = "ConnectionOptionPanel";
            this._socksGroup.ResumeLayout(false);
            this._socksGroup.PerformLayout();
            this._IPv6Group.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private void FillText() {
            StringResource sr = OptionDialogPlugin.Instance.Strings;
            this._useSocks.Text = sr.GetString("Form.OptionDialog._useSocks");
            this._socksServerLabel.Text = sr.GetString("Form.OptionDialog._socksServerLabel");
            this._socksPortLabel.Text = sr.GetString("Form.OptionDialog._socksPortLabel");
            this._socksAccountLabel.Text = sr.GetString("Form.OptionDialog._socksAccountLabel");
            this._socksPasswordLabel.Text = sr.GetString("Form.OptionDialog._socksPasswordLabel");
            this._socksNANetworksLabel.Text = sr.GetString("Form.OptionDialog._socksNANetworksLabel");

            _IPv6Group.Text = sr.GetString("Form.OptionDialog._IPv6Group");
            _IPv6PriorityLabel.Text = sr.GetString("Form.OptionDialog._IPv6PriorityLabel");
            _IPv6PriorityBox.Items.AddRange(EnumListItem<IPVersionPriority>.GetListItems());
        }
        public void InitUI(IProtocolOptions options) {
            _useSocks.Checked = options.UseSocks;
            _socksServerBox.Text = options.SocksServer;
            _socksPortBox.Text = options.SocksPort.ToString();
            _socksAccountBox.Text = options.SocksAccount;
            _socksPasswordBox.Text = options.SocksPassword;
            _socksNANetworksBox.Text = options.SocksNANetworks;

            _IPv6PriorityBox.SelectedItem = options.IPVersionPriority;  // select EnumListItem<T> by T
        }
        public bool Commit(IProtocolOptions options) {
            StringResource sr = OptionDialogPlugin.Instance.Strings;
            string itemname = "";
            try {
                options.UseSocks = _useSocks.Checked;
                if (options.UseSocks && _socksServerBox.Text.Length == 0)
                    throw new Exception(sr.GetString("Message.OptionDialog.EmptySocksServer"));
                options.SocksServer = _socksServerBox.Text;
                itemname = sr.GetString("Caption.OptionDialog.SOCKSPortNumber");
                options.SocksPort = Int32.Parse(_socksPortBox.Text);
                options.SocksAccount = _socksAccountBox.Text;
                options.SocksPassword = _socksPasswordBox.Text;
                itemname = sr.GetString("Caption.OptionDialog.NetworkAddress");
                foreach (string c in _socksNANetworksBox.Text.Split(';')) {
                    if (c.Length > 0 && !NetAddressUtil.IsNetworkAddress(c))
                        throw new FormatException(); //TODOここだけナントカすればNetUtilはinternalにできる
                }
                options.SocksNANetworks = _socksNANetworksBox.Text;

                options.IPVersionPriority = ((EnumListItem<IPVersionPriority>)_IPv6PriorityBox.SelectedItem).Value;
                return true;
            }
            catch (FormatException) {
                GUtil.Warning(this, String.Format(sr.GetString("Message.OptionDialog.InvalidItem"), itemname));
                return false;
            }
            catch (Exception ex) {
                GUtil.Warning(this, ex.Message);
                return false;
            }
        }

        private void OnUseSocksOptionChanged(object sender, EventArgs args) {
            bool e = _useSocks.Checked;
            _socksServerBox.Enabled = e;
            _socksPortBox.Enabled = e;
            _socksAccountBox.Enabled = e;
            _socksPasswordBox.Enabled = e;
            _socksNANetworksBox.Enabled = e;
        }
    }


    internal class ConnectionOptionPanelExtension : OptionPanelExtensionBase {

        private ConnectionOptionPanel _panel;

        public ConnectionOptionPanelExtension()
            : base("Form.OptionDialog._connectionPanel", 5) {
        }

        public override string[] PreferenceFolderIDsToEdit {
            get {
                return new string[] { "org.poderosa.protocols" };
            }
        }
        public override Control ContentPanel {
            get {
                return _panel;
            }
        }

        public override void InitiUI(IPreferenceFolder[] values) {
            if (_panel == null)
                _panel = new ConnectionOptionPanel();
            IProtocolOptions opt = (IProtocolOptions)values[0].QueryAdapter(typeof(IProtocolOptions));
            Debug.Assert(opt != null);
            _panel.InitUI(opt);
        }

        public override bool Commit(IPreferenceFolder[] values) {
            Debug.Assert(_panel != null);
            return _panel.Commit((IProtocolOptions)values[0].QueryAdapter(typeof(IProtocolOptions)));
        }

        public override void Dispose() {
            if (_panel != null) {
                _panel.Dispose();
                _panel = null;
            }
        }
    }
}
