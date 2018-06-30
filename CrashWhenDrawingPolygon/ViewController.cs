using System;
using UIKit;

namespace CrashWhenDrawingPolygon
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
		    View = new MyView(View.Bounds);
        }

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
    }
}