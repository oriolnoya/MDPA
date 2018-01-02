namespace BaseExample.iOS.ViewControllers
{
    using UIKit;

    public partial class DetailViewController : UIViewController
    {
        public ItemDetailViewModel ViewModel { get; set; }

        public DetailViewController() : base("DetailViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            Title = ViewModel.Title;
            ItemNameLabel.Text = ViewModel.Item.Text;
            ItemDescriptionLabel.Text = ViewModel.Item.Description;
        }

    }
}

