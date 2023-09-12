namespace Touhou_Launcher
{
    partial class ConfigForm
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
            openFolder = new System.Windows.Forms.Button();
            openvpatch = new System.Windows.Forms.Button();
            jpDir = new System.Windows.Forms.TextBox();
            enDir = new System.Windows.Forms.TextBox();
            customDir = new System.Windows.Forms.TextBox();
            browseJP = new System.Windows.Forms.Button();
            jpLabel = new System.Windows.Forms.Label();
            enLabel = new System.Windows.Forms.Label();
            customLabel = new System.Windows.Forms.Label();
            openReplays = new System.Windows.Forms.Button();
            browseEN = new System.Windows.Forms.Button();
            browseCustom = new System.Windows.Forms.Button();
            jpApplocale = new System.Windows.Forms.CheckBox();
            defaultExec = new System.Windows.Forms.ComboBox();
            defaultLabel = new System.Windows.Forms.Label();
            launchCustom = new System.Windows.Forms.Button();
            launchEN = new System.Windows.Forms.Button();
            launchJP = new System.Windows.Forms.Button();
            launchcrap = new System.Windows.Forms.Button();
            crapLabel = new System.Windows.Forms.Label();
            customApplocale = new System.Windows.Forms.CheckBox();
            defaultApplocale = new System.Windows.Forms.CheckBox();
            crapApplocale = new System.Windows.Forms.CheckBox();
            enApplocale = new System.Windows.Forms.CheckBox();
            chkCustomBanner = new System.Windows.Forms.CheckBox();
            bannerOnLabel = new System.Windows.Forms.Label();
            browseBannerOn = new System.Windows.Forms.Button();
            bannerOnDir = new System.Windows.Forms.TextBox();
            bannerOffLabel = new System.Windows.Forms.Label();
            browseBannerOff = new System.Windows.Forms.Button();
            bannerOffDir = new System.Windows.Forms.TextBox();
            pc98Settings = new System.Windows.Forms.GroupBox();
            openNP2Folder = new System.Windows.Forms.Button();
            launchHDI = new System.Windows.Forms.Button();
            hdiLabel = new System.Windows.Forms.Label();
            browseHDI = new System.Windows.Forms.Button();
            hdiDir = new System.Windows.Forms.TextBox();
            bannerSettings = new System.Windows.Forms.GroupBox();
            chkCustomText = new System.Windows.Forms.CheckBox();
            btnCustomText = new System.Windows.Forms.Button();
            bannerSize = new System.Windows.Forms.Label();
            windowsSettings = new System.Windows.Forms.GroupBox();
            crapCfg = new System.Windows.Forms.ComboBox();
            crapGame = new System.Windows.Forms.ComboBox();
            openAppdata = new System.Windows.Forms.Button();
            pc98Settings.SuspendLayout();
            bannerSettings.SuspendLayout();
            windowsSettings.SuspendLayout();
            SuspendLayout();
            // 
            // openFolder
            // 
            openFolder.Location = new System.Drawing.Point(393, 271);
            openFolder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            openFolder.Name = "openFolder";
            openFolder.Size = new System.Drawing.Size(282, 27);
            openFolder.TabIndex = 3;
            openFolder.Text = "Open Folder";
            openFolder.UseVisualStyleBackColor = true;
            openFolder.Click += openFolder_Click;
            // 
            // openvpatch
            // 
            openvpatch.AutoEllipsis = true;
            openvpatch.Location = new System.Drawing.Point(270, 262);
            openvpatch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            openvpatch.Name = "openvpatch";
            openvpatch.Size = new System.Drawing.Size(106, 27);
            openvpatch.TabIndex = 21;
            openvpatch.Text = "Edit vpatch.ini";
            openvpatch.UseVisualStyleBackColor = true;
            openvpatch.Click += openvpatch_Click;
            // 
            // jpDir
            // 
            jpDir.AllowDrop = true;
            jpDir.Location = new System.Drawing.Point(10, 37);
            jpDir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            jpDir.Name = "jpDir";
            jpDir.Size = new System.Drawing.Size(210, 23);
            jpDir.TabIndex = 1;
            jpDir.DragDrop += Dir_DragDrop;
            jpDir.DragEnter += Dir_DragEnter;
            jpDir.LostFocus += Dir_LostFocus;
            // 
            // enDir
            // 
            enDir.AllowDrop = true;
            enDir.Location = new System.Drawing.Point(10, 92);
            enDir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            enDir.Name = "enDir";
            enDir.Size = new System.Drawing.Size(210, 23);
            enDir.TabIndex = 5;
            enDir.DragDrop += Dir_DragDrop;
            enDir.DragEnter += Dir_DragEnter;
            enDir.LostFocus += Dir_LostFocus;
            // 
            // customDir
            // 
            customDir.AllowDrop = true;
            customDir.Location = new System.Drawing.Point(10, 148);
            customDir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            customDir.Name = "customDir";
            customDir.Size = new System.Drawing.Size(210, 23);
            customDir.TabIndex = 10;
            customDir.DragDrop += Dir_DragDrop;
            customDir.DragEnter += Dir_DragEnter;
            customDir.LostFocus += Dir_LostFocus;
            // 
            // browseJP
            // 
            browseJP.Location = new System.Drawing.Point(229, 35);
            browseJP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            browseJP.Name = "browseJP";
            browseJP.Size = new System.Drawing.Size(72, 25);
            browseJP.TabIndex = 2;
            browseJP.Text = "Browse";
            browseJP.UseVisualStyleBackColor = true;
            browseJP.Click += browse_Click;
            // 
            // jpLabel
            // 
            jpLabel.AutoSize = true;
            jpLabel.Location = new System.Drawing.Point(7, 18);
            jpLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            jpLabel.Name = "jpLabel";
            jpLabel.Size = new System.Drawing.Size(158, 15);
            jpLabel.TabIndex = 6;
            jpLabel.Text = "Japanese/vpatch Executable:";
            // 
            // enLabel
            // 
            enLabel.AutoSize = true;
            enLabel.Location = new System.Drawing.Point(7, 74);
            enLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            enLabel.Name = "enLabel";
            enLabel.Size = new System.Drawing.Size(108, 15);
            enLabel.TabIndex = 7;
            enLabel.Text = "English Executable:";
            // 
            // customLabel
            // 
            customLabel.AutoSize = true;
            customLabel.Location = new System.Drawing.Point(7, 129);
            customLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            customLabel.Name = "customLabel";
            customLabel.Size = new System.Drawing.Size(73, 15);
            customLabel.TabIndex = 8;
            customLabel.Text = "Custom.exe:";
            // 
            // openReplays
            // 
            openReplays.AutoEllipsis = true;
            openReplays.Location = new System.Drawing.Point(124, 262);
            openReplays.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            openReplays.Name = "openReplays";
            openReplays.Size = new System.Drawing.Size(139, 27);
            openReplays.TabIndex = 20;
            openReplays.Text = "Open Replays Folder";
            openReplays.UseVisualStyleBackColor = true;
            openReplays.Click += openReplays_Click;
            // 
            // browseEN
            // 
            browseEN.Location = new System.Drawing.Point(229, 90);
            browseEN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            browseEN.Name = "browseEN";
            browseEN.Size = new System.Drawing.Size(72, 25);
            browseEN.TabIndex = 6;
            browseEN.Text = "Browse";
            browseEN.UseVisualStyleBackColor = true;
            browseEN.Click += browse_Click;
            // 
            // browseCustom
            // 
            browseCustom.Location = new System.Drawing.Point(229, 145);
            browseCustom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            browseCustom.Name = "browseCustom";
            browseCustom.Size = new System.Drawing.Size(72, 25);
            browseCustom.TabIndex = 11;
            browseCustom.Text = "Browse";
            browseCustom.UseVisualStyleBackColor = true;
            browseCustom.Click += browse_Click;
            // 
            // jpApplocale
            // 
            jpApplocale.AutoSize = true;
            jpApplocale.Location = new System.Drawing.Point(258, 14);
            jpApplocale.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            jpApplocale.Name = "jpApplocale";
            jpApplocale.Size = new System.Drawing.Size(107, 19);
            jpApplocale.TabIndex = 0;
            jpApplocale.Text = "With Applocale";
            jpApplocale.UseVisualStyleBackColor = true;
            jpApplocale.CheckedChanged += Applocale_CheckedChanged;
            // 
            // defaultExec
            // 
            defaultExec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            defaultExec.FormattingEnabled = true;
            defaultExec.Items.AddRange(new object[] { "Japanese/vpatch.ini", "English (non-THCRAP)", "Custom.exe", "thcrap" });
            defaultExec.Location = new System.Drawing.Point(127, 228);
            defaultExec.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            defaultExec.Name = "defaultExec";
            defaultExec.Size = new System.Drawing.Size(131, 23);
            defaultExec.TabIndex = 17;
            defaultExec.SelectedIndexChanged += defaultExec_SelectedIndexChanged;
            // 
            // defaultLabel
            // 
            defaultLabel.AutoSize = true;
            defaultLabel.Location = new System.Drawing.Point(7, 228);
            defaultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            defaultLabel.Name = "defaultLabel";
            defaultLabel.Size = new System.Drawing.Size(108, 15);
            defaultLabel.TabIndex = 16;
            defaultLabel.Text = "Default Executable:";
            // 
            // launchCustom
            // 
            launchCustom.AutoEllipsis = true;
            launchCustom.Location = new System.Drawing.Point(308, 145);
            launchCustom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            launchCustom.Name = "launchCustom";
            launchCustom.Size = new System.Drawing.Size(64, 25);
            launchCustom.TabIndex = 12;
            launchCustom.Text = "Launch";
            launchCustom.UseVisualStyleBackColor = true;
            launchCustom.Click += launch_Click;
            // 
            // launchEN
            // 
            launchEN.AutoEllipsis = true;
            launchEN.Location = new System.Drawing.Point(308, 90);
            launchEN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            launchEN.Name = "launchEN";
            launchEN.Size = new System.Drawing.Size(64, 25);
            launchEN.TabIndex = 7;
            launchEN.Text = "Launch";
            launchEN.UseVisualStyleBackColor = true;
            launchEN.Click += launch_Click;
            // 
            // launchJP
            // 
            launchJP.AutoEllipsis = true;
            launchJP.Location = new System.Drawing.Point(308, 35);
            launchJP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            launchJP.Name = "launchJP";
            launchJP.Size = new System.Drawing.Size(64, 25);
            launchJP.TabIndex = 3;
            launchJP.Text = "Launch";
            launchJP.UseVisualStyleBackColor = true;
            launchJP.Click += launch_Click;
            // 
            // launchcrap
            // 
            launchcrap.AutoEllipsis = true;
            launchcrap.Location = new System.Drawing.Point(308, 197);
            launchcrap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            launchcrap.Name = "launchcrap";
            launchcrap.Size = new System.Drawing.Size(64, 25);
            launchcrap.TabIndex = 16;
            launchcrap.Text = "Launch";
            launchcrap.UseVisualStyleBackColor = true;
            launchcrap.Click += launchcrap_Click;
            // 
            // crapLabel
            // 
            crapLabel.AutoSize = true;
            crapLabel.Location = new System.Drawing.Point(7, 179);
            crapLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            crapLabel.Name = "crapLabel";
            crapLabel.Size = new System.Drawing.Size(81, 15);
            crapLabel.TabIndex = 21;
            crapLabel.Text = "thcrap Profile:";
            // 
            // customApplocale
            // 
            customApplocale.AutoSize = true;
            customApplocale.Location = new System.Drawing.Point(258, 125);
            customApplocale.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            customApplocale.Name = "customApplocale";
            customApplocale.Size = new System.Drawing.Size(107, 19);
            customApplocale.TabIndex = 9;
            customApplocale.Text = "With Applocale";
            customApplocale.UseVisualStyleBackColor = true;
            customApplocale.CheckedChanged += Applocale_CheckedChanged;
            // 
            // defaultApplocale
            // 
            defaultApplocale.AutoSize = true;
            defaultApplocale.Location = new System.Drawing.Point(266, 233);
            defaultApplocale.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            defaultApplocale.Name = "defaultApplocale";
            defaultApplocale.Size = new System.Drawing.Size(107, 19);
            defaultApplocale.TabIndex = 18;
            defaultApplocale.Text = "With Applocale";
            defaultApplocale.UseVisualStyleBackColor = true;
            defaultApplocale.CheckedChanged += defaultApplocale_CheckedChanged;
            // 
            // crapApplocale
            // 
            crapApplocale.AutoSize = true;
            crapApplocale.Location = new System.Drawing.Point(258, 175);
            crapApplocale.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            crapApplocale.Name = "crapApplocale";
            crapApplocale.Size = new System.Drawing.Size(107, 19);
            crapApplocale.TabIndex = 13;
            crapApplocale.Text = "With Applocale";
            crapApplocale.UseVisualStyleBackColor = true;
            crapApplocale.CheckedChanged += Applocale_CheckedChanged;
            // 
            // enApplocale
            // 
            enApplocale.AutoSize = true;
            enApplocale.Location = new System.Drawing.Point(258, 69);
            enApplocale.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            enApplocale.Name = "enApplocale";
            enApplocale.Size = new System.Drawing.Size(107, 19);
            enApplocale.TabIndex = 4;
            enApplocale.Text = "With Applocale";
            enApplocale.UseVisualStyleBackColor = true;
            enApplocale.CheckedChanged += Applocale_CheckedChanged;
            // 
            // chkCustomBanner
            // 
            chkCustomBanner.AutoSize = true;
            chkCustomBanner.Location = new System.Drawing.Point(140, 14);
            chkCustomBanner.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkCustomBanner.Name = "chkCustomBanner";
            chkCustomBanner.Size = new System.Drawing.Size(128, 19);
            chkCustomBanner.TabIndex = 0;
            chkCustomBanner.Text = "Use custom banner";
            chkCustomBanner.UseVisualStyleBackColor = true;
            chkCustomBanner.CheckedChanged += chkCustomBanner_CheckedChanged;
            // 
            // bannerOnLabel
            // 
            bannerOnLabel.AutoSize = true;
            bannerOnLabel.Location = new System.Drawing.Point(7, 18);
            bannerOnLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            bannerOnLabel.Name = "bannerOnLabel";
            bannerOnLabel.Size = new System.Drawing.Size(92, 15);
            bannerOnLabel.TabIndex = 31;
            bannerOnLabel.Text = "Colored Banner:";
            // 
            // browseBannerOn
            // 
            browseBannerOn.Location = new System.Drawing.Point(205, 35);
            browseBannerOn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            browseBannerOn.Name = "browseBannerOn";
            browseBannerOn.Size = new System.Drawing.Size(72, 25);
            browseBannerOn.TabIndex = 2;
            browseBannerOn.Text = "Browse";
            browseBannerOn.UseVisualStyleBackColor = true;
            browseBannerOn.Click += browseBannerOn_Click;
            // 
            // bannerOnDir
            // 
            bannerOnDir.AllowDrop = true;
            bannerOnDir.Location = new System.Drawing.Point(10, 37);
            bannerOnDir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bannerOnDir.Name = "bannerOnDir";
            bannerOnDir.Size = new System.Drawing.Size(187, 23);
            bannerOnDir.TabIndex = 1;
            bannerOnDir.DragDrop += Dir_DragDrop;
            bannerOnDir.DragEnter += Dir_DragEnter;
            bannerOnDir.LostFocus += bannerDir_LostFocus;
            // 
            // bannerOffLabel
            // 
            bannerOffLabel.AutoSize = true;
            bannerOffLabel.Location = new System.Drawing.Point(7, 62);
            bannerOffLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            bannerOffLabel.Name = "bannerOffLabel";
            bannerOffLabel.Size = new System.Drawing.Size(74, 15);
            bannerOffLabel.TabIndex = 34;
            bannerOffLabel.Text = "Grey Banner:";
            // 
            // browseBannerOff
            // 
            browseBannerOff.Location = new System.Drawing.Point(205, 78);
            browseBannerOff.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            browseBannerOff.Name = "browseBannerOff";
            browseBannerOff.Size = new System.Drawing.Size(72, 25);
            browseBannerOff.TabIndex = 4;
            browseBannerOff.Text = "Browse";
            browseBannerOff.UseVisualStyleBackColor = true;
            browseBannerOff.Click += browseBannerOff_Click;
            // 
            // bannerOffDir
            // 
            bannerOffDir.AllowDrop = true;
            bannerOffDir.Location = new System.Drawing.Point(10, 81);
            bannerOffDir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bannerOffDir.Name = "bannerOffDir";
            bannerOffDir.Size = new System.Drawing.Size(187, 23);
            bannerOffDir.TabIndex = 3;
            bannerOffDir.DragDrop += Dir_DragDrop;
            bannerOffDir.DragEnter += Dir_DragEnter;
            bannerOffDir.LostFocus += bannerDir_LostFocus;
            // 
            // pc98Settings
            // 
            pc98Settings.Controls.Add(openNP2Folder);
            pc98Settings.Controls.Add(launchHDI);
            pc98Settings.Controls.Add(hdiLabel);
            pc98Settings.Controls.Add(browseHDI);
            pc98Settings.Controls.Add(hdiDir);
            pc98Settings.Location = new System.Drawing.Point(391, 147);
            pc98Settings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pc98Settings.Name = "pc98Settings";
            pc98Settings.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pc98Settings.Size = new System.Drawing.Size(285, 123);
            pc98Settings.TabIndex = 2;
            pc98Settings.TabStop = false;
            pc98Settings.Text = "PC-98 Game Settings";
            // 
            // openNP2Folder
            // 
            openNP2Folder.AutoEllipsis = true;
            openNP2Folder.Location = new System.Drawing.Point(10, 92);
            openNP2Folder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            openNP2Folder.Name = "openNP2Folder";
            openNP2Folder.Size = new System.Drawing.Size(267, 27);
            openNP2Folder.TabIndex = 3;
            openNP2Folder.Text = "Open Neko Project II Folder";
            openNP2Folder.UseVisualStyleBackColor = true;
            openNP2Folder.Click += openNP2Folder_Click;
            // 
            // launchHDI
            // 
            launchHDI.AutoEllipsis = true;
            launchHDI.Location = new System.Drawing.Point(214, 67);
            launchHDI.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            launchHDI.Name = "launchHDI";
            launchHDI.Size = new System.Drawing.Size(64, 25);
            launchHDI.TabIndex = 2;
            launchHDI.Text = "Launch";
            launchHDI.UseVisualStyleBackColor = true;
            launchHDI.Click += launchHDI_Click;
            // 
            // hdiLabel
            // 
            hdiLabel.AutoSize = true;
            hdiLabel.Location = new System.Drawing.Point(7, 18);
            hdiLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            hdiLabel.Name = "hdiLabel";
            hdiLabel.Size = new System.Drawing.Size(64, 15);
            hdiLabel.TabIndex = 22;
            hdiLabel.Text = "Game HDI:";
            // 
            // browseHDI
            // 
            browseHDI.Location = new System.Drawing.Point(10, 67);
            browseHDI.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            browseHDI.Name = "browseHDI";
            browseHDI.Size = new System.Drawing.Size(72, 25);
            browseHDI.TabIndex = 1;
            browseHDI.Text = "Browse";
            browseHDI.UseVisualStyleBackColor = true;
            browseHDI.Click += browseHDI_Click;
            // 
            // hdiDir
            // 
            hdiDir.AllowDrop = true;
            hdiDir.Location = new System.Drawing.Point(10, 37);
            hdiDir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            hdiDir.Name = "hdiDir";
            hdiDir.Size = new System.Drawing.Size(266, 23);
            hdiDir.TabIndex = 0;
            hdiDir.DragDrop += Dir_DragDrop;
            hdiDir.DragEnter += Dir_DragEnter;
            hdiDir.LostFocus += Dir_LostFocus;
            // 
            // bannerSettings
            // 
            bannerSettings.Controls.Add(chkCustomText);
            bannerSettings.Controls.Add(btnCustomText);
            bannerSettings.Controls.Add(bannerSize);
            bannerSettings.Controls.Add(bannerOnLabel);
            bannerSettings.Controls.Add(chkCustomBanner);
            bannerSettings.Controls.Add(bannerOffLabel);
            bannerSettings.Controls.Add(bannerOnDir);
            bannerSettings.Controls.Add(browseBannerOff);
            bannerSettings.Controls.Add(browseBannerOn);
            bannerSettings.Controls.Add(bannerOffDir);
            bannerSettings.Location = new System.Drawing.Point(391, 3);
            bannerSettings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bannerSettings.Name = "bannerSettings";
            bannerSettings.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bannerSettings.Size = new System.Drawing.Size(285, 138);
            bannerSettings.TabIndex = 1;
            bannerSettings.TabStop = false;
            bannerSettings.Text = "Banner Settings";
            // 
            // chkCustomText
            // 
            chkCustomText.AutoSize = true;
            chkCustomText.Location = new System.Drawing.Point(128, 112);
            chkCustomText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkCustomText.Name = "chkCustomText";
            chkCustomText.Size = new System.Drawing.Size(141, 19);
            chkCustomText.TabIndex = 6;
            chkCustomText.Text = "Use custom text color";
            chkCustomText.UseVisualStyleBackColor = true;
            chkCustomText.CheckedChanged += chkCustomText_CheckedChanged;
            // 
            // btnCustomText
            // 
            btnCustomText.Location = new System.Drawing.Point(10, 107);
            btnCustomText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCustomText.Name = "btnCustomText";
            btnCustomText.Size = new System.Drawing.Size(111, 25);
            btnCustomText.TabIndex = 5;
            btnCustomText.Text = "Set Color";
            btnCustomText.UseVisualStyleBackColor = true;
            btnCustomText.Click += btnCustomText_Click;
            // 
            // bannerSize
            // 
            bannerSize.AutoSize = true;
            bannerSize.Location = new System.Drawing.Point(214, 62);
            bannerSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            bannerSize.Name = "bannerSize";
            bannerSize.Size = new System.Drawing.Size(57, 15);
            bannerSize.TabIndex = 35;
            bannerSize.Text = "* 120 x 44";
            // 
            // windowsSettings
            // 
            windowsSettings.Controls.Add(crapCfg);
            windowsSettings.Controls.Add(crapGame);
            windowsSettings.Controls.Add(openAppdata);
            windowsSettings.Controls.Add(jpLabel);
            windowsSettings.Controls.Add(openvpatch);
            windowsSettings.Controls.Add(enApplocale);
            windowsSettings.Controls.Add(jpDir);
            windowsSettings.Controls.Add(crapApplocale);
            windowsSettings.Controls.Add(enDir);
            windowsSettings.Controls.Add(defaultApplocale);
            windowsSettings.Controls.Add(customDir);
            windowsSettings.Controls.Add(customApplocale);
            windowsSettings.Controls.Add(browseJP);
            windowsSettings.Controls.Add(launchcrap);
            windowsSettings.Controls.Add(enLabel);
            windowsSettings.Controls.Add(customLabel);
            windowsSettings.Controls.Add(crapLabel);
            windowsSettings.Controls.Add(openReplays);
            windowsSettings.Controls.Add(browseEN);
            windowsSettings.Controls.Add(launchJP);
            windowsSettings.Controls.Add(browseCustom);
            windowsSettings.Controls.Add(launchEN);
            windowsSettings.Controls.Add(jpApplocale);
            windowsSettings.Controls.Add(launchCustom);
            windowsSettings.Controls.Add(defaultExec);
            windowsSettings.Controls.Add(defaultLabel);
            windowsSettings.Location = new System.Drawing.Point(4, 3);
            windowsSettings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            windowsSettings.Name = "windowsSettings";
            windowsSettings.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            windowsSettings.Size = new System.Drawing.Size(383, 294);
            windowsSettings.TabIndex = 0;
            windowsSettings.TabStop = false;
            windowsSettings.Text = "Windows Game Settings";
            // 
            // crapCfg
            // 
            crapCfg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            crapCfg.FormattingEnabled = true;
            crapCfg.Items.AddRange(new object[] { "None" });
            crapCfg.Location = new System.Drawing.Point(149, 197);
            crapCfg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            crapCfg.Name = "crapCfg";
            crapCfg.Size = new System.Drawing.Size(151, 23);
            crapCfg.TabIndex = 15;
            crapCfg.SelectedIndexChanged += crapCfg_SelectedIndexChanged;
            // 
            // crapGame
            // 
            crapGame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            crapGame.FormattingEnabled = true;
            crapGame.Items.AddRange(new object[] { "None" });
            crapGame.Location = new System.Drawing.Point(7, 197);
            crapGame.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            crapGame.Name = "crapGame";
            crapGame.Size = new System.Drawing.Size(135, 23);
            crapGame.TabIndex = 14;
            crapGame.SelectedIndexChanged += crapCfg_SelectedIndexChanged;
            // 
            // openAppdata
            // 
            openAppdata.AutoEllipsis = true;
            openAppdata.Location = new System.Drawing.Point(10, 262);
            openAppdata.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            openAppdata.Name = "openAppdata";
            openAppdata.Size = new System.Drawing.Size(106, 27);
            openAppdata.TabIndex = 19;
            openAppdata.Text = "Appdata Folder";
            openAppdata.UseVisualStyleBackColor = true;
            openAppdata.Click += openAppdata_Click;
            // 
            // ConfigForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(681, 302);
            Controls.Add(windowsSettings);
            Controls.Add(bannerSettings);
            Controls.Add(openFolder);
            Controls.Add(pc98Settings);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Icon = Properties.Resources.thicon;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "ConfigForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Game Configuration: ";
            FormClosing += ConfigForm_Closing;
            Load += ConfigForm_Load;
            pc98Settings.ResumeLayout(false);
            pc98Settings.PerformLayout();
            bannerSettings.ResumeLayout(false);
            bannerSettings.PerformLayout();
            windowsSettings.ResumeLayout(false);
            windowsSettings.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button openFolder;
        private System.Windows.Forms.Button openvpatch;
        private System.Windows.Forms.TextBox jpDir;
        private System.Windows.Forms.TextBox enDir;
        private System.Windows.Forms.TextBox customDir;
        private System.Windows.Forms.Button browseJP;
        private System.Windows.Forms.Label jpLabel;
        private System.Windows.Forms.Label enLabel;
        private System.Windows.Forms.Label customLabel;
        private System.Windows.Forms.Button openReplays;
        private System.Windows.Forms.Button browseEN;
        private System.Windows.Forms.Button browseCustom;
        private System.Windows.Forms.CheckBox jpApplocale;
        private System.Windows.Forms.ComboBox defaultExec;
        private System.Windows.Forms.Label defaultLabel;
        private System.Windows.Forms.Button launchCustom;
        private System.Windows.Forms.Button launchEN;
        private System.Windows.Forms.Button launchJP;
        private System.Windows.Forms.Button launchcrap;
        private System.Windows.Forms.Label crapLabel;
        private System.Windows.Forms.CheckBox customApplocale;
        private System.Windows.Forms.CheckBox defaultApplocale;
        private System.Windows.Forms.CheckBox crapApplocale;
        private System.Windows.Forms.CheckBox enApplocale;
        private System.Windows.Forms.CheckBox chkCustomBanner;
        private System.Windows.Forms.Label bannerOnLabel;
        private System.Windows.Forms.Button browseBannerOn;
        private System.Windows.Forms.TextBox bannerOnDir;
        private System.Windows.Forms.Label bannerOffLabel;
        private System.Windows.Forms.Button browseBannerOff;
        private System.Windows.Forms.TextBox bannerOffDir;
        private System.Windows.Forms.GroupBox pc98Settings;
        private System.Windows.Forms.Button launchHDI;
        private System.Windows.Forms.Label hdiLabel;
        private System.Windows.Forms.Button browseHDI;
        private System.Windows.Forms.TextBox hdiDir;
        private System.Windows.Forms.GroupBox bannerSettings;
        private System.Windows.Forms.GroupBox windowsSettings;
        private System.Windows.Forms.Button openAppdata;
        private System.Windows.Forms.Button openNP2Folder;
        private System.Windows.Forms.Label bannerSize;
        private System.Windows.Forms.ComboBox crapGame;
        private System.Windows.Forms.ComboBox crapCfg;
        private System.Windows.Forms.CheckBox chkCustomText;
        private System.Windows.Forms.Button btnCustomText;
    }
}
