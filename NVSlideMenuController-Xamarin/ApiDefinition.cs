//
// Author:
//      Nicolas VERINAUD <n.verinaud@gmail.com>
//
// Copyright (c) 2014 Nicolas Verinaud. All Rights Reserved.
//
using System;
using CoreGraphics;
using ObjCRuntime;
using Foundation;
using UIKit;

namespace NVSlideMenuControllerLib
{
	[BaseType (typeof (UIViewController))]
	public partial interface NVSlideMenuController 
	{
		[Export ("menuViewController", ArgumentSemantic.Retain)]
		UIViewController MenuViewController { get; }

		[Export ("contentViewController", ArgumentSemantic.Retain)]
		UIViewController ContentViewController { get; }

		[Export ("panGestureEnabled")]
		bool PanGestureEnabled { get; set; }

		[Export ("menuWidth")]
		nfloat MenuWidth { get; set; }

		[Export ("autoAdjustMenuWidth")]
		bool AutoAdjustMenuWidth { get; set; }

		[Export ("bounceWhenNavigating")]
		bool BounceWhenNavigating { get; set; }

		[Export ("showShadowOnContentView")]
		bool ShowShadowOnContentView { get; set; }

		[Export ("initWithMenuViewController:andContentViewController:")]
		IntPtr Constructor (UIViewController menuViewController, UIViewController contentViewController);

		[Export ("toggleMenuAnimated:")]
		void ToggleMenuAnimated (NSObject sender);

		[Export ("openMenuAnimated:completion:")]
		void OpenMenuAnimated (bool animated, UICompletionHandler completion);

		[Export ("closeMenuAnimated:completion:")]
		void CloseMenuAnimated (bool animated, UICompletionHandler completion);

		[Export ("closeMenuBehindContentViewController:animated:completion:")]
		void CloseMenuBehindContentViewController (UIViewController contentViewController, bool animated, UICompletionHandler completion);

		[Export ("closeMenuBehindContentViewController:animated:bounce:completion:")]
		void CloseMenuBehindContentViewController (UIViewController contentViewController, bool animated, bool bounce, UICompletionHandler completion);

		[Export ("hideContentViewControllerAnimated:completion:")]
		void HideContentViewControllerAnimated (bool animated, UICompletionHandler completion);

		[Export ("partiallyShowContentViewControllerAnimated:completion:")]
		void PartiallyShowContentViewControllerAnimated (bool animated, UICompletionHandler completion);

		[Export ("slideDirection")]
		NVSlideMenuControllerSlideDirection SlideDirection { get; set; }

		[Export ("setSlideDirection:animated:")]
		void SetSlideDirection (NVSlideMenuControllerSlideDirection slideDirection, bool animated);

		[Export ("isMenuOpen")]
		bool IsMenuOpen { get; }

		[Export ("isContentViewHidden")]
		bool IsContentViewHidden { get; }
	}

	[Category, BaseType (typeof (UIViewController))]
	public partial interface NVSlideMenuController_UIViewController 
	{
		[Export ("slideMenuController")]
		NVSlideMenuController SlideMenuController();
	}

	[Category, BaseType (typeof (UIViewController))]
	public partial interface NVSlideMenuControllerCallbacks_UIViewController 
	{
		[Export ("viewWillSlideIn:inSlideMenuController:")]
		void ViewWillSlideIn (bool animated, NVSlideMenuController slideMenuController);

		[Export ("viewDidSlideIn:inSlideMenuController:")]
		void ViewDidSlideIn (bool animated, NVSlideMenuController slideMenuController);

		[Export ("viewWillSlideOut:inSlideMenuController:")]
		void ViewWillSlideOut (bool animated, NVSlideMenuController slideMenuController);

		[Export ("viewDidSlideOut:inSlideMenuController:")]
		void ViewDidSlideOut (bool animated, NVSlideMenuController slideMenuController);
	}
}
