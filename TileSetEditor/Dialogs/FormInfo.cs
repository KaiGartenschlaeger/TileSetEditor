using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace TileSetEditor.Dialogs
{
    public partial class FormInfo : Form
    {
        #region Constructor

        public FormInfo()
        {
            InitializeComponent();
        }

        #endregion

        #region Control events

        private void lnkHomepage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(lnkHomepage.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Die Webseite konnte nicht geöffnet werden.\n" + ex.Message, "Fehlgeschlagen",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion
    }
}