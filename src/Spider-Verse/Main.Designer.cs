namespace Spider_Verse
{
    partial class Main
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            btn_Flycast = new Button();
            btn_Browse = new Button();
            btn_Download = new Button();
            btn_Costumes = new Button();
            btn_Chars = new Button();
            btn_Gfx = new Button();
            btn_Disable = new Button();
            btn_Reset = new Button();
            btn_Enable = new Button();
            mStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveConfigToolStripMenuItem = new ToolStripMenuItem();
            loadConfigToolStripMenuItem = new ToolStripMenuItem();
            deleteConfigToolStripMenuItem = new ToolStripMenuItem();
            restartToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            cheatsToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            messageBoxToolStripMenuItem = new ToolStripMenuItem();
            soundEffectsToolStripMenuItem = new ToolStripMenuItem();
            autoUpdateCheckToolStripMenuItem = new ToolStripMenuItem();
            infoToolStripMenuItem = new ToolStripMenuItem();
            creditsToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            lst_Mods = new ListBox();
            tb_Search = new TextBox();
            tb_Path = new TextBox();
            cb_HUD = new CheckBox();
            groupBox1 = new GroupBox();
            btn_CheckUpdate = new Button();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            label1 = new Label();
            fswDir = new FileSystemWatcher();
            fswEmu = new FileSystemWatcher();
            lst_Obj = new ListBox();
            fswDirTimer = new System.Windows.Forms.Timer(components);
            fswEmuTimer = new System.Windows.Forms.Timer(components);
            btn_Donate = new Button();
            btn_YouTube = new Button();
            btn_GitHub = new Button();
            btn_Discord = new Button();
            mStrip.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fswDir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fswEmu).BeginInit();
            SuspendLayout();
            // 
            // btn_Flycast
            // 
            btn_Flycast.BackColor = Color.Gainsboro;
            btn_Flycast.Cursor = Cursors.Hand;
            btn_Flycast.Enabled = false;
            btn_Flycast.FlatAppearance.BorderColor = Color.Black;
            btn_Flycast.FlatAppearance.BorderSize = 0;
            btn_Flycast.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            btn_Flycast.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btn_Flycast.FlatStyle = FlatStyle.Flat;
            btn_Flycast.Font = new Font("Aptos", 10F);
            btn_Flycast.ForeColor = Color.Black;
            btn_Flycast.Image = Properties.Resources.Play;
            btn_Flycast.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Flycast.Location = new Point(16, 140);
            btn_Flycast.Name = "btn_Flycast";
            btn_Flycast.Size = new Size(216, 42);
            btn_Flycast.TabIndex = 2;
            btn_Flycast.TabStop = false;
            btn_Flycast.Text = "Play Flycast";
            btn_Flycast.TextAlign = ContentAlignment.MiddleLeft;
            btn_Flycast.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Flycast.UseVisualStyleBackColor = false;
            btn_Flycast.Click += btn_Flycast_Click;
            // 
            // btn_Browse
            // 
            btn_Browse.BackColor = Color.Gainsboro;
            btn_Browse.Cursor = Cursors.Hand;
            btn_Browse.FlatAppearance.BorderColor = Color.Black;
            btn_Browse.FlatAppearance.BorderSize = 0;
            btn_Browse.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            btn_Browse.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btn_Browse.FlatStyle = FlatStyle.Flat;
            btn_Browse.Font = new Font("Aptos", 10F);
            btn_Browse.ForeColor = Color.Black;
            btn_Browse.Image = Properties.Resources.Folder;
            btn_Browse.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Browse.Location = new Point(16, 85);
            btn_Browse.Name = "btn_Browse";
            btn_Browse.Size = new Size(216, 42);
            btn_Browse.TabIndex = 1;
            btn_Browse.TabStop = false;
            btn_Browse.Text = "Browse Flycast Path";
            btn_Browse.TextAlign = ContentAlignment.MiddleLeft;
            btn_Browse.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Browse.UseVisualStyleBackColor = false;
            btn_Browse.Click += btn_Browse_Click;
            // 
            // btn_Download
            // 
            btn_Download.BackColor = Color.Gainsboro;
            btn_Download.Cursor = Cursors.Hand;
            btn_Download.FlatAppearance.BorderColor = Color.Black;
            btn_Download.FlatAppearance.BorderSize = 0;
            btn_Download.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            btn_Download.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btn_Download.FlatStyle = FlatStyle.Flat;
            btn_Download.Font = new Font("Aptos", 10F);
            btn_Download.ForeColor = Color.Black;
            btn_Download.Image = Properties.Resources.Download;
            btn_Download.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Download.Location = new Point(16, 30);
            btn_Download.Name = "btn_Download";
            btn_Download.Size = new Size(216, 42);
            btn_Download.TabIndex = 0;
            btn_Download.TabStop = false;
            btn_Download.Text = "Download Flycast";
            btn_Download.TextAlign = ContentAlignment.MiddleLeft;
            btn_Download.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Download.UseVisualStyleBackColor = false;
            btn_Download.Click += btn_Download_Click;
            // 
            // btn_Costumes
            // 
            btn_Costumes.BackColor = Color.Gainsboro;
            btn_Costumes.BackgroundImageLayout = ImageLayout.None;
            btn_Costumes.Cursor = Cursors.Hand;
            btn_Costumes.Enabled = false;
            btn_Costumes.FlatAppearance.BorderColor = Color.Black;
            btn_Costumes.FlatAppearance.BorderSize = 0;
            btn_Costumes.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            btn_Costumes.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btn_Costumes.FlatStyle = FlatStyle.Flat;
            btn_Costumes.Font = new Font("Aptos", 10F);
            btn_Costumes.ForeColor = Color.Black;
            btn_Costumes.Image = Properties.Resources.Costumes;
            btn_Costumes.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Costumes.Location = new Point(16, 30);
            btn_Costumes.Name = "btn_Costumes";
            btn_Costumes.Size = new Size(216, 42);
            btn_Costumes.TabIndex = 0;
            btn_Costumes.TabStop = false;
            btn_Costumes.Text = "Costumes";
            btn_Costumes.TextAlign = ContentAlignment.MiddleLeft;
            btn_Costumes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Costumes.UseVisualStyleBackColor = false;
            btn_Costumes.Click += btn_LoadType_Click;
            // 
            // btn_Chars
            // 
            btn_Chars.BackColor = Color.Gainsboro;
            btn_Chars.Cursor = Cursors.Hand;
            btn_Chars.Enabled = false;
            btn_Chars.FlatAppearance.BorderColor = Color.Black;
            btn_Chars.FlatAppearance.BorderSize = 0;
            btn_Chars.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            btn_Chars.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btn_Chars.FlatStyle = FlatStyle.Flat;
            btn_Chars.Font = new Font("Aptos", 10F);
            btn_Chars.ForeColor = Color.Black;
            btn_Chars.Image = Properties.Resources.Camera;
            btn_Chars.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Chars.Location = new Point(16, 85);
            btn_Chars.Name = "btn_Chars";
            btn_Chars.Size = new Size(216, 42);
            btn_Chars.TabIndex = 1;
            btn_Chars.TabStop = false;
            btn_Chars.Text = "Characters";
            btn_Chars.TextAlign = ContentAlignment.MiddleLeft;
            btn_Chars.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Chars.UseVisualStyleBackColor = false;
            btn_Chars.Click += btn_LoadType_Click;
            // 
            // btn_Gfx
            // 
            btn_Gfx.BackColor = Color.Gainsboro;
            btn_Gfx.Cursor = Cursors.Hand;
            btn_Gfx.Enabled = false;
            btn_Gfx.FlatAppearance.BorderColor = Color.Black;
            btn_Gfx.FlatAppearance.BorderSize = 0;
            btn_Gfx.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            btn_Gfx.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btn_Gfx.FlatStyle = FlatStyle.Flat;
            btn_Gfx.Font = new Font("Aptos", 10F);
            btn_Gfx.ForeColor = Color.Black;
            btn_Gfx.Image = Properties.Resources.Graphics;
            btn_Gfx.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Gfx.Location = new Point(16, 140);
            btn_Gfx.Name = "btn_Gfx";
            btn_Gfx.Size = new Size(216, 42);
            btn_Gfx.TabIndex = 2;
            btn_Gfx.TabStop = false;
            btn_Gfx.Text = "Graphics";
            btn_Gfx.TextAlign = ContentAlignment.MiddleLeft;
            btn_Gfx.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Gfx.UseVisualStyleBackColor = false;
            btn_Gfx.Click += btn_LoadType_Click;
            // 
            // btn_Disable
            // 
            btn_Disable.BackColor = Color.Gainsboro;
            btn_Disable.Cursor = Cursors.Hand;
            btn_Disable.Enabled = false;
            btn_Disable.FlatAppearance.BorderColor = Color.Black;
            btn_Disable.FlatAppearance.BorderSize = 0;
            btn_Disable.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            btn_Disable.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btn_Disable.FlatStyle = FlatStyle.Flat;
            btn_Disable.Font = new Font("Aptos", 10F);
            btn_Disable.ForeColor = Color.Black;
            btn_Disable.Image = Properties.Resources.Disable;
            btn_Disable.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Disable.Location = new Point(16, 157);
            btn_Disable.Name = "btn_Disable";
            btn_Disable.Size = new Size(216, 42);
            btn_Disable.TabIndex = 1;
            btn_Disable.TabStop = false;
            btn_Disable.Text = "Disable Mods";
            btn_Disable.TextAlign = ContentAlignment.MiddleLeft;
            btn_Disable.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Disable.UseVisualStyleBackColor = false;
            btn_Disable.Click += btn_Disable_Click;
            // 
            // btn_Reset
            // 
            btn_Reset.BackColor = Color.Gainsboro;
            btn_Reset.Cursor = Cursors.Hand;
            btn_Reset.Enabled = false;
            btn_Reset.FlatAppearance.BorderColor = Color.Black;
            btn_Reset.FlatAppearance.BorderSize = 0;
            btn_Reset.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            btn_Reset.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btn_Reset.FlatStyle = FlatStyle.Flat;
            btn_Reset.Font = new Font("Aptos", 10F);
            btn_Reset.ForeColor = Color.Black;
            btn_Reset.Image = Properties.Resources.RecycleBin;
            btn_Reset.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Reset.Location = new Point(16, 212);
            btn_Reset.Name = "btn_Reset";
            btn_Reset.Size = new Size(216, 42);
            btn_Reset.TabIndex = 4;
            btn_Reset.TabStop = false;
            btn_Reset.Text = "Remove All Mods";
            btn_Reset.TextAlign = ContentAlignment.MiddleLeft;
            btn_Reset.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Reset.UseVisualStyleBackColor = false;
            btn_Reset.Click += btn_Reset_Click;
            // 
            // btn_Enable
            // 
            btn_Enable.BackColor = Color.Gainsboro;
            btn_Enable.Cursor = Cursors.Hand;
            btn_Enable.Enabled = false;
            btn_Enable.FlatAppearance.BorderColor = Color.Black;
            btn_Enable.FlatAppearance.BorderSize = 0;
            btn_Enable.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            btn_Enable.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 128);
            btn_Enable.FlatStyle = FlatStyle.Flat;
            btn_Enable.Font = new Font("Aptos", 10F);
            btn_Enable.ForeColor = Color.Black;
            btn_Enable.Image = Properties.Resources.Enable;
            btn_Enable.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Enable.Location = new Point(16, 102);
            btn_Enable.Name = "btn_Enable";
            btn_Enable.Size = new Size(216, 42);
            btn_Enable.TabIndex = 0;
            btn_Enable.TabStop = false;
            btn_Enable.Text = "Enable Mod";
            btn_Enable.TextAlign = ContentAlignment.MiddleLeft;
            btn_Enable.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Enable.UseVisualStyleBackColor = false;
            btn_Enable.Click += btn_Enable_Click;
            // 
            // mStrip
            // 
            mStrip.BackColor = Color.Black;
            mStrip.Font = new Font("Segoe UI", 9F);
            mStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, cheatsToolStripMenuItem, settingsToolStripMenuItem, infoToolStripMenuItem });
            mStrip.Location = new Point(0, 0);
            mStrip.Margin = new Padding(3);
            mStrip.Name = "mStrip";
            mStrip.RenderMode = ToolStripRenderMode.System;
            mStrip.Size = new Size(1259, 32);
            mStrip.TabIndex = 8;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveConfigToolStripMenuItem, loadConfigToolStripMenuItem, deleteConfigToolStripMenuItem, restartToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Font = new Font("Aptos", 10F);
            fileToolStripMenuItem.ForeColor = Color.White;
            fileToolStripMenuItem.Margin = new Padding(3);
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(41, 22);
            fileToolStripMenuItem.Text = "File";
            // 
            // saveConfigToolStripMenuItem
            // 
            saveConfigToolStripMenuItem.Image = Properties.Resources.Save;
            saveConfigToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            saveConfigToolStripMenuItem.ImageTransparentColor = Color.Transparent;
            saveConfigToolStripMenuItem.Name = "saveConfigToolStripMenuItem";
            saveConfigToolStripMenuItem.Size = new Size(124, 26);
            saveConfigToolStripMenuItem.Text = "Save";
            saveConfigToolStripMenuItem.Click += saveConfigToolStripMenuItem_Click;
            // 
            // loadConfigToolStripMenuItem
            // 
            loadConfigToolStripMenuItem.Image = Properties.Resources.Load;
            loadConfigToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            loadConfigToolStripMenuItem.Name = "loadConfigToolStripMenuItem";
            loadConfigToolStripMenuItem.Size = new Size(124, 26);
            loadConfigToolStripMenuItem.Text = "Load";
            loadConfigToolStripMenuItem.Click += loadConfigToolStripMenuItem_Click;
            // 
            // deleteConfigToolStripMenuItem
            // 
            deleteConfigToolStripMenuItem.Image = Properties.Resources.Delete;
            deleteConfigToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            deleteConfigToolStripMenuItem.Name = "deleteConfigToolStripMenuItem";
            deleteConfigToolStripMenuItem.Size = new Size(124, 26);
            deleteConfigToolStripMenuItem.Text = "Delete";
            deleteConfigToolStripMenuItem.Click += deleteConfigToolStripMenuItem_Click;
            // 
            // restartToolStripMenuItem
            // 
            restartToolStripMenuItem.Image = Properties.Resources.Restart;
            restartToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            restartToolStripMenuItem.Size = new Size(124, 26);
            restartToolStripMenuItem.Text = "Restart";
            restartToolStripMenuItem.Click += restartToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Image = Properties.Resources.Exit;
            exitToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(124, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // cheatsToolStripMenuItem
            // 
            cheatsToolStripMenuItem.Font = new Font("Aptos", 10F);
            cheatsToolStripMenuItem.ForeColor = Color.White;
            cheatsToolStripMenuItem.Margin = new Padding(3);
            cheatsToolStripMenuItem.Name = "cheatsToolStripMenuItem";
            cheatsToolStripMenuItem.Size = new Size(64, 22);
            cheatsToolStripMenuItem.Text = "Cheats";
            cheatsToolStripMenuItem.Click += cheatsToolStripMenuItem_Click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { messageBoxToolStripMenuItem, soundEffectsToolStripMenuItem, autoUpdateCheckToolStripMenuItem });
            settingsToolStripMenuItem.Font = new Font("Aptos", 10F);
            settingsToolStripMenuItem.ForeColor = Color.White;
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(70, 28);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.TextImageRelation = TextImageRelation.TextAboveImage;
            // 
            // messageBoxToolStripMenuItem
            // 
            messageBoxToolStripMenuItem.Checked = true;
            messageBoxToolStripMenuItem.CheckOnClick = true;
            messageBoxToolStripMenuItem.CheckState = CheckState.Checked;
            messageBoxToolStripMenuItem.Name = "messageBoxToolStripMenuItem";
            messageBoxToolStripMenuItem.Size = new Size(195, 22);
            messageBoxToolStripMenuItem.Text = "Notifications";
            // 
            // soundEffectsToolStripMenuItem
            // 
            soundEffectsToolStripMenuItem.Checked = true;
            soundEffectsToolStripMenuItem.CheckOnClick = true;
            soundEffectsToolStripMenuItem.CheckState = CheckState.Checked;
            soundEffectsToolStripMenuItem.Name = "soundEffectsToolStripMenuItem";
            soundEffectsToolStripMenuItem.Size = new Size(195, 22);
            soundEffectsToolStripMenuItem.Text = "Sound Effects";
            // 
            // autoUpdateCheckToolStripMenuItem
            // 
            autoUpdateCheckToolStripMenuItem.CheckOnClick = true;
            autoUpdateCheckToolStripMenuItem.Name = "autoUpdateCheckToolStripMenuItem";
            autoUpdateCheckToolStripMenuItem.Size = new Size(195, 22);
            autoUpdateCheckToolStripMenuItem.Text = "Auto Update Check";
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { creditsToolStripMenuItem, aboutToolStripMenuItem });
            infoToolStripMenuItem.Font = new Font("Aptos", 10F);
            infoToolStripMenuItem.ForeColor = Color.White;
            infoToolStripMenuItem.Margin = new Padding(3);
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new Size(44, 22);
            infoToolStripMenuItem.Text = "Info";
            infoToolStripMenuItem.TextImageRelation = TextImageRelation.TextAboveImage;
            // 
            // creditsToolStripMenuItem
            // 
            creditsToolStripMenuItem.Image = Properties.Resources.Credits;
            creditsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            creditsToolStripMenuItem.Size = new Size(125, 26);
            creditsToolStripMenuItem.Text = "Credits";
            creditsToolStripMenuItem.Click += creditsToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Image = Properties.Resources.About;
            aboutToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(125, 26);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // lst_Mods
            // 
            lst_Mods.BackColor = Color.Black;
            lst_Mods.Font = new Font("Aptos", 11F);
            lst_Mods.ForeColor = Color.White;
            lst_Mods.FormattingEnabled = true;
            lst_Mods.Location = new Point(634, 90);
            lst_Mods.Name = "lst_Mods";
            lst_Mods.Size = new Size(370, 498);
            lst_Mods.Sorted = true;
            lst_Mods.TabIndex = 4;
            lst_Mods.TabStop = false;
            lst_Mods.UseTabStops = false;
            lst_Mods.SelectedIndexChanged += lst_Mods_SelectedIndexChanged;
            // 
            // tb_Search
            // 
            tb_Search.BackColor = Color.Gainsboro;
            tb_Search.BorderStyle = BorderStyle.FixedSingle;
            tb_Search.Enabled = false;
            tb_Search.Font = new Font("Aptos", 10F);
            tb_Search.ForeColor = Color.Black;
            tb_Search.Location = new Point(16, 54);
            tb_Search.Name = "tb_Search";
            tb_Search.Size = new Size(216, 24);
            tb_Search.TabIndex = 10;
            tb_Search.TabStop = false;
            tb_Search.TextChanged += tb_Search_TextChanged;
            // 
            // tb_Path
            // 
            tb_Path.BackColor = Color.Gainsboro;
            tb_Path.BorderStyle = BorderStyle.FixedSingle;
            tb_Path.Enabled = false;
            tb_Path.Font = new Font("Aptos", 11F);
            tb_Path.ForeColor = Color.Black;
            tb_Path.Location = new Point(1, 50);
            tb_Path.Name = "tb_Path";
            tb_Path.ReadOnly = true;
            tb_Path.Size = new Size(1003, 25);
            tb_Path.TabIndex = 9;
            tb_Path.Text = "Click on [Browse Flycast Path] and navigate to the directory, where Flycast.exe has been installed.";
            // 
            // cb_HUD
            // 
            cb_HUD.AutoSize = true;
            cb_HUD.BackColor = Color.Transparent;
            cb_HUD.Cursor = Cursors.Hand;
            cb_HUD.Enabled = false;
            cb_HUD.Font = new Font("Aptos", 11F);
            cb_HUD.ForeColor = Color.White;
            cb_HUD.ImageAlign = ContentAlignment.MiddleLeft;
            cb_HUD.Location = new Point(16, 273);
            cb_HUD.Name = "cb_HUD";
            cb_HUD.Size = new Size(200, 23);
            cb_HUD.TabIndex = 14;
            cb_HUD.TabStop = false;
            cb_HUD.Text = "Default HUD (Remastered)";
            cb_HUD.TextImageRelation = TextImageRelation.ImageBeforeText;
            cb_HUD.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Black;
            groupBox1.Controls.Add(btn_Download);
            groupBox1.Controls.Add(btn_CheckUpdate);
            groupBox1.Controls.Add(btn_Browse);
            groupBox1.Controls.Add(btn_Flycast);
            groupBox1.Font = new Font("Aptos", 13F, FontStyle.Bold);
            groupBox1.ForeColor = Color.FromArgb(150, 150, 255);
            groupBox1.Location = new Point(1, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(248, 255);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Setup";
            // 
            // btn_CheckUpdate
            // 
            btn_CheckUpdate.BackColor = Color.Gainsboro;
            btn_CheckUpdate.Cursor = Cursors.Hand;
            btn_CheckUpdate.FlatAppearance.BorderColor = Color.Black;
            btn_CheckUpdate.FlatAppearance.BorderSize = 0;
            btn_CheckUpdate.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            btn_CheckUpdate.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btn_CheckUpdate.FlatStyle = FlatStyle.Flat;
            btn_CheckUpdate.Font = new Font("Aptos", 10F);
            btn_CheckUpdate.ForeColor = Color.Black;
            btn_CheckUpdate.Image = Properties.Resources.Update;
            btn_CheckUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btn_CheckUpdate.Location = new Point(16, 195);
            btn_CheckUpdate.Name = "btn_CheckUpdate";
            btn_CheckUpdate.Size = new Size(216, 42);
            btn_CheckUpdate.TabIndex = 2;
            btn_CheckUpdate.TabStop = false;
            btn_CheckUpdate.Text = "Check for Updates";
            btn_CheckUpdate.TextAlign = ContentAlignment.MiddleLeft;
            btn_CheckUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_CheckUpdate.UseVisualStyleBackColor = false;
            btn_CheckUpdate.Click += btn_CheckUpdate_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Black;
            groupBox2.Controls.Add(btn_Gfx);
            groupBox2.Controls.Add(btn_Costumes);
            groupBox2.Controls.Add(btn_Chars);
            groupBox2.Font = new Font("Aptos", 13F, FontStyle.Bold);
            groupBox2.ForeColor = Color.FromArgb(150, 150, 255);
            groupBox2.Location = new Point(1, 360);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(248, 200);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mod Category";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Black;
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(tb_Search);
            groupBox3.Controls.Add(cb_HUD);
            groupBox3.Controls.Add(btn_Enable);
            groupBox3.Controls.Add(btn_Reset);
            groupBox3.Controls.Add(btn_Disable);
            groupBox3.Font = new Font("Aptos", 13F, FontStyle.Bold);
            groupBox3.ForeColor = Color.FromArgb(150, 150, 255);
            groupBox3.Location = new Point(1010, 90);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(248, 316);
            groupBox3.TabIndex = 19;
            groupBox3.TabStop = false;
            groupBox3.Text = "Mod Settings";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Aptos SemiBold", 11F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(16, 30);
            label1.Name = "label1";
            label1.Size = new Size(116, 19);
            label1.TabIndex = 22;
            label1.Text = "Search for Mods";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // fswDir
            // 
            fswDir.EnableRaisingEvents = true;
            fswDir.IncludeSubdirectories = true;
            fswDir.SynchronizingObject = this;
            fswDir.Changed += fswDir_Changed;
            fswDir.Created += fswDir_Changed;
            fswDir.Deleted += fswDir_Changed;
            fswDir.Renamed += fswDir_Changed;
            // 
            // fswEmu
            // 
            fswEmu.EnableRaisingEvents = true;
            fswEmu.SynchronizingObject = this;
            fswEmu.Changed += fswEmu_Changed;
            fswEmu.Created += fswEmu_Changed;
            fswEmu.Deleted += fswEmu_Changed;
            fswEmu.Renamed += fswEmu_Changed;
            // 
            // lst_Obj
            // 
            lst_Obj.BackColor = Color.Black;
            lst_Obj.Font = new Font("Aptos", 11F);
            lst_Obj.ForeColor = Color.White;
            lst_Obj.FormattingEnabled = true;
            lst_Obj.Location = new Point(255, 90);
            lst_Obj.Name = "lst_Obj";
            lst_Obj.Size = new Size(370, 498);
            lst_Obj.TabIndex = 20;
            lst_Obj.TabStop = false;
            lst_Obj.UseTabStops = false;
            lst_Obj.SelectedIndexChanged += lst_Obj_SelectedIndexChanged;
            // 
            // fswDirTimer
            // 
            fswDirTimer.Interval = 250;
            fswDirTimer.Tick += fswDirTimer_Tick;
            // 
            // fswEmuTimer
            // 
            fswEmuTimer.Interval = 250;
            fswEmuTimer.Tick += fswEmuTimer_Tick;
            // 
            // btn_Donate
            // 
            btn_Donate.BackColor = Color.Khaki;
            btn_Donate.BackgroundImage = Properties.Resources.Donate;
            btn_Donate.BackgroundImageLayout = ImageLayout.Center;
            btn_Donate.Cursor = Cursors.Hand;
            btn_Donate.FlatAppearance.BorderColor = Color.Black;
            btn_Donate.FlatAppearance.BorderSize = 0;
            btn_Donate.FlatStyle = FlatStyle.Flat;
            btn_Donate.Font = new Font("Aptos", 10F);
            btn_Donate.ForeColor = Color.Black;
            btn_Donate.Location = new Point(1226, 556);
            btn_Donate.Name = "btn_Donate";
            btn_Donate.Size = new Size(32, 32);
            btn_Donate.TabIndex = 3;
            btn_Donate.TabStop = false;
            btn_Donate.TextAlign = ContentAlignment.MiddleLeft;
            btn_Donate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Donate.UseVisualStyleBackColor = false;
            btn_Donate.Click += btn_Donate_Click;
            // 
            // btn_YouTube
            // 
            btn_YouTube.BackColor = Color.Transparent;
            btn_YouTube.BackgroundImage = Properties.Resources.YouTube;
            btn_YouTube.BackgroundImageLayout = ImageLayout.Center;
            btn_YouTube.Cursor = Cursors.Hand;
            btn_YouTube.FlatAppearance.BorderColor = Color.Black;
            btn_YouTube.FlatAppearance.BorderSize = 0;
            btn_YouTube.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            btn_YouTube.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btn_YouTube.FlatStyle = FlatStyle.Flat;
            btn_YouTube.Font = new Font("Aptos", 10F);
            btn_YouTube.ForeColor = Color.Black;
            btn_YouTube.Location = new Point(1112, 556);
            btn_YouTube.Name = "btn_YouTube";
            btn_YouTube.Size = new Size(32, 32);
            btn_YouTube.TabIndex = 0;
            btn_YouTube.TabStop = false;
            btn_YouTube.TextAlign = ContentAlignment.MiddleLeft;
            btn_YouTube.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_YouTube.UseVisualStyleBackColor = false;
            btn_YouTube.Click += btn_YouTube_Click;
            // 
            // btn_GitHub
            // 
            btn_GitHub.BackColor = Color.Transparent;
            btn_GitHub.BackgroundImage = Properties.Resources.Github;
            btn_GitHub.BackgroundImageLayout = ImageLayout.Center;
            btn_GitHub.Cursor = Cursors.Hand;
            btn_GitHub.FlatAppearance.BorderColor = Color.Black;
            btn_GitHub.FlatAppearance.BorderSize = 0;
            btn_GitHub.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            btn_GitHub.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btn_GitHub.FlatStyle = FlatStyle.Flat;
            btn_GitHub.Font = new Font("Aptos", 10F);
            btn_GitHub.ForeColor = Color.Black;
            btn_GitHub.Location = new Point(1188, 556);
            btn_GitHub.Name = "btn_GitHub";
            btn_GitHub.Size = new Size(32, 32);
            btn_GitHub.TabIndex = 1;
            btn_GitHub.TabStop = false;
            btn_GitHub.TextAlign = ContentAlignment.MiddleLeft;
            btn_GitHub.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_GitHub.UseVisualStyleBackColor = false;
            btn_GitHub.Click += btn_GitHub_Click;
            // 
            // btn_Discord
            // 
            btn_Discord.BackColor = Color.Transparent;
            btn_Discord.BackgroundImage = Properties.Resources.Discord;
            btn_Discord.BackgroundImageLayout = ImageLayout.Center;
            btn_Discord.Cursor = Cursors.Hand;
            btn_Discord.FlatAppearance.BorderColor = Color.Black;
            btn_Discord.FlatAppearance.BorderSize = 0;
            btn_Discord.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            btn_Discord.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btn_Discord.FlatStyle = FlatStyle.Flat;
            btn_Discord.Font = new Font("Aptos", 10F);
            btn_Discord.ForeColor = Color.Black;
            btn_Discord.Location = new Point(1150, 556);
            btn_Discord.Name = "btn_Discord";
            btn_Discord.Size = new Size(32, 32);
            btn_Discord.TabIndex = 21;
            btn_Discord.TabStop = false;
            btn_Discord.TextAlign = ContentAlignment.MiddleLeft;
            btn_Discord.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Discord.UseVisualStyleBackColor = false;
            btn_Discord.Click += btn_Discord_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.Background1;
            ClientSize = new Size(1259, 593);
            Controls.Add(btn_Discord);
            Controls.Add(btn_Donate);
            Controls.Add(btn_YouTube);
            Controls.Add(btn_GitHub);
            Controls.Add(lst_Obj);
            Controls.Add(groupBox3);
            Controls.Add(lst_Mods);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(tb_Path);
            Controls.Add(mStrip);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = mStrip;
            MaximizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Project: Spider-Verse";
            FormClosing += Main_FormClosing;
            FormClosed += Main_FormClosed;
            Load += Main_Load;
            Shown += Main_Shown;
            mStrip.ResumeLayout(false);
            mStrip.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fswDir).EndInit();
            ((System.ComponentModel.ISupportInitialize)fswEmu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_Browse;
        private Button btn_Download;
        private Button btn_Flycast;
        private Button btn_Costumes;
        private Button btn_Chars;
        private Button btn_Gfx;
        private Button btn_Enable;
        private Button btn_Disable;
        private Button btn_Reset;
        private MenuStrip mStrip;
        private ListBox lst_Mods;
        private TextBox tb_Path;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem cheatsToolStripMenuItem;
        private ToolStripMenuItem infoToolStripMenuItem;
        private TextBox tb_Search;
        private CheckBox cb_HUD;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private ToolStripMenuItem saveConfigToolStripMenuItem;
        private ToolStripMenuItem loadConfigToolStripMenuItem;
        private ToolStripMenuItem deleteConfigToolStripMenuItem;
        private ToolStripMenuItem restartToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem creditsToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem messageBoxToolStripMenuItem;
        private ToolStripMenuItem soundEffectsToolStripMenuItem;
        private FileSystemWatcher fswDir;
        private FileSystemWatcher fswEmu;
        private ToolStripMenuItem autoUpdateCheckToolStripMenuItem;
        private ListBox lst_Obj;
        private System.Windows.Forms.Timer fswDirTimer;
        private System.Windows.Forms.Timer fswEmuTimer;
        private Button btn_CheckUpdate;
        private Button btn_YouTube;
        private Button btn_GitHub;
        private Label label1;
        private Button btn_Donate;
        private Button btn_Discord;
    }
}
