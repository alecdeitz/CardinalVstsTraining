using System.Configuration;

namespace EcdDotnetReferencePipeline.AcceptanceTests
{
    public static class ConfigurationSettings
    {
        public static string BaseUrl { get { return ConfigurationManager.AppSettings["BaseUrl"]; } }
    }
}
