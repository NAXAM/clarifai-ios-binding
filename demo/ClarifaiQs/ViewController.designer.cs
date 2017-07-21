// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace ClarifaiQs
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UIButton btnRecognize { get; set; }

		[Outlet]
		UIKit.UIImageView imgPhoto { get; set; }

		[Outlet]
		UIKit.UITextView txtResult { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (imgPhoto != null) {
				imgPhoto.Dispose ();
				imgPhoto = null;
			}

			if (txtResult != null) {
				txtResult.Dispose ();
				txtResult = null;
			}

			if (btnRecognize != null) {
				btnRecognize.Dispose ();
				btnRecognize = null;
			}
		}
	}
}
