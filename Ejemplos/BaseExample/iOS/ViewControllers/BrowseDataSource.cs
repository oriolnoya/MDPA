namespace BaseExample.iOS.ViewControllers
{
    using System;
    using Foundation;
    using UIKit;

    public class BrowseDataSource : UITableViewSource
    {
        static readonly string CellIdentifier = "TableCell";

        ItemsViewModel viewModel;
        BrowseViewController owner;

        public BrowseDataSource(ItemsViewModel _viewModel, BrowseViewController _owner)
        {
            this.viewModel = _viewModel;
            owner = _owner;
        }

        public override nint RowsInSection(UITableView tableview, nint section) => viewModel.Items.Count;
        public override nint NumberOfSections(UITableView tableView) => 1;

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell(CellIdentifier);
            if (cell == null)
                cell = new UITableViewCell(UITableViewCellStyle.Subtitle, CellIdentifier);

            var item = viewModel.Items[indexPath.Row];
            cell.TextLabel.Text = item.Text;
            cell.DetailTextLabel.Text = item.Description;
            cell.LayoutMargins = UIEdgeInsets.Zero;

            return cell;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            var item = viewModel.Items[indexPath.Row];
            owner.GoToDetailView(item);
        }
    }
}
