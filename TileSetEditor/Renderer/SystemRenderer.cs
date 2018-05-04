using System.Windows.Forms;

namespace TileSetEditor.Renderer
{
    public class SystemRenderer : ToolStripProfessionalRenderer
    {
        #region Constructor

        public SystemRenderer()
            : base(new SystemRendererColors())
        {
        }

        #endregion

        #region Methods

        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
            if (e.ToolStrip.GetType() == typeof(ToolStrip))
            {
                // skip render border
            }
            else
            {
                base.OnRenderToolStripBorder(e);
            }
        }

        #endregion
    }
}