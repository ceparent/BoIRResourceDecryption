namespace BoIRResourceEditor.FormUtils
{
    partial class PathForm
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
            this.components = new System.ComponentModel.Container();
            this.lnkSource = new System.Windows.Forms.LinkLabel();
            this.lnkContribute = new System.Windows.Forms.LinkLabel();
            this.lblBasedOn = new System.Windows.Forms.Label();
            this.brsFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSteamLocation = new System.Windows.Forms.Button();
            this.txtSteamLocation = new System.Windows.Forms.TextBox();
            this.lblSteamLocation = new System.Windows.Forms.Label();
            this.lblOutputLocation = new System.Windows.Forms.Label();
            this.txtOutputLocation = new System.Windows.Forms.TextBox();
            this.btnOutputLocation = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.txtConsole = new System.Windows.Forms.RichTextBox();
            this.bsPaths = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsPaths)).BeginInit();
            this.SuspendLayout();
            // 
            // lnkSource
            // 
            this.lnkSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkSource.AutoSize = true;
            this.lnkSource.Location = new System.Drawing.Point(267, 355);
            this.lnkSource.Name = "lnkSource";
            this.lnkSource.Size = new System.Drawing.Size(191, 13);
            this.lnkSource.TabIndex = 1;
            this.lnkSource.TabStop = true;
            this.lnkSource.Text = "bladecoding/BoIRResourceDecryption";
            this.lnkSource.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSource_LinkClicked);
            // 
            // lnkContribute
            // 
            this.lnkContribute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkContribute.AutoSize = true;
            this.lnkContribute.Location = new System.Drawing.Point(170, 355);
            this.lnkContribute.Name = "lnkContribute";
            this.lnkContribute.Size = new System.Drawing.Size(44, 13);
            this.lnkContribute.TabIndex = 2;
            this.lnkContribute.TabStop = true;
            this.lnkContribute.Text = "Git repo";
            this.lnkContribute.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkContribute_LinkClicked);
            // 
            // lblBasedOn
            // 
            this.lblBasedOn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBasedOn.AutoSize = true;
            this.lblBasedOn.Location = new System.Drawing.Point(220, 355);
            this.lblBasedOn.Name = "lblBasedOn";
            this.lblBasedOn.Size = new System.Drawing.Size(52, 13);
            this.lblBasedOn.TabIndex = 3;
            this.lblBasedOn.Text = "Based on";
            // 
            // btnSteamLocation
            // 
            this.btnSteamLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSteamLocation.Location = new System.Drawing.Point(426, 45);
            this.btnSteamLocation.Name = "btnSteamLocation";
            this.btnSteamLocation.Size = new System.Drawing.Size(32, 20);
            this.btnSteamLocation.TabIndex = 4;
            this.btnSteamLocation.Text = "...";
            this.btnSteamLocation.UseVisualStyleBackColor = true;
            this.btnSteamLocation.Click += new System.EventHandler(this.btnSteamLocation_Click);
            // 
            // txtSteamLocation
            // 
            this.txtSteamLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSteamLocation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPaths, "SteamLocation", true));
            this.txtSteamLocation.Location = new System.Drawing.Point(12, 45);
            this.txtSteamLocation.Name = "txtSteamLocation";
            this.txtSteamLocation.Size = new System.Drawing.Size(408, 20);
            this.txtSteamLocation.TabIndex = 5;
            // 
            // lblSteamLocation
            // 
            this.lblSteamLocation.AutoSize = true;
            this.lblSteamLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSteamLocation.Location = new System.Drawing.Point(12, 20);
            this.lblSteamLocation.Name = "lblSteamLocation";
            this.lblSteamLocation.Size = new System.Drawing.Size(287, 20);
            this.lblSteamLocation.TabIndex = 6;
            this.lblSteamLocation.Text = "Steam location (Binding of Isaac folder)";
            // 
            // lblOutputLocation
            // 
            this.lblOutputLocation.AutoSize = true;
            this.lblOutputLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputLocation.Location = new System.Drawing.Point(12, 69);
            this.lblOutputLocation.Name = "lblOutputLocation";
            this.lblOutputLocation.Size = new System.Drawing.Size(123, 20);
            this.lblOutputLocation.TabIndex = 9;
            this.lblOutputLocation.Text = "Output Location";
            // 
            // txtOutputLocation
            // 
            this.txtOutputLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutputLocation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPaths, "OutputLocation", true));
            this.txtOutputLocation.Location = new System.Drawing.Point(12, 94);
            this.txtOutputLocation.Name = "txtOutputLocation";
            this.txtOutputLocation.Size = new System.Drawing.Size(408, 20);
            this.txtOutputLocation.TabIndex = 8;
            // 
            // btnOutputLocation
            // 
            this.btnOutputLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOutputLocation.Location = new System.Drawing.Point(426, 94);
            this.btnOutputLocation.Name = "btnOutputLocation";
            this.btnOutputLocation.Size = new System.Drawing.Size(32, 20);
            this.btnOutputLocation.TabIndex = 7;
            this.btnOutputLocation.Text = "...";
            this.btnOutputLocation.UseVisualStyleBackColor = true;
            this.btnOutputLocation.Click += new System.EventHandler(this.btnOutputLocation_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(16, 130);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 10;
            this.btnDecrypt.Text = "Start";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // txtConsole
            // 
            this.txtConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsole.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPaths, "Debug", true));
            this.txtConsole.Location = new System.Drawing.Point(12, 159);
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.Size = new System.Drawing.Size(446, 193);
            this.txtConsole.TabIndex = 11;
            this.txtConsole.Text = "";
            // 
            // bsPaths
            // 
            this.bsPaths.DataSource = typeof(BoIRResourceEditor.FormUtils.DecryptionInfos);
            // 
            // PathForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 377);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.lblOutputLocation);
            this.Controls.Add(this.txtOutputLocation);
            this.Controls.Add(this.btnOutputLocation);
            this.Controls.Add(this.lblSteamLocation);
            this.Controls.Add(this.txtSteamLocation);
            this.Controls.Add(this.btnSteamLocation);
            this.Controls.Add(this.lnkSource);
            this.Controls.Add(this.lblBasedOn);
            this.Controls.Add(this.lnkContribute);
            this.Name = "PathForm";
            this.Text = "Binding of Isaac resource decryption tool ";
            ((System.ComponentModel.ISupportInitialize)(this.bsPaths)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel lnkSource;
        private System.Windows.Forms.LinkLabel lnkContribute;
        private System.Windows.Forms.Label lblBasedOn;
        private System.Windows.Forms.FolderBrowserDialog brsFolderBrowser;
        private System.Windows.Forms.Button btnSteamLocation;
        private System.Windows.Forms.TextBox txtSteamLocation;
        private System.Windows.Forms.Label lblSteamLocation;
        private System.Windows.Forms.Label lblOutputLocation;
        private System.Windows.Forms.TextBox txtOutputLocation;
        private System.Windows.Forms.Button btnOutputLocation;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.BindingSource bsPaths;
        private System.Windows.Forms.RichTextBox txtConsole;
    }
}