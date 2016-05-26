using System;
using UIKit;
using System.Collections;

namespace myApp
{
	public class TableSource : UITableViewSource
	{
		ArrayList tableItems;
		string cellIdentifier = "TableCell";



		public TableSource (ArrayList items)
		{
			tableItems = items;
		}

		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return tableItems.Count;
		}

		public override void RowSelected (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			string[] items = (string[])tableItems [indexPath.Row];
			new UIAlertView ("Alert", "You touched: " + items[0], null, "OK", null).Show ();
			tableView.DeselectRow (indexPath, true);
		}

		public override UITableViewCell GetCell (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell (cellIdentifier);
			if (cell == null)
				cell = new UITableViewCell (UITableViewCellStyle.Value1, cellIdentifier);

			string[] items = (string[])tableItems [indexPath.Row];
			cell.TextLabel.Text = items [0];
			cell.ImageView.Image = UIImage.FromBundle(items[1]);
			cell.DetailTextLabel.Text = items [2];



			
			return cell;
		}
	}
}

