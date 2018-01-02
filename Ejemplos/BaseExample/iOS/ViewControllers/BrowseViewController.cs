namespace BaseExample.iOS.ViewControllers
{
    using System;
    using System.Collections.Specialized;
    using UIKit;

    public partial class BrowseViewController : UIViewController
    {
        UIRefreshControl refreshControl;

        public ItemsViewModel ViewModel { get; set; }

        public BrowseViewController() : base("BrowseViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            ViewModel = new ItemsViewModel();

            // Setup UITableView.
            refreshControl = new UIRefreshControl();
            refreshControl.ValueChanged += RefreshControl_ValueChanged;
            TableView.Add(refreshControl);
            TableView.Source = new BrowseDataSource(ViewModel, this);

            Title = ViewModel.Title;

            ViewModel.PropertyChanged += IsBusy_PropertyChanged;
            ViewModel.Items.CollectionChanged += Items_CollectionChanged;


            var uibarButtonItem = new UIBarButtonItem(UIBarButtonSystemItem.Add, HandleEventHandler);
            NavigationItem.SetRightBarButtonItem(uibarButtonItem, true);
        }

        void HandleEventHandler(object sender, EventArgs e)
        {
            GoToItemNewView();
        }

        void GoToItemNewView()
        {
            var itemNewViewController = new ItemNewViewController();
            itemNewViewController.ViewModel = ViewModel;

            NavigationController.PushViewController(itemNewViewController, true);
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);

            if (ViewModel.Items.Count == 0)
                ViewModel.LoadItemsCommand.Execute(null);
        }

        public void GoToDetailView(Item item)
        {
            var detailViewController = new DetailViewController();
            detailViewController.ViewModel = new ItemDetailViewModel(item);

            NavigationController.PushViewController(detailViewController, true);
        }

        void RefreshControl_ValueChanged(object sender, EventArgs e)
        {
            if (!ViewModel.IsBusy && refreshControl.Refreshing)
                ViewModel.LoadItemsCommand.Execute(null);
        }

        void IsBusy_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            var propertyName = e.PropertyName;
            switch (propertyName)
            {
                case nameof(ViewModel.IsBusy):
                    {
                        InvokeOnMainThread(() =>
                        {
                            if (ViewModel.IsBusy && !refreshControl.Refreshing)
                                refreshControl.BeginRefreshing();
                            else if (!ViewModel.IsBusy)
                                refreshControl.EndRefreshing();
                        });
                    }
                    break;
            }
        }

        void Items_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            InvokeOnMainThread(() => TableView.ReloadData());
        }

    }
}

