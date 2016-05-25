using System;
using UIKit;
using System.Collections;

namespace myApp
{
	public class TableSource : UITableViewSource
	{
		ArrayList tableItems;

		string cellIdentifier = "TableCell";



		public TableSource ( ArrayList items)
		{
			tableItems = items;
		}

		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return tableItems.Count;
		}

		public override void RowSelected (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			string[] item = (string[])tableItems [indexPath.Row];
			new UIAlertView ("Alert", "You touched: " + item[0], null, "OK", null).Show ();
			tableView.DeselectRow (indexPath, true);
		}

		public override UITableViewCell GetCell (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell (cellIdentifier);
			if (cell == null)
				cell = new UITableViewCell (UITableViewCellStyle.Subtitle, cellIdentifier);

			string[] item = (string[])tableItems [indexPath.Row];
			cell.TextLabel.Text = item [0];
			cell.ImageView.Image = UIImage.FromBundle (item[1]);

			if (indexPath.Row > 0) {
				
				string[] lastItem = (string[])tableItems [indexPath.Row-1];
				
				cell.DetailTextLabel.Text = lastItem [0];
			}
			
			return cell;
		}
	}
}

