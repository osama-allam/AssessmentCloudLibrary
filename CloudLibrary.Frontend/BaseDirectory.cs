using System.IO;

namespace CloudLibrary.Frontend
{
    public static class BaseDirectory
    {
        private static DirectoryInfo EnsureRootFolderCreated()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\Providers");
            DirectoryInfo directoryInfo = new DirectoryInfo(filePath);
            if (!Directory.Exists(filePath))
            {
                directoryInfo = Directory.CreateDirectory(filePath);
            }
            return directoryInfo;
        }
        public static string GetProvidersPath()
        {
            var directoryInfo = EnsureRootFolderCreated();
            return directoryInfo.FullName;
        }
    }
}