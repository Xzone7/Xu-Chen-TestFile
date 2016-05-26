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

			ArrayList data = new ArrayList ();
			data.Add (new string[]{ "Food", "foodImage", "18 items" });
			data.Add (new string[]{ "View", "viewImage", "27 items" });
			data.Add (new string[]{ "Music", "musicImage", "40 items" });
			data.Add (new string[]{ "Love", "loveImage", "36 items"});


				

			// Perform any additional setup after loading the view, typically from a nib.

			UITableView _table;

			_table = new UITableView {

				Frame = new CoreGraphics.CGRect (0, 30, View.Bounds.Width, View.Bounds.Height - 30),
				Source = new TableSource(data)

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

