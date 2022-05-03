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
                using var reader = new StreamReader(@"..\..\..\..\DbSetting.json");
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
