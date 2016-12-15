using System;
using System.Diagnostics;
using System.Reflection;

namespace ConsoleApplication1
{
    /// <summary>
    /// Application info.
    /// </summary>
    static class ApplicationInfo
    {
        /// <summary>
        /// Writes the header.
        /// </summary>
        public static void WriteHeader()
        {
            var assembly = Assembly.GetEntryAssembly();

            var info = FileVersionInfo.GetVersionInfo(assembly.Location);

            Console.WriteLine($"{assembly.GetName().Name} {info.ProductVersion}");
            Console.WriteLine($"{info.LegalCopyright}");
        }
    }
}
