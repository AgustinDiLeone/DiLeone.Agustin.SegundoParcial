namespace WinForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            FrmLogIn frmLogIn = new FrmLogIn();
            frmLogIn.ShowDialog();
            if (frmLogIn.validacionClaveUsuario)
                Application.Run(new FrmCrudCliente(frmLogIn.Usuario));
              
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            
        }
    }
}