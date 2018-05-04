using System;
using System.Windows.Forms;
using TileSetEditor.Dialogs;

namespace TileSetEditor
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new FormMain(args));
        }
    }
}