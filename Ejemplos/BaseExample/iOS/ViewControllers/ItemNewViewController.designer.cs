// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace BaseExample.iOS.ViewControllers
{
	[Register ("ItemNewViewController")]
	partial class ItemNewViewController
	{
		[Outlet]
		UIKit.UIButton btnSaveItem { get; set; }

		[Outlet]
		UIKit.UILabel txtDesc { get; set; }

		[Outlet]
		UIKit.UITextField txtDescOk { get; set; }

		[Outlet]
		UIKit.UILabel txtTitle { get; set; }

		[Outlet]
		UIKit.UITextField txtTitleOk { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (btnSaveItem != null) {
				btnSaveItem.Dispose ();
				btnSaveItem = null;
			}

			if (txtDesc != null) {
				txtDesc.Dispose ();
				txtDesc = null;
			}

			if (txtTitle != null) {
				txtTitle.Dispose ();
				txtTitle = null;
			}

			if (txtTitleOk != null) {
				txtTitleOk.Dispose ();
				txtTitleOk = null;
			}

			if (txtDescOk != null) {
				txtDescOk.Dispose ();
				txtDescOk = null;
			}
		}
	}
}
