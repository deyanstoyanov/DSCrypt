namespace DSCrypt.Shell
{
    using System.Windows;

    /// <summary>
    /// Interaction logic for Shell.xaml
    /// </summary>
    public partial class Shell : Window
    {
        public Shell()
        {
            this.InitializeComponent();
            this.ViewModel = new ShellViewModel();
            this.DataContext = this.ViewModel;
        }

        public ShellViewModel ViewModel { get; set; }
    }
}