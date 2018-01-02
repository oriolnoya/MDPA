// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace BaseExample.iOS.ViewControllers
{
    [Register ("DetailViewController")]
    partial class DetailViewController
    {
        [Outlet]
        UIKit.UILabel ItemDescriptionLabel { get; set; }


        [Outlet]
        UIKit.UILabel ItemNameLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ItemDescriptionLabel != null) {
                ItemDescriptionLabel.Dispose ();
                ItemDescriptionLabel = null;
            }

            if (ItemNameLabel != null) {
                ItemNameLabel.Dispose ();
                ItemNameLabel = null;
            }
        }
    }
}