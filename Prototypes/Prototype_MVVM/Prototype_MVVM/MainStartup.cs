using System;
using System.Windows;

namespace Prototype_MVVM
{
    class MainStartup
    {
        //Required to uise COM components (indicates that application is single-threaded
        [STAThread]
        public static void Main(string[] args)
        {
            //Requires System.PresentationFramework for System.Windows.Application
            Application app = new Application();
            app.Run(new MainWindow());
        }
    }
}
