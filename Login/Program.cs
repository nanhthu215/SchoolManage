using GUI;
using Org.BouncyCastle.Asn1.Mozilla;

namespace Login
{
    internal static class Program
    {
        public static String server = "", db = "", uid = "", pw = "";

        public static string Username = "", Role = "";
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new Login());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());

        }
    }
}
