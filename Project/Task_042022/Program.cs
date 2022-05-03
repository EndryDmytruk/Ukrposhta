using DB;
using Task_042022.MenuForm;

namespace Task_042022
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            
            try
            {
                var context = new ContextDB();

                Application.Run(new Home());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }
    }
}