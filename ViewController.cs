using System;

using UIKit;

namespace HelloWorld
{
	public partial class ViewController : UIViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.

			UILabel _helloLabel;

			_helloLabel = new UILabel {
				Frame = new CoreGraphics.CGRect(50, 50, 120, 40),
					Text = "Hello World"
			};

			Console.WriteLine ("Hello World Label careated");

			View.AddSubview (_helloLabel);
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

