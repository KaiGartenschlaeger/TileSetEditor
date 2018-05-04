using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using TileSetEditor.Objects;

namespace TileSetEditor.Dialogs
{
    public partial class FormNew : Form
    {
        #region Fields

        private List<TilesetProperties> m_presets;

        #endregion

        #region Constructor

        public FormNew(List<TilesetProperties> presets)
        {
            InitializeComponent();

            m_presets = presets;
            foreach (TilesetProperties tp in presets)
            {
                cbxPreset.Items.Add(tp);
            }
        }

        public FormNew(List<TilesetProperties> presets, TilesetProperties tp)
            : this(presets)
        {
            nudWidth.Value = tp.Width;
            nudHeight.Value = tp.Height;
            nudTileSize.Value = tp.TileSize;
        }

        #endregion

        #region Control events

        private void cbxPreset_SelectedIndexChanged(object sender, EventArgs e)
        {
            TilesetProperties selected = cbxPreset.SelectedItem as TilesetProperties;
            if (selected != null)
            {
                nudWidth.Value = selected.Width;
                nudHeight.Value = selected.Height;
                nudTileSize.Value = selected.TileSize;
            }
        }

        private void btnPreset_Click(object sender, EventArgs e)
        {
            menuPreset.Show(MousePosition);
        }

        #endregion

        #region Menu events

        private void menuPreset_Opening(object sender, CancelEventArgs e)
        {
            mniDeletePreset.Enabled = (cbxPreset.SelectedIndex != -1);
        }

        private void mniSavePreset_Click(object sender, EventArgs e)
        {
            TilesetProperties tp = new TilesetProperties();
            tp.Width = (int)nudWidth.Value;
            tp.Height = (int)nudHeight.Value;
            tp.TileSize = (int)nudTileSize.Value;

            m_presets.Add(tp);

            cbxPreset.Items.Add(tp);
            cbxPreset.SelectedIndex = (cbxPreset.Items.Count - 1);
        }

        private void mniDeletePreset_Click(object sender, EventArgs e)
        {
            if (cbxPreset.SelectedIndex != -1)
            {
                m_presets.RemoveAt(cbxPreset.SelectedIndex);
                cbxPreset.Items.RemoveAt(cbxPreset.SelectedIndex);
            }
        }

        #endregion

        #region Properties

        [Browsable(false)]
        public int TileSetWidth
        {
            get { return (int)nudWidth.Value; }
            set { nudWidth.Value = value; }
        }

        [Browsable(false)]
        public int TileSetHeight
        {
            get { return (int)nudHeight.Value; }
            set { nudHeight.Value = value; }
        }

        [Browsable(false)]
        public int TileSize
        {
            get { return (int)nudTileSize.Value; }
            set { nudTileSize.Value = value; }
        }

        #endregion
    }
}