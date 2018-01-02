namespace BaseExample.iOS.ViewControllers
{
    using UIKit;

    public partial class ItemNewViewController : UIViewController
    {
        public ItemsViewModel ViewModel { get; set; }

        public ItemNewViewController() : base("ItemNewViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            btnSaveItem.TouchUpInside += (sender, e) =>
            {
                var item = new Item
                {
                    Text = txtTitleOk.Text,
                    Description = txtDescOk.Text
                };
                ViewModel.AddItemCommand.Execute(item);
                NavigationController.PopToRootViewController(true);
            };
        }

    }
}

