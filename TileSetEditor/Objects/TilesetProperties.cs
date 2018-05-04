namespace TileSetEditor.Objects
{
    public class TilesetProperties
    {
        #region Constructor

        static TilesetProperties()
        {
            Predefined = new TilesetProperties[]
            {
                new TilesetProperties(){ Width = 10, Height = 10, TileSize = 32 },
                new TilesetProperties(){ Width = 12, Height = 24, TileSize = 32 },
                new TilesetProperties(){ Width = 32, Height = 24, TileSize = 32 }
            };
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return string.Format("{0} x {1} Kacheln - {2} Pixel",
                this.Width, this.Height,
                this.TileSize);
        }

        #endregion

        #region Properties

        public int Width { get; set; }
        public int Height { get; set; }
        public int TileSize { get; set; }

        public static TilesetProperties[] Predefined { get; private set; }

        #endregion
    }
}