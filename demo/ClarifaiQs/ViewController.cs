using System;
using System.Linq;
using ClarifaiSDK;
using Foundation;
using UIKit;

namespace ClarifaiQs
{
    public partial class ViewController : UIViewController, IUIImagePickerControllerDelegate
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            btnRecognize.SetTitle("Select an Image", UIControlState.Normal);

            btnRecognize.TouchUpInside += delegate
            {
                var imagePicker = new UIImagePickerController
                {
                    SourceType = UIImagePickerControllerSourceType.PhotoLibrary
                };
                imagePicker.Delegate = this;

                PresentViewController(imagePicker, true, null);
            };
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        [Export("imagePickerController:didFinishPickingImage:editingInfo:")]
        public void FinishedPickingImage(UIImagePickerController picker, UIImage image, Foundation.NSDictionary editingInfo)
        {
            picker.DismissViewController(true, null);

            imgPhoto.Image = image;
            txtResult.Text = "Recognizing...";
            btnRecognize.Enabled = false;

            RecognizeImage(image);
        }

        void RecognizeImage(UIImage image)
        {
            var app = new ClarifaiApp("e995372b2d2b4225a82c52741a60a540");

            app.GetModelByName("general-v1.3", (model, error) =>
            {
                var clafifaiImage = new ClarifaiImage(image);

                if (error != null)
                {
                    ShowText(error.DebugDescription);
                    return;
                }

                model.PredictOnImages(new[] { clafifaiImage }, (outputs, errors) =>
                {
                    if (errors != null)
					{
						ShowText(error.DebugDescription);
                        return;
                    }

                    var tags = outputs[0].Concepts.Select(x => x.ConceptName);

                    ShowText($"Tags: {string.Join(", ", tags)}");
                });

            });
        }

        void ShowText(string text) {
            InvokeOnMainThread(delegate {
				btnRecognize.Enabled = true;

				txtResult.Text = text;
            });
        }

    }
}
