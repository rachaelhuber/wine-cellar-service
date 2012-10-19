namespace WineCellerService
{
    using System;
    using System.Configuration;
    using System.Globalization;
    using System.Linq;
    using System.Reflection;

    public class Program
    {
        public static void Main(string[] args)
        {
            var assembly = typeof(Program).Assembly;
            var description = assembly.GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false).Cast<AssemblyDescriptionAttribute>().FirstOrDefault();

            var provider = CultureInfo.InvariantCulture;
            Console.Out.WriteLine("Version: {0}", assembly.GetName().Version.ToString());
            Console.Out.WriteLine("Description: {0}", description == null ? string.Empty : description.Description);
            Console.Out.WriteLine("Command line args: {0}", string.Join(" ", args));

            var port = int.Parse(ConfigurationManager.AppSettings["Port"], NumberStyles.Any, CultureInfo.InvariantCulture);
            Console.Out.WriteLine("Port: {0}", port.ToString(provider));

            var listeningOn = string.Format("http://+:{0}/", port);

            var appHost = new WineCellarAppHost();
            appHost.Init();
            appHost.Start(listeningOn);

            Console.WriteLine("AppHost Created at {0}, listening on {1}", DateTime.Now, listeningOn);
            Console.ReadKey();
        }
    }
}
