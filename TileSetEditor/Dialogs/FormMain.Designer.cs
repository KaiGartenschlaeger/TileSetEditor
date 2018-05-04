namespace TileSetEditor.Dialogs
{
    partial class FormMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbxFiles = new System.Windows.Forms.ComboBox();
            this.panSource = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTilesetInfo = new System.Windows.Forms.Label();
            this.lblSelectedPos = new System.Windows.Forms.Label();
            this.lblSelectedSize = new System.Windows.Forms.Label();
            this.toolbarSource = new System.Windows.Forms.ToolStrip();
            this.tbbSourceOpen = new System.Windows.Forms.ToolStripButton();
            this.tbbSourceClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tbbSourceFolder = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tbbSourcePaste = new System.Windows.Forms.ToolStripButton();
            this.panDestination = new System.Windows.Forms.Panel();
            this.pbxCanvas = new System.Windows.Forms.PictureBox();
            this.toolbarTarget = new System.Windows.Forms.ToolStrip();
            this.tbbTargetNew = new System.Windows.Forms.ToolStripButton();
            this.tbbTargetOpen = new System.Windows.Forms.ToolStripButton();
            this.tbbTargetClose = new System.Windows.Forms.ToolStripButton();
            this.tbbTargetSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbbTargetRaster = new System.Windows.Forms.ToolStripButton();
            this.tbbTargetResize = new System.Windows.Forms.ToolStripButton();
            this.tbbTargetTilesize = new System.Windows.Forms.ToolStripDropDownButton();
            this.tbbTargetClear = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbbTargetInfo = new System.Windows.Forms.ToolStripButton();
            this.tileset = new TileSetEditor.Controls.TilesetSelector();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panSource.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.toolbarSource.SuspendLayout();
            this.panDestination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCanvas)).BeginInit();
            this.toolbarTarget.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1.Controls.Add(this.toolbarSource);
            this.splitContainer1.Panel1MinSize = 280;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panDestination);
            this.splitContainer1.Panel2.Controls.Add(this.toolbarTarget);
            this.splitContainer1.Panel2MinSize = 280;
            this.splitContainer1.Size = new System.Drawing.Size(778, 559);
            this.splitContainer1.SplitterDistance = 280;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.splMain_MouseUp);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.cbxFiles, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panSource, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 46);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(278, 511);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // cbxFiles
            // 
            this.cbxFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxFiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFiles.FormattingEnabled = true;
            this.cbxFiles.Location = new System.Drawing.Point(3, 3);
            this.cbxFiles.MaxDropDownItems = 20;
            this.cbxFiles.Name = "cbxFiles";
            this.cbxFiles.Size = new System.Drawing.Size(272, 21);
            this.cbxFiles.TabIndex = 1;
            this.cbxFiles.SelectedIndexChanged += new System.EventHandler(this.cbxFiles_SelectedIndexChanged);
            // 
            // panSource
            // 
            this.panSource.AllowDrop = true;
            this.panSource.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panSource.AutoScroll = true;
            this.panSource.Controls.Add(this.tileset);
            this.panSource.Location = new System.Drawing.Point(0, 27);
            this.panSource.Margin = new System.Windows.Forms.Padding(0);
            this.panSource.Name = "panSource";
            this.panSource.Size = new System.Drawing.Size(278, 455);
            this.panSource.TabIndex = 2;
            this.panSource.DragDrop += new System.Windows.Forms.DragEventHandler(this.panSource_DragDrop);
            this.panSource.DragEnter += new System.Windows.Forms.DragEventHandler(this.panSource_DragEnter);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lblTilesetInfo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblSelectedPos, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblSelectedSize, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 482);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(278, 29);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // lblTilesetInfo
            // 
            this.lblTilesetInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTilesetInfo.AutoSize = true;
            this.lblTilesetInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTilesetInfo.Location = new System.Drawing.Point(5, 5);
            this.lblTilesetInfo.Margin = new System.Windows.Forms.Padding(5);
            this.lblTilesetInfo.Name = "lblTilesetInfo";
            this.lblTilesetInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblTilesetInfo.Size = new System.Drawing.Size(43, 19);
            this.lblTilesetInfo.TabIndex = 0;
            this.lblTilesetInfo.Text = "label1";
            this.lblTilesetInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSelectedPos
            // 
            this.lblSelectedPos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelectedPos.AutoSize = true;
            this.lblSelectedPos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSelectedPos.Location = new System.Drawing.Point(58, 5);
            this.lblSelectedPos.Margin = new System.Windows.Forms.Padding(5);
            this.lblSelectedPos.Name = "lblSelectedPos";
            this.lblSelectedPos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblSelectedPos.Size = new System.Drawing.Size(43, 19);
            this.lblSelectedPos.TabIndex = 1;
            this.lblSelectedPos.Text = "label2";
            this.lblSelectedPos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSelectedSize
            // 
            this.lblSelectedSize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelectedSize.AutoSize = true;
            this.lblSelectedSize.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSelectedSize.Location = new System.Drawing.Point(111, 5);
            this.lblSelectedSize.Margin = new System.Windows.Forms.Padding(5);
            this.lblSelectedSize.Name = "lblSelectedSize";
            this.lblSelectedSize.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblSelectedSize.Size = new System.Drawing.Size(43, 19);
            this.lblSelectedSize.TabIndex = 2;
            this.lblSelectedSize.Text = "label3";
            this.lblSelectedSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolbarSource
            // 
            this.toolbarSource.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolbarSource.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolbarSource.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbbSourceOpen,
            this.tbbSourceClose,
            this.toolStripSeparator3,
            this.tbbSourceFolder,
            this.toolStripSeparator4,
            this.tbbSourcePaste});
            this.toolbarSource.Location = new System.Drawing.Point(0, 0);
            this.toolbarSource.Name = "toolbarSource";
            this.toolbarSource.Padding = new System.Windows.Forms.Padding(2);
            this.toolbarSource.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolbarSource.Size = new System.Drawing.Size(278, 46);
            this.toolbarSource.TabIndex = 0;
            this.toolbarSource.Text = "toolStrip1";
            // 
            // tbbSourceOpen
            // 
            this.tbbSourceOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbSourceOpen.Image = global::TileSetEditor.Properties.Resources.Open;
            this.tbbSourceOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbSourceOpen.Margin = new System.Windows.Forms.Padding(1);
            this.tbbSourceOpen.Name = "tbbSourceOpen";
            this.tbbSourceOpen.Padding = new System.Windows.Forms.Padding(2);
            this.tbbSourceOpen.Size = new System.Drawing.Size(40, 40);
            this.tbbSourceOpen.Text = "Öffnen";
            this.tbbSourceOpen.Click += new System.EventHandler(this.tbbSourceOpen_Click);
            // 
            // tbbSourceClose
            // 
            this.tbbSourceClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbSourceClose.Image = global::TileSetEditor.Properties.Resources.FolderClose;
            this.tbbSourceClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbSourceClose.Margin = new System.Windows.Forms.Padding(1, 1, 5, 1);
            this.tbbSourceClose.Name = "tbbSourceClose";
            this.tbbSourceClose.Padding = new System.Windows.Forms.Padding(2);
            this.tbbSourceClose.Size = new System.Drawing.Size(40, 40);
            this.tbbSourceClose.Text = "Schließen";
            this.tbbSourceClose.Click += new System.EventHandler(this.tbbSourceClose_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 42);
            // 
            // tbbSourceFolder
            // 
            this.tbbSourceFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbSourceFolder.Image = global::TileSetEditor.Properties.Resources.Folder;
            this.tbbSourceFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbSourceFolder.Margin = new System.Windows.Forms.Padding(1);
            this.tbbSourceFolder.Name = "tbbSourceFolder";
            this.tbbSourceFolder.Padding = new System.Windows.Forms.Padding(2);
            this.tbbSourceFolder.Size = new System.Drawing.Size(40, 40);
            this.tbbSourceFolder.Text = "Ordner einlesen";
            this.tbbSourceFolder.Click += new System.EventHandler(this.tbbSourceFolder_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 42);
            // 
            // tbbSourcePaste
            // 
            this.tbbSourcePaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbSourcePaste.Image = global::TileSetEditor.Properties.Resources.Clipboard;
            this.tbbSourcePaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbSourcePaste.Margin = new System.Windows.Forms.Padding(1);
            this.tbbSourcePaste.Name = "tbbSourcePaste";
            this.tbbSourcePaste.Padding = new System.Windows.Forms.Padding(2);
            this.tbbSourcePaste.Size = new System.Drawing.Size(40, 40);
            this.tbbSourcePaste.Text = "Aus Zwischenablage einfügen";
            this.tbbSourcePaste.Click += new System.EventHandler(this.tbbSourcePaste_Click);
            // 
            // panDestination
            // 
            this.panDestination.AllowDrop = true;
            this.panDestination.AutoScroll = true;
            this.panDestination.Controls.Add(this.pbxCanvas);
            this.panDestination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panDestination.Location = new System.Drawing.Point(0, 46);
            this.panDestination.Name = "panDestination";
            this.panDestination.Size = new System.Drawing.Size(488, 511);
            this.panDestination.TabIndex = 1;
            this.panDestination.DragDrop += new System.Windows.Forms.DragEventHandler(this.panDestination_DragDrop);
            this.panDestination.DragEnter += new System.Windows.Forms.DragEventHandler(this.panDestination_DragEnter);
            // 
            // pbxCanvas
            // 
            this.pbxCanvas.Location = new System.Drawing.Point(5, 5);
            this.pbxCanvas.Name = "pbxCanvas";
            this.pbxCanvas.Size = new System.Drawing.Size(120, 120);
            this.pbxCanvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxCanvas.TabIndex = 0;
            this.pbxCanvas.TabStop = false;
            this.pbxCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxCanvas_Paint);
            this.pbxCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbxCanvas_MouseDown);
            this.pbxCanvas.MouseLeave += new System.EventHandler(this.pbxCanvas_MouseLeave);
            this.pbxCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbxCanvas_MouseMove);
            this.pbxCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbxCanvas_MouseUp);
            // 
            // toolbarTarget
            // 
            this.toolbarTarget.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolbarTarget.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolbarTarget.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbbTargetNew,
            this.tbbTargetOpen,
            this.tbbTargetClose,
            this.tbbTargetSave,
            this.toolStripSeparator1,
            this.tbbTargetRaster,
            this.tbbTargetResize,
            this.tbbTargetTilesize,
            this.tbbTargetClear,
            this.toolStripSeparator2,
            this.tbbTargetInfo});
            this.toolbarTarget.Location = new System.Drawing.Point(0, 0);
            this.toolbarTarget.Name = "toolbarTarget";
            this.toolbarTarget.Padding = new System.Windows.Forms.Padding(2);
            this.toolbarTarget.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolbarTarget.Size = new System.Drawing.Size(488, 46);
            this.toolbarTarget.TabIndex = 0;
            this.toolbarTarget.Text = "toolStrip1";
            // 
            // tbbTargetNew
            // 
            this.tbbTargetNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbTargetNew.Image = global::TileSetEditor.Properties.Resources.New;
            this.tbbTargetNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbTargetNew.Margin = new System.Windows.Forms.Padding(1);
            this.tbbTargetNew.Name = "tbbTargetNew";
            this.tbbTargetNew.Padding = new System.Windows.Forms.Padding(2);
            this.tbbTargetNew.Size = new System.Drawing.Size(40, 40);
            this.tbbTargetNew.Text = "Schließen";
            this.tbbTargetNew.Click += new System.EventHandler(this.tbbTargetNew_Click);
            // 
            // tbbTargetOpen
            // 
            this.tbbTargetOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbTargetOpen.Image = global::TileSetEditor.Properties.Resources.Open;
            this.tbbTargetOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbTargetOpen.Margin = new System.Windows.Forms.Padding(1);
            this.tbbTargetOpen.Name = "tbbTargetOpen";
            this.tbbTargetOpen.Padding = new System.Windows.Forms.Padding(2);
            this.tbbTargetOpen.Size = new System.Drawing.Size(40, 40);
            this.tbbTargetOpen.Text = "Öffnen";
            this.tbbTargetOpen.Click += new System.EventHandler(this.tbbTargetOpen_Click);
            // 
            // tbbTargetClose
            // 
            this.tbbTargetClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbTargetClose.Image = global::TileSetEditor.Properties.Resources.Close;
            this.tbbTargetClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbTargetClose.Margin = new System.Windows.Forms.Padding(1);
            this.tbbTargetClose.Name = "tbbTargetClose";
            this.tbbTargetClose.Padding = new System.Windows.Forms.Padding(2);
            this.tbbTargetClose.Size = new System.Drawing.Size(40, 40);
            this.tbbTargetClose.Text = "Schließen";
            this.tbbTargetClose.Click += new System.EventHandler(this.tbbTargetClose_Click);
            // 
            // tbbTargetSave
            // 
            this.tbbTargetSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbTargetSave.Image = global::TileSetEditor.Properties.Resources.Save;
            this.tbbTargetSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbTargetSave.Margin = new System.Windows.Forms.Padding(1);
            this.tbbTargetSave.Name = "tbbTargetSave";
            this.tbbTargetSave.Padding = new System.Windows.Forms.Padding(2);
            this.tbbTargetSave.Size = new System.Drawing.Size(40, 40);
            this.tbbTargetSave.Text = "Speichern";
            this.tbbTargetSave.Click += new System.EventHandler(this.tbbTargetSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 42);
            // 
            // tbbTargetRaster
            // 
            this.tbbTargetRaster.Checked = true;
            this.tbbTargetRaster.CheckOnClick = true;
            this.tbbTargetRaster.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbbTargetRaster.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbTargetRaster.Image = global::TileSetEditor.Properties.Resources.Workspace;
            this.tbbTargetRaster.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbTargetRaster.Margin = new System.Windows.Forms.Padding(1);
            this.tbbTargetRaster.Name = "tbbTargetRaster";
            this.tbbTargetRaster.Padding = new System.Windows.Forms.Padding(2);
            this.tbbTargetRaster.Size = new System.Drawing.Size(40, 40);
            this.tbbTargetRaster.Text = "Raster";
            this.tbbTargetRaster.Click += new System.EventHandler(this.tbbTargetRaster_Click);
            // 
            // tbbTargetResize
            // 
            this.tbbTargetResize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbTargetResize.Image = global::TileSetEditor.Properties.Resources.Resize;
            this.tbbTargetResize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbTargetResize.Name = "tbbTargetResize";
            this.tbbTargetResize.Size = new System.Drawing.Size(36, 39);
            this.tbbTargetResize.Text = "Größe ändern";
            this.tbbTargetResize.Click += new System.EventHandler(this.tbbTargetResize_Click);
            // 
            // tbbTargetTilesize
            // 
            this.tbbTargetTilesize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbTargetTilesize.Image = global::TileSetEditor.Properties.Resources.ShapeHandles;
            this.tbbTargetTilesize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbTargetTilesize.Name = "tbbTargetTilesize";
            this.tbbTargetTilesize.Size = new System.Drawing.Size(45, 39);
            this.tbbTargetTilesize.Text = "Kachelgröße";
            this.tbbTargetTilesize.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tbbTargetTilesize_DropDownItemClicked);
            // 
            // tbbTargetClear
            // 
            this.tbbTargetClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbTargetClear.Image = global::TileSetEditor.Properties.Resources.Clear;
            this.tbbTargetClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbTargetClear.Name = "tbbTargetClear";
            this.tbbTargetClear.Size = new System.Drawing.Size(36, 39);
            this.tbbTargetClear.Text = "Leeren";
            this.tbbTargetClear.Click += new System.EventHandler(this.tbbTargetClear_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 42);
            // 
            // tbbTargetInfo
            // 
            this.tbbTargetInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbTargetInfo.Image = global::TileSetEditor.Properties.Resources.Info;
            this.tbbTargetInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbTargetInfo.Margin = new System.Windows.Forms.Padding(1);
            this.tbbTargetInfo.Name = "tbbTargetInfo";
            this.tbbTargetInfo.Padding = new System.Windows.Forms.Padding(2);
            this.tbbTargetInfo.Size = new System.Drawing.Size(40, 40);
            this.tbbTargetInfo.Text = "Informationen";
            this.tbbTargetInfo.Click += new System.EventHandler(this.tbbTargetInfo_Click);
            // 
            // tileset
            // 
            this.tileset.Location = new System.Drawing.Point(0, 0);
            this.tileset.Name = "tileset";
            this.tileset.SingleTileMode = false;
            this.tileset.Size = new System.Drawing.Size(48, 49);
            this.tileset.TabIndex = 2;
            this.tileset.TileSize = new System.Drawing.Size(32, 32);
            this.tileset.SelectionChanged += new System.EventHandler<TileSetEditor.Controls.TileSelectEventArgs>(this.tileset_SelectionChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 565);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Tileset Studio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panSource.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.toolbarSource.ResumeLayout(false);
            this.toolbarSource.PerformLayout();
            this.panDestination.ResumeLayout(false);
            this.panDestination.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCanvas)).EndInit();
            this.toolbarTarget.ResumeLayout(false);
            this.toolbarTarget.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolbarSource;
        private System.Windows.Forms.ToolStripButton tbbSourceOpen;
        private System.Windows.Forms.ToolStripButton tbbSourceClose;
        private System.Windows.Forms.ToolStripButton tbbSourceFolder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cbxFiles;
        private System.Windows.Forms.ToolStrip toolbarTarget;
        private System.Windows.Forms.ToolStripButton tbbTargetOpen;
        private System.Windows.Forms.ToolStripButton tbbTargetClose;
        private System.Windows.Forms.ToolStripButton tbbTargetSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbbTargetInfo;
        private System.Windows.Forms.Panel panDestination;
        private System.Windows.Forms.PictureBox pbxCanvas;
        private System.Windows.Forms.Panel panSource;
        private TileSetEditor.Controls.TilesetSelector tileset;
        private System.Windows.Forms.ToolStripButton tbbTargetRaster;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tbbTargetResize;
        private System.Windows.Forms.ToolStripButton tbbTargetClear;
        private System.Windows.Forms.ToolStripDropDownButton tbbTargetTilesize;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblSelectedPos;
        private System.Windows.Forms.Label lblSelectedSize;
        private System.Windows.Forms.ToolStripButton tbbTargetNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tbbSourcePaste;
        private System.Windows.Forms.Label lblTilesetInfo;
    }
}

