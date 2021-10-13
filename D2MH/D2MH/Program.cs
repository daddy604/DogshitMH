using System.Windows.Forms;
using D2RAssist;
static class Program
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    //[STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new D2RAssist.Form1());
    }
}