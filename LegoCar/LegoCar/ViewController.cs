using System;
using System.Net;
using UIKit;

namespace LegoCar
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
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

		partial void BtnForward_TouchUpInside (UIButton sender)
		{
			var request = HttpWebRequest.Create("192.168.42.1");
			request.ContentType = "application/json";
			request.Method = "POST";

			// Used to send an Authorization header?
			// httpWebRequest.Credentials = new NetworkCredential (Token, "");

			//var alert = UIAlertController.Create ("Moving", "Forward", UIAlertControllerStyle.Alert);
			//alert.AddAction (UIAlertAction.Create ("Ok", UIAlertActionStyle.Default, null));
			//PresentViewController (alert, true, null);
		}
	}
}

