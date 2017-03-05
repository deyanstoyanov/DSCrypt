namespace DSCrypt.EncryptFiles.Views.RibbonTab
{
    using System.Windows.Controls.Ribbon;

    using DSCrypt.EncryptFiles.ViewModels.RibbonTab;

    /// <summary>
    /// Interaction logic for EncryptFilesRibbonTab.xaml
    /// </summary>
    public partial class EncryptFilesRibbonTab : RibbonTab
    {
        public EncryptFilesRibbonTab()
        {
            this.InitializeComponent();
            this.ViewModel = new EncryptFilesRibbonTabViewModel();
            this.DataContext = this.ViewModel;
        }

        public EncryptFilesRibbonTabViewModel ViewModel { get; set; }
    }
}