using Microsoft.Extensions.Configuration;
using System.IO;

namespace SettingManager
{
    public class SecretsManager
    {
        private readonly IConfigurationRoot _configuration;

        public SecretsManager(IConfigurationRoot configuration)
        {
            _configuration = configuration;
        }

        public void UpdateSecret(string key, string value)
        {
            var filePath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "Microsoft", "UserSecrets", _configuration["UserSecretsId"], "secrets.json");

            var json = File.ReadAllText(filePath);
            dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);

            jsonObj[key] = value;

            string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(filePath, output);
        }
    }

}
