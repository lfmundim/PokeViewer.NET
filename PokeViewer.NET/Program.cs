using PokeViewer.NET.SubForms;

namespace PokeViewer.NET
{
    static class Program
    {
        public static Egg_Viewer? Viewer;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Viewer = new Egg_Viewer();
            Application.Run(Viewer);
        }
    }
}