namespace DSCrypt
{
    using System.Windows;

    using DSCrypt.Bootstrapper;

    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            DsCryptBootstrapper bootstrapper = new DsCryptBootstrapper();
            bootstrapper.Run();
        }
    }
}