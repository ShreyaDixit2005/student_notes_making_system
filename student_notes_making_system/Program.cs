namespace student_notes_making_system
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string username = Properties.Settings.Default.Username;
            string password = Properties.Settings.Default.Password;

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                Application.Run(new notes_and_timet3()); // open main form directly
            }
            else
            {
                Application.Run(new Form1()); // open login form
            }
        }
    }
}