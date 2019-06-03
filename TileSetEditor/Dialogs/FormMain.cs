using SimpleConfiguration;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using TileSetEditor.Controls;
using TileSetEditor.Objects;
using TileSetEditor.Renderer;

namespace TileSetEditor.Dialogs
{
    public partial class FormMain : Form
    {
        #region Fields

        private string[] m_arguments;

        private readonly string SettingsPath;
        private readonly string SettingsFilePath;

        private int m_lastTileSize;
        private int m_lastTileSetWidth;
        private int m_lastTileSetHeight;
        private int m_lastDrawTileSize;

        private TilesetProperties m_properties = null;
        private bool m_mouseIsDown = false;

        private List<TilesetProperties> m_presets;

        private string m_lastPath;

        #endregion

        #region Constructor

        public FormMain(string[] args)
        {
            InitializeComponent();

            this.m_arguments = args;

            this.toolbarSource.Renderer = new SystemRenderer();
            this.toolbarTarget.Renderer = new SystemRenderer();
            this.cbxFiles.Enabled = false;

            for (int i = 1; i < 10; i++)
            {
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Text = (i * 8).ToString() + " Pixel";
                item.Tag = (i * 8);

                tbbTargetTilesize.DropDownItems.Add(item);
            }

            this.SettingsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "TilesetStudio");
            this.SettingsFilePath = Path.Combine(this.SettingsPath, "Settings.xml");

            // open settings
            OpenSettings();

            // init gui
            tileset.TileSize = new Size(m_lastDrawTileSize, m_lastDrawTileSize);
            RefreshGUI();

            // restore last selected path
            if (!string.IsNullOrEmpty(m_lastPath))
            {
                ChangeDirectory(m_lastPath);
            }
        }

        #endregion

        #region Form events

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }

        #endregion

        #region Helper

        private void OpenSettings()
        {
            try
            {
                if (!Directory.Exists(this.SettingsPath))
                {
                    Directory.CreateDirectory(this.SettingsPath);
                }

                ConfigGroup settings = ConfigGroup.Create("Settings");
                if (File.Exists(this.SettingsFilePath))
                {
                    settings = ConfigGroup.Load(this.SettingsFilePath, ConfigFormat.Xml);
                }

                Screen screen = Screen.FromHandle(this.Handle);

                ConfigGroup main = settings.SetGroup("Main");
                this.Width = main.ReadInt32("Width", this.Width);
                this.Height = main.ReadInt32("Height", this.Height);
                this.Left = main.ReadInt32("Left", screen.WorkingArea.Width / 2 - this.Width / 2);
                this.Top = main.ReadInt32("Top", screen.WorkingArea.Height / 2 - this.Height / 2);

                ConfigGroup last = settings.SetGroup("Last");
                m_lastTileSize = last.ReadInt32("TileSize", 32);
                m_lastTileSetWidth = last.ReadInt32("TileSetWidth", 10);
                m_lastTileSetHeight = last.ReadInt32("TileSetHeight", 10);
                m_lastPath = last.ReadString("Path", null);
                m_lastDrawTileSize = last.ReadInt32("DrawTileSize", 32);

                m_presets = new List<TilesetProperties>();

                ConfigGroup presets = settings.SetGroup("Presets");
                foreach (ConfigGroup preset in presets.Groups)
                {
                    TilesetProperties tp = new TilesetProperties();
                    tp.Width = preset.ReadInt32("Width", 10);
                    tp.Height = preset.ReadInt32("Height", 10);
                    tp.TileSize = preset.ReadInt32("TileSize", 32);
                    m_presets.Add(tp);
                }

                this.splitContainer1.SplitterDistance = main.ReadInt32("Splitter", splitContainer1.SplitterDistance);

                ConfigGroup misc = settings.SetGroup("Misc");
                tbbTargetRaster.Checked = misc.ReadBool("Raster", true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Die Einstellungen konnten nicht geöffnet werden.\n" + ex.Message, "Fehler",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveSettings()
        {
            try
            {
                if (!Directory.Exists(this.SettingsPath))
                {
                    Directory.CreateDirectory(this.SettingsPath);
                }

                ConfigGroup settings = ConfigGroup.Create("Settings");

                ConfigGroup main = settings.SetGroup("Main");
                main.Write("Left", this.Left);
                main.Write("Top", this.Top);
                main.Write("Width", this.Width);
                main.Write("Height", this.Height);
                main.Write("Splitter", this.splitContainer1.SplitterDistance);

                ConfigGroup last = settings.SetGroup("Last");
                last.Write("TileSize", m_lastTileSize);
                last.Write("TileSetWidth", m_lastTileSetWidth);
                last.Write("TileSetHeight", m_lastTileSetHeight);
                last.Write("Path", m_lastPath ?? string.Empty);
                last.Write("DrawTileSize", m_lastDrawTileSize);

                ConfigGroup presets = settings.SetGroup("Presets");
                for (int i = 0; i < m_presets.Count; i++)
                {
                    ConfigGroup preset = presets.SetGroup("Preset" + (1 + i));
                    preset.Write("Width", m_presets[i].Width);
                    preset.Write("Height", m_presets[i].Height);
                    preset.Write("TileSize", m_presets[i].TileSize);
                }

                ConfigGroup misc = settings.SetGroup("Misc");
                misc.Write("Raster", tbbTargetRaster.Checked);

                settings.Save(this.SettingsFilePath, ConfigFormat.Xml);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Die Einstellungen konnten nicht gespeichert werden.\n" + ex.Message, "Fehler",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NewTileset(TilesetProperties tp)
        {
            m_properties = tp;

            Bitmap bitmap = new Bitmap(
                m_properties.Width * m_properties.TileSize,
                m_properties.Height * m_properties.TileSize,
                PixelFormat.Format32bppArgb);

            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.Clear(Color.Transparent);
            }

            pbxCanvas.Image = bitmap;

            tileset.TileSize = new Size(m_properties.TileSize, m_properties.TileSize);

            RefreshGUI();
        }

        private void RefreshSelection()
        {
            if (tileset.SourceImage != null)
            {
                var tilesCountX = tileset.SourceImage.Width / tileset.TileSize.Width;
                var tilesCountY = tileset.SourceImage.Height / tileset.TileSize.Height;

                lblTilesetInfo.Show();
                lblTilesetInfo.Text = string.Format("{0} x {1} / {2} x {3}",
                    tileset.SourceImage.Width,
                    tileset.SourceImage.Height,
                    tilesCountX,
                    tilesCountY);

                lblSelectedPos.Show();
                lblSelectedPos.Text = string.Format("{0}, {1} / {2}, {3} / {4:n0}",
                    tileset.SelectedTiles.X,
                    tileset.SelectedTiles.Y,
                    tileset.Selection.Left,
                    tileset.Selection.Top,
                    tileset.SelectedTiles.Top * tilesCountX + tileset.SelectedTiles.Left);

                lblSelectedSize.Show();
                lblSelectedSize.Text = string.Format("{0} x {1} / {2} x {3}",
                    tileset.SelectedTiles.Width,
                    tileset.SelectedTiles.Height,
                    tileset.Selection.Width,
                    tileset.Selection.Height);
            }
            else
            {
                lblTilesetInfo.Hide();
                lblSelectedPos.Hide();
                lblSelectedSize.Hide();
            }
        }

        private void RefreshGUI()
        {
            tbbSourceClose.Enabled = (tileset.SourceImage != null);
            tbbTargetClose.Enabled = (pbxCanvas.Image != null);
            tbbTargetSave.Enabled = (pbxCanvas.Image != null);
            tbbTargetResize.Enabled = (pbxCanvas.Image != null);
            tbbTargetClear.Enabled = (pbxCanvas.Image != null);
            tbbTargetTilesize.Enabled = (pbxCanvas.Image != null);

            RefreshSelection();
        }

        private void AddFiles(string[] files)
        {
            cbxFiles.Items.Clear();
            foreach (string file in files)
            {
                GraphicFile graphic = new GraphicFile();
                graphic.Text = Path.GetFileName(file);
                graphic.Path = file;

                cbxFiles.Items.Add(graphic);
            }

            cbxFiles.Enabled = (cbxFiles.Items.Count > 0);
        }

        private void ChangeTileset(string path)
        {
            try
            {
                CloseTileset();
                using (var stream = File.OpenRead(path))
                {
                    tileset.SourceImage = Image.FromStream(stream);
                    tileset.Size = tileset.SourceImage.Size;
                }

                RefreshGUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim öffnen der Date.\n" + ex.Message, "Fehler",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangeDirectory(string path)
        {
            m_lastPath = path;

            try
            {
                List<string> filesList = new List<string>();

                string[] files = Directory.GetFiles(path, "*.*");
                foreach (string file in files)
                {
                    string extension = Path.GetExtension(file).ToLower().Trim();
                    if (extension == ".png" || extension == ".bmp" || extension == ".jpg")
                    {
                        filesList.Add(file);
                    }
                }

                filesList.Sort();
                AddFiles(filesList.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim öffnen des Ordners.\n" + ex.Message, "Fehler",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CloseTileset()
        {
            var image = tileset.SourceImage;
            if (image != null)
            {
                tileset.Size = new Size(10, 10);
                tileset.SourceImage.Dispose();
                tileset.SourceImage = null;
            }
        }

        private void ChangeSize(TilesetProperties tp)
        {
            Bitmap bitmap = new Bitmap(tp.Width * tp.TileSize, tp.Height * tp.TileSize);
            bitmap.SetResolution(pbxCanvas.Image.HorizontalResolution, pbxCanvas.Image.VerticalResolution);

            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.Clear(Color.Transparent);
                graphics.DrawImage(pbxCanvas.Image, 0, 0);
            }

            pbxCanvas.Image = bitmap;
            this.m_properties = tp;

            tileset.TileSize = new Size(m_properties.TileSize, m_properties.TileSize);

            pbxCanvas.Refresh();
        }

        private void ChangeTilesize(int tileSize)
        {
            m_lastDrawTileSize = tileSize;

            m_properties.TileSize = tileSize;

            tileset.SelectedTiles = new Rectangle(0, 0, 1, 1);
            tileset.TileSize = new Size(m_properties.TileSize, m_properties.TileSize);

            pbxCanvas.Refresh();
        }

        private void DrawTile(int x, int y, bool deleteMode)
        {
            if (pbxCanvas.Image != null)
            {
                if (deleteMode)
                {
                    using (Graphics graphics = Graphics.FromImage(pbxCanvas.Image))
                    {
                        graphics.Clip = new Region(new Rectangle(
                            x / m_properties.TileSize * m_properties.TileSize,
                            y / m_properties.TileSize * m_properties.TileSize,
                            m_properties.TileSize,
                            m_properties.TileSize));
                        graphics.Clear(Color.Transparent);

                        graphics.Clip = new Region(new Rectangle(
                            0, 0,
                            pbxCanvas.Image.Width,
                            pbxCanvas.Image.Height));
                    }
                }
                else
                {
                    if (tileset.SourceImage != null)
                    {
                        if (tileset.SourceImage.HorizontalResolution != pbxCanvas.Image.HorizontalResolution
                           || tileset.SourceImage.VerticalResolution != pbxCanvas.Image.VerticalResolution)
                        {
                            ((Bitmap)pbxCanvas.Image).SetResolution(tileset.SourceImage.HorizontalResolution, tileset.SourceImage.VerticalResolution);
                        }

                        using (Graphics graphics = Graphics.FromImage(pbxCanvas.Image))
                        {
                            if (!System.Windows.Input.Keyboard.IsKeyDown(System.Windows.Input.Key.LeftShift))
                            {
                                graphics.Clip = new Region(new Rectangle(
                                    x / m_properties.TileSize * m_properties.TileSize,
                                    y / m_properties.TileSize * m_properties.TileSize,
                                    tileset.Selection.Width,
                                    tileset.Selection.Height));

                                graphics.Clear(Color.Transparent);
                            }

                            graphics.Clip = new Region(new Rectangle(0, 0,
                                pbxCanvas.Image.Width, pbxCanvas.Image.Height));
                            graphics.DrawImage(tileset.SourceImage,
                                x / m_properties.TileSize * m_properties.TileSize,
                                y / m_properties.TileSize * m_properties.TileSize,
                                tileset.Selection,
                                GraphicsUnit.Pixel);
                        }
                    }
                }

                this.Refresh();
            }
        }

        private void ClearCanvas()
        {
            using (Graphics graphics = Graphics.FromImage(pbxCanvas.Image))
            {
                graphics.Clear(Color.Transparent);
            }

            pbxCanvas.Refresh();
        }

        #endregion

        #region Control events

        private void tileset_SelectionChanged(object sender, TileSelectEventArgs e)
        {
            RefreshSelection();
        }

        private void panSource_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void panSource_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];
            if (files != null && files.Length > 0)
            {
                if (File.Exists(files[0]))
                {
                    ChangeTileset(files[0]);
                }
                else if (Directory.Exists(files[0]))
                {
                    ChangeDirectory(files[0]);
                }
            }
        }

        private void panDestination_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];
            if (files != null && files.Length > 0 && File.Exists(files[0]))
            {
                using (Image source = Image.FromFile(files[0]))
                {
                    Bitmap bitmap = new Bitmap(source.Width, source.Height);
                    bitmap.SetResolution(source.HorizontalResolution, source.VerticalResolution);

                    using (Graphics graphics = Graphics.FromImage(bitmap))
                    {
                        graphics.Clear(Color.Transparent);
                        graphics.DrawImage(source, 0, 0);
                    }

                    pbxCanvas.Image = bitmap;
                }

                m_properties = new TilesetProperties();
                m_properties.TileSize = 32;
                m_properties.Width = pbxCanvas.Image.Width / m_properties.TileSize;
                m_properties.Height = pbxCanvas.Image.Height / m_properties.TileSize;

                RefreshGUI();
            }
        }

        private void panDestination_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            toolbarSource.Focus();

            if (m_arguments != null && m_arguments.Length > 0)
            {
                if (File.Exists(m_arguments[0]))
                {
                    ChangeTileset(m_arguments[0]);
                }
            }
        }

        private void splMain_MouseUp(object sender, MouseEventArgs e)
        {
            toolbarSource.Focus();
        }

        private void cbxFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxFiles.SelectedItem != null)
            {
                GraphicFile graphic = (GraphicFile)cbxFiles.SelectedItem;
                ChangeTileset(graphic.Path);
                RefreshGUI();
            }
            else
            {
                tileset.SourceImage = null;
                tileset.Size = new Size(10, 10);
            }
        }

        private void pbxCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (pbxCanvas.Image != null)
            {
                e.Graphics.SmoothingMode = SmoothingMode.HighSpeed;

                using (Pen pen = new Pen(Color.FromArgb(200, Color.Gray)))
                {
                    if (tbbTargetRaster.Checked)
                    {
                        int rowsX = (int)Math.Ceiling((double)pbxCanvas.Image.Height / m_properties.TileSize);
                        int rowsY = (int)Math.Ceiling((double)pbxCanvas.Image.Width / m_properties.TileSize);

                        for (int x = 1; x < rowsX; x++)
                        {
                            e.Graphics.DrawLine(pen,
                                0, x * m_properties.TileSize,
                                pbxCanvas.Image.Width, x * m_properties.TileSize);
                        }
                        for (int y = 1; y < rowsY; y++)
                        {
                            e.Graphics.DrawLine(pen,
                                y * m_properties.TileSize, 0,
                                y * m_properties.TileSize, pbxCanvas.Image.Height);
                        }
                    }

                    e.Graphics.DrawRectangle(pen, 0, 0,
                        pbxCanvas.Width - 1, pbxCanvas.Height - 1);
                }
            }
        }

        private void pbxCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (!m_mouseIsDown)
            {
                m_mouseIsDown = true;
                DrawTile(e.X, e.Y, e.Button == MouseButtons.Right);
            }
        }

        private void pbxCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (m_mouseIsDown)
            {
                DrawTile(e.X, e.Y, e.Button == MouseButtons.Right);
            }
        }

        private void pbxCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            m_mouseIsDown = false;
        }

        private void pbxCanvas_MouseLeave(object sender, EventArgs e)
        {
            m_mouseIsDown = false;
        }

        #endregion

        #region Toolbar source

        private void tbbSourcePaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsImage())
            {
                CloseTileset();

                tileset.SourceImage = Clipboard.GetImage();
                tileset.Size = tileset.SourceImage.Size;

                RefreshGUI();
            }
        }

        private void tbbSourceOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Tileset öffnen";
                dialog.Filter = "Unterstüzte Formate|*.bmp;*.png;*.jpg";
                dialog.CheckFileExists = true;
                dialog.CheckPathExists = true;

                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    ChangeTileset(dialog.FileName);
                    RefreshGUI();
                }
            }
        }

        private void tbbSourceClose_Click(object sender, EventArgs e)
        {
            CloseTileset();
            RefreshGUI();
        }

        private void tbbSourceFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Quellordner auswählen";
                dialog.ShowNewFolderButton = false;

                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    ChangeDirectory(dialog.SelectedPath);
                }
            }
        }

        #endregion

        #region Toolbar target

        private void tbbTargetResize_Click(object sender, EventArgs e)
        {
            using (FormNew dialog = new FormNew(m_presets, m_properties))
            {
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    TilesetProperties tp = new TilesetProperties();
                    tp.Width = dialog.TileSetWidth;
                    tp.Height = dialog.TileSetHeight;
                    tp.TileSize = dialog.TileSize;

                    ChangeSize(tp);
                }
            }
        }

        private void tbbTargetNew_Click(object sender, EventArgs e)
        {
            using (FormNew dialog = new FormNew(m_presets))
            {
                dialog.TileSetWidth = m_lastTileSetWidth;
                dialog.TileSetHeight = m_lastTileSetHeight;
                dialog.TileSize = m_lastTileSize;

                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    m_lastTileSetWidth = dialog.TileSetWidth;
                    m_lastTileSetHeight = dialog.TileSetHeight;
                    m_lastTileSize = dialog.TileSize;
                    m_lastDrawTileSize = dialog.TileSize;

                    TilesetProperties tp = new TilesetProperties();
                    tp.Width = dialog.TileSetWidth;
                    tp.Height = dialog.TileSetHeight;
                    tp.TileSize = dialog.TileSize;

                    NewTileset(tp);
                }
            }
        }

        private void tbbTargetSave_Click(object sender, EventArgs e)
        {
            if (pbxCanvas.Image != null)
            {
                using (SaveFileDialog dialog = new SaveFileDialog())
                {
                    dialog.Title = "Tileset speichern";
                    dialog.Filter = "PNG|*.png|BMP|*.bmp";
                    dialog.OverwritePrompt = true;
                    dialog.FileName = "Neues Tileset";

                    if (dialog.ShowDialog(this) == DialogResult.OK)
                    {
                        try
                        {
                            pbxCanvas.Image.Save(dialog.FileName,
                                dialog.FilterIndex == 1 ? ImageFormat.Png : ImageFormat.Bmp);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Speichern fehlgeschlagen.\n" + ex.Message, "Fehler",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void tbbTargetOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Tileset öffnen";
                dialog.Filter = "Unterstüzte Formate|*.bmp;*.png;*.jpg";
                dialog.CheckFileExists = true;
                dialog.CheckPathExists = true;

                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    try
                    {
                        using (Image source = Image.FromFile(dialog.FileName))
                        {
                            Bitmap bitmap = new Bitmap(source.Width, source.Height);
                            bitmap.SetResolution(source.HorizontalResolution, source.VerticalResolution);

                            using (Graphics graphics = Graphics.FromImage(bitmap))
                            {
                                graphics.Clear(Color.Transparent);
                                graphics.DrawImage(source, 0, 0);
                            }

                            pbxCanvas.Image = bitmap;
                        }

                        m_properties = new TilesetProperties();
                        m_properties.TileSize = 32;
                        m_properties.Width = pbxCanvas.Image.Width / m_properties.TileSize;
                        m_properties.Height = pbxCanvas.Image.Height / m_properties.TileSize;

                        RefreshGUI();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Fehler beim öffnen der Date.\n" + ex.Message, "Fehler",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void tbbTargetClose_Click(object sender, EventArgs e)
        {
            if (pbxCanvas.Image != null)
            {
                if (MessageBox.Show("Möchten Sie das Tileset wirklich schließen?\nNicht gesicherte Änderungen gehen damit verloren.", "Warnung",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                {
                    return;
                }

                Image image = pbxCanvas.Image;
                pbxCanvas.Image = null;
                image.Dispose();

                RefreshGUI();
            }
        }

        private void tbbTargetRaster_Click(object sender, EventArgs e)
        {
            pbxCanvas.Refresh();
        }

        private void tbbTargetInfo_Click(object sender, EventArgs e)
        {
            using (FormInfo dialog = new FormInfo())
            {
                dialog.ShowDialog(this);
            }
        }

        private void tbbTargetClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hiermit werden alle gezeichneten Inhalte gelöscht.\nMöchten Sie wirklich fortsetzen?", "Warnung",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                ClearCanvas();
            }
        }

        private void tbbTargetTilesize_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ChangeTilesize((int)e.ClickedItem.Tag);
        }

        #endregion
    }
}