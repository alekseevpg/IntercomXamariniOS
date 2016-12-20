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

namespace Intercom.Example
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton OpenMessengerBtn { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton RegisterBtn { get; set; }

        [Action ("OpenMessengerBtn_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void OpenMessengerBtn_TouchUpInside (UIKit.UIButton sender);

        [Action ("RegisterBtn_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void RegisterBtn_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (OpenMessengerBtn != null) {
                OpenMessengerBtn.Dispose ();
                OpenMessengerBtn = null;
            }

            if (RegisterBtn != null) {
                RegisterBtn.Dispose ();
                RegisterBtn = null;
            }
        }
    }
}