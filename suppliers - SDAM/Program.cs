using suppliers___SDAM.Controller;

namespace suppliers___SDAM
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.Run(new testconnection());
            Application.Run(new Forms.AddSupplierForm()); 
            //Application.Run(new Forms.ManageSupplierForm());
        }
    }
}