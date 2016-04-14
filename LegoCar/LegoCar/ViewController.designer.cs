// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace LegoCar
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnBack { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnForward { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnLeft { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnRight { get; set; }

		[Action ("BtnForward_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void BtnForward_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (btnBack != null) {
				btnBack.Dispose ();
				btnBack = null;
			}
			if (btnForward != null) {
				btnForward.Dispose ();
				btnForward = null;
			}
			if (btnLeft != null) {
				btnLeft.Dispose ();
				btnLeft = null;
			}
			if (btnRight != null) {
				btnRight.Dispose ();
				btnRight = null;
			}
		}
	}
}
