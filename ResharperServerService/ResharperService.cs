using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.ServiceProcess;

namespace ResharperServerService
{
    public partial class ResharperService : ServiceBase
    {
        Process myProcess = new Process();
        public ResharperService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            string StrAssemblyFilePath = Assembly.GetExecutingAssembly().Location;
            string AppPath = Path.GetDirectoryName(StrAssemblyFilePath) +
                             "\\IntelliJIDEALicenseServer_windows_amd64.exe";
            // string AppPath = System.Configuration.ConfigurationManager.AppSettings["64bit"];
            myProcess.StartInfo.FileName = AppPath;
            myProcess.StartInfo.Verb = "Open";
            myProcess.StartInfo.CreateNoWindow = true;
            myProcess.Start();
        }

        protected override void OnStop()
        {
            myProcess.Close();
        }
    }
}
