using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORA_Affiliation.Views;

namespace TORA_Affiliation
{
    static class Program
    {

        static Mutex _mutex;

        private static string LoggerFileName { get; } = "Logger.log";


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            InitializeLogger();

            //Check if an instance of the application is already running
            const string appName = "Tora_Affiliation";
            bool createNew;

            _mutex = new Mutex(true, appName, out createNew);

            if (!createNew)
            {
                Trace.TraceError("Application is already running");
                return;
            }

            //Check if application is executed with arguments
            if (args.Any())
            {
                //Only run in command line mode if the argument is "/s" or "-s" for <silent>
                if (args[0] == "/s" || args[0] == "-s")
                {
                    RunCmd();
                }
                else
                {
                    RunUi();
                }
            }
            else
            {
                RunUi();
            }
        }

        /// <summary>
        /// Initialize the Logger file.
        /// </summary>
        static void InitializeLogger()
        {
            var execPath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

            if (execPath != null)
            {
                var logFilePath = Path.Combine(execPath, LoggerFileName);
                Trace.Listeners.Add(new TextWriterTraceListener(logFilePath));
            }

            Trace.AutoFlush = true;
        }

        /// <summary>
        /// Run application in GUI mode.
        /// </summary>
        static void RunUi()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }

        /// <summary>
        /// Run the application in Command Line mode.
        /// </summary>
        static void RunCmd()
        {
            Trace.TraceInformation("Application Started from Command Line");

            var creator = new MainCreator();
            creator.Create();

            Application.Exit();
        }
    }
}
