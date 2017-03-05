namespace DSCrypt.Shell
{
    using System.Windows.Controls.Ribbon;

    /// <summary>
    /// Interaction logic for Shell.xaml
    /// </summary>
    public partial class Shell : RibbonWindow
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