using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BoIRResourceEditor.FormUtils
{
    public partial class PathForm : Form
    {
        private Action<DecryptionInfos> _decryptAction;
        private DecryptionInfos _pathData;
        private System.Threading.Timer _timer;
        

        public PathForm(Action<DecryptionInfos> decryptAction)
        {
            _decryptAction = decryptAction;
            InitializeComponent();
            LoadPaths();
        }

        private void LoadPaths()
        {
            _pathData = new DecryptionInfos();
            bsPaths.Add(_pathData);
            txtSteamLocation.DataBindings[0].Parse += Path_Parse;
            txtOutputLocation.DataBindings[0].Parse += Path_Parse;
            

            //windows accepts both forward and back slashes, so i will use the ones that work everywhere
            
            string homeDir = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

            string steamDir = (string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\Valve\Steam", "SteamPath", "C:/Program Files (x86)/Steam");
            steamDir = steamDir.Replace("/", "\\");
            _pathData.SteamLocation= new DirectoryInfo(Path.Combine(steamDir, "SteamApps\\common\\The Binding of Isaac Rebirth"));
            _pathData.OutputLocation = new DirectoryInfo(Directory.GetCurrentDirectory() + "\\output");
        }

        private void Path_Parse(object sender, ConvertEventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (sender == null) return;

            e.Value = new DirectoryInfo((string)e.Value);
        }

        private void lnkSource_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/bladecoding/BoIRResourceDecryption");
        }

        private void lnkContribute_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/ceparent/BoIRResourceDecryption");
        }

        private void btnSteamLocation_Click(object sender, EventArgs e)
        {

            brsFolderBrowser.SelectedPath = txtSteamLocation.Text;
            brsFolderBrowser.ShowDialog();
            txtSteamLocation.Text = brsFolderBrowser.SelectedPath;
            txtSteamLocation.DataBindings[0].WriteValue();

        }

        private void btnOutputLocation_Click(object sender, EventArgs e)
        {
            brsFolderBrowser.SelectedPath = txtOutputLocation.Text;
            brsFolderBrowser.ShowDialog();
            txtOutputLocation.Text = brsFolderBrowser.SelectedPath;
            txtOutputLocation.DataBindings[0].WriteValue();
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            btnDecrypt.Enabled = false;

            _timer = new System.Threading.Timer(
                d => txtConsole.BeginInvoke((Action)(() =>
                {
                    txtConsole.DataBindings[0].ReadValue();
                })),
                null,
                TimeSpan.FromSeconds(1),   // Start in one second
                TimeSpan.FromSeconds(1)    // Every second
            );

            new Thread(() =>
            {
                try
                {
                    _decryptAction(_pathData);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    _timer = null;
                    btnDecrypt.BeginInvoke((Action)(() =>
                    {
                        btnDecrypt.Enabled = true;
                    }));

                    
                }
            }).Start();
            
            
        }
    }
}
