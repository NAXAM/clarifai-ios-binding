using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using Metal;
using MapKit;
using ModelIO;
using SceneKit;
using Security;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using CoreAnimation;
using CoreFoundation;

namespace ClarifaiSDK
{
    partial class ClarifaiConcept
    {
        [Export ("initWithConceptId:")]
        protected ClarifaiConcept (string conceptId, object fakeParameter)
            : base (NSObjectFlag.Empty)
        {
            if (conceptId == null)
                throw new ArgumentNullException (nameof(conceptId));
            var nsconceptId = NSString.CreateNative (conceptId);
            
            IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
            if (IsDirectBinding) {
                InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithConceptId:"), nsconceptId), "initWithConceptId:");
            } else {
                InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithConceptId:"), nsconceptId), "initWithConceptId:");
            }
            NSString.ReleaseNative (nsconceptId);
        }

        public static ClarifaiConcept CreateClarifaiConceptFromId(string id) {
            return new ClarifaiConcept(id, new {});
        }
    }
}
