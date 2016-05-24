using System;
using UIKit;

namespace myApp
{
	public class TableSource : UITableViewSource
	{
		string[] tableItems;
		string cellIdentifier = "TableCell";



		public TableSource (string[] items)
		{
			tableItems = items;
		}

		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return tableItems.Length;
		}

		public override void RowSelected (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			new UIAlertView ("Alert", "You touched: " + tableItems [indexPath.Row], null, "OK", null).Show ();
			tableView.DeselectRow (indexPath, true);
		}

		public override UITableViewCell GetCell (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell (cellIdentifier);
			if (cell == null)
				cell = new UITableViewCell (UITableViewCellStyle.Subtitle, cellIdentifier);
			cell.TextLabel.Text = tableItems [indexPath.Row];

			if (indexPath.Row > 0)
				cell.DetailTextLabel.Text = tableItems [indexPath.Row - 1];
			
			return cell;
		}
	}
}

