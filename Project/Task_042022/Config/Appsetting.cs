
using System.Reflection;
using System.Text.Json;

namespace Task_042022.Config
{
    public class AppSetting
    {
        public string DefaultConnectionDB { get; set; }

        public AppSetting()
        {
            DefaultConnectionDB = string.Empty;
        }

        public static AppSetting? Initialization()
        {
            try
            {
                var assembly = Assembly.GetExecutingAssembly();
                string resourceName = assembly.GetManifestResourceNames().Single(str => str.EndsWith("AppSetting.json"));
                using var stream = assembly.GetManifestResourceStream(resourceName);
                using var reader = new StreamReader(stream!);
                var result = reader.ReadToEnd();

                return JsonSerializer.Deserialize<AppSetting>(result)!;
            }
            catch
            {
                throw new FileLoadException("The file appSetting was not found or it has the wrong format!\n\nClick OK to exit");
            }
            
        }
    }
}
