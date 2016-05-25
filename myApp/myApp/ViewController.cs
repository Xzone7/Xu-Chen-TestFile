using System;

using UIKit;
using System.Collections.Generic;
using System.Collections;

namespace myApp
{
	public partial class ViewController : UIViewController // ViewController inherits from UIViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			ArrayList dataList = new ArrayList ();
			dataList.Add (new string[] { "Food", "lean" });
			dataList.Add (new string[] { "View", "music" });
			dataList.Add (new string[] { "Music", "lean" });
			dataList.Add (new string[] { "Love", "music" });

			string[] data = new string[]{ 
				"Food", 
				"View", 
				"Music", "Love","Food", "View", "Music", "Love","Food", "View", "Music", "Love" };

			// Perform any additional setup after loading the view, typically from a nib.

			UITableView _table;

			_table = new UITableView {

				Frame = new CoreGraphics.CGRect (0, 30, View.Bounds.Width, View.Bounds.Height - 30),
				Source = new TableSource(dataList)

			};

			View.AddSubview (_table);


		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

