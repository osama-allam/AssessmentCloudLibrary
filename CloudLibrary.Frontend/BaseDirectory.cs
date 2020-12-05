using System.IO;

namespace CloudLibrary.Frontend
{
    public static class BaseDirectory
    {
        private static DirectoryInfo EnsureRootFolderCreated()
        {
            DirectoryInfo directoryInfo = null;
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\Providers");
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