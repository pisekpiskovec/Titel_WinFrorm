﻿namespace Titel__WinFrorm_
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tsTop = new System.Windows.Forms.ToolStrip();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.tssbSave = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbCloseFile = new System.Windows.Forms.ToolStripButton();
            this.tsSp1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslChanges = new System.Windows.Forms.ToolStripLabel();
            this.openFileDiMP3 = new System.Windows.Forms.OpenFileDialog();
            this.lFileName = new System.Windows.Forms.Label();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.tbArtist = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbAlbum = new System.Windows.Forms.TextBox();
            this.tbGenre = new System.Windows.Forms.TextBox();
            this.tbAlbumArtist = new System.Windows.Forms.TextBox();
            this.lArtist = new System.Windows.Forms.Label();
            this.lTitle = new System.Windows.Forms.Label();
            this.lAlbum = new System.Windows.Forms.Label();
            this.lDate = new System.Windows.Forms.Label();
            this.lTrackNumber = new System.Windows.Forms.Label();
            this.lGenre = new System.Windows.Forms.Label();
            this.lAlbumArtist = new System.Windows.Forms.Label();
            this.lPicture = new System.Windows.Forms.Label();
            this.lResulution = new System.Windows.Forms.Label();
            this.bOpenPicture = new System.Windows.Forms.Button();
            this.lRatingBlank = new System.Windows.Forms.Label();
            this.numRatingBlank = new System.Windows.Forms.NumericUpDown();
            this.tbStarsBlank = new System.Windows.Forms.TrackBar();
            this.openFileDiJPGPNG = new System.Windows.Forms.OpenFileDialog();
            this.numDate = new System.Windows.Forms.NumericUpDown();
            this.numTrackNumber = new System.Windows.Forms.NumericUpDown();
            this.tbStarsSpotify = new System.Windows.Forms.TrackBar();
            this.numRatingSpotify = new System.Windows.Forms.NumericUpDown();
            this.lRatingSpotify = new System.Windows.Forms.Label();
            this.tbStarsYouTube = new System.Windows.Forms.TrackBar();
            this.numRatingYouTube = new System.Windows.Forms.NumericUpDown();
            this.lRatingYouTube = new System.Windows.Forms.Label();
            this.tbStarsSoundcloud = new System.Windows.Forms.TrackBar();
            this.numRatingSoundcloud = new System.Windows.Forms.NumericUpDown();
            this.lRatingSoundcloud = new System.Windows.Forms.Label();
            this.lComposer = new System.Windows.Forms.Label();
            this.tbComposer = new System.Windows.Forms.TextBox();
            this.lDiscNumber = new System.Windows.Forms.Label();
            this.tFileChanged = new System.Windows.Forms.Timer(this.components);
            this.numDiscNumber = new System.Windows.Forms.NumericUpDown();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pBoxAlbum = new System.Windows.Forms.PictureBox();
            this.lRemixer = new System.Windows.Forms.Label();
            this.tbRemixer = new System.Windows.Forms.TextBox();
            this.tsTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRatingBlank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStarsBlank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTrackNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStarsSpotify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRatingSpotify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStarsYouTube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRatingYouTube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStarsSoundcloud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRatingSoundcloud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // tsTop
            // 
            resources.ApplyResources(this.tsTop, "tsTop");
            this.tsTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpen,
            this.tssbSave,
            this.tsbCloseFile,
            this.tsSp1,
            this.tslChanges});
            this.tsTop.Name = "tsTop";
            this.tsTop.Stretch = true;
            this.toolTip.SetToolTip(this.tsTop, resources.GetString("tsTop.ToolTip"));
            // 
            // tsbOpen
            // 
            resources.ApplyResources(this.tsbOpen, "tsbOpen");
            this.tsbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbOpen.Image = global::Titel_WinFrorm.Properties.Resources.opened_folder_96px;
            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Click += new System.EventHandler(this.tsbtnOpen_Click);
            // 
            // tssbSave
            // 
            resources.ApplyResources(this.tssbSave, "tssbSave");
            this.tssbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tssbSave.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSave,
            this.tsmiSaveAs});
            this.tssbSave.Image = global::Titel_WinFrorm.Properties.Resources.save_96px;
            this.tssbSave.Name = "tssbSave";
            this.tssbSave.ButtonClick += new System.EventHandler(this.tssbSave_ButtonClick);
            // 
            // tsmiSave
            // 
            resources.ApplyResources(this.tsmiSave, "tsmiSave");
            this.tsmiSave.Image = global::Titel_WinFrorm.Properties.Resources.save_96px;
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.Click += new System.EventHandler(this.tssbSave_ButtonClick);
            // 
            // tsmiSaveAs
            // 
            resources.ApplyResources(this.tsmiSaveAs, "tsmiSaveAs");
            this.tsmiSaveAs.Image = global::Titel_WinFrorm.Properties.Resources.save_as_96px;
            this.tsmiSaveAs.Name = "tsmiSaveAs";
            this.tsmiSaveAs.Click += new System.EventHandler(this.tsmiSaveAs_Click);
            // 
            // tsbCloseFile
            // 
            resources.ApplyResources(this.tsbCloseFile, "tsbCloseFile");
            this.tsbCloseFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCloseFile.Image = global::Titel_WinFrorm.Properties.Resources.close_tab_96px;
            this.tsbCloseFile.Name = "tsbCloseFile";
            this.tsbCloseFile.Click += new System.EventHandler(this.tsbCloseFile_Click);
            // 
            // tsSp1
            // 
            resources.ApplyResources(this.tsSp1, "tsSp1");
            this.tsSp1.Name = "tsSp1";
            // 
            // tslChanges
            // 
            resources.ApplyResources(this.tslChanges, "tslChanges");
            this.tslChanges.Name = "tslChanges";
            // 
            // openFileDiMP3
            // 
            this.openFileDiMP3.DefaultExt = "mp3";
            resources.ApplyResources(this.openFileDiMP3, "openFileDiMP3");
            this.openFileDiMP3.RestoreDirectory = true;
            // 
            // lFileName
            // 
            resources.ApplyResources(this.lFileName, "lFileName");
            this.lFileName.Name = "lFileName";
            this.toolTip.SetToolTip(this.lFileName, resources.GetString("lFileName.ToolTip"));
            // 
            // tbFileName
            // 
            resources.ApplyResources(this.tbFileName, "tbFileName");
            this.tbFileName.Name = "tbFileName";
            this.toolTip.SetToolTip(this.tbFileName, resources.GetString("tbFileName.ToolTip"));
            // 
            // tbArtist
            // 
            resources.ApplyResources(this.tbArtist, "tbArtist");
            this.tbArtist.Name = "tbArtist";
            this.toolTip.SetToolTip(this.tbArtist, resources.GetString("tbArtist.ToolTip"));
            // 
            // tbTitle
            // 
            resources.ApplyResources(this.tbTitle, "tbTitle");
            this.tbTitle.Name = "tbTitle";
            this.toolTip.SetToolTip(this.tbTitle, resources.GetString("tbTitle.ToolTip"));
            // 
            // tbAlbum
            // 
            resources.ApplyResources(this.tbAlbum, "tbAlbum");
            this.tbAlbum.Name = "tbAlbum";
            this.toolTip.SetToolTip(this.tbAlbum, resources.GetString("tbAlbum.ToolTip"));
            // 
            // tbGenre
            // 
            resources.ApplyResources(this.tbGenre, "tbGenre");
            this.tbGenre.Name = "tbGenre";
            this.toolTip.SetToolTip(this.tbGenre, resources.GetString("tbGenre.ToolTip"));
            // 
            // tbAlbumArtist
            // 
            resources.ApplyResources(this.tbAlbumArtist, "tbAlbumArtist");
            this.tbAlbumArtist.Name = "tbAlbumArtist";
            this.toolTip.SetToolTip(this.tbAlbumArtist, resources.GetString("tbAlbumArtist.ToolTip"));
            // 
            // lArtist
            // 
            resources.ApplyResources(this.lArtist, "lArtist");
            this.lArtist.Name = "lArtist";
            this.toolTip.SetToolTip(this.lArtist, resources.GetString("lArtist.ToolTip"));
            // 
            // lTitle
            // 
            resources.ApplyResources(this.lTitle, "lTitle");
            this.lTitle.Name = "lTitle";
            this.toolTip.SetToolTip(this.lTitle, resources.GetString("lTitle.ToolTip"));
            // 
            // lAlbum
            // 
            resources.ApplyResources(this.lAlbum, "lAlbum");
            this.lAlbum.Name = "lAlbum";
            this.toolTip.SetToolTip(this.lAlbum, resources.GetString("lAlbum.ToolTip"));
            // 
            // lDate
            // 
            resources.ApplyResources(this.lDate, "lDate");
            this.lDate.Name = "lDate";
            this.toolTip.SetToolTip(this.lDate, resources.GetString("lDate.ToolTip"));
            // 
            // lTrackNumber
            // 
            resources.ApplyResources(this.lTrackNumber, "lTrackNumber");
            this.lTrackNumber.Name = "lTrackNumber";
            this.toolTip.SetToolTip(this.lTrackNumber, resources.GetString("lTrackNumber.ToolTip"));
            // 
            // lGenre
            // 
            resources.ApplyResources(this.lGenre, "lGenre");
            this.lGenre.Name = "lGenre";
            this.toolTip.SetToolTip(this.lGenre, resources.GetString("lGenre.ToolTip"));
            // 
            // lAlbumArtist
            // 
            resources.ApplyResources(this.lAlbumArtist, "lAlbumArtist");
            this.lAlbumArtist.Name = "lAlbumArtist";
            this.toolTip.SetToolTip(this.lAlbumArtist, resources.GetString("lAlbumArtist.ToolTip"));
            // 
            // lPicture
            // 
            resources.ApplyResources(this.lPicture, "lPicture");
            this.lPicture.Name = "lPicture";
            this.toolTip.SetToolTip(this.lPicture, resources.GetString("lPicture.ToolTip"));
            // 
            // lResulution
            // 
            resources.ApplyResources(this.lResulution, "lResulution");
            this.lResulution.Name = "lResulution";
            this.toolTip.SetToolTip(this.lResulution, resources.GetString("lResulution.ToolTip"));
            // 
            // bOpenPicture
            // 
            resources.ApplyResources(this.bOpenPicture, "bOpenPicture");
            this.bOpenPicture.Name = "bOpenPicture";
            this.toolTip.SetToolTip(this.bOpenPicture, resources.GetString("bOpenPicture.ToolTip"));
            this.bOpenPicture.UseVisualStyleBackColor = true;
            this.bOpenPicture.Click += new System.EventHandler(this.bOpenPicture_Click);
            // 
            // lRatingBlank
            // 
            resources.ApplyResources(this.lRatingBlank, "lRatingBlank");
            this.lRatingBlank.Name = "lRatingBlank";
            this.toolTip.SetToolTip(this.lRatingBlank, resources.GetString("lRatingBlank.ToolTip"));
            // 
            // numRatingBlank
            // 
            resources.ApplyResources(this.numRatingBlank, "numRatingBlank");
            this.numRatingBlank.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numRatingBlank.Name = "numRatingBlank";
            this.toolTip.SetToolTip(this.numRatingBlank, resources.GetString("numRatingBlank.ToolTip"));
            this.numRatingBlank.ValueChanged += new System.EventHandler(this.numRating_ValueChanged);
            // 
            // tbStarsBlank
            // 
            resources.ApplyResources(this.tbStarsBlank, "tbStarsBlank");
            this.tbStarsBlank.LargeChange = 1;
            this.tbStarsBlank.Maximum = 5;
            this.tbStarsBlank.Name = "tbStarsBlank";
            this.toolTip.SetToolTip(this.tbStarsBlank, resources.GetString("tbStarsBlank.ToolTip"));
            this.tbStarsBlank.Scroll += new System.EventHandler(this.tbStarsBlank_Scroll);
            // 
            // openFileDiJPGPNG
            // 
            resources.ApplyResources(this.openFileDiJPGPNG, "openFileDiJPGPNG");
            this.openFileDiJPGPNG.RestoreDirectory = true;
            // 
            // numDate
            // 
            resources.ApplyResources(this.numDate, "numDate");
            this.numDate.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numDate.Name = "numDate";
            this.toolTip.SetToolTip(this.numDate, resources.GetString("numDate.ToolTip"));
            this.numDate.Value = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            // 
            // numTrackNumber
            // 
            resources.ApplyResources(this.numTrackNumber, "numTrackNumber");
            this.numTrackNumber.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numTrackNumber.Name = "numTrackNumber";
            this.toolTip.SetToolTip(this.numTrackNumber, resources.GetString("numTrackNumber.ToolTip"));
            this.numTrackNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbStarsSpotify
            // 
            resources.ApplyResources(this.tbStarsSpotify, "tbStarsSpotify");
            this.tbStarsSpotify.LargeChange = 1;
            this.tbStarsSpotify.Maximum = 5;
            this.tbStarsSpotify.Name = "tbStarsSpotify";
            this.toolTip.SetToolTip(this.tbStarsSpotify, resources.GetString("tbStarsSpotify.ToolTip"));
            this.tbStarsSpotify.Scroll += new System.EventHandler(this.tbStarsSpotify_Scroll);
            // 
            // numRatingSpotify
            // 
            resources.ApplyResources(this.numRatingSpotify, "numRatingSpotify");
            this.numRatingSpotify.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numRatingSpotify.Name = "numRatingSpotify";
            this.toolTip.SetToolTip(this.numRatingSpotify, resources.GetString("numRatingSpotify.ToolTip"));
            this.numRatingSpotify.ValueChanged += new System.EventHandler(this.numRatingSpotify_ValueChanged);
            // 
            // lRatingSpotify
            // 
            resources.ApplyResources(this.lRatingSpotify, "lRatingSpotify");
            this.lRatingSpotify.Name = "lRatingSpotify";
            this.toolTip.SetToolTip(this.lRatingSpotify, resources.GetString("lRatingSpotify.ToolTip"));
            // 
            // tbStarsYouTube
            // 
            resources.ApplyResources(this.tbStarsYouTube, "tbStarsYouTube");
            this.tbStarsYouTube.LargeChange = 1;
            this.tbStarsYouTube.Maximum = 5;
            this.tbStarsYouTube.Name = "tbStarsYouTube";
            this.toolTip.SetToolTip(this.tbStarsYouTube, resources.GetString("tbStarsYouTube.ToolTip"));
            this.tbStarsYouTube.Scroll += new System.EventHandler(this.tbStarsYouTube_Scroll);
            // 
            // numRatingYouTube
            // 
            resources.ApplyResources(this.numRatingYouTube, "numRatingYouTube");
            this.numRatingYouTube.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numRatingYouTube.Name = "numRatingYouTube";
            this.toolTip.SetToolTip(this.numRatingYouTube, resources.GetString("numRatingYouTube.ToolTip"));
            this.numRatingYouTube.ValueChanged += new System.EventHandler(this.numRatingYouTube_ValueChanged);
            // 
            // lRatingYouTube
            // 
            resources.ApplyResources(this.lRatingYouTube, "lRatingYouTube");
            this.lRatingYouTube.Name = "lRatingYouTube";
            this.toolTip.SetToolTip(this.lRatingYouTube, resources.GetString("lRatingYouTube.ToolTip"));
            // 
            // tbStarsSoundcloud
            // 
            resources.ApplyResources(this.tbStarsSoundcloud, "tbStarsSoundcloud");
            this.tbStarsSoundcloud.LargeChange = 1;
            this.tbStarsSoundcloud.Maximum = 5;
            this.tbStarsSoundcloud.Name = "tbStarsSoundcloud";
            this.toolTip.SetToolTip(this.tbStarsSoundcloud, resources.GetString("tbStarsSoundcloud.ToolTip"));
            this.tbStarsSoundcloud.Scroll += new System.EventHandler(this.tbStarsSoundcloud_Scroll);
            // 
            // numRatingSoundcloud
            // 
            resources.ApplyResources(this.numRatingSoundcloud, "numRatingSoundcloud");
            this.numRatingSoundcloud.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numRatingSoundcloud.Name = "numRatingSoundcloud";
            this.toolTip.SetToolTip(this.numRatingSoundcloud, resources.GetString("numRatingSoundcloud.ToolTip"));
            this.numRatingSoundcloud.ValueChanged += new System.EventHandler(this.numRatingSoundcloud_ValueChanged);
            // 
            // lRatingSoundcloud
            // 
            resources.ApplyResources(this.lRatingSoundcloud, "lRatingSoundcloud");
            this.lRatingSoundcloud.Name = "lRatingSoundcloud";
            this.toolTip.SetToolTip(this.lRatingSoundcloud, resources.GetString("lRatingSoundcloud.ToolTip"));
            // 
            // lComposer
            // 
            resources.ApplyResources(this.lComposer, "lComposer");
            this.lComposer.Name = "lComposer";
            this.toolTip.SetToolTip(this.lComposer, resources.GetString("lComposer.ToolTip"));
            // 
            // tbComposer
            // 
            resources.ApplyResources(this.tbComposer, "tbComposer");
            this.tbComposer.Name = "tbComposer";
            this.toolTip.SetToolTip(this.tbComposer, resources.GetString("tbComposer.ToolTip"));
            // 
            // lDiscNumber
            // 
            resources.ApplyResources(this.lDiscNumber, "lDiscNumber");
            this.lDiscNumber.Name = "lDiscNumber";
            this.toolTip.SetToolTip(this.lDiscNumber, resources.GetString("lDiscNumber.ToolTip"));
            // 
            // tFileChanged
            // 
            this.tFileChanged.Interval = 1000;
            this.tFileChanged.Tick += new System.EventHandler(this.tFileChanged_Tick);
            // 
            // numDiscNumber
            // 
            resources.ApplyResources(this.numDiscNumber, "numDiscNumber");
            this.numDiscNumber.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numDiscNumber.Name = "numDiscNumber";
            this.toolTip.SetToolTip(this.numDiscNumber, resources.GetString("numDiscNumber.ToolTip"));
            this.numDiscNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pBoxAlbum
            // 
            resources.ApplyResources(this.pBoxAlbum, "pBoxAlbum");
            this.pBoxAlbum.BackgroundImage = global::Titel_WinFrorm.Properties.Resources.generic_music_file_100px;
            this.pBoxAlbum.ErrorImage = global::Titel_WinFrorm.Properties.Resources.generic_music_file_100px;
            this.pBoxAlbum.InitialImage = global::Titel_WinFrorm.Properties.Resources.generic_music_file_100px;
            this.pBoxAlbum.Name = "pBoxAlbum";
            this.pBoxAlbum.TabStop = false;
            this.toolTip.SetToolTip(this.pBoxAlbum, resources.GetString("pBoxAlbum.ToolTip"));
            this.pBoxAlbum.DragDrop += new System.Windows.Forms.DragEventHandler(this.pBoxAlbum_DragDrop);
            this.pBoxAlbum.DragEnter += new System.Windows.Forms.DragEventHandler(this.pBoxAlbum_DragEnter);
            this.pBoxAlbum.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pBoxAlbum_MouseClick);
            this.pBoxAlbum.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pBoxAlbum_MouseDoubleClick);
            // 
            // lRemixer
            // 
            resources.ApplyResources(this.lRemixer, "lRemixer");
            this.lRemixer.Name = "lRemixer";
            this.toolTip.SetToolTip(this.lRemixer, resources.GetString("lRemixer.ToolTip"));
            // 
            // tbRemixer
            // 
            resources.ApplyResources(this.tbRemixer, "tbRemixer");
            this.tbRemixer.Name = "tbRemixer";
            this.toolTip.SetToolTip(this.tbRemixer, resources.GetString("tbRemixer.ToolTip"));
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbRemixer);
            this.Controls.Add(this.lRemixer);
            this.Controls.Add(this.numDiscNumber);
            this.Controls.Add(this.lDiscNumber);
            this.Controls.Add(this.lComposer);
            this.Controls.Add(this.tbComposer);
            this.Controls.Add(this.tbStarsSoundcloud);
            this.Controls.Add(this.numRatingSoundcloud);
            this.Controls.Add(this.lRatingSoundcloud);
            this.Controls.Add(this.tbStarsYouTube);
            this.Controls.Add(this.numRatingYouTube);
            this.Controls.Add(this.lRatingYouTube);
            this.Controls.Add(this.tbStarsSpotify);
            this.Controls.Add(this.numRatingSpotify);
            this.Controls.Add(this.lRatingSpotify);
            this.Controls.Add(this.numTrackNumber);
            this.Controls.Add(this.numDate);
            this.Controls.Add(this.tbStarsBlank);
            this.Controls.Add(this.numRatingBlank);
            this.Controls.Add(this.lRatingBlank);
            this.Controls.Add(this.bOpenPicture);
            this.Controls.Add(this.lResulution);
            this.Controls.Add(this.lPicture);
            this.Controls.Add(this.pBoxAlbum);
            this.Controls.Add(this.lAlbumArtist);
            this.Controls.Add(this.lGenre);
            this.Controls.Add(this.lTrackNumber);
            this.Controls.Add(this.lDate);
            this.Controls.Add(this.lAlbum);
            this.Controls.Add(this.lTitle);
            this.Controls.Add(this.lArtist);
            this.Controls.Add(this.tbAlbumArtist);
            this.Controls.Add(this.tbGenre);
            this.Controls.Add(this.tbAlbum);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.tbArtist);
            this.Controls.Add(this.tbFileName);
            this.Controls.Add(this.lFileName);
            this.Controls.Add(this.tsTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.toolTip.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tsTop.ResumeLayout(false);
            this.tsTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRatingBlank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStarsBlank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTrackNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStarsSpotify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRatingSpotify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStarsYouTube)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRatingYouTube)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStarsSoundcloud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRatingSoundcloud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAlbum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsTop;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        public System.Windows.Forms.OpenFileDialog openFileDiMP3;
        private System.Windows.Forms.Label lFileName;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.TextBox tbArtist;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbAlbum;
        private System.Windows.Forms.TextBox tbGenre;
        private System.Windows.Forms.TextBox tbAlbumArtist;
        private System.Windows.Forms.Label lArtist;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Label lAlbum;
        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.Label lTrackNumber;
        private System.Windows.Forms.Label lGenre;
        private System.Windows.Forms.Label lAlbumArtist;
        private System.Windows.Forms.PictureBox pBoxAlbum;
        private System.Windows.Forms.Label lPicture;
        private System.Windows.Forms.Label lResulution;
        private System.Windows.Forms.Button bOpenPicture;
        private System.Windows.Forms.Label lRatingBlank;
        private System.Windows.Forms.NumericUpDown numRatingBlank;
        private System.Windows.Forms.TrackBar tbStarsBlank;
        private System.Windows.Forms.OpenFileDialog openFileDiJPGPNG;
        private System.Windows.Forms.ToolStripLabel tslChanges;
        private System.Windows.Forms.NumericUpDown numDate;
        private System.Windows.Forms.NumericUpDown numTrackNumber;
        private System.Windows.Forms.TrackBar tbStarsSpotify;
        private System.Windows.Forms.NumericUpDown numRatingSpotify;
        private System.Windows.Forms.Label lRatingSpotify;
        private System.Windows.Forms.TrackBar tbStarsYouTube;
        private System.Windows.Forms.NumericUpDown numRatingYouTube;
        private System.Windows.Forms.Label lRatingYouTube;
        private System.Windows.Forms.TrackBar tbStarsSoundcloud;
        private System.Windows.Forms.NumericUpDown numRatingSoundcloud;
        private System.Windows.Forms.Label lRatingSoundcloud;
        private System.Windows.Forms.Label lComposer;
        private System.Windows.Forms.TextBox tbComposer;
        private System.Windows.Forms.Label lDiscNumber;
        private System.Windows.Forms.ToolStripSeparator tsSp1;
        public System.Windows.Forms.Timer tFileChanged;
        private System.Windows.Forms.ToolStripSplitButton tssbSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveAs;
        private System.Windows.Forms.ToolStripButton tsbCloseFile;
        private System.Windows.Forms.NumericUpDown numDiscNumber;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label lRemixer;
        private System.Windows.Forms.TextBox tbRemixer;
    }
}

