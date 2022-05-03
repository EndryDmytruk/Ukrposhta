using System.Reflection;
using System.Text.Json;

namespace Common
{
    public class DbSetting
    {
        public string DefaultConnectionDB { get; set; }

        public DbSetting()
        {
            DefaultConnectionDB = string.Empty;
        }

        public static DbSetting? Initialization()
        {
            try
            {
                var assembly = Assembly.GetExecutingAssembly();
                string resourceName = assembly.GetManifestResourceNames().Single(str => str.EndsWith("DbSetting.json"));
                using var stream = assembly.GetManifestResourceStream(resourceName);
                using var reader = new StreamReader(stream!);
                var result = reader.ReadToEnd();
                return JsonSerializer.Deserialize<DbSetting>(result)!;
            }
            catch
            {
                throw new Exception("The file appSetting was not found or it has the wrong format!\n\nClick OK to exit");
            }
            
        }
    }
}
