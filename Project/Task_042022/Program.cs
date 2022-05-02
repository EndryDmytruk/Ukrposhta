using Task_042022.Config;
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
                var setting = AppSetting.Initialization();


                Application.Run(new Home());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }
    }
}