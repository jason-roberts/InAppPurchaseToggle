using InAppPurchaseToggle.WindowsStore;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace SampleApplication
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var inAppFeature1 = new Feature1();           
            
#if DEBUG            
            // By default the feature will use the real store gateway, for testing this can be overridden
            inAppFeature1.WindowsStoreGateway = new SimulatedAlwaysPurchasedGateway();
#endif

            Feature1PurchaseStatus.Text = inAppFeature1.IsPurchased.ToString();


            var inAppFeature2 = new Feature2();
#if DEBUG            
            inAppFeature2.WindowsStoreGateway = new SimulatedNeverPurchasedGateway();
#endif

            Feature2PurchaseStatus.Text = inAppFeature2.IsPurchased.ToString();
        }
    }
}
