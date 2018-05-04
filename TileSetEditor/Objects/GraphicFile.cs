namespace TileSetEditor.Objects
{
    public class GraphicFile
    {
        public string Text { get; set; }
        public string Path { get; set; }

        public override string ToString()
        {
            return this.Text;
        }
    }
}