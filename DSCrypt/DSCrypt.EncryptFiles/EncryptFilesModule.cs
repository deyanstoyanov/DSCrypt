namespace DSCrypt.EncryptFiles
{
    using DSCrypt.EncryptFiles.Views.RibbonTab;

    using Microsoft.Practices.Prism.Modularity;
    using Microsoft.Practices.Prism.Regions;

    public class EncryptFilesModule : IModule
    {
        private readonly IRegionViewRegistry regionViewRegistry;

        public EncryptFilesModule(IRegionViewRegistry registry)
        {
            this.regionViewRegistry = registry;
        }

        public void Initialize()
        {
            this.regionViewRegistry.RegisterViewWithRegion("MainRegion", typeof(EncryptFilesRibbonTab));
        }
    }
}