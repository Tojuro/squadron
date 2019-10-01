using System.Collections.Generic;

namespace Squadron
{
    public class AzureStorageQueueImageSettings : IImageSettings
    {
        public AzureStorageQueueImageSettings()
        {
            EnvironmentVariable =
                new List<string>(); 
        }

        public string Name { get; } = ContainerName.Create();
        public string Image { get; } = "mcr.microsoft.com/azure-storage/azurite";
        public long ContainerPort { get; } = 10001;
        public long HostPort { get; set; }
        public string ContainerId { get; set; }
        public string ContainerAddress { get; set; }
        public string Username { get; } = string.Empty;
        public string Password { get; } = string.Empty;
        public List<string> EnvironmentVariable { get; }
        public string Logs { get; set; }
    }
}
