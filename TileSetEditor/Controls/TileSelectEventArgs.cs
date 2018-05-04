using System;
using System.Drawing;

namespace TileSetEditor.Controls
{
    public class TileSelectEventArgs : EventArgs
    {
        public TileSelectEventArgs(Rectangle tileSelection, Rectangle pixelSelection)
        {
            this.TileSelection = tileSelection;
            this.PixelSelection = pixelSelection;
        }

        public Rectangle TileSelection { get; private set; }
        public Rectangle PixelSelection { get; private set; }
    }
}